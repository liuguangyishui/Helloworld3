using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Booming
{
    public partial class frmLanguage : DevExpress.XtraEditors.XtraForm
    {
        private string _languageType = "";
        public string LanguageType
        {
            get { return _languageType; }
            set { _languageType = value; }
        }
     
        public frmLanguage()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.comboxLanguage.SelectedIndex == 0)
            {
                _languageType = "";
            }
            else
            {
                _languageType = "en-US";
            }

            DialogResult = DialogResult.OK;
        }

        private void frmLanguage_Load(object sender, EventArgs e)
        {
            if (Booming.Common.Pub.PubSystemSetting.CurrentLanguage == "")
            {
                this.comboxLanguage.Properties.Items.Add("ÖÐÎÄ");
                this.comboxLanguage.Properties.Items.Add("Ó¢ÎÄ");
            }
            else
            {
                this.comboxLanguage.Properties.Items.Add("Chinese");
                this.comboxLanguage.Properties.Items.Add("English");
            }

            if (_languageType == "")
            {
                this.comboxLanguage.SelectedIndex = 0;
            }
            else
            {
                this.comboxLanguage.SelectedIndex = 1;
            }            
        }
    }
}