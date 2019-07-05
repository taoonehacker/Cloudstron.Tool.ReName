using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloudstron.Tool.ReName
{
    public partial class AddRuleForm : Form
    {
        public string _txtRuleName;
        public string TxtRuleName => this._txtRuleName;

        public string _txtRule;
        public string TxtRule => this._txtRule;

        public AddRuleForm()
        {
            InitializeComponent();
        }

        private void BtnAddRule_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRuleName.Text))
            {
                lblWarning.Text = "请输入正确的规则名称";
                return;
            }

            if (string.IsNullOrEmpty(txtRule.Text))
            {
                lblWarning.Text = "请输入正确的规则";
                return;
            }

            _txtRuleName = txtRuleName.Text;
            _txtRule = txtRule.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
