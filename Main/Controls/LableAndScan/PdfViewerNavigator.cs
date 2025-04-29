using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Telerik.Licensing;
using Telerik.WinControls;
using Telerik.WinControls.Design;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.Localization;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Data;
using Telerik.WinControls.UI.Localization;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Search;

namespace RASF.Main.Controls
{
    [Designer("Telerik.WinControls.UI.Design.PdfViewerNavigatorDesigner, Telerik.WinControls.UI.Design, Version=2016.1.112.40, Culture=neutral, PublicKeyToken=5bb2a467cbec794e")]
    [LicenseProvider(typeof(TelerikLicenseProvider))]
    [TelerikToolboxCategory("PdfViewer")]
    [ToolboxItem(true)]
    public class RadPdfViewerNavigator : Telerik.WinControls.UI.RadCommandBar
    {
        public event EventHandler OpenClick
        {
            add { this.openButton.Click += value; }
            remove { this.openButton.Click -= value; }
        }

        private float[] zoomFactors = new float[] { 5f, 8.33f, 12f, 25f, 33.33f, 50f, 66.67f, 75f, 100f, 200f, 300f, 400f, 600f, 800f, 1200f };

        private CommandBarButton openButton = new CommandBarButton();

        private CommandBarButton printButton = new CommandBarButton();

        private CommandBarButton previousButton = new CommandBarButton();

        private CommandBarButton nextButton = new CommandBarButton();

        private CommandBarTextBox currentPageTextBox = new CommandBarTextBox();

        private CommandBarLabel totalPagesLabel = new CommandBarLabel();

        private CommandBarButton zoomInButton = new CommandBarButton();

        private CommandBarButton zoomOutButton = new CommandBarButton();

        private CommandBarDropDownList zoomDropDown = new CommandBarDropDownList();

        private CommandBarToggleButton fitToWidthButton = new CommandBarToggleButton();

        private CommandBarToggleButton fitToPageButton = new CommandBarToggleButton();

        private CommandBarToggleButton handToolButton = new CommandBarToggleButton();

        private CommandBarToggleButton selectToolButton = new CommandBarToggleButton();

        private CommandBarButton findPreviousButton = new CommandBarButton();

        private CommandBarTextBox searchTextBox = new CommandBarTextBox();

        private CommandBarButton findNextButton = new CommandBarButton();

        private CommandBarStripElement defaultStrip = new CommandBarStripElement();

        //private Telerik.Windows.Pdf.Documents.Fixed.Search.TextSearchOptions searchOptions;
        private TextSearchOptions searchOptions;


        private RadPdfViewer pdfViewer;

        private RadPdfViewerElement pdfViewerElement;

        private bool toggleButtonsUpdating;

        private bool showPrintPreview = true;

        private readonly RadPrintDocument printDocument = new RadPrintDocument();

