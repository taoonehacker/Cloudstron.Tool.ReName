namespace Cloudstron.Tool.ReName
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConfig = new System.Windows.Forms.Label();
            this.txtConfig = new System.Windows.Forms.TextBox();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.clbRoot = new System.Windows.Forms.CheckedListBox();
            this.lblRoot = new System.Windows.Forms.Label();
            this.btnAddRoot = new System.Windows.Forms.Button();
            this.lblExtension = new System.Windows.Forms.Label();
            this.btnExtension = new System.Windows.Forms.Button();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.btnExportConfig = new System.Windows.Forms.Button();
            this.clbRule = new System.Windows.Forms.CheckedListBox();
            this.lblRule = new System.Windows.Forms.Label();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnRecover = new System.Windows.Forms.Button();
            this.lblService = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.btnServiceName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnProcessAndReStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Location = new System.Drawing.Point(103, 48);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(105, 15);
            this.lblConfig.TabIndex = 0;
            this.lblConfig.Text = "配置文件位置:";
            // 
            // txtConfig
            // 
            this.txtConfig.Location = new System.Drawing.Point(213, 48);
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.Size = new System.Drawing.Size(370, 25);
            this.txtConfig.TabIndex = 1;
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Location = new System.Drawing.Point(594, 48);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(100, 25);
            this.btnLoadConfig.TabIndex = 2;
            this.btnLoadConfig.Text = "加载配置";
            this.btnLoadConfig.UseVisualStyleBackColor = true;
            this.btnLoadConfig.Click += new System.EventHandler(this.BtnLoadConfig_Click);
            // 
            // clbRoot
            // 
            this.clbRoot.FormattingEnabled = true;
            this.clbRoot.Location = new System.Drawing.Point(213, 191);
            this.clbRoot.Name = "clbRoot";
            this.clbRoot.Size = new System.Drawing.Size(370, 84);
            this.clbRoot.TabIndex = 3;
            // 
            // lblRoot
            // 
            this.lblRoot.AutoSize = true;
            this.lblRoot.Location = new System.Drawing.Point(103, 191);
            this.lblRoot.Name = "lblRoot";
            this.lblRoot.Size = new System.Drawing.Size(60, 15);
            this.lblRoot.TabIndex = 4;
            this.lblRoot.Text = "根目录:";
            // 
            // btnAddRoot
            // 
            this.btnAddRoot.Location = new System.Drawing.Point(594, 191);
            this.btnAddRoot.Name = "btnAddRoot";
            this.btnAddRoot.Size = new System.Drawing.Size(100, 25);
            this.btnAddRoot.TabIndex = 5;
            this.btnAddRoot.Text = "添加目录";
            this.btnAddRoot.UseVisualStyleBackColor = true;
            this.btnAddRoot.Click += new System.EventHandler(this.BtnAddRoot_Click);
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(103, 127);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(45, 15);
            this.lblExtension.TabIndex = 7;
            this.lblExtension.Text = "后缀:";
            // 
            // btnExtension
            // 
            this.btnExtension.Location = new System.Drawing.Point(594, 130);
            this.btnExtension.Name = "btnExtension";
            this.btnExtension.Size = new System.Drawing.Size(100, 25);
            this.btnExtension.TabIndex = 8;
            this.btnExtension.Text = "更新后缀";
            this.btnExtension.UseVisualStyleBackColor = true;
            this.btnExtension.Click += new System.EventHandler(this.BtnExtension_Click);
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(213, 127);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(370, 25);
            this.txtExtension.TabIndex = 9;
            // 
            // btnExportConfig
            // 
            this.btnExportConfig.Location = new System.Drawing.Point(708, 48);
            this.btnExportConfig.Name = "btnExportConfig";
            this.btnExportConfig.Size = new System.Drawing.Size(100, 25);
            this.btnExportConfig.TabIndex = 10;
            this.btnExportConfig.Text = "导出配置";
            this.btnExportConfig.UseVisualStyleBackColor = true;
            this.btnExportConfig.Click += new System.EventHandler(this.BtnExportConfig_Click);
            // 
            // clbRule
            // 
            this.clbRule.FormattingEnabled = true;
            this.clbRule.Location = new System.Drawing.Point(213, 296);
            this.clbRule.Name = "clbRule";
            this.clbRule.Size = new System.Drawing.Size(370, 84);
            this.clbRule.TabIndex = 11;
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.Location = new System.Drawing.Point(103, 296);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(45, 15);
            this.lblRule.TabIndex = 12;
            this.lblRule.Text = "规则:";
            // 
            // btnRoot
            // 
            this.btnRoot.Location = new System.Drawing.Point(594, 296);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(100, 25);
            this.btnRoot.TabIndex = 13;
            this.btnRoot.Text = "添加规则";
            this.btnRoot.UseVisualStyleBackColor = true;
            this.btnRoot.Click += new System.EventHandler(this.BtnRoot_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(106, 495);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(185, 50);
            this.btnProcess.TabIndex = 14;
            this.btnProcess.Text = "执行";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // btnRecover
            // 
            this.btnRecover.Location = new System.Drawing.Point(499, 495);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(185, 50);
            this.btnRecover.TabIndex = 15;
            this.btnRecover.Text = "恢复";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.BtnRecover_Click);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(103, 87);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(75, 15);
            this.lblService.TabIndex = 16;
            this.lblService.Text = "服务名称:";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(213, 87);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(370, 25);
            this.txtServiceName.TabIndex = 17;
            // 
            // btnServiceName
            // 
            this.btnServiceName.Location = new System.Drawing.Point(594, 87);
            this.btnServiceName.Name = "btnServiceName";
            this.btnServiceName.Size = new System.Drawing.Size(100, 25);
            this.btnServiceName.TabIndex = 18;
            this.btnServiceName.Text = "更新服务";
            this.btnServiceName.UseVisualStyleBackColor = true;
            this.btnServiceName.Click += new System.EventHandler(this.BtnServiceName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "替换文本:";
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(213, 415);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(370, 25);
            this.txtReplace.TabIndex = 20;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(229, 459);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 21;
            // 
            // btnProcessAndReStart
            // 
            this.btnProcessAndReStart.Location = new System.Drawing.Point(297, 495);
            this.btnProcessAndReStart.Name = "btnProcessAndReStart";
            this.btnProcessAndReStart.Size = new System.Drawing.Size(185, 50);
            this.btnProcessAndReStart.TabIndex = 22;
            this.btnProcessAndReStart.Text = "执行并重启";
            this.btnProcessAndReStart.UseVisualStyleBackColor = true;
            this.btnProcessAndReStart.Click += new System.EventHandler(this.BtnProcessAndReStart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 564);
            this.Controls.Add(this.btnProcessAndReStart);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnServiceName);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.lblRule);
            this.Controls.Add(this.clbRule);
            this.Controls.Add(this.btnExportConfig);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.btnExtension);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.btnAddRoot);
            this.Controls.Add(this.lblRoot);
            this.Controls.Add(this.clbRoot);
            this.Controls.Add(this.btnLoadConfig);
            this.Controls.Add(this.txtConfig);
            this.Controls.Add(this.lblConfig);
            this.Name = "MainForm";
            this.Text = "ReName Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.TextBox txtConfig;
        private System.Windows.Forms.Button btnLoadConfig;
        private System.Windows.Forms.CheckedListBox clbRoot;
        private System.Windows.Forms.Label lblRoot;
        private System.Windows.Forms.Button btnAddRoot;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Button btnExtension;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Button btnExportConfig;
        private System.Windows.Forms.CheckedListBox clbRule;
        private System.Windows.Forms.Label lblRule;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Button btnServiceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnProcessAndReStart;
    }
}

