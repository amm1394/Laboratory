using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms
{
    public partial class NewMainForm : Form
    {
        private Dictionary<string, General.Forms.Base.DockContentForm> openForms = new Dictionary<string, General.Forms.Base.DockContentForm>();
        private System.Windows.Forms.MenuStrip MyMenu;
        private RASF.Messaging.Client.Classes.Client_Connection Client;
        public WeifenLuo.WinFormsUI.Docking.DockPanel CurrentDockPanel
        {
            get
            {
               return this.dockPanel1;
            }
        }
        private delegate void SendPackets(List<RASF.Messaging.General.Classes.Packet> Packets);
        private delegate void RecivePacket(RASF.Messaging.General.Classes.Packet Packet);
        private delegate void SetStatusBarYear();

        public NewMainForm()
        {
            InitializeComponent();
        }
        private Int16 Num;
        private void NewMainForm_Load(object sender, EventArgs e)
        {

            string LData = "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4NCjxMaWNlbnNlPg0KICAgIDxEYXRhPg0KICAgICAgICA8TGljZW5zZWRUbz5pckRldmVsb3BlcnMuY29tPC9MaWNlbnNlZFRvPg0KICAgICAgICA8RW1haWxUbz5pbmZvQGlyRGV2ZWxvcGVycy5jb208L0VtYWlsVG8+DQogICAgICAgIDxMaWNlbnNlVHlwZT5EZXZlbG9wZXIgT0VNPC9MaWNlbnNlVHlwZT4NCiAgICAgICAgPExpY2Vuc2VOb3RlPkxpbWl0ZWQgdG8gMTAwMCBkZXZlbG9wZXIsIHVubGltaXRlZCBwaHlzaWNhbCBsb2NhdGlvbnM8L0xpY2Vuc2VOb3RlPg0KICAgICAgICA8T3JkZXJJRD43ODQzMzY0Nzc4NTwvT3JkZXJJRD4NCiAgICAgICAgPFVzZXJJRD4xMTk0NDkyNDM3OTwvVXNlcklEPg0KICAgICAgICA8T0VNPlRoaXMgaXMgYSByZWRpc3RyaWJ1dGFibGUgbGljZW5zZTwvT0VNPg0KICAgICAgICA8UHJvZHVjdHM+DQogICAgICAgICAgICA8UHJvZHVjdD5Bc3Bvc2UuVG90YWwgUHJvZHVjdCBGYW1pbHk8L1Byb2R1Y3Q+DQogICAgICAgIDwvUHJvZHVjdHM+DQogICAgICAgIDxFZGl0aW9uVHlwZT5FbnRlcnByaXNlPC9FZGl0aW9uVHlwZT4NCiAgICAgICAgPFNlcmlhbE51bWJlcj57RjJCOTcwNDUtMUIyOS00QjNGLUJENTMtNjAxRUZGQTE1QUE5fTwvU2VyaWFsTnVtYmVyPg0KICAgICAgICA8U3Vic2NyaXB0aW9uRXhwaXJ5PjIwOTkxMjMxPC9TdWJzY3JpcHRpb25FeHBpcnk+DQogICAgICAgIDxMaWNlbnNlVmVyc2lvbj4zLjA8L0xpY2Vuc2VWZXJzaW9uPg0KICAgIDwvRGF0YT4NCiAgICA8U2lnbmF0dXJlPlFYTndiM05sTGxSdmRHRnNMb1B5YjJSMVkzUWdSbUZ0YVd4NTwvU2lnbmF0dXJlPg0KPC9MaWNlbnNlPg==";
            System.IO.Stream stream = new System.IO.MemoryStream(Convert.FromBase64String(LData));

            stream.Seek(0, System.IO.SeekOrigin.Begin);
            new Aspose.Words.License().SetLicense(stream);

            stream.Seek(0, System.IO.SeekOrigin.Begin);
            new Aspose.Pdf.License().SetLicense(stream);

            stream.Seek(0, System.IO.SeekOrigin.Begin);
            new Aspose.Imaging.License().SetLicense(stream);

            this.uiStatusBar2.Panels[0].Text = String.Format("کاربر جاری: {0}", RASF.General.Classes.Global.CurrentUserName);

            RASF.Main.Forms.Message.OpenMessage OpenMessage = new RASF.Main.Forms.Message.OpenMessage();
            OpenMessage.NumofUnreadMessage += OpenMessage_NumofUnreadMessage;

            CalculateNum();

            this.uiStatusBar2.Panels[1].Text = string.Format("{0}:پیام های خوانده نشده", Num);

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            RASF.General.Lists.MenuForUserList MenuList = new General.Lists.MenuForUserList();
            MenuList.Fill(Parameter);

            if (MenuList.Count() > 0)
            {
                MyMenu = RASF.Main.Classes.MakeMenu.CreateMenu(MenuList[0].XmlMenu);

                MyMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));


                foreach (System.Windows.Forms.ToolStripMenuItem Item in MyMenu.Items)
                {
                    AddEvents(Item);
                }

                this.Controls.Add(MyMenu);
            }
            RASF.General.Classes.Global.temprature = 25;//25
            RASF.General.Classes.Global.humid = 41;//41
            this.SetYear();

            Client = new RASF.Messaging.Client.Classes.Client_Connection();
            Client.Intial("192.168.0.7", RASF.General.Classes.Global.CurrentUserCode);
            Client.RecivedMessage += Client_RecivedMessage;

            ShowDocument(new WelcomeForm());
        }

        public void ShowDocument(General.Forms.Base.DockContentForm baseForm)
        {
            if (!openForms.ContainsKey(baseForm.Name))
            {
                openForms.Add(baseForm.Name, baseForm);

                string key = baseForm.Name;

                baseForm.FormClosed += (s, e) => openForms.Remove(key);

                baseForm.Show(dockPanel1);
            }
            else
            {
                MessageBox.Show("فرم انتخابی باز می‌باشد؛ لطفاً روی فرم در وسط صفحه کلیک کنید تا فعال شود.",
                                "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);

                openForms[baseForm.Name].Activate();
            }
        }

        public void ShowDocumentForReciepcien(General.Forms.Base.DockContentForm baseForm)
        {
            string key = baseForm.Name;

            baseForm.FormClosed += (s, e) => openForms.Remove(key);

            baseForm.Show(dockPanel1);
        }

        //public void ShowDocument(General.Forms.Base.DockContentForm baseForm)
        //{
        //    if (openForms.Keys.Contains(baseForm.Name) == false)
        //    {
        //        openForms.Add(baseForm.Name, baseForm);
        //        baseForm.FormClosed += (x,y) => {openForms.Remove(baseForm.Name());};
        //        baseForm.Show(dockPanel1);
        //    }
        //    else
        //    {
        //        MessageBox.Show("فرم انتخابی باز می باشد لطفا بروی فرم در وسط صفحه کلیک تا فعال شود", "پیغام");
        //        baseForm.Select();
        //    }
        //}

        //public void ShowDocumentForReciepcien(General.Forms.Base.DockContentForm baseForm)
        //{
             
        //        baseForm.FormClosed += (x, y) => { openForms.Remove(baseForm.Name()); };
        //        baseForm.Show(dockPanel1);
           
        //}

        private void UpdateStatusBarText(int FinancialYear)
        {
            this.uiStatusBar2.Text = String.Format(" سال مالی: {0}", FinancialYear);
            this.uiStatusBar2.Invalidate();
            this.uiStatusBar2.Refresh();
        }
        private void ShowMessage(RASF.Messaging.General.Classes.Packet packet)
        {
            Num++;
            this.uiStatusBar2.Panels[1].Text = string.Format("{0}:پیام های خوانده نشده", Num);
            this.radDesktopAlert1.ContentText = packet.Message;
            this.radDesktopAlert1.Show();
        }
        private void Client_RecivedMessage(Messaging.General.Events.RecivedEventArgs e)
        {
            if (e.Packet.DataIdentifier == Messaging.General.Enums.DataIdentifier.Message)
            {
                if (this.InvokeRequired == true)
                {
                    this.Invoke(new RecivePacket(ShowMessage), e.Packet);
                }
                else
                {
                    this.ShowMessage(e.Packet);
                }
            }
        }

        private void AddEvents(System.Windows.Forms.ToolStripMenuItem MenuItem)
        {
            foreach (System.Windows.Forms.ToolStripMenuItem item in MenuItem.DropDownItems)
            {
                String MethodeName = String.Format("{0}_Click", item.Name);
                System.Reflection.MethodInfo OnClick_Method = this.GetType().GetMethod(MethodeName, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (OnClick_Method != null)
                {
                    System.Reflection.EventInfo ClickInfo = item.GetType().GetEvent("Click");
                    if (ClickInfo != null)
                    {
                        System.Delegate d = System.Delegate.CreateDelegate(ClickInfo.EventHandlerType, this, OnClick_Method.Name);
                        ClickInfo.AddEventHandler(item, d);
                    }
                }
                if (item.DropDownItems.Count > 0)
                {
                    AddEvents(item);
                }
            }
        }

        private void mnuBank_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Banks banks = new RASF.Main.Forms.Banks();
            //banks.MdiParent = this;
            banks.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(banks);
        }

        private void mnuCancelReportWrite_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.CancelReportWrite CancelReportWrite = new RASF.Main.Forms.Harmony.CancelReportWrite();
            //CancelReportWrite.MdiParent = this;
            CancelReportWrite.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CancelReportWrite);
        }

        private void mnuInsertReportWrite_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.InsertReportWrite InsertReportWrite = new RASF.Main.Forms.Harmony.InsertReportWrite();
            //CancelReportWrite.MdiParent = this;
            InsertReportWrite.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(InsertReportWrite);
        }

        private void mnuReceiveChequeForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ReceiveChequeForm ReceiveChequeForm = new RASF.Main.Forms.Financial.ReceiveChequeForm();
            //CancelReportWrite.MdiParent = this;
            ReceiveChequeForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReceiveChequeForm);
        }

        private void mnuChequeForTafahomName_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.ChequeForTafahomName ChequeForTafahomName = new RASF.Main.Forms.Manager.ChequeForTafahomName();
            //CancelReportWrite.MdiParent = this;
            ChequeForTafahomName.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ChequeForTafahomName);
        }

        private void mnuChequeNoPassedForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ChequeNoPassedForm ChequeNoPassedForm = new RASF.Main.Forms.Financial.ChequeNoPassedForm();
            //CancelReportWrite.MdiParent = this;
            ChequeNoPassedForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ChequeNoPassedForm);
        }

        private void mnuChequeIsVoidedForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ChequeIsVoidedForm ChequeIsVoidedForm = new RASF.Main.Forms.Financial.ChequeIsVoidedForm();
            //CancelReportWrite.MdiParent = this;
            ChequeIsVoidedForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ChequeIsVoidedForm);
        }

        private void mnuExecuters_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Settings.Executers Executers = new RASF.Main.Forms.Settings.Executers();
            //Executers.MdiParent = this;
            Executers.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Executers);
        }

        private void mnuShowDeliveryDateChange_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ShowDeliveryDateChange ShowDeliveryDateChange = new RASF.Main.Forms.Harmony.ShowDeliveryDateChange();
            //ShowDeliveryDateChange.MdiParent = this;
            ShowDeliveryDateChange.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ShowDeliveryDateChange);
        }

        private void mnuTestForThePresenceDateChange_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.TestForThePresenceDateChange TestForThePresenceDateChange = new RASF.Main.Forms.Harmony.TestForThePresenceDateChange();
            //ShowDeliveryDateChange.MdiParent = this;
            TestForThePresenceDateChange.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(TestForThePresenceDateChange);
        }

        private void mnuOnSiteTestingDateChange_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.OnSiteTestingDateChange OnSiteTestingDateChange = new RASF.Main.Forms.Harmony.OnSiteTestingDateChange();
            //ShowDeliveryDateChange.MdiParent = this;
            OnSiteTestingDateChange.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(OnSiteTestingDateChange);
        }

        private void mnuChash_Click(object sender, EventArgs e)
        {
            RAFS.Main.Forms.Chash chash = new RAFS.Main.Forms.Chash();
            //chash.MdiParent = this;
            chash.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(chash);
        }

        private void mnuPrintRequestContractors_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.PrintRequestContractors PrintRequestContractors = new RASF.Main.Forms.Harmony.PrintRequestContractors();
            //chash.MdiParent = this;
            PrintRequestContractors.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PrintRequestContractors);
        }

        private void mnuCompanies_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.COMPANIES_BASE companiesBase = new RASF.Main.Forms.COMPANIES_BASE(Janus.Windows.GridEX.InheritableBoolean.True);
            //companiesBase.MdiParent = this;
            companiesBase.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(companiesBase);
        }

        private void mnuCOMPANIES_BASEForActivity_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.COMPANIES_BASEForActivity companiesBase = new RASF.Main.Forms.COMPANIES_BASEForActivity(Janus.Windows.GridEX.InheritableBoolean.True);
            //companiesBase.MdiParent = this;
            companiesBase.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(companiesBase);
        }

        private void mnudiscountOfCompany_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.COMPANIES_BASEForManager companiesBase = new RASF.Main.Forms.COMPANIES_BASEForManager(Janus.Windows.GridEX.InheritableBoolean.True);
            //companiesBase.MdiParent = this;
            companiesBase.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(companiesBase);
        }

        private void mnuCOMPANIES_BASEForMarketing_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.COMPANIES_BASEForMarketing companiesBase = new RASF.Main.Forms.COMPANIES_BASEForMarketing(Janus.Windows.GridEX.InheritableBoolean.True);
            //companiesBase.MdiParent = this;
            companiesBase.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(companiesBase);
        }

        private void mnuCOMPANIES_BASEMarketingView_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.COMPANIES_BASEForMarketing companiesBase = new RASF.Main.Forms.COMPANIES_BASEForMarketing(Janus.Windows.GridEX.InheritableBoolean.False);
            //companiesBase.MdiParent = this;
            companiesBase.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(companiesBase);
        }

        private void mnuRegidterMarketingActivity_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.RegidterMarketingActivity MarketingActivity = new RASF.Main.Forms.Marketing.RegidterMarketingActivity();
            //companiesBase.MdiParent = this;
            MarketingActivity.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(MarketingActivity);
        }

        private void mnuReportTotalMarketingActivityForExpert_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.ReportTotalMarketingActivityForExpert ReportTotalMarketingActivity = new RASF.Main.Forms.Marketing.ReportTotalMarketingActivityForExpert();
            //companiesBase.MdiParent = this;
            ReportTotalMarketingActivity.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportTotalMarketingActivity);
        }

        private void mnuReportTotalMarketingActivity_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.ReportTotalMarketingActivity ReportTotalMarketingActivity = new RASF.Main.Forms.Marketing.ReportTotalMarketingActivity();
            //companiesBase.MdiParent = this;
            ReportTotalMarketingActivity.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportTotalMarketingActivity);
        }

        private void mnuAcquaintanceType_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Acquaintance Acquaintance = new RASF.Main.Forms.Acquaintance();
            // Acquaintance.MdiParent = this;
            Acquaintance.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Acquaintance);
        }

        private void mnuActivitiesType_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ActivityType ActivityType = new RASF.Main.Forms.ActivityType();
            //ActivityType.MdiParent = this;
            ActivityType.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ActivityType);
        }

        private void mnuProvinces_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Provinses Provices = new RASF.Main.Forms.Provinses();
            //Provices.MdiParent = this;
            Provices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Provices);
        }

        private void mnuOperationType_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.OperationType OperationType = new RASF.Main.Forms.OperationType();
            // OperationType.MdiParent = this;
            OperationType.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(OperationType);
        }

        private void mnuCompanies_AgencyList_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Companies_AgencyList Companies_AgencyList = new RASF.Main.Forms.Companies_AgencyList();
            // Companies_AgencyList.MdiParent = this;
            Companies_AgencyList.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Companies_AgencyList);
        }

        private void mnuCOMPANIES_FAXNUM_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.COMPANIES_FAXNUM COMPANIES_FAXNUM = new RASF.Main.Forms.COMPANIES_FAXNUM();
            //COMPANIES_FAXNUM.MdiParent = this;
            COMPANIES_FAXNUM.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(COMPANIES_FAXNUM);
        }

        private void mnuLaboratory_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.LABORATORY LABORATORY = new RASF.Main.Forms.LABORATORY();
            //LABORATORY.MdiParent = this;
            LABORATORY.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(LABORATORY);
        }

        private void mnuLABORATORYForNano_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.LABORATORYForNano LABORATORYForNano = new RASF.Main.Forms.LABORATORYForNano();
            //LABORATORY.MdiParent = this;
            LABORATORYForNano.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(LABORATORYForNano);
        }

        private void mnuCOMPANIES_English_Click_1(object sender, EventArgs e)
        {
            RASF.Main.Forms.COMPANIES_ENGLISH COMPANIES_ENGLISH = new RASF.Main.Forms.COMPANIES_ENGLISH();
            //COMPANIES_ENGLISH.MdiParent = this;
            COMPANIES_ENGLISH.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(COMPANIES_ENGLISH);
        }

        private void mnuMACHINS_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.MACHINS MACHINS = new RASF.Main.Forms.MACHINS();
            //MACHINS.MdiParent = this;
            MACHINS.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(MACHINS);
        }

        private void mnuTAX_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.TAX TAX = new RASF.Main.Forms.TAX();
            //TAX.MdiParent = this;
            TAX.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(TAX);
        }

        private void mnuTarrif_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Tarrif_Master Tarrif = new RASF.Main.Forms.Tarrif_Master();
            //Tarrif.MdiParent = this;
            Tarrif.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Tarrif);
        }

        private void mnuViewTarrif_Master_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ViewTarrif_Master ViewTarrif_Master = new RASF.Main.Forms.ViewTarrif_Master();
            //ViewTarrif_Master.MdiParent = this;
            ViewTarrif_Master.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ViewTarrif_Master);
        }

        private void mnuViewTarrif_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Base.ViewTarrif ViewTarrif = new RASF.Main.Forms.Base.ViewTarrif();
            //ViewTarrif_Master.MdiParent = this;
            ViewTarrif.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ViewTarrif);
        }

        private void NewReciption_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.New_Reception Reception = new RASF.Main.Forms.Reception.New_Reception();
            //Reception.MdiParent = this;
            Reception.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocumentForReciepcien(Reception);
        }

        private void mnuNew_ReceptionDeclareCost_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Reception.New_Reception22 Reception = new RASF.Main.Forms.Reception.New_Reception22();
            ////Reception.MdiParent = this;
            //Reception.Text = ((ToolStripMenuItem)sender).Text;
            //ShowDocumentForReciepcien(Reception);
        }

        private void mnuRegisterNotInPersonPart_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.RegisterNotInPersonPart Reception = new RASF.Main.Forms.Harmony.RegisterNotInPersonPart();
            //Reception.MdiParent = this;
            Reception.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocumentForReciepcien(Reception);
        }

        private void mnuPeciesEnterToRecieption_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.PeciesEnterToRecieption Reception = new RASF.Main.Forms.Reception.PeciesEnterToRecieption();
            //Reception.MdiParent = this;
            Reception.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocumentForReciepcien(Reception);
        }


        private void mnuEditContractDeclareCost_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.EditContractDeclareCost Reception = new RASF.Main.Forms.Reception.EditContractDeclareCost();
            //Reception.MdiParent = this;
            Reception.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocumentForReciepcien(Reception);
        }

        private void mnuNew_ReceptionForAgency_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.New_ReceptionForAgency Reception = new RASF.Main.Forms.Reception.New_ReceptionForAgency();
            //Reception.MdiParent = this;
            Reception.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Reception);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Base.LaboratoryMachin LaboratoryMachin = new RASF.Main.Forms.Base.LaboratoryMachin();
            // LaboratoryMachin.MdiParent = this;
            LaboratoryMachin.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(LaboratoryMachin);
        }

       private void mnuEditContractForEditName_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.EditContractForEditName EditContract = new RASF.Main.Forms.Reception.EditContractForEditName();
            //EditContract.MdiParent = this;
            EditContract.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocumentForReciepcien(EditContract);
        }

       private void mnuEditContractForEditNameForHarmony_Click(object sender, EventArgs e)
       {
           RASF.Main.Forms.Reception.EditContractForEditNameForHarmony EditContract = new RASF.Main.Forms.Reception.EditContractForEditNameForHarmony();
           //EditContract.MdiParent = this;
           EditContract.Text = ((ToolStripMenuItem)sender).Text;
           ShowDocumentForReciepcien(EditContract);
       }

       private void mnuEditContractForEditAgencyName_Click(object sender, EventArgs e)
       {
           RASF.Main.Forms.Reception.EditContractForEditAgencyName EditContract = new RASF.Main.Forms.Reception.EditContractForEditAgencyName();
           //EditContract.MdiParent = this;
           EditContract.Text = ((ToolStripMenuItem)sender).Text;
           ShowDocumentForReciepcien(EditContract);
       }

        private void EditRecieption_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.EditContract EditContract = new RASF.Main.Forms.Reception.EditContract();
            //EditContract.MdiParent = this;
            EditContract.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocumentForReciepcien(EditContract);
        }

        private void mnuEditContractForHarmony_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.EditContractForHarmony EditContract = new RASF.Main.Forms.Reception.EditContractForHarmony();
            //EditContract.MdiParent = this;
            EditContract.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocumentForReciepcien(EditContract);
        }

        private void mnuPrintOfCostPaper_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.PrintOfCostPaper PrintOfCostPaper = new RASF.Main.Forms.Reception.PrintOfCostPaper();
            //EditContract.MdiParent = this;
            PrintOfCostPaper.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocumentForReciepcien(PrintOfCostPaper);
        }

        private void mnuEditContractForOffices_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.EditContractForOffices EditContractForOffices = new RASF.Main.Forms.Reception.EditContractForOffices();
            //EditContractForOffices.MdiParent = this;
            EditContractForOffices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(EditContractForOffices);
        }

        private void mnuAzpun_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.Print_Test_Form Print_Test_Form = new RASF.Main.Forms.Reception.Print_Test_Form();
            //Print_Test_Form.MdiParent = this;
            Print_Test_Form.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Print_Test_Form);
        }

        private void mnuBillsOfSale_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.Bill_Form BillsOfSales = new RASF.Main.Forms.Reception.Bill_Form();
            //BillsOfSales.MdiParent = this;
            BillsOfSales.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(BillsOfSales);
        }

        private void mnuInvoiceForContractors_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.InvoiceContractors.InvoiceForContractors InvoiceForContractors = new RASF.Main.Forms.InvoiceContractors.InvoiceForContractors();
            //BillsOfSales.MdiParent = this;
            InvoiceForContractors.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(InvoiceForContractors);
        }

        private void mnuRemindSeperatorByCustomer_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.RemindSeperatorByCustomer RemindSeperatorByCustomer = new RASF.Main.Forms.Manager.RemindSeperatorByCustomer();
            //BillsOfSales.MdiParent = this;
            RemindSeperatorByCustomer.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RemindSeperatorByCustomer);
        }

        private void mnuBilling_FormBeforCompleted_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.Billing_FormBeforCompleted Billing_FormBeforCompleted = new RASF.Main.Forms.Reception.Billing_FormBeforCompleted();
            //BillsOfSales.MdiParent = this;
            Billing_FormBeforCompleted.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Billing_FormBeforCompleted);
        }

        private void mnuReasonOfDntExportInvoiceForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ReasonOfDntExportInvoiceForm ReasonOfDntExportInvoiceForm = new RASF.Main.Forms.Harmony.ReasonOfDntExportInvoiceForm();
            //BillsOfSales.MdiParent = this;
            ReasonOfDntExportInvoiceForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReasonOfDntExportInvoiceForm);
        }

        private void mnuIsCompleted_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.IsCompletedForm IsCompletedForm = new RASF.Main.Forms.Reception.IsCompletedForm();
            //IsCompletedForm.MdiParent = this;
            IsCompletedForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(IsCompletedForm);
        }

        private void mnuIsCompletedZeroAmountForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.IsCompletedZeroAmountForm IsCompletedForm = new RASF.Main.Forms.Reception.IsCompletedZeroAmountForm();
            //IsCompletedForm.MdiParent = this;
            IsCompletedForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(IsCompletedForm);
        }

        private void mnuReportSalesYearlyForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.ReportSalesYearlyForm ReportSalesYearlyForm = new RASF.Main.Forms.Manager.ReportSalesYearlyForm();
            //IsCompletedForm.MdiParent = this;
            ReportSalesYearlyForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportSalesYearlyForm);
        }

        private void mnuIsCompletedForCancelToExite_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.IsCompletedForCancelToExite IsCompletedForm = new RASF.Main.Forms.Reception.IsCompletedForCancelToExite();
            //IsCompletedForm.MdiParent = this;
            IsCompletedForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(IsCompletedForm);
        }

        private void mnuReportOFCancelToExit_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.CancelToExitReport CancelToExitReport = new RASF.Main.Forms.Reception.CancelToExitReport();
            //IsCompletedForm.MdiParent = this;
            CancelToExitReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CancelToExitReport);
        }

        private void mnuIsCompletedForCancelToExiteReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.IsCompletedForCancelToExiteReport IsCompletedForm = new RASF.Main.Forms.Reception.IsCompletedForCancelToExiteReport();
            //IsCompletedForm.MdiParent = this;
            IsCompletedForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(IsCompletedForm);
        }

        private void mnuRessuiseBill_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.ReissuesForm ReissuesForm = new RASF.Main.Forms.Reception.ReissuesForm();
            //ReissuesForm.MdiParent = this;
            ReissuesForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReissuesForm);
        }

        private void mnuInvoiceForPrint_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.InvoiceForPrint InvoiceForPrint = new RASF.Main.Forms.Harmony.InvoiceForPrint();
            //ReissuesForm.MdiParent = this;
            InvoiceForPrint.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(InvoiceForPrint);
        }

        private void mnuPrintFactorOfDaneshBonyan_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.PrintFactorOfDaneshBonyan PrintFactorOfDaneshBonyan = new RASF.Main.Forms.Harmony.PrintFactorOfDaneshBonyan();
            //ReissuesForm.MdiParent = this;
            PrintFactorOfDaneshBonyan.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PrintFactorOfDaneshBonyan);
        }

        private void mnuShowConnector_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.ShowConnector ShowConnector = new RASF.Main.Forms.ContractsReport.ShowConnector();
            //ReissuesForm.MdiParent = this;
            ShowConnector.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ShowConnector);
        }

        private void mnuSavepdfReissuesForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.SavepdfReissuesForm SavepdfReissuesForm = new RASF.Main.Forms.Reception.SavepdfReissuesForm();
            //ReissuesForm.MdiParent = this;
            SavepdfReissuesForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SavepdfReissuesForm);
        }

        private void mnuDiscountOfCompanies_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.DiscountOfCompanies DiscountOfCompanies = new RASF.Main.Forms.Manager.DiscountOfCompanies();
            //ReissuesForm.MdiParent = this;
            DiscountOfCompanies.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DiscountOfCompanies);
        }

        private void mnuSendEmailOfBills_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.SendEmailOfBills SendEmailOfBills = new RASF.Main.Forms.Harmony.SendEmailOfBills();
            // SendEmailOfBills.MdiParent = this;
            SendEmailOfBills.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendEmailOfBills);
        }

        private void mnuCostomerCost_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.CostomersCost CostomersCost = new RASF.Main.Forms.Reception.CostomersCost();
            // CostomersCost.MdiParent = this;
            CostomersCost.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CostomersCost);
        }

        private void mnuMonthlyReportForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.MonthlyReportForm MonthlyReportForm = new RASF.Main.Forms.Manager.MonthlyReportForm();
            // CostomersCost.MdiParent = this;
            MonthlyReportForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(MonthlyReportForm);
        }

        private void mnuCostomersCostForOffices_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.CostomersCostForOffices CostomersCostForOffices = new RASF.Main.Forms.Reception.CostomersCostForOffices();
            // CostomersCostForOffices.MdiParent = this;
            CostomersCostForOffices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CostomersCostForOffices);
        }

        private void mnuCancelToExit_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.CancelToExit CancelToExit = new RASF.Main.Forms.Reception.CancelToExit();
            //CancelToExit.MdiParent = this;
            CancelToExit.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CancelToExit);
            
        }

        private void mnuCancelToExitForLaboratory_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.CancelToExitForLaboratory CancelToExit = new RASF.Main.Forms.Reception.CancelToExitForLaboratory();
            //CancelToExit.MdiParent = this;
            CancelToExit.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CancelToExit);

        }

        private void mnuRedactForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.RedactForm RedactForm = new RASF.Main.Forms.Reports.RedactForm();
            //CancelToExit.MdiParent = this;
            RedactForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RedactForm);
        }

        private void mnuReceiptAmount_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Receipt.ReceiptForm ReceiptForm = new RASF.Main.Forms.Receipt.ReceiptForm();
            //ReceiptForm.MdiParent = this;
            ReceiptForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReceiptForm);
        }

        private void mnuRegisterGrant_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Receipt.RegisterGrant RegisterGrant = new RASF.Main.Forms.Receipt.RegisterGrant();
            //ReceiptForm.MdiParent = this;
            RegisterGrant.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RegisterGrant);
        }

        private void mnuSendGrantToNano_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Receipt.SendGrantToNano SendGrantToNano = new RASF.Main.Forms.Receipt.SendGrantToNano();
            //ReceiptForm.MdiParent = this;
            SendGrantToNano.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendGrantToNano);
        }

        private void mnuPaperOfDiscount_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.PaperOfDiscount PaperOfDiscount = new RASF.Main.Forms.Financial.PaperOfDiscount();
            //ReceiptForm.MdiParent = this;
            PaperOfDiscount.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PaperOfDiscount);
        }

        private void mnuAcceptGrant_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.AcceptGrant RegisterGrant = new RASF.Main.Forms.Financial.AcceptGrant();
            //ReceiptForm.MdiParent = this;
            RegisterGrant.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RegisterGrant);
        }

        private void mnuContractDontHaveInvoice_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.ContractDontHaveInvoice ContractDontHaveInvoice = new RASF.Main.Forms.ContractsReport.ContractDontHaveInvoice();
            //ReceiptForm.MdiParent = this;
            ContractDontHaveInvoice.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ContractDontHaveInvoice);
        }

        private void mnuRepotOfGrant_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.RepotOfGrant RepotOfGrant = new RASF.Main.Forms.Financial.RepotOfGrant();
            //ReceiptForm.MdiParent = this;
            RepotOfGrant.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RepotOfGrant);
        }

        private void mnuViewGrant_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.ViewGrant RepotOfGrant = new RASF.Main.Forms.ContractsReport.ViewGrant();
            //ReceiptForm.MdiParent = this;
            RepotOfGrant.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RepotOfGrant);
        }

        private void mnuShowRegisterGrant_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.ShowRegisterGrant ShowRegisterGrant = new RASF.Main.Forms.Manager.ShowRegisterGrant();
            //ReceiptForm.MdiParent = this;
            ShowRegisterGrant.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ShowRegisterGrant);
        }

        private void mnuReportOfInsurance_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ReportOfInsurance ReportOfInsurance = new RASF.Main.Forms.Financial.ReportOfInsurance();
            //ReceiptForm.MdiParent = this;
            ReportOfInsurance.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfInsurance);
        }

        private void mnuRegisterInsurance_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Receipt.RegisterInsurance RegisterInsurance = new RASF.Main.Forms.Receipt.RegisterInsurance();
            //ReceiptForm.MdiParent = this;
            RegisterInsurance.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RegisterInsurance);
        }

        private void mnuRegisterReduceWage_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Receipt.RegisterReduceWage RegisterReduceWage = new RASF.Main.Forms.Receipt.RegisterReduceWage();
            //ReceiptForm.MdiParent = this;
            RegisterReduceWage.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RegisterReduceWage);
        }

        private void mnuRecieptReduceWage_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.BillsReports.RecieptReduceWage mnuRecieptReduceWage = new RASF.Main.Forms.BillsReports.RecieptReduceWage();
            //ReceiptForm.MdiParent = this;
            mnuRecieptReduceWage.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(mnuRecieptReduceWage);
        }

        private void mnuReportOfInsurence_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.BillsReports.ReportOfInsurence ReportOfInsurence = new RASF.Main.Forms.BillsReports.ReportOfInsurence();
            //ReceiptForm.MdiParent = this;
            ReportOfInsurence.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfInsurence);
        }

        private void mnuReceiptFormForAgency_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Receipt.ReceiptFormForAgency ReceiptForm = new RASF.Main.Forms.Receipt.ReceiptFormForAgency();
            //ReceiptForm.MdiParent = this;
            ReceiptForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReceiptForm);
        }
        private void mnuCostomersCostOfSeeing_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.CostomersCostOfSeeing CostomersCostOfSeeing = new RASF.Main.Forms.Financial.CostomersCostOfSeeing();
            //CostomersCostOfSeeing.MdiParent = this;
            CostomersCostOfSeeing.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CostomersCostOfSeeing);
        }

        private void mnuSendEmailOfCostOfCustomer_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.SendEmailCostomerCostPDF SendEmailOfCostOfCustomer = new RASF.Main.Forms.Harmony.SendEmailCostomerCostPDF();
            //SendEmailOfCostOfCustomer.MdiParent = this;
            SendEmailOfCostOfCustomer.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendEmailOfCostOfCustomer);
        }

        private void mnuSendFaxCostomerCostPDF_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.SendFaxCostomerCostPDF SendFaxCostomerCostPDF = new RASF.Main.Forms.Harmony.SendFaxCostomerCostPDF();
            //SendEmailOfCostOfCustomer.MdiParent = this;
            SendFaxCostomerCostPDF.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendFaxCostomerCostPDF);
        }

        private void mnuSendEmailFinancialSuport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.SendEmailFinancialSuport SendEmailFinancialSuport = new RASF.Main.Forms.Harmony.SendEmailFinancialSuport();
            //SendEmailOfCostOfCustomer.MdiParent = this;
            SendEmailFinancialSuport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendEmailFinancialSuport);
        }

        private void mnuSendEmailForConnector_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.SendEmailForConnector SendEmailOfCostOfCustomer = new RASF.Main.Forms.Reports.SendEmailForConnector();
            //SendEmailOfCostOfCustomer.MdiParent = this;
            SendEmailOfCostOfCustomer.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendEmailOfCostOfCustomer);
        }

        private void mnuSendEmailRecieptionPicForConnector_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.SendEmailRecieptionPicForConnector SendEmailOfCostOfCustomer = new RASF.Main.Forms.Reports.SendEmailRecieptionPicForConnector();
            //SendEmailOfCostOfCustomer.MdiParent = this;
            SendEmailOfCostOfCustomer.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendEmailOfCostOfCustomer);
        }

        private void mnuSendEmailWithPictureForOffices_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.SendEmailWithPictureForOffices SendEmailWithPictureForOffices = new RASF.Main.Forms.Reports.SendEmailWithPictureForOffices();
            //SendEmailOfCostOfCustomer.MdiParent = this;
            SendEmailWithPictureForOffices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendEmailWithPictureForOffices);
        }

        private void mnuSendEmailCostomerCostPDFForConnector_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.SendEmailCostomerCostPDFForConnector SendEmailOfCostOfCustomer = new RASF.Main.Forms.Harmony.SendEmailCostomerCostPDFForConnector();
            //SendEmailOfCostOfCustomer.MdiParent = this;
            SendEmailOfCostOfCustomer.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendEmailOfCostOfCustomer);
        }

        private void mnushowNotFinancialForOffices_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.showNotFinancialForOffices showNotFinancialForOffices = new RASF.Main.Forms.Financial.showNotFinancialForOffices();
            // FinancialAccept.MdiParent = this;
            showNotFinancialForOffices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(showNotFinancialForOffices);
        }

        private void mnuNotFinancialCreditCompany_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.NotFinancialCreditCompany NotFinancialCreditCompany = new RASF.Main.Forms.Financial.NotFinancialCreditCompany();
            // FinancialAccept.MdiParent = this;
            NotFinancialCreditCompany.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(NotFinancialCreditCompany);
        }

        private void mnuCompaniesOfDontGoBonyad2Month_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.CompaniesOfDontGoBonyad2Month NotFinancialCreditCompany = new RASF.Main.Forms.ContractsReport.CompaniesOfDontGoBonyad2Month();
            // FinancialAccept.MdiParent = this;
            NotFinancialCreditCompany.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(NotFinancialCreditCompany);
        }

        private void mnuCompaniesOfDontGoBonyadConnector_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.CompaniesOfDontGoBonyadConnector CompaniesOfDontGoBonyadConnector = new RASF.Main.Forms.ContractsReport.CompaniesOfDontGoBonyadConnector();
            // FinancialAccept.MdiParent = this;
            CompaniesOfDontGoBonyadConnector.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CompaniesOfDontGoBonyadConnector);
        }

        private void mnuCompaniesOfDontGoBonyadMarketing_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.CompaniesOfDontGoBonyadMarketing CompaniesOfDontGoBonyadMarketing = new RASF.Main.Forms.ContractsReport.CompaniesOfDontGoBonyadMarketing();
            // FinancialAccept.MdiParent = this;
            CompaniesOfDontGoBonyadMarketing.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CompaniesOfDontGoBonyadMarketing);
        }

        private void mnuBedBesCompanyWithDate_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.BedBesCompanyWithDate BedBesCompanyWithDate = new RASF.Main.Forms.ContractsReport.BedBesCompanyWithDate();
            // FinancialAccept.MdiParent = this;
            BedBesCompanyWithDate.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(BedBesCompanyWithDate);
        }

        private void mnuTransferToMainCompany_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Base.TransferToMainCompany TransferToMainCompany = new RASF.Main.Forms.Base.TransferToMainCompany();
            // FinancialAccept.MdiParent = this;
            TransferToMainCompany.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(TransferToMainCompany);
        }

        private void mnuTransferCompaniesToMarketing_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.TransferCompaniesToMarketing TransferToMarketing = new RASF.Main.Forms.Marketing.TransferCompaniesToMarketing();
            // FinancialAccept.MdiParent = this;
            TransferToMarketing.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(TransferToMarketing);
        }

        //private void mnucompanyWorkFlowBaseOfPeymentCostomer_Click(object sender, EventArgs e)
        //{
        //    RASF.Main.Forms.Financial.companyWorkFlowBaseOfPeymentCostomer NotFinancialCreditCompany = new RASF.Main.Forms.Financial.companyWorkFlowBaseOfPeymentCostomer();
        //    // FinancialAccept.MdiParent = this;
        //    NotFinancialCreditCompany.Text = ((ToolStripMenuItem)sender).Text;
        //    ShowDocument(NotFinancialCreditCompany);
        //}

        private void mnuFinancial_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.FinancialAccept FinancialAccept = new RASF.Main.Forms.Financial.FinancialAccept();
            // FinancialAccept.MdiParent = this;
            FinancialAccept.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FinancialAccept);

            //RASF.Main.Forms.Harmony.DeliveryDateChange DeliveryDateChange = new RASF.Main.Forms.Harmony.DeliveryDateChange();
            //DeliveryDateChange.Show();
        }

        private void mnuFinanciacceptManagerMali_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.FinanciacceptManagerMali FinancialAccept = new RASF.Main.Forms.Financial.FinanciacceptManagerMali();
            // FinancialAccept.MdiParent = this;
            FinancialAccept.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FinancialAccept);

            //RASF.Main.Forms.Harmony.DeliveryDateChange DeliveryDateChange = new RASF.Main.Forms.Harmony.DeliveryDateChange();
            //DeliveryDateChange.Show();
        }

        private void mnuViewFinanciacceptManagerMali_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ViewFinanciacceptManagerMali FinancialAccept = new RASF.Main.Forms.Financial.ViewFinanciacceptManagerMali();
            // FinancialAccept.MdiParent = this;
            FinancialAccept.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FinancialAccept);

            //RASF.Main.Forms.Harmony.DeliveryDateChange DeliveryDateChange = new RASF.Main.Forms.Harmony.DeliveryDateChange();
            //DeliveryDateChange.Show();
        }

        private void mnuViewFinanciacceptManager_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ViewFinanciacceptManager FinancialAccept = new RASF.Main.Forms.Financial.ViewFinanciacceptManager();
            // FinancialAccept.MdiParent = this;
            FinancialAccept.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FinancialAccept);

            //RASF.Main.Forms.Harmony.DeliveryDateChange DeliveryDateChange = new RASF.Main.Forms.Harmony.DeliveryDateChange();
            //DeliveryDateChange.Show();
        }

        private void mnuFinanciacceptManager_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.FinanciacceptManager FinancialAccept = new RASF.Main.Forms.Financial.FinanciacceptManager();
            // FinancialAccept.MdiParent = this;
            FinancialAccept.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FinancialAccept);

            //RASF.Main.Forms.Harmony.DeliveryDateChange DeliveryDateChange = new RASF.Main.Forms.Harmony.DeliveryDateChange();
            //DeliveryDateChange.Show();
        }


        private void mnuSendReportForCustomer_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.SendReportForCustomer SendReportForCustomer = new RASF.Main.Forms.Harmony.SendReportForCustomer();
            // FinancialAccept.MdiParent = this;
            SendReportForCustomer.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendReportForCustomer);

        }

        private void mnuLicensingdeliveryreport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.Licensingdeliveryreport Licensingdeliveryreport = new RASF.Main.Forms.Harmony.Licensingdeliveryreport();
            // FinancialAccept.MdiParent = this;
            Licensingdeliveryreport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Licensingdeliveryreport);

        }

        private void mnuSpecialCustomerReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.SpecialCustomerReport SpecialCustomerReport = new RASF.Main.Forms.Harmony.SpecialCustomerReport();
            // FinancialAccept.MdiParent = this;
            SpecialCustomerReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SpecialCustomerReport);

        }
        private void mnuCalcLaboratoryCost_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.CalcLaboratoryCost CalcLaboratoryCost = new RASF.Main.Forms.Financial.CalcLaboratoryCost();
            // FinancialAccept.MdiParent = this;
            CalcLaboratoryCost.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CalcLaboratoryCost);
        }

        private void mnuSabtComplaintForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Complaint.SabtComplaintForm SabtComplaintForm = new RASF.Main.Forms.Complaint.SabtComplaintForm();
            // FinancialAccept.MdiParent = this;
            SabtComplaintForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SabtComplaintForm);
        }

        private void mnuReferralComplaintToUser_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Complaint.ReferralComplaintToUser ReferralComplaintToUser = new RASF.Main.Forms.Complaint.ReferralComplaintToUser();
            // FinancialAccept.MdiParent = this;
            ReferralComplaintToUser.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReferralComplaintToUser);
        }

        private void mnuInitialComplaintReview_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Complaint.InitialComplaintReview InitialComplaintReview = new RASF.Main.Forms.Complaint.InitialComplaintReview();
            // FinancialAccept.MdiParent = this;
            InitialComplaintReview.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(InitialComplaintReview);
        }

        private void mnuReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.SEM.Report Report = new RASF.Main.Forms.SEM.Report();
            // FinancialAccept.MdiParent = this;
            Report.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Report);
        }

        private void mnuForm1_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.SEM.Form1 Report = new RASF.Main.Forms.SEM.Form1();
            // FinancialAccept.MdiParent = this;
            Report.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Report);
        }

        private void mnuReportOfSem_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.SEM.ReportOfSem Report = new RASF.Main.Forms.SEM.ReportOfSem();
            // FinancialAccept.MdiParent = this;
            Report.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Report);
        }
        private void mnuRegisterStandards_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.AddStandardForm AddStandardForm = new RASF.Main.Forms.Laboratory.AddStandardForm();
            // FinancialAccept.MdiParent = this;
            AddStandardForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(AddStandardForm);
        }

        private void mnuSentPartToContractorsForVoid_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.SentPartToContractorsForVoid SentPartToContractorsForVoid = new RASF.Main.Forms.Harmony.SentPartToContractorsForVoid();
            // FinancialAccept.MdiParent = this;
            SentPartToContractorsForVoid.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SentPartToContractorsForVoid);
        }

        private void mnuSentPartToContractorsForLaboratory_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.SentPartToContractorsForLaboratory SentPartToContractorsForVoid = new RASF.Main.Forms.Harmony.SentPartToContractorsForLaboratory();
            // FinancialAccept.MdiParent = this;
            SentPartToContractorsForVoid.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SentPartToContractorsForVoid);
        }
        private void UserAccesToLaboratory_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Settings.LaboratoryUser LaboratoryUser = new RASF.Main.Forms.Settings.LaboratoryUser();
            //LaboratoryUser.MdiParent = this;
            LaboratoryUser.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(LaboratoryUser);
        }

        private void mnuEnterPartsToLab_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.EnterForm enterForm = new RASF.Main.Forms.Laboratory.EnterForm();
            // EnterForm.MdiParent = this;
            enterForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(enterForm);
        }

        private void mnuActivePartForEnter_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.ActivePartForEnter ActivePartForEnter = new RASF.Main.Forms.Laboratory.ActivePartForEnter();
            // EnterForm.MdiParent = this;
            ActivePartForEnter.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ActivePartForEnter);
        }

        private void mnuEnterFormAmadesazi_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.EnterFormAmadesazi enterForm = new RASF.Main.Forms.Laboratory.EnterFormAmadesazi();
            // EnterForm.MdiParent = this;
            enterForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(enterForm);
        }

        private void mnuCountOfPage_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.CountOfPage CountOfPage = new RASF.Main.Forms.Manager.CountOfPage();
            // EnterForm.MdiParent = this;
            CountOfPage.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CountOfPage);
        }

        private void mnuExitFormAmadesazi_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.ExitFormAmadesazi ExitFormAmadesazi = new RASF.Main.Forms.Laboratory.ExitFormAmadesazi();
            // EnterForm.MdiParent = this;
            ExitFormAmadesazi.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ExitFormAmadesazi);
        }

        private void mnuEnterFormPart_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.EnterFormPart enterForm = new RASF.Main.Forms.Laboratory.EnterFormPart();
            // EnterForm.MdiParent = this;
            enterForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(enterForm);
        }

        private void mnuCompaniesConector_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Base.CompaniesConector CompaniesConector = new RASF.Main.Forms.Base.CompaniesConector();
            // EnterForm.MdiParent = this;
            CompaniesConector.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CompaniesConector);
        }

        private void mnuEnterFormScientificexperts_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.EnterFormScientificexpertsForHarmony enterForm = new RASF.Main.Forms.Laboratory.EnterFormScientificexpertsForHarmony();
            // EnterForm.MdiParent = this;
            enterForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(enterForm);
        }

        private void mnuExitFormScientificexperts_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.ExitFormScientificexpertsForHarmony enterForm = new RASF.Main.Forms.Laboratory.ExitFormScientificexpertsForHarmony();
            // EnterForm.MdiParent = this;
            enterForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(enterForm);
        }

        private void mnuCancelExitForEdit_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.CancelExitForEdit CancelExitForEdit = new RASF.Main.Forms.Laboratory.CancelExitForEdit();
            // EnterForm.MdiParent = this;
            CancelExitForEdit.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CancelExitForEdit);
        }

        private void mnuCancelExitForEditReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.CancelExitForEditReport CancelExitForEditReport = new RASF.Main.Forms.Laboratory.CancelExitForEditReport();
            // EnterForm.MdiParent = this;
            CancelExitForEditReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CancelExitForEditReport);
        }

        private void mnuExitFromEdit_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.ExitFromEdit ExitFromEdit = new RASF.Main.Forms.Laboratory.ExitFromEdit();
            // EnterForm.MdiParent = this;
            ExitFromEdit.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ExitFromEdit);
        }

        private void mnuThreemonthssales_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.Threemonthssales Threemonthssales = new RASF.Main.Forms.Financial.Threemonthssales();
            //Threemonthssales.MdiParent = this;
            Threemonthssales.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Threemonthssales);
        }

        private void mnuThreemonthssalesForInformalFactor_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ThreemonthssalesForInformalFactor ThreemonthssalesForInformalFactor = new RASF.Main.Forms.Financial.ThreemonthssalesForInformalFactor();
            //Threemonthssales.MdiParent = this;
            ThreemonthssalesForInformalFactor.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ThreemonthssalesForInformalFactor);
        }

        private void mnuExitFromLab_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.ExitForm exitForm = new RASF.Main.Forms.Laboratory.ExitForm();
            //exitForm.MdiParent = this;
            //exitForm.Text = ((ToolStripMenuItem)sender).Text;
            //ExitForm.Show();
            ShowDocument(exitForm);
        }

        private void mnuContractWith2Company_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.ContractWith2Company ContractWith2Company = new RASF.Main.Forms.Manager.ContractWith2Company();
            //exitForm.MdiParent = this;
            //exitForm.Text = ((ToolStripMenuItem)sender).Text;
            ContractWith2Company.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ContractWith2Company);
        }

        private void mnuSreachWirhPartsName_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Search.FindPartsName FindPartsName = new RASF.Main.Forms.Search.FindPartsName();
            //FindPartsName.MdiParent = this;
            FindPartsName.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FindPartsName);
        }

        private void mnuFindPartsNameForOffices_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Search.FindPartsNameForOffices FindPartsNameForOffices = new RASF.Main.Forms.Search.FindPartsNameForOffices();
            //FindPartsName.MdiParent = this;
            FindPartsNameForOffices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FindPartsNameForOffices);
        }

        private void mnuSreachWirhMasterName_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Search.FindMasterName FindMasterName = new RASF.Main.Forms.Search.FindMasterName();
            //FindPartsName.MdiParent = this;
            FindMasterName.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FindMasterName);
        }

        private void mnFindMasterNameForOffices_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Search.FindMasterNameForOffices FindMasterNameForOffices = new RASF.Main.Forms.Search.FindMasterNameForOffices();
            //FindPartsName.MdiParent = this;
            FindMasterNameForOffices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FindMasterNameForOffices);
        }

        private void mnuFindCompanyNameBaseOfReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Search.FindCompanyNameBaseOfReport FindCompanyNameBaseOfReport = new RASF.Main.Forms.Search.FindCompanyNameBaseOfReport();
            //FindCompanyNameBaseOfReport.MdiParent = this;
            FindCompanyNameBaseOfReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FindCompanyNameBaseOfReport);
        }

        private void mnuFindCompanyNameBaseOfReportForOfficest_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Search.FindCompanyNameBaseOfReportForOffices FindCompanyNameBaseOfReportForOffices = new RASF.Main.Forms.Search.FindCompanyNameBaseOfReportForOffices();
            //FindCompanyNameBaseOfReport.MdiParent = this;
            FindCompanyNameBaseOfReportForOffices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FindCompanyNameBaseOfReportForOffices);
        }

        private void mnuSreachWirhLetterNo_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Search.FindLetterNo FindLetterNo = new RASF.Main.Forms.Search.FindLetterNo();
            //FindLetterNo.MdiParent = this;
            FindLetterNo.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FindLetterNo);
        }

        private void mnuFindLetterNoForOffices_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Search.FindLetterNoForOffices FindLetterNoForOffices = new RASF.Main.Forms.Search.FindLetterNoForOffices();
            //FindLetterNo.MdiParent = this;
            FindLetterNoForOffices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FindLetterNoForOffices);
        }

        private void mnuSreachWirhContractNo_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Search.FindContractNo FindContractNo = new RASF.Main.Forms.Search.FindContractNo();
            //FindContractNo.MdiParent = this;
            FindContractNo.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FindContractNo);
        }

        private void mnuFindContractNoForOffices_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Search.FindContractNoForOffices FindContractNoForOffices = new RASF.Main.Forms.Search.FindContractNoForOffices();
            //FindContractNo.MdiParent = this;
            FindContractNoForOffices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FindContractNoForOffices);
        }

        private void mnuSreachWirhCompanyName_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Search.FindCompanyName FindCompanyName = new RASF.Main.Forms.Search.FindCompanyName();
            // FindCompanyName.MdiParent = this;
            FindCompanyName.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FindCompanyName);
        }

        private void mnuFindCompanyNameForOffices_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Search.FindCompanyNameForOffices FindCompanyNameForOffices = new RASF.Main.Forms.Search.FindCompanyNameForOffices();
            // FindCompanyName.MdiParent = this;
            FindCompanyNameForOffices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FindCompanyNameForOffices);
        }

        private void mnuVoidContract_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.VoidContract VoidContract = new RASF.Main.Forms.Reception.VoidContract();
            //VoidContract.MdiParent = this;
            VoidContract.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(VoidContract);
        }

        private void mnuvoidContractForHarmony_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.voidContractForHarmony VoidContract = new RASF.Main.Forms.Reception.voidContractForHarmony();
            //VoidContract.MdiParent = this;
            VoidContract.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(VoidContract);
        }

        private void mnuCompaniesWorkFlow_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.CompanyWorkFlow CompanyWorkFlow = new RASF.Main.Forms.Financial.CompanyWorkFlow();
            //CompanyWorkFlow.MdiParent = this;
            CompanyWorkFlow.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CompanyWorkFlow);
        }

        private void mnuConvertToInformal_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.ConvertToInformal ConvertToInformal = new RASF.Main.Forms.Manager.ConvertToInformal();
            //CompanyWorkFlow.MdiParent = this;
            ConvertToInformal.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ConvertToInformal);
        }

        private void mnuCompanyWorkFlowInformal_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.CompanyWorkFlowInformal CompanyWorkFlowInformal = new RASF.Main.Forms.Financial.CompanyWorkFlowInformal();
            //CompanyWorkFlow.MdiParent = this;
            CompanyWorkFlowInformal.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CompanyWorkFlowInformal);
        }

        private void mnuViewReceiptDemandForm_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Financial.ViewReceiptDemandForm ViewReceiptDemandForm = new RASF.Main.Forms.Financial.ViewReceiptDemandForm();
            ////CompanyWorkFlow.MdiParent = this;
            //ViewReceiptDemandForm.Text = ((ToolStripMenuItem)sender).Text;
            //ShowDocument(ViewReceiptDemandForm);
        }

        private void mnuReceiptDemandForCompaniesForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ReceiptDemandForCompaniesForm CompanyWorkFlow = new RASF.Main.Forms.Harmony.ReceiptDemandForCompaniesForm();
            //CompanyWorkFlow.MdiParent = this;
            CompanyWorkFlow.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CompanyWorkFlow);
        }

        private void mnuCompaniesReferntForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.CompaniesReferntForm CompaniesReferntForm = new RASF.Main.Forms.Marketing.CompaniesReferntForm();
            //CompanyWorkFlow.MdiParent = this;
            CompaniesReferntForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CompaniesReferntForm);
        }

        private void mnuCompaniesReferntForManager_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.CompaniesReferntForManager CompaniesReferntForm = new RASF.Main.Forms.Manager.CompaniesReferntForManager();
            //CompanyWorkFlow.MdiParent = this;
            CompaniesReferntForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CompaniesReferntForm);
        }

        private void mnuReciepOfCustomerForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.ReciepOfCustomerForm CompaniesReferntForm = new RASF.Main.Forms.Marketing.ReciepOfCustomerForm();
            //CompanyWorkFlow.MdiParent = this;
            CompaniesReferntForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CompaniesReferntForm);
        }

        private void mnuEnterMobileNoForCustomer_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Customer.EnterMobileNoForCustomer EnterMobileNoForCustomer = new RASF.Main.Forms.Customer.EnterMobileNoForCustomer();
            //CompanyWorkFlow.MdiParent = this;
            EnterMobileNoForCustomer.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(EnterMobileNoForCustomer);
        }
        private void mnuPOGCReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.POGCReport POGCReport = new RASF.Main.Forms.Marketing.POGCReport();
            //POGCReport.MdiParent = this;
            POGCReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(POGCReport);
        }

        private void mnuSertPartToContractors_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.SendToContractors SendToContractors = new RASF.Main.Forms.Laboratory.SendToContractors();
            //POGCReport.MdiParent = this;
            SendToContractors.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendToContractors);
        }

        private void mnuCostPaper_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new RASF.Main.Forms.Harmony.ViewCostPaper();
            //CostPaper.MdiParent = this;
            CostPaper.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CostPaper);
        }

        private void mnuViewLogDateToDate_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ViewLogDateToDate ViewLog = new RASF.Main.Forms.Harmony.ViewLogDateToDate();
            //CostPaper.MdiParent = this;
            ViewLog.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ViewLog);
        }

        private void mnuViewLog_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ViewLog ViewLog = new RASF.Main.Forms.Harmony.ViewLog();
            //CostPaper.MdiParent = this;
            ViewLog.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ViewLog);
        }

        private void mnuViewLogOpenReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ViewLogOpenReport ViewLog = new RASF.Main.Forms.Harmony.ViewLogOpenReport();
            //CostPaper.MdiParent = this;
            ViewLog.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ViewLog);
        }

        private void mnuViewCostPaperLaboratory_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.ViewCostPaperLaboratory CostPaper = new RASF.Main.Forms.Laboratory.ViewCostPaperLaboratory();
            //CostPaper.MdiParent = this;
            CostPaper.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CostPaper);
        }

        private void mnuMarketing_Credit_Company_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.Marketing_Credit_Company ValidateMarketing = new RASF.Main.Forms.Manager.Marketing_Credit_Company();
            //CostPaper.MdiParent = this;
            ValidateMarketing.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ValidateMarketing);
        }

        private void mnuWriteOffMarketingCompany_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.WriteOffMarketingCompany WriteOffMarketingCompany = new RASF.Main.Forms.Marketing.WriteOffMarketingCompany();
            //CostPaper.MdiParent = this;
            WriteOffMarketingCompany.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(WriteOffMarketingCompany);
        }

        private void mnuSaveCostPaper_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.EditContractForSaveCostPaper EditContractForSaveCostPaper = new RASF.Main.Forms.Harmony.EditContractForSaveCostPaper();
            //CostPaper.MdiParent = this;
            EditContractForSaveCostPaper.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(EditContractForSaveCostPaper);
        }

        private void mnuSaveEditedReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.EditeContractsSaveEditedReports EditeContractsSaveEditedReports = new RASF.Main.Forms.Harmony.EditeContractsSaveEditedReports();
            //CostPaper.MdiParent = this;
            EditeContractsSaveEditedReports.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(EditeContractsSaveEditedReports);
        }
        private void mnuTestForThePresenceDateChangeWithTime_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.TestForThePresenceDateChangeWithTime TestForThePresenceDateChangeWithTime = new RASF.Main.Forms.Harmony.TestForThePresenceDateChangeWithTime();
            //CostPaper.MdiParent = this;
            TestForThePresenceDateChangeWithTime.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(TestForThePresenceDateChangeWithTime);
        }

        private void mnuDifferenceInvoiceContract_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.DifferenceInvoiceContract DifferenceInvoiceContract = new RASF.Main.Forms.Financial.DifferenceInvoiceContract();
            //CostPaper.MdiParent = this;
            DifferenceInvoiceContract.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DifferenceInvoiceContract);
        }

        private void mnuEarnDeliveryDay_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.EarnDeliveryDay EarnDeliveryDay = new RASF.Main.Forms.Financial.EarnDeliveryDay();
            //CostPaper.MdiParent = this;
            EarnDeliveryDay.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(EarnDeliveryDay);
        }

        private void mnuIndicator_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.Indicator Indicator = new RASF.Main.Forms.Harmony.Indicator();
            //CostPaper.MdiParent = this;
            Indicator.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Indicator);
        }

        private void mnuIndicatorDelivery_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.IndicatorDelivery Indicator = new RASF.Main.Forms.Harmony.IndicatorDelivery();
            //CostPaper.MdiParent = this;
            Indicator.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Indicator);
        }

        private void mnuReportOfIndicator_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ReportOfIndicator ReportOfIndicator = new RASF.Main.Forms.Harmony.ReportOfIndicator();
            //CostPaper.MdiParent = this;
            ReportOfIndicator.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfIndicator);
        }

        private void mnuNotDeliveryReportToCustomer_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.NotDeliveryReportToCustomer NotDeliveryReportToCustomer = new RASF.Main.Forms.Harmony.NotDeliveryReportToCustomer();
            //CostPaper.MdiParent = this;
            NotDeliveryReportToCustomer.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(NotDeliveryReportToCustomer);
        }

        private void mnuDescriptionForSendTestContractors_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.DescriptionForSendTestContractors DescriptionForSendTestContractors = new RASF.Main.Forms.Harmony.DescriptionForSendTestContractors();
            //CostPaper.MdiParent = this;
            DescriptionForSendTestContractors.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DescriptionForSendTestContractors);
        }

        private void mnuRecieveExperimentFromContractor_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ReportOfSentPartToContractors ReportOfSentPartToContractors = new RASF.Main.Forms.Harmony.ReportOfSentPartToContractors();
            //CostPaper.MdiParent = this;
            ReportOfSentPartToContractors.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfSentPartToContractors);
        }

        private void mnuReportOfInvoiceOfContractors_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ReportOfInvoiceOfContractors ReportOfInvoiceOfContractors = new RASF.Main.Forms.Harmony.ReportOfInvoiceOfContractors();
            //CostPaper.MdiParent = this;
            ReportOfInvoiceOfContractors.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfInvoiceOfContractors);
        }

        private void mnuSentPartToContractorsForPreBill_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.SentPartToContractorsForPreBill SentPartToContractorsForPreBill = new RASF.Main.Forms.Harmony.SentPartToContractorsForPreBill();
            //CostPaper.MdiParent = this;
            SentPartToContractorsForPreBill.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SentPartToContractorsForPreBill);
        }

        private void mnuSentPartToContractorsForBill_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.SentPartToContractorsForBill SentPartToContractorsForBill = new RASF.Main.Forms.Harmony.SentPartToContractorsForBill();
            //CostPaper.MdiParent = this;
            SentPartToContractorsForBill.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SentPartToContractorsForBill);
        }
        
        private void mnuViewCostPaperForOfficess_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ViewCostPaperForOfficess ViewCostPaperForOfficess = new RASF.Main.Forms.Harmony.ViewCostPaperForOfficess();
            //CostPaper.MdiParent = this;
            ViewCostPaperForOfficess.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ViewCostPaperForOfficess);
        }

        private void mnuReferralCompanyReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.ReferralCompanyReport ReferralCompanyReport = new RASF.Main.Forms.Marketing.ReferralCompanyReport();
            //CostPaper.MdiParent = this;
            ReferralCompanyReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReferralCompanyReport);
        }

        private void mnuViewPartMasterOfContract_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ViewPartMasterOfContract ViewPartMasterOfContract = new RASF.Main.Forms.Harmony.ViewPartMasterOfContract();
            //ViewPartMasterOfContract.MdiParent = this;
            ViewPartMasterOfContract.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ViewPartMasterOfContract);
        }

        private void mnuCostPaperForOffices_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.CostPaperForOffices CostPaperForOffices = new RASF.Main.Forms.Harmony.CostPaperForOffices();
            //CostPaperForOffices.MdiParent = this;
            CostPaperForOffices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CostPaperForOffices);
        }

        private void mnuTheseparationofoffices_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.Theseparationofoffices Theseparationofoffices = new RASF.Main.Forms.Harmony.Theseparationofoffices();
            //Theseparationofoffices.MdiParent = this;
            Theseparationofoffices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Theseparationofoffices);
        }

        private void mnuFinancialOffices_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.FinancialOffices FinancialOffices = new RASF.Main.Forms.Financial.FinancialOffices();
            //FinancialOffices.MdiParent = this;
            FinancialOffices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FinancialOffices);
        }

        private void mnuEarninigOfAgencyRecieption_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.EarninigOfAgencyRecieption EarninigOfAgencyRecieption = new RASF.Main.Forms.ContractsReport.EarninigOfAgencyRecieption();
            //FinancialOffices.MdiParent = this;
            EarninigOfAgencyRecieption.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(EarninigOfAgencyRecieption);
        }


        private void mnuFinancialLaboratory_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.FinancialLaboratory FinancialLaboratory = new RASF.Main.Forms.Financial.FinancialLaboratory();
            //FinancialLaboratory.MdiParent = this;
            FinancialLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FinancialLaboratory);
        }

        private void mnucontactsiscompletednothasinvoiceForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.contactsiscompletednothasinvoiceForm contactsiscompletednothasinvoiceForm = new RASF.Main.Forms.Financial.contactsiscompletednothasinvoiceForm();
            //FinancialLaboratory.MdiParent = this;
            contactsiscompletednothasinvoiceForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(contactsiscompletednothasinvoiceForm);
        }

        private void mnuInvoceDebtor_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.DebtorInvoice DebtorInvoice = new RASF.Main.Forms.Financial.DebtorInvoice();
            // DebtorInvoice.MdiParent = this;
            DebtorInvoice.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DebtorInvoice);
        }

        private void mnuEnterPartsToStore_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.PartsSender PartsSender = new RASF.Main.Forms.Store.PartsSender();
            //PartsSender.MdiParent = this;
            PartsSender.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PartsSender);
        }

        private void mnuDontWaste_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.DontWaste DontWaste = new RASF.Main.Forms.Store.DontWaste();
            //PartsSender.MdiParent = this;
            DontWaste.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DontWaste);
        }

        private void mnuPartsSenderNotApproved_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.PartsSenderNotApproved PartsSender = new RASF.Main.Forms.Store.PartsSenderNotApproved();
            //PartsSender.MdiParent = this;
            PartsSender.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PartsSender);
        }

        private void mnuReportsOfEnterExitPiecesWestSideForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.ReportsOfEnterExitPiecesWestSideForm PartsSender = new RASF.Main.Forms.Store.ReportsOfEnterExitPiecesWestSideForm();
            //PartsSender.MdiParent = this;
            PartsSender.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PartsSender);
        }

        private void mnuPartsSenderForWestSide_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.PartsSenderForWestSide PartsSender = new RASF.Main.Forms.Store.PartsSenderForWestSide();
            //PartsSender.MdiParent = this;
            PartsSender.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PartsSender);
        }

        private void mnuPartsSenderForLargeSample_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.PartsSenderForLargeSample PartsSenderForLargeSample = new RASF.Main.Forms.Store.PartsSenderForLargeSample();
            //PartsSender.MdiParent = this;
            PartsSenderForLargeSample.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PartsSenderForLargeSample);
        }

        private void mnuCultchStore_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.CultchStore CultchStore = new RASF.Main.Forms.Store.CultchStore();
            //PartsSender.MdiParent = this;
            CultchStore.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CultchStore);
        }

        private void mnuBeDestroyedReport1Form_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.BeDestroyedReport1Form CultchStore = new RASF.Main.Forms.Store.BeDestroyedReport1Form();
            //PartsSender.MdiParent = this;
            CultchStore.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CultchStore);
        }

        private void mnuRemindSamleOfCompanyForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.RemindSamleOfCompanyForm RemindSamleOfCompanyForm = new RASF.Main.Forms.Store.RemindSamleOfCompanyForm();
            //PartsSender.MdiParent = this;
            RemindSamleOfCompanyForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RemindSamleOfCompanyForm);
        }

        private void mnuBeDestroyedReport2Form_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.BeDestroyedReport2Form CultchStore = new RASF.Main.Forms.Store.BeDestroyedReport2Form();
            //PartsSender.MdiParent = this;
            CultchStore.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CultchStore);
        }

        private void mnuBeDestroyedReport3Form_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.BeDestroyedReport3Form CultchStore = new RASF.Main.Forms.Store.BeDestroyedReport3Form();
            //PartsSender.MdiParent = this;
            CultchStore.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CultchStore);
        }

        private void mnuReportCultchStore_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.ReportCultchStore ReportCultchStore = new RASF.Main.Forms.Store.ReportCultchStore();
            //PartsSender.MdiParent = this;
            ReportCultchStore.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportCultchStore);
        }

        private void mnuPiecesNotExitedBonyad_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.PiecesNotExitedBonyad PiecesNotExitedBonyad = new RASF.Main.Forms.Store.PiecesNotExitedBonyad();
            //PartsSender.MdiParent = this;
            PiecesNotExitedBonyad.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PiecesNotExitedBonyad);
        }

        private void mnuReportsOfEnterExitPiecesForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.ReportsOfEnterExitPiecesForm ReportsOfEnterExitPiecesForm = new RASF.Main.Forms.Store.ReportsOfEnterExitPiecesForm();
            // ReportsOfEnterExitPiecesForm.MdiParent = this;
            ReportsOfEnterExitPiecesForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportsOfEnterExitPiecesForm);
        }

        private void mnuReportsOfEnterExitPiecesForLargeSampleForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.ReportsOfEnterExitPiecesForLargeSampleForm ReportsOfEnterExitPiecesForm = new RASF.Main.Forms.Store.ReportsOfEnterExitPiecesForLargeSampleForm();
            // ReportsOfEnterExitPiecesForm.MdiParent = this;
            ReportsOfEnterExitPiecesForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportsOfEnterExitPiecesForm);
        }

        private void mnuPartsThatExitedFromStoreToLaboratory_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.PartsThatExitedFromStoreToLaboratory PartsThatExitedFromStoreToLaboratory = new RASF.Main.Forms.Store.PartsThatExitedFromStoreToLaboratory();
            //PartsThatExitedFromStoreToLaboratory.MdiParent = this;
            PartsThatExitedFromStoreToLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PartsThatExitedFromStoreToLaboratory);
        }

        private void mnuPartsThatExitedFromStoreToLaboratoryLargeSample_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.PartsThatExitedFromStoreToLaboratoryLargeSample PartsThatExitedFromStoreToLaboratory = new RASF.Main.Forms.Store.PartsThatExitedFromStoreToLaboratoryLargeSample();
            //PartsThatExitedFromStoreToLaboratory.MdiParent = this;
            PartsThatExitedFromStoreToLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PartsThatExitedFromStoreToLaboratory);
        }

        private void mnuPartsThatExitedFromStoreToLaboratoryWestSide_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.PartsThatExitedFromStoreToLaboratoryWestSide PartsThatExitedFromStoreToLaboratory = new RASF.Main.Forms.Store.PartsThatExitedFromStoreToLaboratoryWestSide();
            //PartsThatExitedFromStoreToLaboratory.MdiParent = this;
            PartsThatExitedFromStoreToLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PartsThatExitedFromStoreToLaboratory);
        }

        private void mnuPartsThatExitedToLaboratory_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.PartsThatExitedToLaboratory PartsThatExitedToLaboratory = new RASF.Main.Forms.Store.PartsThatExitedToLaboratory();
            //PartsThatExitedToLaboratory.MdiParent = this;
            PartsThatExitedToLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PartsThatExitedToLaboratory);
        }

        private void mnuPartsThatExitedToLaboratoryLargeSample_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.PartsThatExitedToLaboratoryLargeSample PartsThatExitedToLaboratory = new RASF.Main.Forms.Store.PartsThatExitedToLaboratoryLargeSample();
            //PartsThatExitedToLaboratory.MdiParent = this;
            PartsThatExitedToLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PartsThatExitedToLaboratory);
        }

        private void mnuPartsThatExitedToLaboratoryWestSide_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.PartsThatExitedToLaboratoryWestSide PartsThatExitedToLaboratory = new RASF.Main.Forms.Store.PartsThatExitedToLaboratoryWestSide();
            //PartsThatExitedToLaboratory.MdiParent = this;
            PartsThatExitedToLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PartsThatExitedToLaboratory);
        }


        private void mnuAccesUsers_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Settings.AccessUser AccessUser = new RASF.Main.Forms.Settings.AccessUser();
            // AccessUser.MdiParent = this;
            AccessUser.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(AccessUser);
        }

        private void mnuRelationBetweenExecuterAndUsers_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Settings.RelationBetweenExecuterAndUsers RelationBetweenExecuterAndUsers = new RASF.Main.Forms.Settings.RelationBetweenExecuterAndUsers();
            // RelationBetweenExecuterAndUsers.MdiParent = this;
            RelationBetweenExecuterAndUsers.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RelationBetweenExecuterAndUsers);
        }

        private void mnuUserAndExecuterForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Settings.UserAndExecuterForm UserAndExecuterForm = new RASF.Main.Forms.Settings.UserAndExecuterForm();
            // RelationBetweenExecuterAndUsers.MdiParent = this;
            UserAndExecuterForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(UserAndExecuterForm);
        }

        private void mnuCOMPANIES_BASEForManager_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.COMPANIES_BASE companiesBase = new RASF.Main.Forms.COMPANIES_BASE(Janus.Windows.GridEX.InheritableBoolean.False);
            // companiesBase.MdiParent = this;
            companiesBase.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(companiesBase);
        }

        private void mnuCompanies_Base_CellNum_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Base.Companies_Base_CellNum companiesBase = new RASF.Main.Forms.Base.Companies_Base_CellNum();
            // companiesBase.MdiParent = this;
            companiesBase.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(companiesBase);
        }

        private void mnuInspectCompany_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Base.InspectCompany InspectCompany = new RASF.Main.Forms.Base.InspectCompany();
            // companiesBase.MdiParent = this;
            InspectCompany.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(InspectCompany);
        }

        private void mnuDaneshBonyanForLaboratory_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.DaneshBonyanForLaboratory DaneshBonyanForLaboratory = new RASF.Main.Forms.Manager.DaneshBonyanForLaboratory();
            // OfficeofFinancialConditionReport.MdiParent = this;
            DaneshBonyanForLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DaneshBonyanForLaboratory);
        }

        private void mnuCountTestOfLaboratory_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.CountTestOfLaboratory CountTestOfLaboratory = new RASF.Main.Forms.Manager.CountTestOfLaboratory();
            // OfficeofFinancialConditionReport.MdiParent = this;
            CountTestOfLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CountTestOfLaboratory);
        }
        private void mnuReportMounthlyLaboratory2014To2015Form_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Financial.ReportMounthlyLaboratory2014To2015Form ReportMounthlyLaboratory2014To2015Form = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory2014To2015Form();
            RASF.Main.Forms.Financial.ReportMounthlyLaboratory ReportMounthlyLaboratory = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory(1393);
            ReportMounthlyLaboratory.Name += "_1393";
            ReportMounthlyLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMounthlyLaboratory);
        }
        private void mnuReportMounthlyLaboratory2015To2016Form_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Financial.ReportMounthlyLaboratory2015To2016Form ReportMounthlyLaboratory2015To2016Form = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory2015To2016Form();
            RASF.Main.Forms.Financial.ReportMounthlyLaboratory ReportMounthlyLaboratory = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory(1394);
            ReportMounthlyLaboratory.Name += "_1394";
            ReportMounthlyLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMounthlyLaboratory);
        }
        private void mnuReportMounthlyLaboratoryForm_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Financial.ReportMounthlyLaboratoryForm ReportMounthlyLaboratoryForm = new RASF.Main.Forms.Financial.ReportMounthlyLaboratoryForm();
            RASF.Main.Forms.Financial.ReportMounthlyLaboratory ReportMounthlyLaboratory = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory(1395);
            ReportMounthlyLaboratory.Name += "_1395";
            ReportMounthlyLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMounthlyLaboratory);
        }
        private void mnuReportMounthlyLaboratory2017To2018Form_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Financial.ReportMounthlyLaboratory2017To2018Form ReportMounthlyLaboratory2017To2018Form = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory2017To2018Form();
            RASF.Main.Forms.Financial.ReportMounthlyLaboratory ReportMounthlyLaboratory = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory(1396);
            ReportMounthlyLaboratory.Name += "_1396";
            ReportMounthlyLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMounthlyLaboratory);
        }

        private void mnuReportMounthlyLaboratory2018To2019Form_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Financial.ReportMounthlyLaboratory2018To2019Form ReportMounthlyLaboratory2018To2019Form = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory2018To2019Form();
            RASF.Main.Forms.Financial.ReportMounthlyLaboratory ReportMounthlyLaboratory = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory(1397);
            ReportMounthlyLaboratory.Name += "_1397";
            ReportMounthlyLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMounthlyLaboratory);
        }

        private void mnuReportMounthlyLaboratory2019To2020Form_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Financial.ReportMounthlyLaboratory2019To2020Form ReportMounthlyLaboratory2019To2020Form = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory2019To2020Form();
            RASF.Main.Forms.Financial.ReportMounthlyLaboratory ReportMounthlyLaboratory = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory(1398);
            ReportMounthlyLaboratory.Name += "_1398";
            ReportMounthlyLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMounthlyLaboratory);
        }

        private void mnuReportMounthlyLaboratory2020To2021Form_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Financial.ReportMounthlyLaboratory2020To2021Form ReportMounthlyLaboratory2020To2021Form = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory2020To2021Form();
            RASF.Main.Forms.Financial.ReportMounthlyLaboratory ReportMounthlyLaboratory = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory(1399);
            ReportMounthlyLaboratory.Name += "_1399";
            ReportMounthlyLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMounthlyLaboratory);
        }

        private void mnuReportMounthlyLaboratory2021To2022Form_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Financial.ReportMounthlyLaboratory2021To2022Form ReportMounthlyLaboratory2021To2022Form = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory2021To2022Form();
            RASF.Main.Forms.Financial.ReportMounthlyLaboratory ReportMounthlyLaboratory = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory(1400);
            ReportMounthlyLaboratory.Name += "_1400";
            ReportMounthlyLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMounthlyLaboratory);
        }

        private void mnuReportMounthlyLaboratory2022To2023Form_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Financial.ReportMounthlyLaboratory2022To2023Form ReportMounthlyLaboratory2022To2023Form = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory2022To2023Form();
            RASF.Main.Forms.Financial.ReportMounthlyLaboratory ReportMounthlyLaboratory = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory(1401);
            ReportMounthlyLaboratory.Name += "_1401";
            ReportMounthlyLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMounthlyLaboratory);
        }

        private void mnuReportMounthlyLaboratory2023To2024Form_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Financial.ReportMounthlyLaboratory2023To2024Form ReportMounthlyLaboratory2023To2024Form = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory2023To2024Form();
            RASF.Main.Forms.Financial.ReportMounthlyLaboratory ReportMounthlyLaboratory = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory(1402);
            ReportMounthlyLaboratory.Name += "_1402";
            ReportMounthlyLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMounthlyLaboratory);
        }

        private void mnuReportMounthlyLaboratory2024To2025Form_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Financial.ReportMounthlyLaboratory2024To2025Form ReportMounthlyLaboratory2024To2025Form = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory2024To2025Form();
            RASF.Main.Forms.Financial.ReportMounthlyLaboratory ReportMounthlyLaboratory = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory(1403);
            ReportMounthlyLaboratory.Name += "_1403";
            ReportMounthlyLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMounthlyLaboratory);
        }

        private void mnuReportMounthlyLaboratory2025To2026Form_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Financial.ReportMounthlyLaboratory2025To2026Form ReportMounthlyLaboratory2025To2026Form = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory2025To2026Form();
            RASF.Main.Forms.Financial.ReportMounthlyLaboratory ReportMounthlyLaboratory = new RASF.Main.Forms.Financial.ReportMounthlyLaboratory(1404);
            ReportMounthlyLaboratory.Name += "_1404";
            ReportMounthlyLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMounthlyLaboratory);
        }

        private void mnuReportMounthlyAgency2018To2019_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.ReportMounthlyAgency2018To2019 ReportMounthlyAgency2018To2019 = new RASF.Main.Forms.Manager.ReportMounthlyAgency2018To2019();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ReportMounthlyAgency2018To2019.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMounthlyAgency2018To2019);
        }

        private void mnuReportMounthly2018To2019FinancialForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ReportMounthly2018To2019FinancialForm ReportMounthlyLaboratory2018To2019Form = new RASF.Main.Forms.Financial.ReportMounthly2018To2019FinancialForm();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ReportMounthlyLaboratory2018To2019Form.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMounthlyLaboratory2018To2019Form);
        }

        private void mnuReportMounthly2019To20209FinancialForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ReportMounthly2019To2020FinancialForm ReportMounthly2019To2020FinancialForm = new RASF.Main.Forms.Financial.ReportMounthly2019To2020FinancialForm();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ReportMounthly2019To2020FinancialForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMounthly2019To2020FinancialForm);
        }

        private void mnuDailyProcessReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.DailyProcessReport DailyProcessReport = new RASF.Main.Forms.Financial.DailyProcessReport();
            // OfficeofFinancialConditionReport.MdiParent = this;
            DailyProcessReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DailyProcessReport);
        }

        private void mnuManagerOfDiscount_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.ManagerOfDiscount ManagerOfDiscount = new RASF.Main.Forms.Manager.ManagerOfDiscount();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ManagerOfDiscount.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ManagerOfDiscount);
        }

        private void mnuKarkardCooperationForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.KarkardCooperationForm KarkardCooperationForm = new RASF.Main.Forms.Manager.KarkardCooperationForm();
            // OfficeofFinancialConditionReport.MdiParent = this;
            KarkardCooperationForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(KarkardCooperationForm);
        }

        private void mnuKarkardCooperationWithAgency_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.KarkardCooperationWithAgencyForm KarkardCooperationWithAgencyForm = new RASF.Main.Forms.Manager.KarkardCooperationWithAgencyForm();
            // OfficeofFinancialConditionReport.MdiParent = this;
            KarkardCooperationWithAgencyForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(KarkardCooperationWithAgencyForm);
        }

        private void mnuChartOfDailyProcessReport_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Dash.ChartOfDailyProcessReport DailyProcessReport = new RASF.Main.Forms.Dash.ChartOfDailyProcessReport();
            //// OfficeofFinancialConditionReport.MdiParent = this;
            //DailyProcessReport.Text = ((ToolStripMenuItem)sender).Text;
            //ShowDocument(DailyProcessReport);
        }

        private void mnuReportMounthlyLaboratory2017To2018_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Dash.ReportMounthlyLaboratory2017To2018 ReportMounthlyLaboratory2017To2018 = new RASF.Main.Forms.Dash.ReportMounthlyLaboratory2017To2018();
            //// OfficeofFinancialConditionReport.MdiParent = this;
            //ReportMounthlyLaboratory2017To2018.Text = ((ToolStripMenuItem)sender).Text;
            //ShowDocument(ReportMounthlyLaboratory2017To2018);
        }


        private void mnuReportMounthlyTedadLaboratory2022To2023Form_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ReportMounthlyTedadLaboratory2022To2023Form ReportMounthlyTedadLaboratory2022To2023Form = new RASF.Main.Forms.Financial.ReportMounthlyTedadLaboratory2022To2023Form();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ReportMounthlyTedadLaboratory2022To2023Form.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMounthlyTedadLaboratory2022To2023Form);
        }

        private void mnuReportMounthlyTedadLaboratory2023To2024Form_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ReportMounthlyTedadLaboratory2023To2024Form ReportMounthlyTedadLaboratory2023To2024Form = new RASF.Main.Forms.Financial.ReportMounthlyTedadLaboratory2023To2024Form();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ReportMounthlyTedadLaboratory2023To2024Form.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMounthlyTedadLaboratory2023To2024Form);
        }

        private void mnuDarsadReportMounthlyLaboratory2017To2018_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Dash.DarsadReportMounthlyLaboratory2017To2018 DarsadReportMounthlyLaboratory2017To2018 = new RASF.Main.Forms.Dash.DarsadReportMounthlyLaboratory2017To2018();
            //// OfficeofFinancialConditionReport.MdiParent = this;
            //DarsadReportMounthlyLaboratory2017To2018.Text = ((ToolStripMenuItem)sender).Text;
            //ShowDocument(DarsadReportMounthlyLaboratory2017To2018);
        }

        private void mnuContractIsVoidSegregate_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ContractIsVoidSegregate ContractIsVoidSegregate = new RASF.Main.Forms.Financial.ContractIsVoidSegregate();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ContractIsVoidSegregate.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ContractIsVoidSegregate);
        }

        private void mnuDailyProcessReportForLaboratoryForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.DailyProcessReportForLaboratoryForm DailyProcessReportForLaboratoryForm = new RASF.Main.Forms.Financial.DailyProcessReportForLaboratoryForm();
            // OfficeofFinancialConditionReport.MdiParent = this;
            DailyProcessReportForLaboratoryForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DailyProcessReportForLaboratoryForm);
        }

        private void mnuChartOfDailyProcessReportForLaboratoryForm_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Dash.ChartOfDailyProcessReportForLaboratoryForm DailyProcessReportForLaboratoryForm = new RASF.Main.Forms.Dash.ChartOfDailyProcessReportForLaboratoryForm();
            //// OfficeofFinancialConditionReport.MdiParent = this;
            //DailyProcessReportForLaboratoryForm.Text = ((ToolStripMenuItem)sender).Text;
            //ShowDocument(DailyProcessReportForLaboratoryForm);
        }
        private void mnuOfficeofFinancialConditionReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.OfficeofFinancialConditionReport OfficeofFinancialConditionReport = new RASF.Main.Forms.Financial.OfficeofFinancialConditionReport();
            // OfficeofFinancialConditionReport.MdiParent = this;
            OfficeofFinancialConditionReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(OfficeofFinancialConditionReport);
        }

        //گزارش شرکت های اعتباری
        //private void mnuReportOfCreditCompany_Click(object sender, EventArgs e)
        //{
        //    RASF.Main.Forms.Financial.ReportOfCreditCompany ReportOfCreditCompany = new RASF.Main.Forms.Financial.ReportOfCreditCompany();
        //    // OfficeofFinancialConditionReport.MdiParent = this;
        //    ReportOfCreditCompany.Text = ((ToolStripMenuItem)sender).Text;
        //    ShowDocument(ReportOfCreditCompany);
        //}

        private void mnuReportOfCashCompany_Fin_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ReportOfCashCompany_Fin ReportOfCashCompany_Fin = new RASF.Main.Forms.Financial.ReportOfCashCompany_Fin();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ReportOfCashCompany_Fin.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfCashCompany_Fin);
        }

        private void mnuReportOfCreditCompany_Fin_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ReportOfCreditCompany_Fin ReportOfCreditCompany = new RASF.Main.Forms.Financial.ReportOfCreditCompany_Fin();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ReportOfCreditCompany.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfCreditCompany);
        }

        private void mnuViewSabtSamane_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.ViewSabtSamane ViewSabtSamane = new RASF.Main.Forms.ContractsReport.ViewSabtSamane();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ViewSabtSamane.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ViewSabtSamane);
        }

        private void mnuViewRegisteredReportSamene_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.ViewRegisteredReportSamene ViewSabtSamane = new RASF.Main.Forms.ContractsReport.ViewRegisteredReportSamene();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ViewSabtSamane.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ViewSabtSamane);
        }

        private void mnuGiveReportDependOnClearing_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.GiveReportDependOnClearing GiveReportDependOnClearing = new RASF.Main.Forms.Harmony.GiveReportDependOnClearing();
            // OfficeofFinancialConditionReport.MdiParent = this;
            GiveReportDependOnClearing.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(GiveReportDependOnClearing);
        }

        private void mnuDependOnClearingBeforFactor_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.DependOnClearingBeforFactor DependOnClearingBeforFactor = new RASF.Main.Forms.Harmony.DependOnClearingBeforFactor();
            // OfficeofFinancialConditionReport.MdiParent = this;
            DependOnClearingBeforFactor.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DependOnClearingBeforFactor);
        }

        private void mnuChequeForWarrantyForCompanyReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ChequeForWarrantyForCompanyReport ChequeForWarrantyForCompanyReport = new RASF.Main.Forms.Harmony.ChequeForWarrantyForCompanyReport();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ChequeForWarrantyForCompanyReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ChequeForWarrantyForCompanyReport);
        }

        //گزارش شرکت های نقدی
        //private void mnuReportOfCashCompany_Click(object sender, EventArgs e)
        //{
        //    RASF.Main.Forms.Financial.ReportOfCashCompany ReportOfCashCompany = new RASF.Main.Forms.Financial.ReportOfCashCompany();
        //    // OfficeofFinancialConditionReport.MdiParent = this;
        //    ReportOfCashCompany.Text = ((ToolStripMenuItem)sender).Text;
        //    ShowDocument(ReportOfCashCompany);
        //}

        private void mnuReportOfCompanyKol_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ReportOfCompanyKol ReportOfCompanyKol = new RASF.Main.Forms.Financial.ReportOfCompanyKol();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ReportOfCompanyKol.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfCompanyKol);
        }

        private void mnuReportOfCompanyKol_1_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ReportOfCompanyKol_1 ReportOfCompanyKol_1 = new RASF.Main.Forms.Financial.ReportOfCompanyKol_1();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ReportOfCompanyKol_1.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfCompanyKol_1);
        }

        private void mnuCompaniesOfTafahomName_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.CompaniesOfTafahomName CompaniesOfTafahomName = new RASF.Main.Forms.Manager.CompaniesOfTafahomName();
            // OfficeofFinancialConditionReport.MdiParent = this;
            CompaniesOfTafahomName.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CompaniesOfTafahomName);
        }


        private void mnuDebtors_AgeBalance_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.Debtors_AgeBalance Debtors_AgeBalance = new RASF.Main.Forms.Manager.Debtors_AgeBalance();
            // OfficeofFinancialConditionReport.MdiParent = this;
            Debtors_AgeBalance.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Debtors_AgeBalance);
        }

        private void mnuNanoReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.NanoReport NanoReports = new RASF.Main.Forms.Harmony.NanoReport();
            // OfficeofFinancialConditionReport.MdiParent = this;
            NanoReports.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(NanoReports);
        }

        private void mnuNanoReports_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.NanoReports NanoReports = new RASF.Main.Forms.Marketing.NanoReports();
            // OfficeofFinancialConditionReport.MdiParent = this;
            NanoReports.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(NanoReports);
        }

        private void mnuReportMarketingActivity_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.ReportMarketingActivity ReportMarketingActivity = new RASF.Main.Forms.Marketing.ReportMarketingActivity();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ReportMarketingActivity.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMarketingActivity);
        }

        private void mnuSummaryofCompaniesstatus_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.SummaryofCompaniesstatus SummaryofCompaniesstatus = new RASF.Main.Forms.Marketing.SummaryofCompaniesstatus();
            // OfficeofFinancialConditionReport.MdiParent = this;
            SummaryofCompaniesstatus.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SummaryofCompaniesstatus);
        }

        private void mnuAcceptAndNonAcceptActivity_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.AcceptAndNonAcceptActivity MarketingActivity = new RASF.Main.Forms.Marketing.AcceptAndNonAcceptActivity();
            // OfficeofFinancialConditionReport.MdiParent = this;
            MarketingActivity.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(MarketingActivity);
        }

        private void mnuReferralsCompany_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.ReferralsCompany ReferralsCompany = new RASF.Main.Forms.Marketing.ReferralsCompany();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ReferralsCompany.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReferralsCompany);
        }

        private void mnuReferralsCompanyToConnector_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.ReferralsCompanyToConnector ReferralsCompany = new RASF.Main.Forms.Marketing.ReferralsCompanyToConnector();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ReferralsCompany.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReferralsCompany);
        }

        private void mnuLaboratoryDayDelivery_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.LaboratoryDayDelivery LaboratoryDayDelivery = new RASF.Main.Forms.ContractsReport.LaboratoryDayDelivery();
            // OfficeofFinancialConditionReport.MdiParent = this;
            LaboratoryDayDelivery.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(LaboratoryDayDelivery);
        }

        private void mnuTimingSem_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.SEM.TimingSem TimingSem = new RASF.Main.Forms.SEM.TimingSem();
            // OfficeofFinancialConditionReport.MdiParent = this;
            TimingSem.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(TimingSem);
        }

        private void mnuReportOfWarrantyCheque_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ReportOfWarrantyCheque ReportOfWarrantyCheque = new RASF.Main.Forms.Financial.ReportOfWarrantyCheque();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ReportOfWarrantyCheque.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfWarrantyCheque);
        }

        private void mnuReportOfBetOfClearing_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ReportOfBetOfClearing ReportOfBetOfClearing = new RASF.Main.Forms.Financial.ReportOfBetOfClearing();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ReportOfBetOfClearing.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfBetOfClearing);
        }

        private void mnuReportOfClearingBeforFactor_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ReportOfClearingBeforFactor ReportOfClearingBeforFactor = new RASF.Main.Forms.Financial.ReportOfClearingBeforFactor();
            // OfficeofFinancialConditionReport.MdiParent = this;
            ReportOfClearingBeforFactor.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfClearingBeforFactor);
        }

        
        private void mnuLaboratoryofFinancialConditionReport1_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.LaboratoryofFinancialConditionReport LaboratoryofFinancialConditionReport = new RASF.Main.Forms.Financial.LaboratoryofFinancialConditionReport();
            // LaboratoryofFinancialConditionReport.MdiParent = this;
            LaboratoryofFinancialConditionReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(LaboratoryofFinancialConditionReport);
        }

            private void mnuLaboratoryofFinancialConditionReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.LaboratoryofFinancialConditionReport LaboratoryofFinancialConditionReport = new RASF.Main.Forms.Financial.LaboratoryofFinancialConditionReport();
            // LaboratoryofFinancialConditionReport.MdiParent = this;
            LaboratoryofFinancialConditionReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(LaboratoryofFinancialConditionReport);
        }

        private void mnuChartLaboratoryofFinancialConditionReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ChartLaboratoryofFinancialConditionReport ChartLaboratoryofFinancialConditionReport = new RASF.Main.Forms.Financial.ChartLaboratoryofFinancialConditionReport();
            // ChartLaboratoryofFinancialConditionReport.MdiParent = this;
            ChartLaboratoryofFinancialConditionReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ChartLaboratoryofFinancialConditionReport);
        }

        private void mnuMissMatchCompanyNameRecieptAmount_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.MissMatchCompanyNameRecieptAmount MissMatchCompanyNameRecieptAmount = new RASF.Main.Forms.Financial.MissMatchCompanyNameRecieptAmount();
            // Theamountofdailyintake.MdiParent = this;
            MissMatchCompanyNameRecieptAmount.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(MissMatchCompanyNameRecieptAmount);
        }

        private void mnuTheamountofdailyintake_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Receipt.Theamountofdailyintake Theamountofdailyintake = new RASF.Main.Forms.Receipt.Theamountofdailyintake();
            // Theamountofdailyintake.MdiParent = this;
            Theamountofdailyintake.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Theamountofdailyintake);
        }

        private void mnuVoidOfReciept_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Receipt.VoidOfReciept VoidOfReciept = new RASF.Main.Forms.Receipt.VoidOfReciept();
            // Theamountofdailyintake.MdiParent = this;
            VoidOfReciept.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(VoidOfReciept);
        }

        private void mnuTheamountofdailyintakeForInformal_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Receipt.TheamountofdailyintakeForInformal TheamountofdailyintakeForInformal = new RASF.Main.Forms.Receipt.TheamountofdailyintakeForInformal();
            // Theamountofdailyintake.MdiParent = this;
            TheamountofdailyintakeForInformal.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(TheamountofdailyintakeForInformal);
        }

        private void mnuViewWriteOff_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Receipt.ViewWriteOff ViewWriteOff = new RASF.Main.Forms.Receipt.ViewWriteOff();
            // Theamountofdailyintake.MdiParent = this;
            ViewWriteOff.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ViewWriteOff);
        }


        private void mnuGenerateLable_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Lable.GenerateLabel GenerateLable = new RASF.Main.Forms.Lable.GenerateLabel();
            // GenerateLable.MdiParent = this;
            GenerateLable.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(GenerateLable);
        }

        private void mnuGenerateLableForAll_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Lable.GenerateLableForAll GenerateLable = new RASF.Main.Forms.Lable.GenerateLableForAll();
            // GenerateLable.MdiParent = this;
            GenerateLable.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(GenerateLable);
        }

        private void mnuSettledcontracts_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.Settledcontracts Settledcontracts = new RASF.Main.Forms.ContractsReport.Settledcontracts();
            //  Settledcontracts.MdiParent = this;
            Settledcontracts.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Settledcontracts);
        }

        private void mnuDeliveryDay_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.DeliveryDay DeliveryDay = new RASF.Main.Forms.ContractsReport.DeliveryDay();
            //  DeliveryDay.MdiParent = this;
            DeliveryDay.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDay);
        }

        private void mnuDeliveryDayExecutersLaboratory_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.DeliveryDayExecutersLaboratory DeliveryDay = new RASF.Main.Forms.ContractsReport.DeliveryDayExecutersLaboratory();
            //  DeliveryDay.MdiParent = this;
            DeliveryDay.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDay);
        }

        private void mnuRegisterLaboratoryExecuters_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.RegisterLaboratoryExecuters RegisterLaboratoryExecuters = new RASF.Main.Forms.ContractsReport.RegisterLaboratoryExecuters();
            //  DeliveryDay.MdiParent = this;
            RegisterLaboratoryExecuters.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RegisterLaboratoryExecuters);
        }

        private void mnuTahviliAmadesazi_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Amadesazi.TahviliAmadesazi TahviliAmadesazi = new RASF.Main.Forms.Amadesazi.TahviliAmadesazi();
           // TahviliAmadesazi.MdiParent = this;
            TahviliAmadesazi.Show();
          //  TahviliAmadesazi.Text = ((ToolStripMenuItem)sender).Text;
           // ShowDocument(TahviliAmadesazi);
        }

        private void mnuDeliveryDayForMasterName_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.DeliveryDayForMasterName DeliveryDayForMasterName = new RASF.Main.Forms.ContractsReport.DeliveryDayForMasterName();
            //  DeliveryDay.MdiParent = this;
            DeliveryDayForMasterName.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDayForMasterName);
        }

        private void mnuDeliveryDayForMasterNameVayerkat_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.DeliveryDayForMasterNameVayerkat DeliveryDayForMasterNameVayerkat = new RASF.Main.Forms.ContractsReport.DeliveryDayForMasterNameVayerkat();
            //  DeliveryDay.MdiParent = this;
            DeliveryDayForMasterNameVayerkat.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDayForMasterNameVayerkat);
        }

        private void mnuDeliveryDayForDetailName_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.DeliveryDayForDetailName DeliveryDayForDetailName = new RASF.Main.Forms.ContractsReport.DeliveryDayForDetailName();
            //  DeliveryDay.MdiParent = this;
            DeliveryDayForDetailName.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDayForDetailName);
        }

        private void mnuDeliveryDayCountOfMain_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.DeliveryDayCountOfMain DeliveryDayCountOfMain = new RASF.Main.Forms.ContractsReport.DeliveryDayCountOfMain();
            //  DeliveryDay.MdiParent = this;
            DeliveryDayCountOfMain.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDayCountOfMain);
        }

        private void mnuDeliveryNotEntered_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.DeliveryNotEntered DeliveryDayCountOfMain = new RASF.Main.Forms.ContractsReport.DeliveryNotEntered();
            //  DeliveryDay.MdiParent = this;
            DeliveryDayCountOfMain.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDayCountOfMain);
        }

        private void mnuDeliveryNotExited_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.DeliveryNotExited DeliveryNotExited = new RASF.Main.Forms.ContractsReport.DeliveryNotExited();
            //  DeliveryDay.MdiParent = this;
            DeliveryNotExited.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryNotExited);
        }

        private void mnuDeliveryDatePreparationOfMain_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.DeliveryDatePreparationOfMain DeliveryDatePreparationOfMain = new RASF.Main.Forms.ContractsReport.DeliveryDatePreparationOfMain();
            //  DeliveryDay.MdiParent = this;
            DeliveryDatePreparationOfMain.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDatePreparationOfMain);
        }

        private void mnuDeliveraDayAbadi_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.DeliveraDayAbadi DeliveraDayAbadi = new RASF.Main.Forms.ContractsReport.DeliveraDayAbadi();
            //  DeliveryDay.MdiParent = this;
            DeliveraDayAbadi.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveraDayAbadi);
        }

        private void mnuDetailOfDeliveryDatePreparation_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.DetailOfDeliveryDatePreparation DeliveryDatePreparationOfMain = new RASF.Main.Forms.ContractsReport.DetailOfDeliveryDatePreparation();
            //  DeliveryDay.MdiParent = this;
            DeliveryDatePreparationOfMain.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDatePreparationOfMain);
        }

        private void mnuDeliveryDayForOffices_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.DeliveryDayForOffices DeliveryDayForOffices = new RASF.Main.Forms.ContractsReport.DeliveryDayForOffices();
            //  DeliveryDay.MdiParent = this;
            DeliveryDayForOffices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDayForOffices);
        }

        private void mnuDeliveryDayForRecieption_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.DeliveryDayForRecieption DeliveryDay = new RASF.Main.Forms.ContractsReport.DeliveryDayForRecieption();
            //  DeliveryDay.MdiParent = this;
            DeliveryDay.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDay);
        }

        private void mnuViewLogOpenReportFromTo_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ViewLogOpenReportFromTo ViewLogOpenReportFromTo = new RASF.Main.Forms.Harmony.ViewLogOpenReportFromTo();
            //  DeliveryDay.MdiParent = this;
            ViewLogOpenReportFromTo.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ViewLogOpenReportFromTo);
        }

        private void mnuReportOfCompanyForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.ReportOfCompanyForm ReportOfCompanyForm = new RASF.Main.Forms.ContractsReport.ReportOfCompanyForm();
            //  DeliveryDay.MdiParent = this;
            ReportOfCompanyForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfCompanyForm);
        }

        private void mnuDeliveryDayForHarmony_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.DeliveryDayForHarmony DeliveryDay = new RASF.Main.Forms.ContractsReport.DeliveryDayForHarmony();
            //  DeliveryDay.MdiParent = this;
            DeliveryDay.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDay);
        }

        private void mnuDeliveryDayForTaeenGrade_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.DeliveryDayForTaeenGrade DeliveryDay = new RASF.Main.Forms.ContractsReport.DeliveryDayForTaeenGrade();
            //  DeliveryDay.MdiParent = this;
            DeliveryDay.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDay);
        }

        private void mnuReturnedToScience_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.ReturnedToScience ReturnedToScience = new RASF.Main.Forms.ContractsReport.ReturnedToScience();
            //  DeliveryDay.MdiParent = this;
            ReturnedToScience.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReturnedToScience);
        }

        private void mnuTestForThePresenceForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.TestForThePresenceForm TestForThePresenceForm = new RASF.Main.Forms.Harmony.TestForThePresenceForm();
            //  DeliveryDay.MdiParent = this;
            TestForThePresenceForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(TestForThePresenceForm);
        }

        private void mnuTestForThePresenceDateForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.TestForThePresenceDateForm TestForThePresenceForm = new RASF.Main.Forms.Harmony.TestForThePresenceDateForm();
            //  DeliveryDay.MdiParent = this;
            TestForThePresenceForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(TestForThePresenceForm);
        }

        private void mnuDontHaveDeliveryDateForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.DontHaveDeliveryDateForm DontHaveDeliveryDateForm = new RASF.Main.Forms.Harmony.DontHaveDeliveryDateForm();
            //  DeliveryDay.MdiParent = this;
            DontHaveDeliveryDateForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DontHaveDeliveryDateForm);
        }
        private void mnuDeliveryDayForManager_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.DeliveryDayForManager DeliveryDayForManager = new RASF.Main.Forms.Manager.DeliveryDayForManager();
            //  DeliveryDay.MdiParent = this;
            DeliveryDayForManager.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDayForManager);
        }

        private void mnuRepotOfPeices_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.RepotOfPeices RepotOfPeices = new RASF.Main.Forms.Harmony.RepotOfPeices();
            //  DeliveryDay.MdiParent = this;
            RepotOfPeices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RepotOfPeices);
        }

        private void mnuReportDeliveryReportThetNotIsCompleted_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.ReportDeliveryReportThetNotIsCompleted DeliveryDayForManager = new RASF.Main.Forms.Manager.ReportDeliveryReportThetNotIsCompleted();
            //  DeliveryDay.MdiParent = this;
            DeliveryDayForManager.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDayForManager);
        }

        private void mnuHasCD_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.HasCD HasCD = new RASF.Main.Forms.Laboratory.HasCD();
            //  DeliveryDay.MdiParent = this;
            HasCD.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(HasCD);
        }

        private void mnuReportOfRemindHaghighi_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.ReportOfRemindHaghighi DeliveryDayForManager = new RASF.Main.Forms.Manager.ReportOfRemindHaghighi();
            //  DeliveryDay.MdiParent = this;
            DeliveryDayForManager.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDayForManager);
        }

        private void mnuFinancialSupprtDailyForStore_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Store.FinancialSupprtDailyForStore FinancialSupprtDailyForStore = new RASF.Main.Forms.Store.FinancialSupprtDailyForStore();
            //  DeliveryDay.MdiParent = this;
            FinancialSupprtDailyForStore.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FinancialSupprtDailyForStore);
        }

     
        private void mnuNotDestruct_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.NotDestruct NotDestruct = new RASF.Main.Forms.Harmony.NotDestruct();
            //  DeliveryDay.MdiParent = this;
            NotDestruct.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(NotDestruct);
        }

        private void mnuStepByStep_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.StepByStep StepByStep = new RASF.Main.Forms.Harmony.StepByStep();
            //  DeliveryDay.MdiParent = this;
            StepByStep.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(StepByStep);
        }

        private void mnuCurrentWorkOfCompany_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.CurrentWorkOfCompany CurrentWorkOfCompany = new RASF.Main.Forms.Financial.CurrentWorkOfCompany();
            //  DeliveryDay.MdiParent = this;
            CurrentWorkOfCompany.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CurrentWorkOfCompany);
        }

        private void mnuApprovedfinanciallyandnot_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.Approvedfinanciallyandnot Approvedfinanciallyandnot = new RASF.Main.Forms.Manager.Approvedfinanciallyandnot();
            //  DeliveryDay.MdiParent = this;
            Approvedfinanciallyandnot.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Approvedfinanciallyandnot);
        }

        private void mnuSent_To_ContractorsForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.Sent_To_ContractorsForm Sent_To_ContractorsForm = new RASF.Main.Forms.Manager.Sent_To_ContractorsForm();
            //  DeliveryDay.MdiParent = this;
            Sent_To_ContractorsForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Sent_To_ContractorsForm);
        }

        private void mnudontApprovedfinanciallyForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.dontApprovedfinanciallyForm dontApprovedfinancially = new RASF.Main.Forms.Manager.dontApprovedfinanciallyForm();
            //  DeliveryDay.MdiParent = this;
            dontApprovedfinancially.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(dontApprovedfinancially);
        }


        private void mnuDailyInvoice_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.DailyInvoice DailyInvoice = new RASF.Main.Forms.Manager.DailyInvoice();
            //  DeliveryDay.MdiParent = this;
            DailyInvoice.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DailyInvoice);
        }

      

        private void mnuApprovedfinanciallyandnotForConnector_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.ApprovedfinanciallyandnotForConnector Approvedfinanciallyandnot = new RASF.Main.Forms.Manager.ApprovedfinanciallyandnotForConnector();
            //  DeliveryDay.MdiParent = this;
            Approvedfinanciallyandnot.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Approvedfinanciallyandnot);
        }

        private void mnuRemindDebtorYearToYear_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.RemindDebtorYearToYear RemindDebtorYearToYear = new RASF.Main.Forms.Manager.RemindDebtorYearToYear();
            //  DeliveryDay.MdiParent = this;
            RemindDebtorYearToYear.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RemindDebtorYearToYear);
        }

        private void mnuRemindDebtorYearToYearForAlpha_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.RemindDebtorYearToYearForAlpha RemindDebtorYearToYear = new RASF.Main.Forms.Manager.RemindDebtorYearToYearForAlpha();
            //  DeliveryDay.MdiParent = this;
            RemindDebtorYearToYear.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RemindDebtorYearToYear);
        }

        private void mnuReportOfDaneshBonyan_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ReportOfDaneshBonyan ReportOfDaneshBonyan = new RASF.Main.Forms.Financial.ReportOfDaneshBonyan();
            //  DeliveryDay.MdiParent = this;
            ReportOfDaneshBonyan.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfDaneshBonyan);
        }

        private void mnuReportOfNoDaneshBonyan_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ReportOfNODaneshBonyan ReportOfNODaneshBonyan = new RASF.Main.Forms.Financial.ReportOfNODaneshBonyan();
            //  DeliveryDay.MdiParent = this;
            ReportOfNODaneshBonyan.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfNODaneshBonyan);
        }

        private void mnuEmailMonthlyBillShow_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.EmailMonthlyBillShow EmailMonthlyBillShow = new RASF.Main.Forms.Harmony.EmailMonthlyBillShow();
            //  DeliveryDay.MdiParent = this;
            EmailMonthlyBillShow.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(EmailMonthlyBillShow);
        }

        private void mnuReportOfCorrosion_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.ReportOfCorrosion ReportOfCorrosion = new RASF.Main.Forms.Manager.ReportOfCorrosion();
            //  DeliveryDay.MdiParent = this;
            ReportOfCorrosion.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfCorrosion);
        }

        private void mnuMotaleat_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.Motaleat Motaleat = new RASF.Main.Forms.Laboratory.Motaleat();
            //  DeliveryDay.MdiParent = this;
            Motaleat.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Motaleat);
        }

        private void mnuContractsInPending_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.ContractsInPending ContractsInPending = new RASF.Main.Forms.Manager.ContractsInPending();
            //  DeliveryDay.MdiParent = this;
            ContractsInPending.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ContractsInPending);
        }

        private void mnuFinancialSupprtDaily_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.FinancialSupprtDaily FinancialSupprtDaily = new RASF.Main.Forms.Manager.FinancialSupprtDaily();
            //  DeliveryDay.MdiParent = this;
            FinancialSupprtDaily.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FinancialSupprtDaily);
        }

        private void mnuFinancialDaily_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.FinancialDaily FinancialDaily = new RASF.Main.Forms.Financial.FinancialDaily();
            //  DeliveryDay.MdiParent = this;
            FinancialDaily.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FinancialDaily);
        }

        private void mnuFinancialSupprtDailyForCash_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.FinancialSupprtDailyForCash FinancialSupprtDaily = new RASF.Main.Forms.Financial.FinancialSupprtDailyForCash();
            //  DeliveryDay.MdiParent = this;
            FinancialSupprtDaily.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FinancialSupprtDaily);
        }

        private void mnuCheckDestruct_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.CheckDestruct CheckDestruct = new RASF.Main.Forms.Manager.CheckDestruct();
            //  DeliveryDay.MdiParent = this;
            CheckDestruct.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CheckDestruct);
        }

        private void mnuStandardStudy_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.StandardStudy StandardStudy = new RASF.Main.Forms.Manager.StandardStudy();
            //  DeliveryDay.MdiParent = this;
            StandardStudy.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(StandardStudy);
        }

        private void mnuAzmoonAmalkard_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.AzmoonAmalkard AzmoonAmalkard = new RASF.Main.Forms.Manager.AzmoonAmalkard();
            //  DeliveryDay.MdiParent = this;
            AzmoonAmalkard.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(AzmoonAmalkard);
        }

        private void mnuDeliveryDayForMagement_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.DeliveryDayForMagement DeliveryDay = new RASF.Main.Forms.ContractsReport.DeliveryDayForMagement();
            //  DeliveryDay.MdiParent = this;
            DeliveryDay.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDay);
        }

        private void mnuSendSMSForHoldedContracts_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.SendSMSForHoldedContracts SendSMSForHoldedContracts = new RASF.Main.Forms.ContractsReport.SendSMSForHoldedContracts();
            //  DeliveryDay.MdiParent = this;
            SendSMSForHoldedContracts.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendSMSForHoldedContracts);
        }

        private void mnuMarketingReportFollowUp_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.MarketingReportFollowUp MarketingReportFollowUp = new RASF.Main.Forms.Marketing.MarketingReportFollowUp();
            //  DeliveryDay.MdiParent = this;
            MarketingReportFollowUp.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(MarketingReportFollowUp);
        }

        private void mnuReportMarketingOperation_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.ReportMarketingOperation ReportMarketingOperation = new RASF.Main.Forms.Marketing.ReportMarketingOperation();
            //  DeliveryDay.MdiParent = this;
            ReportMarketingOperation.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportMarketingOperation);
        }

        private void mnuThefunctionoftheentirecompany_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.Thefunctionoftheentirecompany Thefunctionoftheentirecompany = new RASF.Main.Forms.Manager.Thefunctionoftheentirecompany();
            //  DeliveryDay.MdiParent = this;
            Thefunctionoftheentirecompany.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Thefunctionoftheentirecompany);
        }

        private void mnuRecieptionLongForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.RecieptionLongForm RecieptionLongForm = new RASF.Main.Forms.ContractsReport.RecieptionLongForm();
            //  DeliveryDay.MdiParent = this;
            RecieptionLongForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RecieptionLongForm);
        }

        private void mnuTestDoneForCompany_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.TestDoneForCompany TestDoneForCompany = new RASF.Main.Forms.Harmony.TestDoneForCompany();
            //  DeliveryDay.MdiParent = this;
            TestDoneForCompany.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(TestDoneForCompany);
        }

        private void mnuContractBaseWithDiscount_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ContractBaseWithDiscount ContractBaseWithDiscount = new RASF.Main.Forms.Harmony.ContractBaseWithDiscount();
            // ContractBaseWithDiscount.MdiParent = this;
            ContractBaseWithDiscount.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ContractBaseWithDiscount);
        }

        private void mnuCompanyMarking_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.CompanyMarking CompanyMarking = new RASF.Main.Forms.Marketing.CompanyMarking();
            // ContractBaseWithDiscount.MdiParent = this;
            CompanyMarking.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CompanyMarking);
        }

        private void mnuContractsenteredintotheLaboratory_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.ContractsenteredintotheLaboratory ContractsenteredintotheLaboratory = new RASF.Main.Forms.ContractsReport.ContractsenteredintotheLaboratory();
            // ContractsenteredintotheLaboratory.MdiParent = this;
            ContractsenteredintotheLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ContractsenteredintotheLaboratory);
        }

        private void mnuRecieptionDay_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.RecieptionDay RecieptionDay = new RASF.Main.Forms.ContractsReport.RecieptionDay();
            //  RecieptionDay.MdiParent = this;
            RecieptionDay.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RecieptionDay);
        }

        private void mnuDescForEditContractBaseReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.DescForEditContractBaseReport DescForEditContractBaseReport = new RASF.Main.Forms.ContractsReport.DescForEditContractBaseReport();
            //  RecieptionDay.MdiParent = this;
            DescForEditContractBaseReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DescForEditContractBaseReport);
        }

        private void mnuNewCompany_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Connector.NewCompany NewCompany = new RASF.Main.Forms.Connector.NewCompany();
            //  RecieptionDay.MdiParent = this;
            NewCompany.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(NewCompany);
        }

        private void mnuCompanyHasConnector_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Connector.CompanyHasConnector CompanyHasConnector = new RASF.Main.Forms.Connector.CompanyHasConnector();
            //  RecieptionDay.MdiParent = this;
            CompanyHasConnector.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CompanyHasConnector);
        }

        private void mnuInfoOfCompany_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.InfoOfCompany InfoOfCompany = new RASF.Main.Forms.Manager.InfoOfCompany();
            //  RecieptionDay.MdiParent = this;
            InfoOfCompany.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(InfoOfCompany);
        }

        private void mnuDetailOfReceptionForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.DetailOfReceptionForm DetailOfReceptionForm = new RASF.Main.Forms.Harmony.DetailOfReceptionForm();
            //  RecieptionDay.MdiParent = this;
            DetailOfReceptionForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DetailOfReceptionForm);
        }

        private void mnuDetailOfReceptionLaboratory_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.DetailOfReceptionLaboratory DetailOfReceptionForm = new RASF.Main.Forms.Harmony.DetailOfReceptionLaboratory();
            //  RecieptionDay.MdiParent = this;
            DetailOfReceptionForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DetailOfReceptionForm);
        }

        private void mnuDetailOfReceptionForCashCompanyForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.DetailOfReceptionForCashCompanyForm DetailOfReceptionForCashCompanyForm = new RASF.Main.Forms.Harmony.DetailOfReceptionForCashCompanyForm();
            //  RecieptionDay.MdiParent = this;
            DetailOfReceptionForCashCompanyForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DetailOfReceptionForCashCompanyForm);
        }

        private void mnuEarninigOfAgency_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.EarninigOfAgency EarninigOfAgency = new RASF.Main.Forms.ContractsReport.EarninigOfAgency();
            //  RecieptionDay.MdiParent = this;
            EarninigOfAgency.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(EarninigOfAgency);
        }

        private void mnuShowVoidedContracts_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.ShowVoidedContracts ShowVoidedContracts = new RASF.Main.Forms.ContractsReport.ShowVoidedContracts();
            //  ShowVoidedContracts.MdiParent = this;
            ShowVoidedContracts.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ShowVoidedContracts);
        }

        private void mnuShowVoidedContractsForManager_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.ShowVoidedContractsForManager ShowVoidedContractsForManager = new RASF.Main.Forms.ContractsReport.ShowVoidedContractsForManager();
            //  ShowVoidedContracts.MdiParent = this;
            ShowVoidedContractsForManager.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ShowVoidedContractsForManager);
        }

        private void mnuContractsNotenteredintotheLaboratory_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.ContractsReport.ContractsNotenteredintotheLaboratory ContractsNotenteredintotheLaboratory = new RASF.Main.Forms.ContractsReport.ContractsNotenteredintotheLaboratory();
            //ContractsNotenteredintotheLaboratory.MdiParent = this;
            ContractsNotenteredintotheLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ContractsNotenteredintotheLaboratory);
        }

        private void mnuInsert_Sanad_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.Insert_Sanad Insert_Sanad = new RASF.Main.Forms.Financial.Insert_Sanad();
            // Insert_Sanad.MdiParent = this;
            Insert_Sanad.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Insert_Sanad);
        }

        private void mnuDeletedLetter_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.DeletedLetter DeletedLetter = new RASF.Main.Forms.Harmony.DeletedLetter();
            // Insert_Sanad.MdiParent = this;
            DeletedLetter.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeletedLetter);
        }

        private void mnuSampleOfFinancialSanads_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.SampleOfFinancialSanads Insert_Sanad = new RASF.Main.Forms.Financial.SampleOfFinancialSanads();
            // Insert_Sanad.MdiParent = this;
            Insert_Sanad.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Insert_Sanad);
        }

        private void mnuDetailOfSanad_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.DetailOfSanad DetailOfSanad = new RASF.Main.Forms.Financial.DetailOfSanad();
            // Insert_Sanad.MdiParent = this;
            DetailOfSanad.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DetailOfSanad);
        }

        private void mnuSendBills_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.BillsReports.SendBills SendBills = new RASF.Main.Forms.BillsReports.SendBills();
            // Insert_Sanad.MdiParent = this;
            SendBills.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendBills);
        }

        private void mnuCreditreportingcompanies_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.Creditreportingcompanies Creditreportingcompanies = new RASF.Main.Forms.Harmony.Creditreportingcompanies();
            //Creditreportingcompanies.MdiParent = this;
            Creditreportingcompanies.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Creditreportingcompanies);
        }

        private void mnuBillsissued_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.BillsReports.Billsissued Billsissued = new RASF.Main.Forms.BillsReports.Billsissued();
            // Billsissued.MdiParent = this;
            Billsissued.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Billsissued);
        }

        private void mnuContractMatters_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.BillsReports.ContractMatters ContractMatters = new RASF.Main.Forms.BillsReports.ContractMatters();
            // Billsissued.MdiParent = this;
            ContractMatters.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ContractMatters);
        }
        private void mnuReportOfRecieveCustomer_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.BillsReports.ReportOfRecieveCustomer ReportOfRecieveCustomer = new RASF.Main.Forms.BillsReports.ReportOfRecieveCustomer();
            // Billsissued.MdiParent = this;
            ReportOfRecieveCustomer.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfRecieveCustomer);
        }

        private void mnuReportOfGrant_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.BillsReports.ReportOfGrant ReportOfGrant = new RASF.Main.Forms.BillsReports.ReportOfGrant();
            // Billsissued.MdiParent = this;
            ReportOfGrant.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfGrant);
        }

        private void mnuReportOfReduceWage_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.BillsReports.ReportOfReduceWage ReportOfReduceWage = new RASF.Main.Forms.BillsReports.ReportOfReduceWage();
            // Billsissued.MdiParent = this;
            ReportOfReduceWage.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportOfReduceWage);
        }

        private void mnuChengeForAmountOfBill_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.BillsReports.ChengeForAmountOfBill ChengeForAmountOfBill = new RASF.Main.Forms.BillsReports.ChengeForAmountOfBill();
            // Billsissued.MdiParent = this;
            ChengeForAmountOfBill.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ChengeForAmountOfBill);
        }

        private void mnuPageOfLaboratory_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.PageOfLaboratory Billsissued = new RASF.Main.Forms.Financial.PageOfLaboratory();
            // Billsissued.MdiParent = this;
            Billsissued.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Billsissued);
        }

        private void mnuPrePaidAmountForContract_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.PrePaidAmountForContract PrePaidAmountForContract = new RASF.Main.Forms.Manager.PrePaidAmountForContract();
            // Billsissued.MdiParent = this;
            PrePaidAmountForContract.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PrePaidAmountForContract);
        }

        private void mnuDebPayCompaniesForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.DebPayCompaniesForm DebPayCompaniesForm = new RASF.Main.Forms.Manager.DebPayCompaniesForm();
            // Billsissued.MdiParent = this;
            DebPayCompaniesForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DebPayCompaniesForm);
        }

        private void mnuCloseBill_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.CloseBill CloseBill = new RASF.Main.Forms.Financial.CloseBill();
            // Billsissued.MdiParent = this;
            CloseBill.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CloseBill);
        }

        private void mnuBillsissuedInformalFactor_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.BillsReports.BillsissuedInformalFactor BillsissuedInformalFactor = new RASF.Main.Forms.BillsReports.BillsissuedInformalFactor();
            // Billsissued.MdiParent = this;
            BillsissuedInformalFactor.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(BillsissuedInformalFactor);
        }

        private void mnuReturnVoidPartForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ReturnVoidPartForm ReturnVoidPartForm = new RASF.Main.Forms.Harmony.ReturnVoidPartForm();
            // Billsissued.MdiParent = this;
            ReturnVoidPartForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReturnVoidPartForm);
        }
     
        private void mnuReturnForScience_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ReturnForScience ReturnForScience = new RASF.Main.Forms.Harmony.ReturnForScience();
            // Billsissued.MdiParent = this;
            ReturnForScience.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReturnForScience);
        }

        private void mnuCancelEnterLaboratory_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.CancelEnterLaboratory CancelEnterLaboratory = new RASF.Main.Forms.Laboratory.CancelEnterLaboratory();
            // Billsissued.MdiParent = this;
            CancelEnterLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CancelEnterLaboratory);
        }

        private void mnuBillsOfSeeingInformal_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.BillsOfSeeingInformal BillsissuedInformalFactor = new RASF.Main.Forms.Financial.BillsOfSeeingInformal();
            // Billsissued.MdiParent = this;
            BillsissuedInformalFactor.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(BillsissuedInformalFactor);
        }

        private void mnuReportingdelays_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.Reportingdelays Reportingdelays = new RASF.Main.Forms.Harmony.Reportingdelays();
            // Reportingdelays.MdiParent = this;
            Reportingdelays.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Reportingdelays);
        }

        private void mnuDefinitionPersionTemplates_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.DefinitionPersionTemplates DefinitionTemplates = new RASF.Main.Forms.Reports.DefinitionPersionTemplates("Pershian Template");
            // DefinitionTemplates.MdiParent = this;
            DefinitionTemplates.MyMdiParent = this;
            DefinitionTemplates.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DefinitionTemplates);
        }

        private void mnuEditDefinitionPersionTemplates_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.EditDefinitionPersionTemplates DefinitionTemplates = new RASF.Main.Forms.Reports.EditDefinitionPersionTemplates("Pershian Template");
            // DefinitionTemplates.MdiParent = this;
            DefinitionTemplates.MyMdiParent = this;
            DefinitionTemplates.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DefinitionTemplates);
        }

        private void mnuDefinitionEnglishTemplates_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.DefinitionPersionTemplates DefinitionTemplates = new RASF.Main.Forms.Reports.DefinitionPersionTemplates("English Template");
            //   DefinitionTemplates.MdiParent = this;
            DefinitionTemplates.MyMdiParent = this;
            DefinitionTemplates.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DefinitionTemplates);
        }

        private void mnuEditDefinitionEnglishTemplates_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.EditDefinitionPersionTemplates DefinitionTemplates = new RASF.Main.Forms.Reports.EditDefinitionPersionTemplates("English Template");
            //   DefinitionTemplates.MdiParent = this;
            DefinitionTemplates.MyMdiParent = this;
            DefinitionTemplates.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DefinitionTemplates);
        }

        private void mnuFindBillNo_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Search.FindBillNo FindBillNo = new RASF.Main.Forms.Search.FindBillNo();
            // FindBillNo.MdiParent = this;
            FindBillNo.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FindBillNo);
        }

        private void mnuContractsWithoutBills_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ContractsWithoutBills ContractsWithoutBills = new RASF.Main.Forms.Financial.ContractsWithoutBills();
            //ContractsWithoutBills.MdiParent = this;
            ContractsWithoutBills.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ContractsWithoutBills);
        }

        private void mnuContractsWasCompleted_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ContractsWasCompleted ContractsWasCompleted = new RASF.Main.Forms.Harmony.ContractsWasCompleted();
            // ContractsWasCompleted.MdiParent = this;
            ContractsWasCompleted.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ContractsWasCompleted);
        }

        private void mnuInsert_RecieptAmountSanad_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.Insert_RecieptAmountSanad Insert_RecieptAmountSanad = new RASF.Main.Forms.Financial.Insert_RecieptAmountSanad();
            //  Insert_RecieptAmountSanad.MdiParent = this;
            Insert_RecieptAmountSanad.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Insert_RecieptAmountSanad);
        }

        private void mnuFinancialLaboratoryNumberOfTests_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.FinancialLaboratoryNumberOfTests FinancialLaboratoryNumberOfTests = new RASF.Main.Forms.Financial.FinancialLaboratoryNumberOfTests();
            // FinancialLaboratoryNumberOfTests.MdiParent = this;
            FinancialLaboratoryNumberOfTests.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FinancialLaboratoryNumberOfTests);
        }

        private void mnuNumberOfExecutersOutputForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.NumberOfExecutersOutputForm NumberOfExecutersOutputForm = new RASF.Main.Forms.Financial.NumberOfExecutersOutputForm();
            // NumberOfExecutersOutputForm.MdiParent = this;
            NumberOfExecutersOutputForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(NumberOfExecutersOutputForm);
        }

        private void mnuNumberOfExecutersAmadesazi_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.NumberOfExecutersAmadesazi NumberOfExecutersAmadesazi = new RASF.Main.Forms.Financial.NumberOfExecutersAmadesazi();
            // NumberOfExecutersOutputForm.MdiParent = this;
            NumberOfExecutersAmadesazi.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(NumberOfExecutersAmadesazi);
        }

        private void mnuOutPutExecutersm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.OutPutExecuters OutPutExecuters = new RASF.Main.Forms.Harmony.OutPutExecuters();
            // NumberOfExecutersOutputForm.MdiParent = this;
            OutPutExecuters.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(OutPutExecuters);
        }

        private void mnuPersonnelfunction_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Personel.Personnelfunction Personnelfunction = new RASF.Main.Forms.Personel.Personnelfunction();
            // NumberOfExecutersOutputForm.MdiParent = this;
            Personnelfunction.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Personnelfunction);
        }

        private void mnuCountOfContracts_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.CountOfContracts CountOfContracts = new RASF.Main.Forms.Financial.CountOfContracts();
            // NumberOfExecutersOutputForm.MdiParent = this;
            CountOfContracts.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CountOfContracts);
        }

        private void mnuOutPutExecutersManager_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.OutPutExecutersManager OutPutExecuters = new RASF.Main.Forms.Harmony.OutPutExecutersManager();
            // NumberOfExecutersOutputForm.MdiParent = this;
            OutPutExecuters.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(OutPutExecuters);
        }

        private void mnuFinancialLaboratoryNumberOfTestsExited_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.FinancialLaboratoryNumberOfTestsExited FinancialLaboratoryNumberOfTestsExited = new RASF.Main.Forms.Financial.FinancialLaboratoryNumberOfTestsExited();
            // FinancialLaboratoryNumberOfTestsExited.MdiParent = this;
            FinancialLaboratoryNumberOfTestsExited.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FinancialLaboratoryNumberOfTestsExited);
        }

        private void mnuFinancialLaboratoryNumberOfTestsDeliveryDay_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.FinancialLaboratoryNumberOfTestsDeliveryDay FinancialLaboratoryNumberOfTestsDeliveryDay = new RASF.Main.Forms.Financial.FinancialLaboratoryNumberOfTestsDeliveryDay();
            // FinancialLaboratoryNumberOfTestsDeliveryDay.MdiParent = this;
            FinancialLaboratoryNumberOfTestsDeliveryDay.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FinancialLaboratoryNumberOfTestsDeliveryDay);
        }

        private void mnuFinancialLaboratoryNumberOfTestsBill_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.FinancialLaboratoryNumberOfTestsBill FinancialLaboratoryNumberOfTestsBill = new RASF.Main.Forms.Financial.FinancialLaboratoryNumberOfTestsBill();
            //  FinancialLaboratoryNumberOfTestsBill.MdiParent = this;
            FinancialLaboratoryNumberOfTestsBill.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FinancialLaboratoryNumberOfTestsBill);
        }

        private void mnuFinancialLaboratoryNumberOfTestsBillTypeCustomer_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.FinancialLaboratoryNumberOfTestsBillTypeCustomer FinancialLaboratoryNumberOfTestsBill = new RASF.Main.Forms.Financial.FinancialLaboratoryNumberOfTestsBillTypeCustomer();
            //  FinancialLaboratoryNumberOfTestsBill.MdiParent = this;
            FinancialLaboratoryNumberOfTestsBill.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FinancialLaboratoryNumberOfTestsBill);
        }

        private void mnuShowTahviliAmadesazi_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Laboratory.ShowTahviliAmadesazi ShowTahviliAmadesazi = new RASF.Main.Forms.Laboratory.ShowTahviliAmadesazi();
            //  FinancialLaboratoryNumberOfTestsBill.MdiParent = this;
            ShowTahviliAmadesazi.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ShowTahviliAmadesazi);
        }
        private void mnuAddReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.AddReport AddReport = new RASF.Main.Forms.Reports.AddReport();
            //  AddReport.MdiParent = this;
            AddReport.Text = ((ToolStripMenuItem)sender).Text;
            AddReport.MyMdiParent = this;
            ShowDocument(AddReport);
           
        }

        private void mnuSaveAttachmentOfReports_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.SaveAttachmentOfReports SaveAttachmentOfReports = new RASF.Main.Forms.Reports.SaveAttachmentOfReports();
            //  FinancialLaboratoryNumberOfTestsBill.MdiParent = this;
            SaveAttachmentOfReports.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SaveAttachmentOfReports);
        }

        private void mnuClearReportForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.ClearReportForm ClearReportForm = new RASF.Main.Forms.Reports.ClearReportForm();
            //  AddReport.MdiParent = this;
            ClearReportForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ClearReportForm);

        }

        private void mnuEditReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.EditReport EditReport = new RASF.Main.Forms.Reports.EditReport();
            // EditReport.MdiParent = this;
            EditReport.MyMdiParent = this;
            EditReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(EditReport);

        }

        private void mnuTempAndHumid_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.TempAndHumid TempAndHumid = new RASF.Main.Forms.Reports.TempAndHumid();
            //TempAndHumid.MdiParent = this;
            TempAndHumid.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(TempAndHumid);
        }

        private void mnuWorkFlowForLaboratory_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.WorkFlow.WorkFlowForLaboratoryScience WorkFlowForLaboratory = new RASF.Main.Forms.WorkFlow.WorkFlowForLaboratoryScience();
            WorkFlowForLaboratory.MyMdiParent = this;
            WorkFlowForLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(WorkFlowForLaboratory);
        }

        private void mnuWorkFlowDescriptionReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.WorkFlow.WorkFlowDescriptionReport WorkFlowForLaboratory = new RASF.Main.Forms.WorkFlow.WorkFlowDescriptionReport();
            WorkFlowForLaboratory.MyMdiParent = this;
            WorkFlowForLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(WorkFlowForLaboratory);
        }

        private void mnuWorkFlowForLaboratoryCreator_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.WorkFlow.WorkFlowForLaboratoryCreator WorkFlowForLaboratory = new RASF.Main.Forms.WorkFlow.WorkFlowForLaboratoryCreator();
            WorkFlowForLaboratory.MyMdiParent = this;
            WorkFlowForLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(WorkFlowForLaboratory);
        }

        private void mnuWorkFlowForLaboratoryExpert_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.WorkFlow.WorkFlowForLaboratoryExpert WorkFlowForLaboratory = new RASF.Main.Forms.WorkFlow.WorkFlowForLaboratoryExpert();
            WorkFlowForLaboratory.MyMdiParent = this;
            WorkFlowForLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(WorkFlowForLaboratory);
        }



        private void mnuWorkFlowForLaboratoryTechnical_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.WorkFlow.WorkFlowForLaboratoryTechnical WorkFlowForLaboratory = new RASF.Main.Forms.WorkFlow.WorkFlowForLaboratoryTechnical();
            WorkFlowForLaboratory.MyMdiParent = this;
            WorkFlowForLaboratory.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(WorkFlowForLaboratory);
        }

        private void mnuEnterScience_Form_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.WorkFlow.EnterScience_Form EnterScience_Form = new RASF.Main.Forms.WorkFlow.EnterScience_Form();
            EnterScience_Form.MyMdiParent = this;
            EnterScience_Form.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(EnterScience_Form);
        }

        private void mnuExitScience_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.WorkFlow.ExitScience_Form ExitScience_Form = new RASF.Main.Forms.WorkFlow.ExitScience_Form();
            ExitScience_Form.MyMdiParent = this;
            ExitScience_Form.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ExitScience_Form);
        }

        private void mnuObservationReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.ObservationReport ObservationReport = new RASF.Main.Forms.Reports.ObservationReport();
            // ObservationReport.MdiParent = this;
            ObservationReport.MyMdiParent = this;
            ObservationReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ObservationReport);
        }

        private void mnuObservationReportForConnector_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.ObservationReportForConnector ObservationReport = new RASF.Main.Forms.Reports.ObservationReportForConnector();
            // ObservationReport.MdiParent = this;
            ObservationReport.MyMdiParent = this;
            ObservationReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ObservationReport);
        }

        private void mnuPrintOfReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.PrintOfReport PrintOfReport = new RASF.Main.Forms.Reports.PrintOfReport();
            // PrintOfReport.MdiParent = this;
            PrintOfReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PrintOfReport);
        }

        private void mnuPrintOfReportWithoutExit_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.PrintOfReportWithoutExit PrintOfReport = new RASF.Main.Forms.Reports.PrintOfReportWithoutExit();
            // PrintOfReport.MdiParent = this;
            PrintOfReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PrintOfReport);
        }

        private void mnuPartsMasterPrintReportWithoutExitForConnector_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.PartsMasterPrintReportWithoutExitForConnector PrintOfReport = new RASF.Main.Forms.Reports.PartsMasterPrintReportWithoutExitForConnector();
            // PrintOfReport.MdiParent = this;
            PrintOfReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PrintOfReport);
        }

        private void mnuSendEmailRecieptionPicWithoutExit_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.SendEmailRecieptionPicWithoutExit PrintOfReport = new RASF.Main.Forms.Reports.SendEmailRecieptionPicWithoutExit();
            // PrintOfReport.MdiParent = this;
            PrintOfReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PrintOfReport);
        }

        private void mnuPrintOfReportRecieptPic_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.OldPrintOfReportRecieptPic PrintOfReport = new RASF.Main.Forms.Reports.OldPrintOfReportRecieptPic();
            // PrintOfReport.MdiParent = this;
            PrintOfReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PrintOfReport);
        }

        private void mnuNewPrintOfReportRecieptPic_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.NewPrintOfReportRecieptPic PrintOfReport = new RASF.Main.Forms.Reports.NewPrintOfReportRecieptPic();
            // PrintOfReport.MdiParent = this;
            PrintOfReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PrintOfReport);
        }

        private void mnuNewPrintOfReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.NewPrintOfReport PrintOfReport = new RASF.Main.Forms.Reports.NewPrintOfReport();
            // PrintOfReport.MdiParent = this;
            PrintOfReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PrintOfReport);
        }

        private void mnuNewPrintOfReportForSpecialCompany_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.NewPrintOfReportForSpecialCompany PrintOfReport = new RASF.Main.Forms.Reports.NewPrintOfReportForSpecialCompany();
            // PrintOfReport.MdiParent = this;
            PrintOfReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PrintOfReport);
        }

        private void mnuPrintOfRecieptPic_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.PrintOfRecieptPic PrintOfRecieptPic = new RASF.Main.Forms.Reports.PrintOfRecieptPic();
            // PrintOfReport.MdiParent = this;
            PrintOfRecieptPic.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PrintOfRecieptPic);
        }

        private void mnuNewPrintOfRecieptPic_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.NewPrintOfRecieptPic PrintOfRecieptPic = new RASF.Main.Forms.Reports.NewPrintOfRecieptPic();
            // PrintOfReport.MdiParent = this;
            PrintOfRecieptPic.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PrintOfRecieptPic);
        }

        private void mnuPrintOfReportDuplicate_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.PrintOfReportDuplicate mnuPrintOfReportDuplicate = new RASF.Main.Forms.Reports.PrintOfReportDuplicate();
            // mnuPrintOfReportDuplicate.MdiParent = this;
            mnuPrintOfReportDuplicate.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(mnuPrintOfReportDuplicate);
        }

        private void mnuPrintOfReportDuplicateWithoutPic_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.PrintOfReportDuplicateWithoutPic PrintOfReportDuplicateWithoutPic = new RASF.Main.Forms.Reports.PrintOfReportDuplicateWithoutPic();
            // mnuPrintOfReportDuplicate.MdiParent = this;
            PrintOfReportDuplicateWithoutPic.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PrintOfReportDuplicateWithoutPic);
        }

        private void mnuNewPrintOfReportDuplicate_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.NewPrintOfReportDuplicate mnuPrintOfReportDuplicate = new RASF.Main.Forms.Reports.NewPrintOfReportDuplicate();
            // mnuPrintOfReportDuplicate.MdiParent = this;
            mnuPrintOfReportDuplicate.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(mnuPrintOfReportDuplicate);
        }

        private void mnuPrintOfReportWithoutExitNewFormat_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.PrintOfReportWithoutExitNewFormat mnuPrintOfReportDuplicate = new RASF.Main.Forms.Reports.PrintOfReportWithoutExitNewFormat();
            // mnuPrintOfReportDuplicate.MdiParent = this;
            mnuPrintOfReportDuplicate.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(mnuPrintOfReportDuplicate);
        }

        private void mnuNewPrintOfReportDuplicateWithoutPic_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.NewPrintOfReportDuplicateWithoutPic NewPrintOfReportDuplicateWithoutPic = new RASF.Main.Forms.Reports.NewPrintOfReportDuplicateWithoutPic();
            // mnuPrintOfReportDuplicate.MdiParent = this;
            NewPrintOfReportDuplicateWithoutPic.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(NewPrintOfReportDuplicateWithoutPic);
        }

        //private void mnuPrintOfReportDuplicateRecieptPic_Click(object sender, EventArgs e)
        //{
        //    RASF.Main.Forms.Reports.PrintOfReportDuplicateRecieptPic mnuPrintOfReportDuplicate = new RASF.Main.Forms.Reports.PrintOfReportDuplicateRecieptPic();
        //    // mnuPrintOfReportDuplicate.MdiParent = this;
        //    mnuPrintOfReportDuplicate.Text = ((ToolStripMenuItem)sender).Text;
        //    ShowDocument(mnuPrintOfReportDuplicate);
        //}

        private void mnuPrintOfReportCopy_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.NewPrintOfReportCopy PrintOfReportCopy = new RASF.Main.Forms.Reports.NewPrintOfReportCopy();
            // mnuPrintOfReportDuplicate.MdiParent = this;
            PrintOfReportCopy.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PrintOfReportCopy);
        }

        private void mnuUncertainvariations_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Receipt.Uncertainvariations Uncertainvariations = new RASF.Main.Forms.Receipt.Uncertainvariations();
            // mnuPrintOfReportDuplicate.MdiParent = this;
            Uncertainvariations.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Uncertainvariations);
        }

        private void mnuStatusInsurancedeductions_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.StatusInsurancedeductions StatusInsurancedeductions = new RASF.Main.Forms.Financial.StatusInsurancedeductions();
            // mnuPrintOfReportDuplicate.MdiParent = this;
            StatusInsurancedeductions.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(StatusInsurancedeductions);
        }

        private void mnuReportStatusInsurancedeductions_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.ReportStatusInsurancedeductions ReportStatusInsurancedeductions = new RASF.Main.Forms.Manager.ReportStatusInsurancedeductions();
            // mnuPrintOfReportDuplicate.MdiParent = this;
            ReportStatusInsurancedeductions.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportStatusInsurancedeductions);
        }

        private void mnuMetalPicture_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is RASF.Main.Forms.Reports.EditWordDocument)
            {
                RASF.Main.Forms.Reports.EditWordDocument EditForm = (RASF.Main.Forms.Reports.EditWordDocument)this.ActiveMdiChild;
                if (EditForm.PartsTestMasterCode != Guid.Empty)
                {
                    EditForm.Insert_Picture(((ToolStripMenuItem)sender).Text);
                }
                else
                {
                    MessageBox.Show("این قابلیت در فرم جاری در دسترس نیست", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("این قابلیت در فرم جاری در دسترس نیست", "", MessageBoxButtons.OK);
            }
        }

        private void mnuReceptionPicture_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is RASF.Main.Forms.Reports.EditWordDocument)
            {
                RASF.Main.Forms.Reports.EditWordDocument EditForm = (RASF.Main.Forms.Reports.EditWordDocument)this.ActiveMdiChild;
                if (EditForm.PartsTestMasterCode != Guid.Empty)
                {
                    EditForm.Insert_PartPicture(((ToolStripMenuItem)sender).Text);
                }
                else
                {
                    MessageBox.Show("این قابلیت در فرم جاری در دسترس نیست", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("این قابلیت در فرم جاری در دسترس نیست", "", MessageBoxButtons.OK);
            }
           
        }

        private void mnuReceptionPicture2_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is RASF.Main.Forms.Reports.EditWordDocument)
            {
                RASF.Main.Forms.Reports.EditWordDocument EditForm = (RASF.Main.Forms.Reports.EditWordDocument)this.ActiveMdiChild;
                if (EditForm.PartsTestMasterCode != Guid.Empty)
                {
                    EditForm.Insert_PartPicture2(((ToolStripMenuItem)sender).Text);
                }
                else
                {
                    MessageBox.Show("این قابلیت در فرم جاری در دسترس نیست", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("این قابلیت در فرم جاری در دسترس نیست", "", MessageBoxButtons.OK);
            }

        }

        private void mnuSendEmail_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.SendEmail SendEmail = new RASF.Main.Forms.Reports.SendEmail();
            //SendEmail.MdiParent = this;
            SendEmail.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendEmail);
        }

        private void mnuSendedReports_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.SendedReports SendedReports = new RASF.Main.Forms.Harmony.SendedReports();
            //SendEmail.MdiParent = this;
            SendedReports.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendedReports);
        }

        private void mnuSendEmailRecieptionPic_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.SendEmailRecieptionPic SendEmail = new RASF.Main.Forms.Reports.SendEmailRecieptionPic();
            //SendEmail.MdiParent = this;
            SendEmail.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendEmail);
        }

        private void mnuSendEmailSpecialCompany_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.SendEmailSpecialCompany SendEmail = new RASF.Main.Forms.Reports.SendEmailSpecialCompany();
            //SendEmail.MdiParent = this;
            SendEmail.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendEmail);
        }

        private void mnuSendFax_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.SendFax SendFax = new RASF.Main.Forms.Reports.SendFax();
            //SendEmail.MdiParent = this;
            SendFax.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendFax);
        }

        private void mnuSendFaxForOffices_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.SendFaxForOffices SendFax = new RASF.Main.Forms.Reports.SendFaxForOffices();
            //SendEmail.MdiParent = this;
            SendFax.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendFax);
        }

        private void mnuSendEmailForOffices_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.SendEmailForOffices SendEmailForOffices = new RASF.Main.Forms.Reports.SendEmailForOffices();
            //SendEmail.MdiParent = this;
            SendEmailForOffices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendEmailForOffices);
        }

        private void mnuSendEmailCostomerCostPDFForOffices_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.SendEmailCostomerCostPDFForOffices SendEmailForOffices = new RASF.Main.Forms.Harmony.SendEmailCostomerCostPDFForOffices();
            //SendEmail.MdiParent = this;
            SendEmailForOffices.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendEmailForOffices);
        }

        private void mnuIsHoldForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.IsHoldForm IsHoldForm = new RASF.Main.Forms.Harmony.IsHoldForm();
            //IsHoldForm.MdiParent = this;
            IsHoldForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(IsHoldForm);
        }

        private void mnuIsHoldBeforeFinancial_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.IsHoldBeforeFinancial IsHoldForm = new RASF.Main.Forms.Reception.IsHoldBeforeFinancial();
            //IsHoldForm.MdiParent = this;
            IsHoldForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(IsHoldForm);
        }

        private void mnuDeliveryReportThetNotIsCompleted_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.DeliveryReportThetNotIsCompleted DeliveryReportThetNotIsCompleted = new RASF.Main.Forms.Harmony.DeliveryReportThetNotIsCompleted();
            //IsHoldForm.MdiParent = this;
            DeliveryReportThetNotIsCompleted.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryReportThetNotIsCompleted);
        }

        private void mnuCheckContract_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.CheckContract CheckContract = new RASF.Main.Forms.Reception.CheckContract();
            //IsHoldForm.MdiParent = this;
            CheckContract.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CheckContract);
        }

        private void mnuEmailChangePriceForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.EmailChangePriceForm CheckContract = new RASF.Main.Forms.Reception.EmailChangePriceForm();
            //IsHoldForm.MdiParent = this;
            CheckContract.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CheckContract);
        }

        private void mnuCheckAgencyContract_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.CheckAgencyContract CheckContract = new RASF.Main.Forms.Reception.CheckAgencyContract();
            //IsHoldForm.MdiParent = this;
            CheckContract.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CheckContract);
        }

        private void mnuFollowupFinancialContracts_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.FollowupFinancialContracts FollowupFinancialContracts = new RASF.Main.Forms.Harmony.FollowupFinancialContracts();
            //IsHoldForm.MdiParent = this;
            FollowupFinancialContracts.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FollowupFinancialContracts);
        }

        private void mnuReportOfFollowupFinancialContracts_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ReportOfFollowupFinancialContracts FollowupFinancialContracts = new RASF.Main.Forms.Harmony.ReportOfFollowupFinancialContracts();
            //IsHoldForm.MdiParent = this;
            FollowupFinancialContracts.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FollowupFinancialContracts);
        }

        private void mnuVoidingBillForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.VoidingBillForm VoidingBillForm = new RASF.Main.Forms.Financial.VoidingBillForm();
            //IsHoldForm.MdiParent = this;
            VoidingBillForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(VoidingBillForm);
        }

        private void mnuReportOfVoidBill_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ReportOfVoidBill VoidingBillForm = new RASF.Main.Forms.Financial.ReportOfVoidBill();
            //IsHoldForm.MdiParent = this;
            VoidingBillForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(VoidingBillForm);
        }

        private void mnuReportSendingType_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.TypeSendingCost ReportSendingType = new RASF.Main.Forms.Harmony.TypeSendingCost();
            //IsHoldForm.MdiParent = this;
            ReportSendingType.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportSendingType);
        }

        private void mnuTypeSendingCostForConnector_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Connector.TypeSendingCostForConnector ReportSendingType = new RASF.Main.Forms.Connector.TypeSendingCostForConnector();
            //IsHoldForm.MdiParent = this;
            ReportSendingType.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ReportSendingType);
        }

        private void mnuSendedCostPaper_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.SendedCostPaper SendedCostPaper = new RASF.Main.Forms.Harmony.SendedCostPaper();
            //IsHoldForm.MdiParent = this;
            SendedCostPaper.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendedCostPaper);
        }

        private void mnuOpenCloseInvoice_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.OpenCloseInvoice OpenCloseInvoice = new RASF.Main.Forms.Harmony.OpenCloseInvoice();
            //IsHoldForm.MdiParent = this;
            OpenCloseInvoice.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(OpenCloseInvoice);
        }

        private void mnuShowOpenInvoice_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ShowOpenInvoice ShowOpenInvoice = new RASF.Main.Forms.Financial.ShowOpenInvoice();
            //IsHoldForm.MdiParent = this;
            ShowOpenInvoice.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ShowOpenInvoice);
        }

        private void mnuRegisterNopaymentsForView_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.RegisterNopaymentsForView RegisterNopaymentsForView = new RASF.Main.Forms.Manager.RegisterNopaymentsForView();
            //IsHoldForm.MdiParent = this;
            RegisterNopaymentsForView.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RegisterNopaymentsForView);
        }

        private void mnuDilatoryForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.DilatoryForm DilatoryForm = new RASF.Main.Forms.Harmony.DilatoryForm();
            //IsHoldForm.MdiParent = this;
            DilatoryForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DilatoryForm);
        }
        //قراردادهای مشکوک الوصول
        private void mnuRegisterNopayments_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.RegisterNopayments RegisterNopayments = new RASF.Main.Forms.Financial.RegisterNopayments();
            //IsHoldForm.MdiParent = this;
            RegisterNopayments.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RegisterNopayments);

        }

        private void mnuOrderStatuseCashCompany_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.OrderStatuseCashCompany OrderStatuseCashCompany = new RASF.Main.Forms.Financial.OrderStatuseCashCompany();
            //IsHoldForm.MdiParent = this;
            OrderStatuseCashCompany.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(OrderStatuseCashCompany);

        }

        private void mnuResonOfRecieptionLong_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ResonOfRecieptionLong ResonOfRecieptionLong = new RASF.Main.Forms.Harmony.ResonOfRecieptionLong();
            //IsHoldForm.MdiParent = this;
            ResonOfRecieptionLong.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ResonOfRecieptionLong);
        }

        private void mnuHoldContractNotCompleted_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.HoldContractNotCompleted HoldContractNotCompleted = new RASF.Main.Forms.Harmony.HoldContractNotCompleted();
            //IsHoldForm.MdiParent = this;
            HoldContractNotCompleted.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(HoldContractNotCompleted);
        }
        private void mnuPayMentAmount_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.PeymentAmount.PayMentAmount PayMentAmount = new RASF.Main.Forms.PeymentAmount.PayMentAmount();
            //IsHoldForm.MdiParent = this;
            PayMentAmount.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(PayMentAmount);
        }

        private void mnuWageofagencyPay_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.WageofagencyPay WageofagencyPay = new RASF.Main.Forms.Harmony.WageofagencyPay();
            //IsHoldForm.MdiParent = this;
            WageofagencyPay.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(WageofagencyPay);
        }

        private void mnuInsertStandard_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is RASF.Main.Forms.Reports.EditWordDocument)
            {
                RASF.Main.Forms.Reports.EditWordDocument EditForm = (RASF.Main.Forms.Reports.EditWordDocument)this.ActiveMdiChild;
                if (EditForm.PartsTestMasterCode != Guid.Empty)
                {
                    EditForm.Insert_Standard(((ToolStripMenuItem)sender).Text);
                    
                }
                else
                {
                    MessageBox.Show("این قابلیت در فرم جاری در دسترس نیست", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("این قابلیت در فرم جاری در دسترس نیست", "", MessageBoxButtons.OK);
            }
        }

        private void mnuInsertARL_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is RASF.Main.Forms.Reports.EditWordDocument)
            {
                ((RASF.Main.Forms.Reports.EditWordDocument)this.ActiveMdiChild).Insert_arl();
            }
            else
            {
                MessageBox.Show("این قابلیت در فرم جاری در دسترس نیست", "", MessageBoxButtons.OK);
            }
        }

        private void mnuInsertWAS_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild is RASF.Main.Forms.Reports.EditWordDocument)
            {
                ((RASF.Main.Forms.Reports.EditWordDocument)this.ActiveMdiChild).Insert_Was();
            }
            else
            {
                MessageBox.Show("این قابلیت در فرم جاری در دسترس نیست", "", MessageBoxButtons.OK);
            }
        }
        
        private void mnuChangePrice_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ChangePrice ChangePrice = new RASF.Main.Forms.Financial.ChangePrice();
            //ChangePrice.MdiParent = this;
            ChangePrice.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ChangePrice);
        }

        private void mnuChangePriceForHarmony_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.ChangePriceForHarmony ChangePrice = new RASF.Main.Forms.Financial.ChangePriceForHarmony();
            //ChangePrice.MdiParent = this;
            ChangePrice.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ChangePrice);
        }

        private void mnuConnector_PeapleRelatedForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.Connector_PeapleRelatedForm Connector = new RASF.Main.Forms.Manager.Connector_PeapleRelatedForm();
            //ChangePrice.MdiParent = this;
            Connector.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(Connector);
        }

        private void mnuBillsOfSeeing_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.BillsOfSeeing BillsOfSeeing = new RASF.Main.Forms.Financial.BillsOfSeeing();
            //BillsOfSeeing.MdiParent = this;
            BillsOfSeeing.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(BillsOfSeeing);
        }

        private void mnuBillsissuedTakeInsurance_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.BillsReports.BillsissuedTakeInsurance BillsOfSeeing = new RASF.Main.Forms.BillsReports.BillsissuedTakeInsurance();
            //BillsOfSeeing.MdiParent = this;
            BillsOfSeeing.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(BillsOfSeeing);
        }

        private void mnuCancellationOfContractsVoid_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.CancellationOfVoidContracts CancellationOfVoidContracts = new RASF.Main.Forms.Reception.CancellationOfVoidContracts();
            //CancellationOfVoidContracts.MdiParent = this;
            CancellationOfVoidContracts.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CancellationOfVoidContracts);
        }

        private void mnuSendMessage_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Message.SendMessage sendMessage = new RASF.Main.Forms.Message.SendMessage();
            sendMessage.ReturnPacket += SendMessage_ReturnPacket;
           // SendMessage.MdiParent = this;
            sendMessage.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(sendMessage);
        }

        private void mnuResponceToMessagingMarketing_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.ResponceToMessagingMarketing sendMessage = new RASF.Main.Forms.Marketing.ResponceToMessagingMarketing();
           // SendMessage.MdiParent = this;
            sendMessage.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(sendMessage);
        }

        private void mnuShowSendMessage_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Message.ShowSendMessage ShowSendMessage = new RASF.Main.Forms.Message.ShowSendMessage();
           // ShowSendMessage.ReturnPacket += SendMessage_ReturnPacket;
            // SendMessage.MdiParent = this;
            ShowSendMessage.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ShowSendMessage);
        }

        private void mnuShowRecieveMessage_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Message.ShowRecieveMessage ShowRecieveMessage = new RASF.Main.Forms.Message.ShowRecieveMessage();
            // ShowSendMessage.ReturnPacket += SendMessage_ReturnPacket;
            // SendMessage.MdiParent = this;
            ShowRecieveMessage.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ShowRecieveMessage);
        }

        private void mnuEditMessage_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.EditMessaging EditMessaging = new RASF.Main.Forms.Harmony.EditMessaging();
            // ShowSendMessage.ReturnPacket += SendMessage_ReturnPacket;
            // SendMessage.MdiParent = this;
            EditMessaging.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(EditMessaging);
        }

        private void mnuCompanyWorkFlowWithDate_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.CompanyWorkFlowWithDate companyWorkFlowBaseOfPeymentCostomer = new RASF.Main.Forms.Financial.CompanyWorkFlowWithDate();
            // companyWorkFlowBaseOfPeymentCostomer.MdiParent = this;
            companyWorkFlowBaseOfPeymentCostomer.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(companyWorkFlowBaseOfPeymentCostomer);
        }

        private void mnuChangeYear_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Settings.ChangeYear ChangeYear = new RASF.Main.Forms.Settings.ChangeYear();
            ChangeYear.ChangedYead += ChangeYear_ChangedYead;
            //ChangeYear.MdiParent = this;
            ChangeYear.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ChangeYear);
        }

        private void ChangeYear_ChangedYead(object sender, EventArgs e)
        {
            if (this.InvokeRequired == true)
            {
                this.Invoke(new SetStatusBarYear(SetYear));
            }
            else
            {
                this.SetYear();
            }
        }

        private void SetYear()
        {
            this.uiStatusBar2.Panels[2].Text = string.Format("سال جاری:{0}", RASF.General.Classes.Global.FinancialYear);
        }

        private void mnuCancelIsHoldForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.CancelHoldedContract CancelIsHoldForm = new RASF.Main.Forms.Harmony.CancelHoldedContract();
            //CancelIsHoldForm.MdiParent = this;
            CancelIsHoldForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CancelIsHoldForm);
        }

        private void mnuHoldedContractBeforeFinancialReports_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.HoldedContractBeforeFinancialReports CancelIsHoldForm = new RASF.Main.Forms.Reception.HoldedContractBeforeFinancialReports();
            //CancelIsHoldForm.MdiParent = this;
            CancelIsHoldForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CancelIsHoldForm);
        }

        private void mnuContractors_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Base.Contractors DefinitionOfContractors = new RASF.Main.Forms.Base.Contractors();
            //DefinitionOfContractors.MdiParent = this;
            DefinitionOfContractors.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DefinitionOfContractors);
        }

        private void mnuLaboratoryPriorityRecieption_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Base.LaboratoryPriorityRecieption LaboratoryPriorityRecieption = new RASF.Main.Forms.Base.LaboratoryPriorityRecieption();
            //DefinitionOfContractors.MdiParent = this;
            LaboratoryPriorityRecieption.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(LaboratoryPriorityRecieption);
        }

        private void mnuCancelFinacialSupportForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.CancelFinacialSupportForm CancelFinacialSupportForm = new RASF.Main.Forms.Harmony.CancelFinacialSupportForm();
            // RequestOfConstractors.MdiParent = this;
            CancelFinacialSupportForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CancelFinacialSupportForm);
        }


        private void mnuViewIsHoldForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ViewIsHoldForm ViewIsHoldForm = new RASF.Main.Forms.Harmony.ViewIsHoldForm();
            // ViewIsHoldForm.MdiParent = this;
            ViewIsHoldForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ViewIsHoldForm);
        }

        private void mnuViewCancelExitedContractsForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.ViewCancelExitedContractsForm ViewCancelExitedContractsForm = new RASF.Main.Forms.Harmony.ViewCancelExitedContractsForm();
            //ViewCancelExitedContractsForm.MdiParent = this;
            ViewCancelExitedContractsForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ViewCancelExitedContractsForm);
        }

        private void mnuFollowUpIsHoldContract_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.FollowUpIsHoldContract FollowUpIsHoldContract = new RASF.Main.Forms.Harmony.FollowUpIsHoldContract();
            //ViewCancelExitedContractsForm.MdiParent = this;
            FollowUpIsHoldContract.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(FollowUpIsHoldContract);
        }

        private void mnuEmptyDateOfPrint_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.EmptyDateOfPrint EmptyDateOfPrint = new RASF.Main.Forms.Harmony.EmptyDateOfPrint();
            //EmptyDateOfPrint.MdiParent = this;
            EmptyDateOfPrint.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(EmptyDateOfPrint);
        }

        private void mnuCloseEmptyDateOfPrint_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.CloseEmptyDateOfPrint EmptyDateOfPrint = new RASF.Main.Forms.Harmony.CloseEmptyDateOfPrint();
            //EmptyDateOfPrint.MdiParent = this;
            EmptyDateOfPrint.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(EmptyDateOfPrint);
        }

        private void mnuOpenReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.OpenReport OpenReport = new RASF.Main.Forms.Harmony.OpenReport();
            //EmptyDateOfPrint.MdiParent = this;
            OpenReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(OpenReport);
        }

        private void mnuOpenReportPDF_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.OpenReportPDF OpenReportPDF = new RASF.Main.Forms.Harmony.OpenReportPDF();
            //EmptyDateOfPrint.MdiParent = this;
            OpenReportPDF.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(OpenReportPDF);
        }

        private void mnuObservationReportWord_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reports.EditReportForView ObservationReportWord = new RASF.Main.Forms.Reports.EditReportForView();
            //EmptyDateOfPrint.MdiParent = this;
            ObservationReportWord.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ObservationReportWord);
        }

        private void mnuCloseOpenReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.CloseOpenReport CloseOpenReport = new RASF.Main.Forms.Harmony.CloseOpenReport();
            //EmptyDateOfPrint.MdiParent = this;
            CloseOpenReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(CloseOpenReport);
        }

        private void mnuOnceMeetCustomerToBonyad_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.OnceMeetCustomerToBonyad OnceMeetCustomerToBonyad = new RASF.Main.Forms.Harmony.OnceMeetCustomerToBonyad();
            //OnceMeetCustomerToBonyad.MdiParent = this;
            OnceMeetCustomerToBonyad.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(OnceMeetCustomerToBonyad);
        }

        private void mnuRequestOfContractorDoesnotSendForm_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.RequestOfContractorDoesnotSendForm RequestOfContractorDoesnotSendForm = new RASF.Main.Forms.Harmony.RequestOfContractorDoesnotSendForm();
            // RequestOfContractorDoesnotSendForm.MdiParent = this;
            RequestOfContractorDoesnotSendForm.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(RequestOfContractorDoesnotSendForm);
        }

        private void mnuDeliveryDateChange_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.DeliveryDateChange DeliveryDateChange = new RASF.Main.Forms.Harmony.DeliveryDateChange();
            //DeliveryDateChange.MdiParent = this;
            DeliveryDateChange.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDateChange);
        }

        private void mnuDeliveryDateChangeForHarmony_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.DeliveryDateChangeForHarmony DeliveryDateChangeForHarmony = new RASF.Main.Forms.Harmony.DeliveryDateChangeForHarmony();
            //DeliveryDateChange.MdiParent = this;
            DeliveryDateChangeForHarmony.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDateChangeForHarmony);
        }

        private void mnuDeliveryDateChangeOnSiteTesting_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Harmony.DeliveryDateChangeOnSiteTesting DeliveryDateChangeOnSiteTesting = new RASF.Main.Forms.Harmony.DeliveryDateChangeOnSiteTesting();
            //DeliveryDateChange.MdiParent = this;
            DeliveryDateChangeOnSiteTesting.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(DeliveryDateChangeOnSiteTesting);
        }

        private void mnuShowDeliveryDateChangeForManager_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Manager.ShowDeliveryDateChangeForManager ShowDeliveryDateChangeForManager = new RASF.Main.Forms.Manager.ShowDeliveryDateChangeForManager();
            //DeliveryDateChange.MdiParent = this;
            ShowDeliveryDateChangeForManager.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(ShowDeliveryDateChangeForManager);
        }

        private void mnuAssignGroup_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.WorkFlow.AssignGroup AssignGroup = new RASF.Main.Forms.WorkFlow.AssignGroup();
            //DeliveryDateChange.MdiParent = this;
            AssignGroup.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(AssignGroup);
        }

        private void mnuAssignExecuters_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.WorkFlow.AssignExecuters AssignExecuters = new RASF.Main.Forms.WorkFlow.AssignExecuters();
            //DeliveryDateChange.MdiParent = this;
            AssignExecuters.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(AssignExecuters);
        }

        private void mnuSendLetters_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Secretariat.SendLetters SendLetters = new RASF.Main.Forms.Secretariat.SendLetters();
            //DeliveryDateChange.MdiParent = this;
            SendLetters.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendLetters);
        }

        private void mnuSendLettersReport_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Secretariat.SendLettersReport SendLettersReport = new RASF.Main.Forms.Secretariat.SendLettersReport();
            //DeliveryDateChange.MdiParent = this;
            SendLettersReport.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendLettersReport);
        }

        private void mnuSendLettersForDelete_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Secretariat.SendLettersForDelete SendLettersForDelete = new RASF.Main.Forms.Secretariat.SendLettersForDelete();
            //DeliveryDateChange.MdiParent = this;
            SendLettersForDelete.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(SendLettersForDelete);
        }

        private void mnuEditSendLetters_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Secretariat.SendLettersReportForEdit EditSendLetters = new RASF.Main.Forms.Secretariat.SendLettersReportForEdit();
            //DeliveryDateChange.MdiParent = this;
            EditSendLetters.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(EditSendLetters);
        }

        private void mnuInvoiceDaneshBonyan_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Financial.InvoiceDaneshBonyan InvoiceDaneshBonyan = new RASF.Main.Forms.Financial.InvoiceDaneshBonyan();
            //DeliveryDateChange.MdiParent = this;
            InvoiceDaneshBonyan.Text = ((ToolStripMenuItem)sender).Text;
            ShowDocument(InvoiceDaneshBonyan);
        }

        private void OpenMessage_NumofUnreadMessage(object sender, EventArgs e)
        {
            if (this.InvokeRequired == true)
            {
                this.Invoke(new SetStatusBarYear(CalculateNum));
            }
            else
            {
                this.CalculateNum();
            }
        }

        private void SendMessage_ReturnPacket(General.Events.ReternListOfPacketEventArgs e)
        {
            if (this.InvokeRequired == true)
            {
                this.Invoke(new SendPackets(SendMessage), e.Packets);
            }
            else
            {
                this.SendMessage(e.Packets);
            }
        }

        private void NewMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("آیا مایل به خروج از برنامه می باشید", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (Client != null)
                {
                    this.Client.LogOut();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void SendMessage(List<RASF.Messaging.General.Classes.Packet> Packets)
        {
            foreach (RASF.Messaging.General.Classes.Packet packet in Packets)
            {
                if (Client != null)
                {
                    this.Client.SendMessage(packet);
                }
            }
        }

        private void uiStatusBar2_Click(object sender, EventArgs e)
        {
            if (Num > 0)
            {
                RASF.Main.Forms.Message.OpenMessage OpenMessage = new RASF.Main.Forms.Message.OpenMessage();
                OpenMessage.NumofUnreadMessage += OpenMessage_NumofUnreadMessage;
                OpenMessage.Save += OpenMessage_Save;
                OpenMessage.MyMdiParent = this;
               // OpenMessage.Show();
                OpenMessage.ShowDocument(CurrentDockPanel);
            }

        }

        private void CalculateNum()
        {
            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection("Data Source=192.168.0.3;Initial Catalog=LaboratoryRASF;Persist Security Info=True;User ID=sa;Password=AliReza23280;ApplicationIntent=ReadOnly"))
            {
                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand("UnreadMessage_Select", Connection))
                {
                    Command.CommandType = System.Data.CommandType.StoredProcedure;
                    Command.Parameters.Add(new System.Data.SqlClient.SqlParameter("Receiver", RASF.General.Classes.Global.CurrentUserCode));
                    Connection.Open();
                    Num = Convert.ToInt16(Command.ExecuteScalar());
                    Connection.Close();
                    this.uiStatusBar2.Panels[1].Text = string.Format("{0}:پیام های خوانده نشده", Num);
                }
            }
        }

        private void OpenMessage_Save(object sender, EventArgs e)
        {
            CalculateNum();

            this.uiStatusBar2.Panels[1].Text = string.Format("{0}:پیام های خوانده نشده", Num);

        }

        private void NewMainForm_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.Control==true && e.KeyCode == Keys.W)
        //    if (e.KeyData == Keys.Escape)
            {
                if (this.ActiveMdiChild is RASF.Main.Forms.Reports.EditWordDocument)
                {
                    ((RASF.Main.Forms.Reports.EditWordDocument)this.ActiveMdiChild).Insert_Was();
                }
                else
                {
                    MessageBox.Show("این قابلیت در فرم جاری در دسترس نیست", "", MessageBoxButtons.OK);
                }
            }
        }

      
    }
}