        [Browsable(true)]
        [DefaultValue(null)]
        public RadPdfViewer AssociatedViewer
        {
            get
            {
                return this.pdfViewer;
            }
            set
            {
                RadPdfViewerElement pdfViewerElement;
                this.pdfViewer = value;
                if (this.pdfViewer != null)
                {
                    pdfViewerElement = this.pdfViewer.PdfViewerElement;
                }
                else
                {
                    pdfViewerElement = null;
                }
                this.AssociatedViewerElement = pdfViewerElement;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public RadPdfViewerElement AssociatedViewerElement
        {
            get
            {
                return this.pdfViewerElement;
            }
            set
            {
                if (this.pdfViewerElement != value)
                {
                    this.UnwireViewerEvents();
                    this.pdfViewerElement = value;
                    this.WireViewerEvents();
                    this.OnAssociatedViewerChanged();
                }
            }
        }

        [Browsable(false)]
        public CommandBarTextBox CurrentPageTextBox
        {
            get
            {
                return this.currentPageTextBox;
            }
        }

        protected override System.Drawing.Size DefaultSize
        {
            get
            {
                return RadControl.GetDpiScaledSize(new System.Drawing.Size(610, 38));
            }
        }

        [Browsable(false)]
        public CommandBarStripElement DefaultStrip
        {
            get
            {
                return this.defaultStrip;
            }
        }

        [Category("Layout")]
        [DefaultValue(DockStyle.None)]
        [Localizable(true)]
        [RefreshProperties(RefreshProperties.All)]
        public override DockStyle Dock
        {
            get
            {
                return base.Dock;
            }
            set
            {
                base.Dock = value;
            }
        }

        [Browsable(false)]
        public CommandBarButton FindNextButton
        {
            get
            {
                return this.findNextButton;
            }
        }

        [Browsable(false)]
        public CommandBarButton FindPreviousButton
        {
            get
            {
                return this.findPreviousButton;
            }
        }

        [Browsable(false)]
        public CommandBarToggleButton FitToPageButton
        {
            get
            {
                return this.fitToPageButton;
            }
        }

        [Browsable(false)]
        public CommandBarToggleButton FitToWidthButton
        {
            get
            {
                return this.fitToWidthButton;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override bool Focusable
        {
            get
            {
                return base.Focusable;
            }
            set
            {
                base.Focusable = value;
            }
        }

        [Browsable(false)]
        public CommandBarToggleButton HandToolButton
        {
            get
            {
                return this.handToolButton;
            }
        }

        [Browsable(false)]
        public CommandBarButton NextButton
        {
            get
            {
                return this.nextButton;
            }
        }

        [Browsable(false)]
        public CommandBarButton OpenButton
        {
            get
            {
                return this.openButton;
            }
        }

        [Browsable(false)]
        public CommandBarButton PreviousButton
        {
            get
            {
                return this.previousButton;
            }
        }

        [Browsable(false)]
        public CommandBarButton PrintButton
        {
            get
            {
                return this.printButton;
            }
        }

        [Browsable(false)]
        public RadPrintDocument PrintDocument
        {
            get
            {
                return this.printDocument;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new RadCommandBarLinesElementCollection Rows
        {
            get
            {
                return base.Rows;
            }
        }

        [Browsable(false)]
        public CommandBarTextBox SearchTextBox
        {
            get
            {
                return this.searchTextBox;
            }
        }

        [Browsable(false)]
        public CommandBarToggleButton SelectToolButton
        {
            get
            {
                return this.selectToolButton;
            }
        }

        [Browsable(true)]
        [DefaultValue(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ShowPrintPreview
        {
            get
            {
                return this.showPrintPreview;
            }
            set
            {
                this.showPrintPreview = value;
            }
        }

        [Browsable(false)]
        public CommandBarLabel TotalPagesLabel
        {
            get
            {
                return this.totalPagesLabel;
            }
        }

        [Browsable(false)]
        public CommandBarDropDownList ZoomDropDown
        {
            get
            {
                return this.zoomDropDown;
            }
        }

        [Browsable(false)]
        public CommandBarButton ZoomInButton
        {
            get
            {
                return this.zoomInButton;
            }
        }

        [Browsable(false)]
        public CommandBarButton ZoomOutButton
        {
            get
            {
                return this.zoomOutButton;
            }
        }

        public RadPdfViewerNavigator()
        {
            this.ThemeClassName = typeof(RadCommandBar).FullName;
            this.Focusable = false;
            this.printDocument.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            this.Rows.Add(new CommandBarRowElement());
            this.Rows[0].Strips.Add(this.defaultStrip);
            this.AddDefaultItems();
            //this.searchOptions = new Telerik.Windows.Pdf.Documents.Fixed.Search.TextSearchOptions(false);
            this.searchOptions = new TextSearchOptions(false);
            this.UpdateButtonsEnableState();
            this.LocalizeStrings();
            LocalizationProvider<object>.CurrentProviderChanged += new EventHandler(this.PdfViewerLocalizationProvider_CurrentProviderChanged);
        }

        public RadPdfViewerNavigator(RadPdfViewer owner) : this()
        {
            this.AssociatedViewer = owner;
        }

        protected virtual void AddDefaultItems()
        {
            this.defaultStrip.StretchHorizontally = true;
            this.openButton.Image = global::Main.Properties.Resources.open;
            this.openButton.MinSize = new System.Drawing.Size(34, 34);
            this.printButton.Image = global::Main.Properties.Resources.print;
            this.printButton.MinSize = new System.Drawing.Size(34, 34);
            this.previousButton.Image = global::Main.Properties.Resources.arrow_up;
            this.previousButton.MinSize = new System.Drawing.Size(34, 34);
            this.nextButton.Image = global::Main.Properties.Resources.arrow_down;
            this.nextButton.MinSize = new System.Drawing.Size(34, 34);
            this.zoomInButton.Image = global::Main.Properties.Resources.zoom_in;
            this.zoomInButton.MinSize = new System.Drawing.Size(34, 34);
            this.zoomOutButton.Image = global::Main.Properties.Resources.zoom_out;
            this.zoomOutButton.MinSize = new System.Drawing.Size(34, 34);
            this.handToolButton.Image = global::Main.Properties.Resources.hand_free;
            this.handToolButton.MinSize = new System.Drawing.Size(34, 34);
            this.selectToolButton.Image = global::Main.Properties.Resources.text_selection;
            this.selectToolButton.MinSize = new System.Drawing.Size(34, 34);
            this.findNextButton.Image = global::Main.Properties.Resources.find_next;
            this.findNextButton.MinSize = new System.Drawing.Size(34, 34);
            this.findPreviousButton.Image = global::Main.Properties.Resources.find_previous;
            this.findPreviousButton.MinSize = new System.Drawing.Size(34, 34);
            this.fitToWidthButton.Image = global::Main.Properties.Resources.fit_page_width;
            this.fitToWidthButton.MinSize = new System.Drawing.Size(34, 34);
            this.fitToPageButton.Image = global::Main.Properties.Resources.fit_full_page;
            this.fitToPageButton.MinSize = new System.Drawing.Size(34, 34);
            this.totalPagesLabel.Text = " / 0";
            this.currentPageTextBox.TextBoxElement.TextBoxItem.TextAlign = HorizontalAlignment.Center;
            this.defaultStrip.Items.Add(this.openButton);
            this.defaultStrip.Items.Add(this.printButton);
            this.defaultStrip.Items.Add(new CommandBarSeparator());
            this.defaultStrip.Items.Add(this.previousButton);
            this.defaultStrip.Items.Add(this.nextButton);
            this.defaultStrip.Items.Add(this.currentPageTextBox);
            this.defaultStrip.Items.Add(this.totalPagesLabel);
            this.defaultStrip.Items.Add(new CommandBarSeparator());
            this.defaultStrip.Items.Add(this.handToolButton);
            this.defaultStrip.Items.Add(this.selectToolButton);
            this.defaultStrip.Items.Add(new CommandBarSeparator());
            this.defaultStrip.Items.Add(this.zoomOutButton);
            this.defaultStrip.Items.Add(this.zoomInButton);
            this.defaultStrip.Items.Add(this.zoomDropDown);
            this.defaultStrip.Items.Add(new CommandBarSeparator());
            this.defaultStrip.Items.Add(this.fitToWidthButton);
            this.defaultStrip.Items.Add(this.fitToPageButton);
            this.defaultStrip.Items.Add(new CommandBarSeparator());
            this.defaultStrip.Items.Add(this.searchTextBox);
            this.defaultStrip.Items.Add(this.findPreviousButton);
            this.defaultStrip.Items.Add(this.findNextButton);
            this.findPreviousButton.MouseUp += new MouseEventHandler(this.commandBarButtonPrev_Click);
            this.findNextButton.MouseUp += new MouseEventHandler(this.commandBarButtonNext_Click);
            this.printButton.MouseUp += new MouseEventHandler(this.print_Click);
            this.searchTextBox.NullText = "Find";
            this.searchTextBox.MinSize = new System.Drawing.Size(110, 0);
            this.searchTextBox.TextChanged += new EventHandler(this.commandBarTextBoxSearch_TextChanged);
            this.handToolButton.ToggleStateChanged += new StateChangedEventHandler(this.handToolButton_ToggleStateChanged);
            this.selectToolButton.ToggleStateChanged += new StateChangedEventHandler(this.selectToolButton_ToggleStateChanged);
            this.zoomInButton.MouseUp += new MouseEventHandler(this.zoomInButton_Click);
            this.zoomOutButton.MouseUp += new MouseEventHandler(this.zoomOutButton_Click);
            this.fitToWidthButton.ToggleStateChanging += new StateChangingEventHandler(this.fitToWidthButton_ToggleStateChanging);
            this.fitToPageButton.ToggleStateChanging += new StateChangingEventHandler(this.fitToPageButton_ToggleStateChanging);
            this.currentPageTextBox.KeyDown += new KeyEventHandler(this.commandBarTextBox1_KeyDown);
            this.previousButton.MouseUp += new MouseEventHandler(this.previousButton_Click);
            this.nextButton.MouseUp += new MouseEventHandler(this.nextButton_Click);
            this.InitializeZoomDropDown();
        }

        private void commandBarButtonNext_Click(object sender, MouseEventArgs e)
        {
            if (this.pdfViewerElement == null || this.pdfViewerElement.Document == null)
            {
                return;
            }
        }

        private void commandBarButtonPrev_Click(object sender, MouseEventArgs e)
        {
            if (this.pdfViewerElement == null || this.pdfViewerElement.Document == null)
            {
                return;
            }
        }

        private void commandBarTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.pdfViewerElement == null)
            {
                return;
            }
            if (e.KeyCode == Keys.Return)
            {
                int num = 0;
                if (int.TryParse(this.currentPageTextBox.Text, out num))
                {
                    this.pdfViewerElement.GoToPage(num);
                    this.UpdateCurrentPage();
                }
            }
        }

        private void commandBarTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            this.UpdateButtonsEnableState();
        }

        protected override void Dispose(bool disposing)
        {
            LocalizationProvider<object>.CurrentProviderChanged -= new EventHandler(this.PdfViewerLocalizationProvider_CurrentProviderChanged);
            base.Dispose(disposing);
        }

        private void Editor_ValueChanged(object sender, EventArgs e)
        {
            if (this.pdfViewerElement == null)
            {
                return;
            }
            this.SetZoom(this.pdfViewerElement.ScaleFactor / 100f);
        }

        private void fitToPageButton_ToggleStateChanging(object sender, StateChangingEventArgs args)
        {
            this.fitToWidthButton.ToggleState = ToggleState.Off;
//            this.pdfViewerElement.FitFullPage = args.NewValue == ToggleState.On;
        }

        private void fitToWidthButton_ToggleStateChanging(object sender, StateChangingEventArgs args)
        {
            this.fitToPageButton.ToggleState = ToggleState.Off;
  //          this.pdfViewerElement.FitToWidth = args.NewValue == ToggleState.On;
        }

        private void handToolButton_ToggleStateChanged(object sender, StateChangedEventArgs e)
        {
            if (this.pdfViewerElement == null || this.toggleButtonsUpdating)
            {
                return;
            }
            this.toggleButtonsUpdating = true;
            if (this.handToolButton.ToggleState != ToggleState.On)
            {
                this.pdfViewerElement.Mode = FixedDocumentViewerMode.None;
            }
            else
            {
                this.pdfViewerElement.Mode = FixedDocumentViewerMode.Pan;
                this.selectToolButton.ToggleState = ToggleState.Off;
            }
            this.toggleButtonsUpdating = false;
        }

        private void HostedControl_KeyDown(object sender, KeyEventArgs e)
        {
            float single;
            if (e.KeyCode == Keys.Return)
            {
                string str = this.zoomDropDown.DropDownListElement.TextBox.Text.Trim();
                char[] chrArray = new char[] { '%' };
                if (float.TryParse(str.Trim(chrArray), out single))
                {
                    this.SetZoom(single / 100f);
                }
            }
        }

        protected virtual void InitializeZoomDropDown()
        {
            for (int i = 0; i < (int)this.zoomFactors.Length; i++)
            {
                this.zoomDropDown.Items.Add(new RadListDataItem(string.Concat(this.zoomFactors[i].ToString(), " %"), (object)(this.zoomFactors[i] / 100f)));
            }
            this.zoomDropDown.SelectedValue = 1f;
            this.currentPageTextBox.TextBoxElement.MinSize = new System.Drawing.Size(35, 22);
            this.currentPageTextBox.TextBoxElement.TextAlign = HorizontalAlignment.Right;
            this.zoomDropDown.DropDownListElement.TextBox.TextBoxItem.HostedControl.KeyDown += new KeyEventHandler(this.HostedControl_KeyDown);
            this.zoomDropDown.SelectedValueChanged += new ValueChangedEventHandler(this.zoomDropDown_SelectedValueChanged);
        }

        protected virtual void LocalizeStrings()
        {
            CommandBarToggleButton commandBarToggleButton = this.fitToWidthButton;
            CommandBarToggleButton commandBarToggleButton1 = this.fitToWidthButton;
            CommandBarToggleButton commandBarToggleButton2 = this.fitToWidthButton;
            string localizedString = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("NavigatorFitToWidthButton");
            string str = localizedString;
            commandBarToggleButton2.ToolTipText = localizedString;
            string str1 = str;
            string str2 = str1;
            commandBarToggleButton1.DisplayName = str1;
            commandBarToggleButton.Text = str2;
            CommandBarToggleButton fitToPageButton = this.FitToPageButton;
            CommandBarToggleButton fitToPageButton1 = this.FitToPageButton;
            CommandBarToggleButton fitToPageButton2 = this.FitToPageButton;
            string localizedString1 = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("NavigatorFitToPageButton");
            string str3 = localizedString1;
            fitToPageButton2.ToolTipText = localizedString1;
            string str4 = str3;
            string str5 = str4;
            fitToPageButton1.DisplayName = str4;
            fitToPageButton.Text = str5;
            CommandBarButton commandBarButton = this.openButton;
            CommandBarButton commandBarButton1 = this.openButton;
            CommandBarButton commandBarButton2 = this.openButton;
            string localizedString2 = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("NavigatorOpenButton");
            string str6 = localizedString2;
            commandBarButton2.ToolTipText = localizedString2;
            string str7 = str6;
            string str8 = str7;
            commandBarButton1.DisplayName = str7;
            commandBarButton.Text = str8;
            CommandBarButton commandBarButton3 = this.printButton;
            CommandBarButton commandBarButton4 = this.printButton;
            CommandBarButton commandBarButton5 = this.printButton;
            string localizedString3 = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("NavigatorPrintButton");
            string str9 = localizedString3;
            commandBarButton5.ToolTipText = localizedString3;
            string str10 = str9;
            string str11 = str10;
            commandBarButton4.DisplayName = str10;
            commandBarButton3.Text = str11;
            CommandBarButton commandBarButton6 = this.previousButton;
            CommandBarButton commandBarButton7 = this.previousButton;
            CommandBarButton commandBarButton8 = this.previousButton;
            string localizedString4 = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("NavigatorPreviousPageButton");
            string str12 = localizedString4;
            commandBarButton8.ToolTipText = localizedString4;
            string str13 = str12;
            string str14 = str13;
            commandBarButton7.DisplayName = str13;
            commandBarButton6.Text = str14;
            CommandBarButton commandBarButton9 = this.nextButton;
            CommandBarButton commandBarButton10 = this.nextButton;
            CommandBarButton commandBarButton11 = this.nextButton;
            string localizedString5 = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("NavigatorNextPageButton");
            string str15 = localizedString5;
            commandBarButton11.ToolTipText = localizedString5;
            string str16 = str15;
            string str17 = str16;
            commandBarButton10.DisplayName = str16;
            commandBarButton9.Text = str17;
            this.currentPageTextBox.DisplayName = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("NavigatorCurrentPageTextBox");
            this.totalPagesLabel.DisplayName = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("NavigatorTotalPagesLabel");
            CommandBarButton commandBarButton12 = this.zoomInButton;
            CommandBarButton commandBarButton13 = this.zoomInButton;
            CommandBarButton commandBarButton14 = this.zoomInButton;
            string localizedString6 = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("NavigatorZoomInButton");
            string str18 = localizedString6;
            commandBarButton14.ToolTipText = localizedString6;
            string str19 = str18;
            string str20 = str19;
            commandBarButton13.DisplayName = str19;
            commandBarButton12.Text = str20;
            CommandBarButton commandBarButton15 = this.zoomOutButton;
            CommandBarButton commandBarButton16 = this.zoomOutButton;
            CommandBarButton commandBarButton17 = this.zoomOutButton;
            string localizedString7 = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("NavigatorZoomOutButton");
            string str21 = localizedString7;
            commandBarButton17.ToolTipText = localizedString7;
            string str22 = str21;
            string str23 = str22;
            commandBarButton16.DisplayName = str22;
            commandBarButton15.Text = str23;
            this.zoomDropDown.DisplayName = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("NavigatorZoomDropDown");
            CommandBarToggleButton commandBarToggleButton3 = this.handToolButton;
            CommandBarToggleButton commandBarToggleButton4 = this.handToolButton;
            CommandBarToggleButton commandBarToggleButton5 = this.handToolButton;
            string localizedString8 = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("NavigatorHandToolButton");
            string str24 = localizedString8;
            commandBarToggleButton5.ToolTipText = localizedString8;
            string str25 = str24;
            string str26 = str25;
            commandBarToggleButton4.DisplayName = str25;
            commandBarToggleButton3.Text = str26;
            CommandBarToggleButton commandBarToggleButton6 = this.selectToolButton;
            CommandBarToggleButton commandBarToggleButton7 = this.selectToolButton;
            CommandBarToggleButton commandBarToggleButton8 = this.selectToolButton;
            string localizedString9 = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("NavigatorSelectToolButton");
            string str27 = localizedString9;
            commandBarToggleButton8.ToolTipText = localizedString9;
            string str28 = str27;
            string str29 = str28;
            commandBarToggleButton7.DisplayName = str28;
            commandBarToggleButton6.Text = str29;
            CommandBarButton commandBarButton18 = this.findNextButton;
            CommandBarButton commandBarButton19 = this.findNextButton;
            CommandBarButton commandBarButton20 = this.findNextButton;
            string localizedString10 = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("NavigatorFindNextButton");
            string str30 = localizedString10;
            commandBarButton20.ToolTipText = localizedString10;
            string str31 = str30;
            string str32 = str31;
            commandBarButton19.DisplayName = str31;
            commandBarButton18.Text = str32;
            CommandBarButton commandBarButton21 = this.findPreviousButton;
            CommandBarButton commandBarButton22 = this.findPreviousButton;
            CommandBarButton commandBarButton23 = this.findPreviousButton;
            string localizedString11 = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("NavigatorFindPreviousButton");
            string str33 = localizedString11;
            commandBarButton23.ToolTipText = localizedString11;
            string str34 = str33;
            string str35 = str34;
            commandBarButton22.DisplayName = str34;
            commandBarButton21.Text = str35;
            this.searchTextBox.DisplayName = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("NavigatorSearchTextBox");
            this.searchTextBox.NullText = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("Find");
            this.defaultStrip.DisplayName = LocalizationProvider<PdfViewerLocalizationProvider>.CurrentProvider.GetLocalizedString("NavigatorDefaultStrip");
        }

        private void nextButton_Click(object sender, MouseEventArgs e)
        {
            if (this.pdfViewerElement == null)
            {
                return;
            }
            this.pdfViewerElement.PageDown();
        }

        protected virtual void OnAssociatedViewerChanged()
        {
            this.UpdatePageCount();
            this.UpdateCurrentPage();
            if (this.pdfViewerElement == null)
            {
                return;
            }
            this.handToolButton.ToggleState = (this.pdfViewerElement.Mode == FixedDocumentViewerMode.Pan ? ToggleState.On : ToggleState.Off);
            this.selectToolButton.ToggleState = (this.pdfViewerElement.Mode == FixedDocumentViewerMode.TextSelection ? ToggleState.On : ToggleState.Off);
            this.zoomDropDown.MinSize = new System.Drawing.Size(67, 22);
            this.zoomDropDown.SelectedValueChanged -= new ValueChangedEventHandler(this.zoomDropDown_SelectedValueChanged);
            this.zoomDropDown.DropDownListElement.SelectedValue = this.pdfViewerElement.ScaleFactor;
            this.zoomDropDown.DropDownListElement.TextBox.Text = string.Format("{0:p2}", this.pdfViewer.ScaleFactor);
            this.zoomDropDown.SelectedValueChanged += new ValueChangedEventHandler(this.zoomDropDown_SelectedValueChanged);
        }
     
        private void pdfViewerElement_DocumentLoaded(object sender, EventArgs e)
        {
            this.UpdatePageCount();
            this.UpdateCurrentPage();
            this.UpdatePrintLandscapeMode();
        }

        private void pdfViewerElement_DocumentUnloaded(object sender, EventArgs e)
        {
            this.totalPagesLabel.Text = " / 0";
            this.currentPageTextBox.Text = "0";
        }

        private void pdfViewerElement_FitFullPageChanged(object sender, EventArgs e)
        {
//            this.fitToPageButton.ToggleState = (this.pdfViewerElement.FitFullPage ? ToggleState.On : ToggleState.Off);
        }

        private void pdfViewerElement_FitToWidthChanged(object sender, EventArgs e)
        {
  //          this.fitToWidthButton.ToggleState = (this.pdfViewerElement.FitToWidth ? ToggleState.On : ToggleState.Off);
        }

        private void pdfViewerElement_ScaleFactorChanged(object sender, EventArgs e)
        {
            this.zoomDropDown.DropDownListElement.SelectedValue = this.pdfViewerElement.ScaleFactor;
            this.zoomDropDown.DropDownListElement.TextBox.Text = string.Format("{0:p2}", this.pdfViewerElement.ScaleFactor);
        }

        private void pdfViewerElement_ViewerModeChanged(object sender, EventArgs e)
        {
            if (this.toggleButtonsUpdating)
            {
                return;
            }
            this.toggleButtonsUpdating = true;
            this.handToolButton.ToggleState = (this.pdfViewerElement.Mode == FixedDocumentViewerMode.Pan ? ToggleState.On : ToggleState.Off);
            this.selectToolButton.ToggleState = (this.pdfViewerElement.Mode == FixedDocumentViewerMode.TextSelection ? ToggleState.On : ToggleState.Off);
            this.toggleButtonsUpdating = false;
        }

        private void PdfViewerLocalizationProvider_CurrentProviderChanged(object sender, EventArgs e)
        {
            this.LocalizeStrings();
        }

        private void previousButton_Click(object sender, MouseEventArgs e)
        {
            if (this.pdfViewerElement == null)
            {
                return;
            }
            this.pdfViewerElement.PageUp();
        }

        private void print_Click(object sender, MouseEventArgs e)
        {
            if (this.pdfViewerElement == null)
            {
                return;
            }
            if (this.ShowPrintPreview)
            {
                this.pdfViewerElement.PrintPreview(this.printDocument);
                return;
            }
            this.pdfViewerElement.Print(true, this.printDocument);
        }

        private void Scroller_ScrollerUpdated(object sender, EventArgs e)
        {
            this.UpdatePageCount();
            this.UpdateCurrentPage();
        }

        private void selectToolButton_ToggleStateChanged(object sender, StateChangedEventArgs e)
        {
            if (this.pdfViewerElement == null || this.toggleButtonsUpdating)
            {
                return;
            }
            this.toggleButtonsUpdating = true;
            if (this.selectToolButton.ToggleState != ToggleState.On)
            {
                this.pdfViewerElement.Mode = FixedDocumentViewerMode.None;
            }
            else
            {
                this.pdfViewerElement.Mode = FixedDocumentViewerMode.TextSelection;
                this.handToolButton.ToggleState = ToggleState.Off;
            }
            this.toggleButtonsUpdating = false;
        }

        protected void SetZoom(float factor)
        {
            this.fitToWidthButton.ToggleState = ToggleState.Off;
            this.fitToPageButton.ToggleState = ToggleState.Off;
            if (factor < 0f || this.pdfViewerElement == null)
            {
                return;
            }
            this.pdfViewerElement.ScaleFactorChanged -= new EventHandler(this.pdfViewerElement_ScaleFactorChanged);
            this.zoomDropDown.SelectedValueChanged -= new ValueChangedEventHandler(this.zoomDropDown_SelectedValueChanged);
            this.pdfViewerElement.ScaleFactor = factor;
            this.zoomDropDown.DropDownListElement.SelectedValue = this.pdfViewerElement.ScaleFactor;
            this.zoomDropDown.DropDownListElement.TextBox.Text = string.Format("{0:p2}", this.pdfViewerElement.ScaleFactor);
            this.zoomDropDown.SelectedValueChanged += new ValueChangedEventHandler(this.zoomDropDown_SelectedValueChanged);
            this.pdfViewerElement.ScaleFactorChanged += new EventHandler(this.pdfViewerElement_ScaleFactorChanged);
        }

        protected virtual void UnwireViewerEvents()
        {
            if (this.pdfViewerElement == null)
            {
                return;
            }
            this.pdfViewerElement.Scroller.ScrollerUpdated -= new EventHandler(this.Scroller_ScrollerUpdated);
            this.pdfViewerElement.DocumentLoaded -= new EventHandler(this.pdfViewerElement_DocumentLoaded);
            this.pdfViewerElement.DocumentUnloaded -= new EventHandler(this.pdfViewerElement_DocumentUnloaded);
            this.pdfViewerElement.ScaleFactorChanged -= new EventHandler(this.pdfViewerElement_ScaleFactorChanged);
            this.pdfViewerElement.ViewerModeChanged -= new EventHandler(this.pdfViewerElement_ViewerModeChanged);
            //this.pdfViewerElement.FitFullPageChanged -= new EventHandler(this.pdfViewerElement_FitFullPageChanged);
            //this.pdfViewerElement.FitToWidthChanged -= new EventHandler(this.pdfViewerElement_FitToWidthChanged);
        }

        protected virtual void UpdateButtonsEnableState()
        {
            bool flag = string.IsNullOrEmpty(this.searchTextBox.Text);
            this.findPreviousButton.Enabled = !flag;
            this.findNextButton.Enabled = !flag;
        }

        public void UpdateCurrentPage()
        {
            if (this.pdfViewerElement == null || this.pdfViewerElement.CurrentPage == null)
            {
                this.currentPageTextBox.Text = "0";
                return;
            }
            this.currentPageTextBox.Text = this.pdfViewerElement.CurrentPage.PageNo.ToString();
        }

        public void UpdatePageCount()
        {
            if (this.pdfViewerElement == null || this.pdfViewerElement.Document == null)
            {
                this.totalPagesLabel.Text = " / 0";
                return;
            }
            CommandBarLabel commandBarLabel = this.totalPagesLabel;
            int count = this.pdfViewerElement.Document.Pages.Count;
            commandBarLabel.Text = string.Concat(" / ", count.ToString());
        }

        public virtual void UpdatePrintLandscapeMode()
        {
            if (this.AssociatedViewer == null || this.AssociatedViewer.PdfViewerElement.Document == null)
            {
                return;
            }
            //Telerik.Windows.Pdf.Documents.Fixed.Model.RadFixedDocument document = this.AssociatedViewer.PdfViewerElement.Document;
            RadFixedDocument document = this.AssociatedViewer.PdfViewerElement.Document;
            if (document.Pages == null || document.Pages.Count < 1)
            {
                return;
            }
            //this.PrintDocument.Landscape = this.AssociatedViewer.PdfViewerElement.Document.Pages[0].ActualWidth > this.AssociatedViewer.PdfViewerElement.Document.Pages[0].ActualHeight;
            var firstPage = document.Pages[0];
            bool isLandscape = firstPage.Size.Width > firstPage.Size.Height;

            this.PrintDocument.Landscape = isLandscape;
        }

        protected virtual void WireViewerEvents()
        {
            if (this.pdfViewerElement == null)
            {
                return;
            }
            this.pdfViewerElement.Scroller.ScrollerUpdated += new EventHandler(this.Scroller_ScrollerUpdated);
            this.pdfViewerElement.DocumentLoaded += new EventHandler(this.pdfViewerElement_DocumentLoaded);
            this.pdfViewerElement.DocumentUnloaded += new EventHandler(this.pdfViewerElement_DocumentUnloaded);
            this.pdfViewerElement.ScaleFactorChanged += new EventHandler(this.pdfViewerElement_ScaleFactorChanged);
            this.pdfViewerElement.ViewerModeChanged += new EventHandler(this.pdfViewerElement_ViewerModeChanged);
            //this.pdfViewerElement.FitFullPageChanged += new EventHandler(this.pdfViewerElement_FitFullPageChanged);
            //this.pdfViewerElement.FitToWidthChanged += new EventHandler(this.pdfViewerElement_FitToWidthChanged);
        }

        private void zoomDropDown_SelectedValueChanged(object sender, Telerik.WinControls.UI.Data.ValueChangedEventArgs e)
        {
            if (this.zoomDropDown.SelectedValue is float)
            {
                this.SetZoom((float)this.zoomDropDown.SelectedValue);
                this.fitToPageButton.ToggleState = ToggleState.Off;
                this.fitToWidthButton.ToggleState = ToggleState.Off;
            }
        }

        private void zoomInButton_Click(object sender, MouseEventArgs e)
        {
            if (this.pdfViewerElement == null)
            {
                return;
            }
            float scaleFactor = this.pdfViewerElement.ScaleFactor;
            int num = 0;
            int num1 = 0;
            while (num1 < (int)this.zoomFactors.Length)
            {
                if ((double)(this.zoomFactors[num1] / 100f - scaleFactor) <= 0.0001)
                {
                    num = num1;
                    num1++;
                }
                else
                {
                    num = num1;
                    break;
                }
            }
            this.SetZoom(this.zoomFactors[num] / 100f);
        }

        private void zoomOutButton_Click(object sender, MouseEventArgs e)
        {
            if (this.pdfViewerElement == null)
            {
                return;
            }
            float scaleFactor = this.pdfViewerElement.ScaleFactor;
            int num = 0;
            for (int i = 0; i < (int)this.zoomFactors.Length && (double)(scaleFactor - this.zoomFactors[i] / 100f) > 0.0001; i++)
            {
                num = i;
            }
            this.SetZoom(this.zoomFactors[num] / 100f);
        }
    }
}