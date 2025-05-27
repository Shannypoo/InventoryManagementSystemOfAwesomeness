namespace LoginForm
{
    partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			panelControl1 = new DevExpress.XtraEditors.PanelControl();
			labelControl3 = new DevExpress.XtraEditors.LabelControl();
			labelControl1 = new DevExpress.XtraEditors.LabelControl();
			emailTxt = new DevExpress.XtraEditors.TextEdit();
			passTxt = new DevExpress.XtraEditors.TextEdit();
			signinBtn = new DevExpress.XtraEditors.SimpleButton();
			labelControl4 = new DevExpress.XtraEditors.LabelControl();
			labelControl5 = new DevExpress.XtraEditors.LabelControl();
			labelControl2 = new DevExpress.XtraEditors.LabelControl();
			pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
			panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)emailTxt.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)passTxt.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
			SuspendLayout();
			// 
			// panelControl1
			// 
			panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			panelControl1.ContentImage = (System.Drawing.Image)resources.GetObject("panelControl1.ContentImage");
			panelControl1.Controls.Add(labelControl3);
			panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
			panelControl1.Location = new System.Drawing.Point(367, 0);
			panelControl1.Name = "panelControl1";
			panelControl1.Size = new System.Drawing.Size(487, 499);
			panelControl1.TabIndex = 0;
			// 
			// labelControl3
			// 
			labelControl3.Appearance.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			labelControl3.Appearance.Options.UseFont = true;
			labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			labelControl3.Location = new System.Drawing.Point(183, 102);
			labelControl3.Name = "labelControl3";
			labelControl3.Size = new System.Drawing.Size(176, 44);
			labelControl3.TabIndex = 14;
			labelControl3.Text = "ResourceX";
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold);
			labelControl1.Appearance.Options.UseFont = true;
			labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			labelControl1.Location = new System.Drawing.Point(52, 141);
			labelControl1.Name = "labelControl1";
			labelControl1.Size = new System.Drawing.Size(162, 44);
			labelControl1.TabIndex = 1;
			labelControl1.Text = "Hello DMCIAN";
			// 
			// emailTxt
			// 
			emailTxt.EditValue = "";
			emailTxt.Location = new System.Drawing.Point(52, 208);
			emailTxt.Name = "emailTxt";
			emailTxt.Properties.AutoHeight = false;
			emailTxt.Size = new System.Drawing.Size(289, 44);
			emailTxt.TabIndex = 4;
			// 
			// passTxt
			// 
			passTxt.Location = new System.Drawing.Point(52, 250);
			passTxt.Name = "passTxt";
			passTxt.Properties.AutoHeight = false;
			passTxt.Properties.PasswordChar = '*';
			passTxt.Properties.UseSystemPasswordChar = true;
			passTxt.Size = new System.Drawing.Size(289, 44);
			passTxt.TabIndex = 5;
			// 
			// signinBtn
			// 
			signinBtn.Appearance.BackColor = System.Drawing.Color.Teal;
			signinBtn.Appearance.BorderColor = System.Drawing.Color.Black;
			signinBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			signinBtn.Appearance.Options.UseBackColor = true;
			signinBtn.Appearance.Options.UseBorderColor = true;
			signinBtn.Appearance.Options.UseFont = true;
			signinBtn.Location = new System.Drawing.Point(126, 358);
			signinBtn.Name = "signinBtn";
			signinBtn.Size = new System.Drawing.Size(119, 37);
			signinBtn.TabIndex = 7;
			signinBtn.Text = "Sign in";
			signinBtn.Click += signinBtn_Click;
			// 
			// labelControl4
			// 
			labelControl4.Appearance.BackColor = System.Drawing.Color.White;
			labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 7F);
			labelControl4.Appearance.ForeColor = System.Drawing.Color.Gray;
			labelControl4.Appearance.Options.UseBackColor = true;
			labelControl4.Appearance.Options.UseFont = true;
			labelControl4.Appearance.Options.UseForeColor = true;
			labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			labelControl4.Location = new System.Drawing.Point(58, 213);
			labelControl4.Name = "labelControl4";
			labelControl4.Size = new System.Drawing.Size(66, 10);
			labelControl4.TabIndex = 11;
			labelControl4.Text = "Username";
			// 
			// labelControl5
			// 
			labelControl5.Appearance.BackColor = System.Drawing.Color.White;
			labelControl5.Appearance.Font = new System.Drawing.Font("Arial", 7F);
			labelControl5.Appearance.ForeColor = System.Drawing.Color.Gray;
			labelControl5.Appearance.Options.UseBackColor = true;
			labelControl5.Appearance.Options.UseFont = true;
			labelControl5.Appearance.Options.UseForeColor = true;
			labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			labelControl5.Location = new System.Drawing.Point(58, 253);
			labelControl5.Name = "labelControl5";
			labelControl5.Size = new System.Drawing.Size(66, 10);
			labelControl5.TabIndex = 12;
			labelControl5.Text = "Password";
			// 
			// labelControl2
			// 
			labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 10F);
			labelControl2.Appearance.Options.UseFont = true;
			labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			labelControl2.Location = new System.Drawing.Point(55, 177);
			labelControl2.Name = "labelControl2";
			labelControl2.Size = new System.Drawing.Size(261, 18);
			labelControl2.TabIndex = 2;
			labelControl2.Text = "Please Login to your account !";
			// 
			// pictureEdit1
			// 
			pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
			pictureEdit1.Location = new System.Drawing.Point(52, 12);
			pictureEdit1.Name = "pictureEdit1";
			pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gray;
			pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
			pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			pictureEdit1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			pictureEdit1.Size = new System.Drawing.Size(100, 95);
			pictureEdit1.TabIndex = 17;
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(854, 499);
			Controls.Add(pictureEdit1);
			Controls.Add(labelControl5);
			Controls.Add(labelControl4);
			Controls.Add(signinBtn);
			Controls.Add(passTxt);
			Controls.Add(emailTxt);
			Controls.Add(labelControl2);
			Controls.Add(labelControl1);
			Controls.Add(panelControl1);
			MaximizeBox = false;
			Name = "LoginForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = " ";
			((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
			panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)emailTxt.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)passTxt.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit emailTxt;
        private DevExpress.XtraEditors.TextEdit passTxt;
        private DevExpress.XtraEditors.SimpleButton signinBtn;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}

