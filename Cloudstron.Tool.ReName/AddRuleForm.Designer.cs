namespace Cloudstron.Tool.ReName
{
    partial class AddRuleForm
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
            this.txtRuleName = new System.Windows.Forms.TextBox();
            this.txtRule = new System.Windows.Forms.TextBox();
            this.lblRuleName = new System.Windows.Forms.Label();
            this.lblRule = new System.Windows.Forms.Label();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRuleName
            // 
            this.txtRuleName.Location = new System.Drawing.Point(238, 78);
            this.txtRuleName.Name = "txtRuleName";
            this.txtRuleName.Size = new System.Drawing.Size(265, 25);
            this.txtRuleName.TabIndex = 0;
            // 
            // txtRule
            // 
            this.txtRule.Location = new System.Drawing.Point(238, 122);
            this.txtRule.Name = "txtRule";
            this.txtRule.Size = new System.Drawing.Size(265, 25);
            this.txtRule.TabIndex = 1;
            // 
            // lblRuleName
            // 
            this.lblRuleName.AutoSize = true;
            this.lblRuleName.Location = new System.Drawing.Point(153, 78);
            this.lblRuleName.Name = "lblRuleName";
            this.lblRuleName.Size = new System.Drawing.Size(75, 15);
            this.lblRuleName.TabIndex = 2;
            this.lblRuleName.Text = "规则名称:";
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.Location = new System.Drawing.Point(153, 122);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(45, 15);
            this.lblRule.TabIndex = 2;
            this.lblRule.Text = "规则:";
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(238, 219);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(185, 50);
            this.btnAddRule.TabIndex = 3;
            this.btnAddRule.Text = "添加";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.BtnAddRule_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(238, 174);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 15);
            this.lblWarning.TabIndex = 4;
            // 
            // AddRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnAddRule);
            this.Controls.Add(this.lblRule);
            this.Controls.Add(this.lblRuleName);
            this.Controls.Add(this.txtRule);
            this.Controls.Add(this.txtRuleName);
            this.Name = "AddRuleForm";
            this.Text = "AddRuleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRuleName;
        private System.Windows.Forms.TextBox txtRule;
        private System.Windows.Forms.Label lblRuleName;
        private System.Windows.Forms.Label lblRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Label lblWarning;
    }
}