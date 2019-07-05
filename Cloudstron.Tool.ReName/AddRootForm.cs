using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cloudstron.Tool.ReName
{
    public partial class AddRootForm : Form
    {
        public string _txtRoot;
        public string TxtRoot => this._txtRoot;

        public AddRootForm()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.txtBrowser.Text = path.SelectedPath;
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrowser.Text))
            {
                lblWarning.Text = "请选择正确的根目录";
                return;;
            }
            _txtRoot = txtBrowser.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
