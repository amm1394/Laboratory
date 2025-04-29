using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Controls
{
    public class Save_Button : Janus.Windows.EditControls.UIButton
    {
        [System.ComponentModel.Category("RASF")]
        public Save_Button()
            : base()
        {
            this.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
        }

        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.DefaultValue(false)]
        public Boolean IsShowMessage { get; set; }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                if (IsShowMessage == false)
                    System.Windows.Forms.MessageBox.Show("اطلاعات با موفقیت ثبت شد.");
            }
        }
    }
}
