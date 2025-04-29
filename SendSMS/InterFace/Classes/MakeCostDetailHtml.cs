using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS.Classes
{
    public class MakeCostDetailHtml 
    {
        public MakeCostDetailHtml()
        {
        }
        public string MakeHtml(SendSMS.ContractInfoList ContractInfo, SendSMS.PartsInfoList PartsInfo, SendSMS.TestInfoList TestInfo)
        {
            using (System.IO.StringWriter stringWriter = new System.IO.StringWriter())
            {
                using (System.Web.UI.HtmlTextWriter writer = new System.Web.UI.HtmlTextWriter(stringWriter))
                {
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "1000");
                    writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Dir, "RTL");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Table);

                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Tr);
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "260px");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Href, "http://www.razi-foundation.com");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.A);
                    writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Src, "http://www.razi-foundation.com/images/email/logo.png");
                    writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Align, "Right");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Img);
                    writer.RenderEndTag();
                    writer.RenderEndTag();
                    writer.RenderEndTag();
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "480px");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontFamily, "BMitra");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontSize, "5");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.VerticalAlign, "top");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.TextAlign, "Center");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.Write("به نام خداوند جان و خرد");
                    writer.RenderEndTag();
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "260px");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.RenderEndTag();
                    writer.RenderEndTag();
                    writer.RenderEndTag();


                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "1000");
                    writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Dir, "RTL");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Table);

                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Height, "20px");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Tr);
                    writer.RenderEndTag();


                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Tr);
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "75px");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.RenderEndTag();
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "850px");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontFamily, "BTitr");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontSize, "5");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.VerticalAlign, "top");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.Write("اعلام هزینه به مشتری");
                    writer.RenderEndTag();
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "75px");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.RenderEndTag();
                    writer.RenderEndTag();

                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Height, "20px");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Tr);
                    writer.RenderEndTag();


                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Overflow, "75px");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Tr);
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "75px");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.RenderEndTag();
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "850px");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontFamily, "BTrafic;line-height: 2.5");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontSize, "3");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.VerticalAlign, "top");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.TextAlign, "justify");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.Write(String.Format("مشتری گرامی ، نماینده محترم شرکت: {0}،  پیرو درخواست ارسالی طی نامه به شماره :  {1}مورخ{2} ، خواهشمند است مبلغ:  {3}  ریال بابت علی الحساب هزینه آزمایشهای درخواستی به شماره پیگیری{4}به حساب جام بانک ملت به نام بنیاد علوم کاربردی رازی به شماره حساب47901713/71 و شماره شبا IR4301200000000047901713/71 واریز فرموده و فیش واریزی را با درج شماره قرارداد  بر روی آن به شماره  46841122-021 فکس فرمایید.", ContractInfo.list[0].CompanyName, ContractInfo.list[0].LetterNo, ContractInfo.list[0].LetterDate, (ContractInfo.list[0].Amount + ContractInfo.list[0].Amount * ContractInfo.list[0].Tax / 100).ToString("N0"), ContractInfo.list[0].ContractNo));
                    writer.RenderEndTag();
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "75px");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.RenderEndTag();
                    writer.RenderEndTag();

                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Height, "20px");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Tr);
                    writer.RenderEndTag();

                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Tr);
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "75px");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.RenderEndTag();
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "850px");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontFamily, "BTitr");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontSize, "4");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.VerticalAlign, "top");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.TextAlign, "Right");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.Write("نکات قابل توجه:");
                    writer.RenderEndTag();
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "75px");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.RenderEndTag();
                    writer.RenderEndTag();
                    writer.RenderEndTag();

                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "1000");
                    writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Dir, "RTL");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Table);

                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Height, "10px");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Tr);
                    writer.RenderEndTag();

                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Tr);
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "100px");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.RenderEndTag();
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "800px");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontFamily, "BTrafic");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontSize, "3");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.VerticalAlign, "top");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.TextAlign, "justify");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.Write("ارائه رسید دریافت وجه  و یا اصل فیش واریزی جهت دریافت گزارش و نمونه الزامی است.<br><br>درج شماره قرارداد بر روی تصویر فیش واریزی به منظورایجاد امکان ردیابی  الزامی است. <br><br>در صورتی که هزینه انجام آزمون ها با مبلغ علی الحساب بیش از 25% اختلاف  داشته باشد و یا زمان ارائه گزارش  تغییر یابد ،  هماهنگی های لازم انجام خواهد گرفت.<br><br>در صورت عدم پرداخت هزینه آزمون ها، امکان نگهداری نمونه های ارسالی حداکثر به مدت 1 ماه وجود دارد و پس از آن مسولیتی بابت نگهداری نمونه متوجه بنیاد نخواهد بود.<br><br>باقیمانده نمونه های ارسالی پس از انجام آزمون حداکثر به مدت 1 ماه نگهداری و پس از آن دور ریز خواهد شد ، لذا خواهشمند است در صورت نیاز به باقیمانده نمونه طی مدت مقرر اقدام فرمایید.<br><br>خواهشمند است هزینه انجام آزمون ها صرفا از طریق صدور چک و یا واریز به شماره حساب اعلام شده و یا شماره کارت 6104337926816255 به نام بنیاد علوم کاربردی رازی پرداخت گردد<br><br>تحویل گزارش در تاریخ مقرر از ساعت 16 به بعد مقدور می باشد <br><br>");
                    writer.RenderEndTag();
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "100px");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.RenderEndTag();
                    writer.RenderEndTag();
                    writer.RenderEndTag();
                    writer.Write("<br><br>");

                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "1000");
                    writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Dir, "RTL");
                    writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Border, "1");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontFamily, "BTrafic");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontSize, "3");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Table);

                    foreach (SendSMS.PartsInfoList Parts in PartsInfo.list)
                    {
                        writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.TextAlign, "Right");
                        writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Tr);
                        writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Colspan, "4");
                        writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                        writer.Write(String.Format("نام قطعه: {0}", Parts.PiecesName));
                        writer.RenderEndTag();
                        writer.RenderEndTag();


                        writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.TextAlign, "Center");
                        writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Tr);
                        writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "50");
                        writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                        writer.Write("ردیف");
                        writer.RenderEndTag();

                        writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "730");
                        writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                        writer.Write("نام آزمایش");
                        writer.RenderEndTag();

                        writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "70");
                        writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                        writer.Write("تعداد");
                        writer.RenderEndTag();

                        writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "150");
                        writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);

                        writer.Write("قیمت واحد به ریال");
                        writer.RenderEndTag();
                        writer.RenderEndTag();

                        int Radif = 1;
                        foreach (SendSMS.TestInfoList Test in TestInfo.list.Where(row => row.PartNumber == Parts.PartNumber))
                        {
                            writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.TextAlign, "Center");
                            writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Tr);
                            writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "50");
                            writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                            writer.Write(Radif);
                            writer.RenderEndTag();

                            writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "730");
                            writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                            writer.Write(Test.MasterName);
                            writer.RenderEndTag();

                            writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "70");
                            writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                            writer.Write(Test.NumberOfTests);
                            writer.RenderEndTag();

                            writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "150");
                            writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                            writer.Write(Test.TotalPrice.ToString("N0"));
                            writer.RenderEndTag();
                            writer.RenderEndTag();

                            Radif++;
                        }
                    }

                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.TextAlign, "Right");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Tr);
                    writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Colspan, "4");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.Write(String.Format("مجموع تعداد تنوع: {0}", PartsInfo.list.Count));
                    writer.RenderEndTag();
                    writer.RenderEndTag();
                    
                    writer.RenderEndTag();


                    writer.Write("<br>");

                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "1000");
                    writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Dir, "RTL");
                    writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Border, "1");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontFamily, "BTrafic");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontSize, "3");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Table);

                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.TextAlign, "Center");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Tr);

                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "234");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.Write("جمع مبلغ بدون مالیات برارزش افزوده");
                    writer.RenderEndTag();

                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "100");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.Write(ContractInfo.list[0].Amount.ToString("N0"));
                    writer.RenderEndTag();

                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "233");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.Write("جمع مبلغ مالیات برارزش افزوده");
                    writer.RenderEndTag();

                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "100");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.Write((ContractInfo.list[0].Amount * ContractInfo.list[0].Tax / 100).ToString("N0"));
                    writer.RenderEndTag();

                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "233");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.Write("جمع مبلغ با مالیات برارزش افزوده");
                    writer.RenderEndTag();

                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "100");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.Write((ContractInfo.list[0].Amount + (ContractInfo.list[0].Amount * ContractInfo.list[0].Tax / 100)).ToString("N0"));
                    writer.RenderEndTag();

                    writer.RenderEndTag();
                    writer.RenderEndTag();

                    writer.Write("<br><br>");

                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "1000");
                    writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Dir, "RTL");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Table);
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.TextAlign, "Center");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Tr);
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "800");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.RenderEndTag();
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontFamily, "BTitr");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontSize, "4");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.Width, "200");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.Write("با سپاس و احترام<br>بنیاد علوم کاربردی رازی<br><br>");
                    writer.RenderEndTag();
                    writer.RenderEndTag();

                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Tr);

                    writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Colspan, "2");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontFamily, "BTrafic");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontSize, "3");
                    writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.TextAlign, "Center");
                    writer.RenderBeginTag(System.Web.UI.HtmlTextWriterTag.Th);
                    writer.Write("تهران ، جاده مخصوص کرج ، بلوار شهید قاسم اصغری ، خیابان فرنان ، پلاک 7  تلفکس : 021-46841121<br><br>سایت : www.razi-foundation.com                    پست الکترونیکی  : Info@razi-foundation.com");
                    writer.RenderEndTag();
                    writer.RenderEndTag();
                    writer.RenderEndTag();


                }
                return stringWriter.ToString();
            }
        }

       
    }
}



