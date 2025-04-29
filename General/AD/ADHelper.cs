using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;

namespace RASF.General.AD
{
    /// <summary>
    /// Helper class for common Active Directory tasks using <see cref="System.DirectoryServices"/> (raw LDAP).
    /// </summary>
    public class ADHelper : IDisposable
    {
        //  ─────────────────────────────────────────  Configuration  ──────────────────────────────────────────
        private const string LdapPath = "LDAP://192.168.0.6";   //  یا  LDAP://192.168.0.6  اگر ترجیح می‌دهید
        private const string DomainPrefix = "razi-foundation";          //  NetBIOS یا DNS prefix (برای نام کاربری)
        private const string ServiceUser = "Lab";                       //  UserName سرویسی که اجازهٔ bind دارد
        private const string ServicePassword = "Razi@1234";            //  Password کاربر سرویس

        //  ─────────────────────────────────────────  Fields & Ctor  ─────────────────────────────────────────
        private readonly DirectoryEntry _rootEntry;

        public ADHelper()
        {
            string bindUser = $"{DomainPrefix}\\{ServiceUser}";
            _rootEntry = new DirectoryEntry(LdapPath, bindUser, ServicePassword, AuthenticationTypes.Secure);
        }

        //  ───────────────────────────────────────  Group Utilities  ─────────────────────────────────────────

        /// <summary>
        /// بر اساس Guid کاربر، لیست SamAccountName گروه‌های ۳۲ کاراکتری او را (با کاما جدا) برمی‌گرداند.
        /// </summary>
        public string GetGroupsByUserID(Guid userID)
        {
            var groups = new List<string>();

            using (var searcher = new DirectorySearcher(_rootEntry))
            {
                searcher.Filter = $"(objectGUID={GuidToLdapFilter(userID)})";
                searcher.PropertiesToLoad.Add("memberOf");
                SearchResult res = searcher.FindOne();
                if (res != null && res.Properties.Contains("memberOf"))
                {
                    foreach (var dn in res.Properties["memberOf"])
                    {
                        string groupSam = GetSamAccountNameFromDn(dn.ToString());
                        if (!string.IsNullOrEmpty(groupSam) && groupSam.Replace("-", string.Empty).Length == 32)
                            groups.Add(groupSam);
                    }
                }
            }
            return string.Join(",", groups);
        }

        /// <summary>
        /// بر اساس کد لاب (Guid گروه)، لیست اعضا را برمی‌گرداند.
        /// </summary>
        public List<RASF.General.Data.TestExecutersLaboratorys> GetLabodeList(Guid labCode)
        {
            var result = new List<RASF.General.Data.TestExecutersLaboratorys>();

            using (var searcher = new DirectorySearcher(_rootEntry))
            {
                searcher.Filter = $"(&(objectClass=group)(sAMAccountName={labCode}))";
                searcher.PropertiesToLoad.Add("member");
                SearchResult grp = searcher.FindOne();
                if (grp != null && grp.Properties.Contains("member"))
                {
                    foreach (string memberDn in grp.Properties["member"])
                    {
                        using (var memberEntry = new DirectoryEntry($"LDAP://{memberDn}", _rootEntry.Username, ServicePassword))
                        {
                            string displayName = memberEntry.Properties["displayName"].Value?.ToString();
                            string guidStr = new Guid((byte[])memberEntry.Properties["objectGUID"].Value).ToString();
                            result.Add(new Data.TestExecutersLaboratorys
                            {
                                LabId = labCode,
                                UserId = new Guid(guidStr),
                                UserName = displayName
                            });
                        }
                    }
                }
            }
            return result;
        }

        //  ───────────────────────────────────────  Authentication  ─────────────────────────────────────────

        /// <summary>
        /// اعتبارسنجی کاربر در AD و بررسی عضویت در گروه "Laboratory_User".
        /// موفقیت → Guid کاربر، عدم موفقیت → Guid.Empty
        /// </summary>
        public Guid Authentication(string userName, string password)
        {
            string userDn = $"{DomainPrefix}\\{userName}";
            try
            {
                using (var testBind = new DirectoryEntry(LdapPath, userDn, password, AuthenticationTypes.Secure))
                {
                    // سعی در bind → اگر پسورد اشتباه باشد Exception می‌گیرد
                    _ = testBind.NativeObject;
                }
            }
            catch
            {
                return Guid.Empty; // credential غلط
            }

            // حالا کاربر را پیدا کنیم و گروه را چک کنیم
            using (var searcher = new DirectorySearcher(_rootEntry))
            {
                searcher.Filter = $"(&(objectClass=user)(sAMAccountName={userName}))";
                searcher.PropertiesToLoad.AddRange(new[] { "objectGUID", "memberOf" });
                SearchResult userRes = searcher.FindOne();
                if (userRes == null) return Guid.Empty;

                bool isLabUser = false;
                if (userRes.Properties.Contains("memberOf"))
                {
                    isLabUser = userRes.Properties["memberOf"].Cast<object>()
                        .Any(dn => dn.ToString().StartsWith("CN=Laboratory_User", StringComparison.OrdinalIgnoreCase));
                }

                if (!isLabUser) return Guid.Empty;
                return new Guid((byte[])userRes.Properties["objectGUID"][0]);
            }
        }

        /// <summary>
        /// دریافت نام کامل کاربر بر اساس SamAccountName.
        /// </summary>
        public string GetFullName(string userName)
        {
            using (var searcher = new DirectorySearcher(_rootEntry))
            {
                searcher.Filter = $"(&(objectClass=user)(sAMAccountName={userName}))";
                searcher.PropertiesToLoad.Add("displayName");
                SearchResult res = searcher.FindOne();
                return res?.Properties["displayName"].Count > 0 ? res.Properties["displayName"][0].ToString() : string.Empty;
            }
        }

        //  ─────────────────────────────────────────  Helpers  ──────────────────────────────────────────────

        /// <summary>
        /// GUID را به رشتهٔ هگزادسیمال موردنیاز فیلتر LDAP تبدیل می‌کند.
        ///   (objectGUID=\AA\BB\CC…)
        /// </summary>
        private static string GuidToLdapFilter(Guid guid)
        {
            byte[] b = guid.ToByteArray();
            return string.Concat(b.Select(bt => $"\\{bt:X2}"));
        }

        /// <summary>
        /// از DN گروه، مقدار CN یا sAMAccountName را استخراج می‌کند.
        /// مثال: "CN=MyGroup,OU=…" → "MyGroup"
        /// </summary>
        private static string GetSamAccountNameFromDn(string distinguishedName)
        {
            if (string.IsNullOrWhiteSpace(distinguishedName)) return string.Empty;
            var cnPart = distinguishedName.Split(',').FirstOrDefault(part => part.StartsWith("CN=", StringComparison.OrdinalIgnoreCase));
            return cnPart?.Substring(3) ?? string.Empty;
        }

        //  ───────────────────────────────────────  IDisposable  ────────────────────────────────────────────
        public void Dispose()
        {
            _rootEntry?.Dispose();
        }
    }
}
