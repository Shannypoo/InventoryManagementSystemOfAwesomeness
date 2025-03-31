namespace LoginForm.Forms
{
    partial class SignUp
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
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            emailTxt = new DevExpress.XtraEditors.TextEdit();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            checkBox1 = new System.Windows.Forms.CheckBox();
            signinBtn = new DevExpress.XtraEditors.SimpleButton();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            sunburstControl1 = new DevExpress.XtraTreeMap.SunburstControl();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emailTxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sunburstControl1).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(sunburstControl1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(170, 555);
            panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Location = new System.Drawing.Point(216, 12);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(219, 44);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "Create an Account";
            // 
            // emailTxt
            // 
            emailTxt.Location = new System.Drawing.Point(229, 94);
            emailTxt.Name = "emailTxt";
            emailTxt.Properties.AutoHeight = false;
            emailTxt.Size = new System.Drawing.Size(250, 44);
            emailTxt.TabIndex = 12;
            // 
            // textEdit1
            // 
            textEdit1.Location = new System.Drawing.Point(229, 159);
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.AutoHeight = false;
            textEdit1.Size = new System.Drawing.Size(250, 44);
            textEdit1.TabIndex = 14;
            // 
            // textEdit2
            // 
            textEdit2.Location = new System.Drawing.Point(229, 233);
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.AutoHeight = false;
            textEdit2.Size = new System.Drawing.Size(250, 44);
            textEdit2.TabIndex = 16;
            // 
            // textEdit3
            // 
            textEdit3.Location = new System.Drawing.Point(229, 302);
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.AutoHeight = false;
            textEdit3.Size = new System.Drawing.Size(250, 44);
            textEdit3.TabIndex = 18;
            // 
            // checkBox1
            // 
            checkBox1.Font = new System.Drawing.Font("Tahoma", 6.25F);
            checkBox1.Location = new System.Drawing.Point(205, 360);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(242, 20);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "I Agree All Statements  In Terms of Service";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // signinBtn
            // 
            signinBtn.Appearance.BackColor = System.Drawing.Color.Teal;
            signinBtn.Appearance.BorderColor = System.Drawing.Color.Black;
            signinBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            signinBtn.Appearance.Options.UseBackColor = true;
            signinBtn.Appearance.Options.UseBorderColor = true;
            signinBtn.Appearance.Options.UseFont = true;
            signinBtn.Location = new System.Drawing.Point(247, 401);
            signinBtn.Name = "signinBtn";
            signinBtn.Size = new System.Drawing.Size(210, 50);
            signinBtn.TabIndex = 19;
            signinBtn.Text = "Create an account";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.Location = new System.Drawing.Point(264, 466);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(128, 18);
            labelControl2.TabIndex = 20;
            labelControl2.Text = "Im already a Member!";
            // 
            // hyperlinkLabelControl1
            // 
            hyperlinkLabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            hyperlinkLabelControl1.Appearance.Options.UseFont = true;
            hyperlinkLabelControl1.Location = new System.Drawing.Point(397, 467);
            hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            hyperlinkLabelControl1.Size = new System.Drawing.Size(38, 14);
            hyperlinkLabelControl1.TabIndex = 21;
            hyperlinkLabelControl1.Text = "Sign In";
            // 
            // sunburstControl1
            // 
            sunburstControl1.Label.AutoLayout = false;
            sunburstControl1.Label.Visible = true;
            sunburstControl1.Location = new System.Drawing.Point(111, 334);
            sunburstControl1.Name = "sunburstControl1";
            sunburstControl1.Padding = new System.Windows.Forms.Padding(2);
            sunburstControl1.Size = new System.Drawing.Size(8, 8);
            sunburstControl1.TabIndex = 0;
            // 
            // SignUp
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(538, 555);
            Controls.Add(hyperlinkLabelControl1);
            Controls.Add(labelControl2);
            Controls.Add(signinBtn);
            Controls.Add(checkBox1);
            Controls.Add(textEdit3);
            Controls.Add(textEdit2);
            Controls.Add(textEdit1);
            Controls.Add(emailTxt);
            Controls.Add(labelControl1);
            Controls.Add(panelControl1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            Name = "SignUp";
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)emailTxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)sunburstControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit emailTxt;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraEditors.SimpleButton signinBtn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraTreeMap.SunburstControl sunburstControl1;
    }
}