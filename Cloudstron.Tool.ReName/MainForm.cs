using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Win32;

namespace Cloudstron.Tool.ReName
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            InitializeData();

            BtnLoadConfig_Click(null, null);

        }

        private void InitializeData()
        {
            txtConfig.Text = Path.GetFullPath("../..") + "\\appsetting.xml";
            txtReplace.Text = GetAddressIP();
        }

        //加载配置文件
        private void BtnLoadConfig_Click(object sender, EventArgs e)
        {
            //加载配置
            var elements = from ele in XElement.Load(txtConfig.Text).Elements()
                                     select ele;

            clbRoot.Items.Clear();
            clbRule.Items.Clear();

            foreach (var element in elements)
            {
                if (element.Name == "service")
                {
                    txtServiceName.Text = element.Value;
                    var serviceNameList = element.Value.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    var services = ServiceController.GetServices().Where(a => serviceNameList.Any(s => s == a.ServiceName)).ToList();
                    foreach (var service in services)
                    {
                        var path = GetWindowsServiceInstallPath(service.ServiceName);
                        clbRoot.Items.Add(service.ServiceName + " " + path, true);
                    }
                }
                if (element.Name == "extension")
                {
                    txtExtension.Text = element.Value;
                }

                if (element.Name != "rules") continue;
                foreach (var item in element.Elements())
                {
                    clbRule.Items.Add(item.FirstAttribute.Value+" "+item.Value, true);
                }
            }

        }


        private string GetWindowsServiceInstallPath(string serviceName)
        {
            var key = @"SYSTEM\CurrentControlSet\Services\" + serviceName;
            var path = Registry.LocalMachine.OpenSubKey(key)?.GetValue("ImagePath").ToString();
            path = path.Replace("\"", string.Empty);
            var fi = new FileInfo(path);
            return fi.Directory.ToString();
        }

        //更新后缀
        private void BtnExtension_Click(object sender, EventArgs e)
        {
            XElement lexeme = XElement.Load(txtConfig.Text);

            var elements = from ele in lexeme.Elements()
                select ele;
            var extension = elements.FirstOrDefault(a => a.Name == "extension");
            extension?.SetValue(txtExtension.Text);
            lexeme.Save(txtConfig.Text);

            btnLoadConfig.PerformClick();
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
           var form = new AddRootForm();
           form.ShowDialog();
           if (form.DialogResult == DialogResult.OK)
           {
               clbRoot.Items.Add(form.TxtRoot, true);
           }
        }

        private void BtnRoot_Click(object sender, EventArgs e)
        {
            var form = new AddRuleForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                clbRule.Items.Add(form.TxtRuleName+" "+form.TxtRule, true);
            }
        }

        private void BtnServiceName_Click(object sender, EventArgs e)
        {
            XElement lexeme = XElement.Load(txtConfig.Text);

            var elements = from ele in lexeme.Elements()
                select ele;
            var extension = elements.FirstOrDefault(a => a.Name == "service");
            extension?.SetValue(txtServiceName.Text);
            lexeme.Save(txtConfig.Text);

            btnLoadConfig.PerformClick();
        }

        private string GetAddressIP()
        {
            var addressIp = string.Empty;
            foreach (var ipAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (ipAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    addressIp = ipAddress.ToString();
                }
            }
            return addressIp;
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            var newContext = txtReplace.Text;
            var extensionList = txtExtension.Text.Split(",".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            Stopwatch sp = new Stopwatch();
            sp.Start();
            for (var i = 0; i < clbRoot.Items.Count; i++)
            {
                if(clbRoot.GetItemChecked(i))
                {
                    var rootText = clbRoot.GetItemText(clbRoot.Items[i]);
                    var root = rootText.Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)[1];
                    RenameFileContent(root, newContext, extensionList);
                }
            }
            sp.Stop();
            lblResult.Text = "Config content rename complete! spend:"+sp.ElapsedMilliseconds;
        }


        private void BtnExportConfig_Click(object sender, EventArgs e)
        {
            var path = Path.GetFullPath("../..") + "\\backsetting.xml";

            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(dec);
            //根节点 
            XmlElement root = doc.CreateElement("configuration");
            doc.AppendChild(root);

            //根节点的添加独立子节点 
            XmlElement service = doc.CreateElement("service");
            service.InnerText=txtServiceName.Text;
            root.AppendChild(service);

            //根节点的添加独立子节点 
            var extension = doc.CreateElement("extension");
            extension.InnerText=txtExtension.Text;
            root.AppendChild(extension);

            var rules = doc.CreateElement("rules");

            for (var i = 0; i < clbRule.Items.Count; i++)
            {
                if (clbRule.GetItemChecked(i))
                {
                    var rule = clbRule.GetItemText(clbRule.Items[i]);
                    var ruleList = rule.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    XmlElement xmlElement = doc.CreateElement("rule");
                    xmlElement.InnerText = ruleList[1];
                    xmlElement.SetAttribute("name", ruleList[0]);
                    rules.AppendChild(xmlElement);
                }
            }
            root.AppendChild(rules);

            doc.Save(path);
            lblResult.Text = "导出成功";
        }

        private void BtnProcessAndReStart_Click(object sender, EventArgs e)
        {
            var newContext = txtReplace.Text;
            var extensionList = txtExtension.Text.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Stopwatch sp = new Stopwatch();
            sp.Start();
            for (var i = 0; i < clbRoot.Items.Count; i++)
            {
                if (clbRoot.GetItemChecked(i))
                {
                    var rootText = clbRoot.GetItemText(clbRoot.Items[i]);
                    var root = rootText.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[1];
                    RenameFileContent(root, newContext, extensionList);
                }
            }
            sp.Stop();
            lblResult.Text = "Config content rename complete! spend:" + sp.ElapsedMilliseconds;

            var serviceNameList = txtServiceName.Text.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var services = ServiceController.GetServices().Where(a => serviceNameList.Any(s => s == a.ServiceName)).ToList();
            foreach (var service in services)
            {
                try
                {
                    lblResult.Text = service.ServiceName + service.Status;
                    if (service.Status == ServiceControllerStatus.Running)
                    {
                        service.Stop();
                        service.WaitForStatus(ServiceControllerStatus.Stopped);
                        service.Refresh();
                        lblResult.Text = service.ServiceName + service.Status;
                        Thread.Sleep(5000);
                    }
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running);
                    service.Refresh();
                    lblResult.Text = service.ServiceName + service.Status;
                }
                catch (Exception exception)
                {
                    lblResult.Text = exception.Message;
                }
            }
        }

        private void BtnRecover_Click(object sender, EventArgs e)
        {
            var extensionList = txtExtension.Text.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Stopwatch sp = new Stopwatch();
            sp.Start();
            for (var i = 0; i < clbRoot.Items.Count; i++)
            {
                if (clbRoot.GetItemChecked(i))
                {
                    var rootText = clbRoot.GetItemText(clbRoot.Items[i]);
                    var root = rootText.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[1];
                    RecoverFileContent(root, extensionList);
                }
            }
            sp.Stop();
            lblResult.Text = "Config content recover complete! spend:" + sp.ElapsedMilliseconds;
        }

        private void RenameFileContent(string root, string newContext, string[] extensionList)
        {
            var files = new DirectoryInfo(root).GetFiles().Where(m => extensionList.Any(f => f == m.Extension)&&!m.Name.Contains("bak")).ToList();
            foreach (var file in files)
            {
                var text = File.ReadAllText(file.FullName, Encoding.UTF8);
                try
                {
                    File.Copy(file.FullName, root + "\\" + Path.GetFileNameWithoutExtension(file.FullName) + "bak." + file.Extension);
                }
                catch (Exception ex)
                {
                    lblResult.Text = "Back up file error:" + ex.Message;
                }
                //rules
                for (var i = 0; i < clbRule.Items.Count; i++)
                {
                    if (clbRule.GetItemChecked(i))
                    {
                        var rule = clbRule.GetItemText(clbRule.Items[i]);
                        var regex = rule.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[1];

                        //var reg = new Regex(regex);

                        //var match = reg.Match(text);

                        text = Regex.Replace(text, regex, newContext);
                    }
                }
                File.WriteAllText(file.FullName, text, Encoding.UTF8);
                //转换完成
            }
            //获取子目录
            var childRootList = Directory.GetDirectories(root);
            foreach (var childRoot in childRootList)
            {
                RenameFileContent(childRoot, newContext, extensionList);
            }
        }
        private void RecoverFileContent(string root, string[] extensionList)
        {
            var files = new DirectoryInfo(root).GetFiles().Where(m => extensionList.Any(f => f == m.Extension)&&!m.Name.Contains("bak")).ToList();
            foreach (var file in files)
            {
                try
                {
                    var text = File.ReadAllText(root +"\\"+ Path.GetFileNameWithoutExtension(file.FullName) + "bak." + file.Extension, Encoding.UTF8);
                    File.WriteAllText(file.FullName, text, Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    lblResult.Text = "Recover file error:" + ex.Message;
                }
            }
            var childRootList = Directory.GetDirectories(root);
            foreach (var childRoot in childRootList)
            {
                RecoverFileContent(childRoot, extensionList);
            }
        }
    }
}
