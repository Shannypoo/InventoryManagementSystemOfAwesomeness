namespace EmployeeManagementSystem.Forms
{
	partial class EmployeeEditForm
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
			teEmployeeID = new DevExpress.XtraEditors.TextEdit();
			btnEdit = new DevExpress.XtraEditors.SimpleButton();
			teFirstName = new DevExpress.XtraEditors.TextEdit();
			teMiddleName = new DevExpress.XtraEditors.TextEdit();
			groupControl1 = new DevExpress.XtraEditors.GroupControl();
			labelControl5 = new DevExpress.XtraEditors.LabelControl();
			labelControl4 = new DevExpress.XtraEditors.LabelControl();
			teNameExtension = new DevExpress.XtraEditors.TextEdit();
			teLastName = new DevExpress.XtraEditors.TextEdit();
			labelControl3 = new DevExpress.XtraEditors.LabelControl();
			labelControl2 = new DevExpress.XtraEditors.LabelControl();
			labelControl1 = new DevExpress.XtraEditors.LabelControl();
			xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
			groupControl2 = new DevExpress.XtraEditors.GroupControl();
			deDateOfBirth = new DevExpress.XtraEditors.DateEdit();
			meAddress = new DevExpress.XtraEditors.MemoEdit();
			teContactNumber = new DevExpress.XtraEditors.TextEdit();
			labelControl8 = new DevExpress.XtraEditors.LabelControl();
			labelControl9 = new DevExpress.XtraEditors.LabelControl();
			labelControl10 = new DevExpress.XtraEditors.LabelControl();
			xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
			groupControl4 = new DevExpress.XtraEditors.GroupControl();
			lpPositions = new DevExpress.XtraEditors.LookUpEdit();
			labelControl13 = new DevExpress.XtraEditors.LabelControl();
			labelControl12 = new DevExpress.XtraEditors.LabelControl();
			lpDepartments = new DevExpress.XtraEditors.LookUpEdit();
			groupControl3 = new DevExpress.XtraEditors.GroupControl();
			labelControl6 = new DevExpress.XtraEditors.LabelControl();
			labelControl11 = new DevExpress.XtraEditors.LabelControl();
			teEmployeeID2 = new DevExpress.XtraEditors.TextEdit();
			labelControl7 = new DevExpress.XtraEditors.LabelControl();
			teUsername = new DevExpress.XtraEditors.TextEdit();
			tePassword = new DevExpress.XtraEditors.TextEdit();
			btnCancel = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)teEmployeeID.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)teFirstName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)teMiddleName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
			groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)teNameExtension.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)teLastName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)xtraTabControl1).BeginInit();
			xtraTabControl1.SuspendLayout();
			xtraTabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
			groupControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)deDateOfBirth.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)deDateOfBirth.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)meAddress.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)teContactNumber.Properties).BeginInit();
			xtraTabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)groupControl4).BeginInit();
			groupControl4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)lpPositions.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)lpDepartments.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
			groupControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)teEmployeeID2.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)teUsername.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)tePassword.Properties).BeginInit();
			SuspendLayout();
			// 
			// teEmployeeID
			// 
			teEmployeeID.Location = new System.Drawing.Point(13, 51);
			teEmployeeID.Name = "teEmployeeID";
			teEmployeeID.Size = new System.Drawing.Size(100, 28);
			teEmployeeID.TabIndex = 0;
			// 
			// btnEdit
			// 
			btnEdit.Location = new System.Drawing.Point(200, 288);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new System.Drawing.Size(75, 23);
			btnEdit.TabIndex = 1;
			btnEdit.Text = "EDIT";
			btnEdit.Click += btnEdit_Click;
			// 
			// teFirstName
			// 
			teFirstName.Location = new System.Drawing.Point(166, 51);
			teFirstName.Name = "teFirstName";
			teFirstName.Size = new System.Drawing.Size(100, 28);
			teFirstName.TabIndex = 2;
			// 
			// teMiddleName
			// 
			teMiddleName.Location = new System.Drawing.Point(272, 51);
			teMiddleName.Name = "teMiddleName";
			teMiddleName.Size = new System.Drawing.Size(100, 28);
			teMiddleName.TabIndex = 3;
			// 
			// groupControl1
			// 
			groupControl1.Controls.Add(labelControl5);
			groupControl1.Controls.Add(labelControl4);
			groupControl1.Controls.Add(teNameExtension);
			groupControl1.Controls.Add(teLastName);
			groupControl1.Controls.Add(labelControl3);
			groupControl1.Controls.Add(labelControl2);
			groupControl1.Controls.Add(labelControl1);
			groupControl1.Controls.Add(teFirstName);
			groupControl1.Controls.Add(teMiddleName);
			groupControl1.Controls.Add(teEmployeeID);
			groupControl1.Location = new System.Drawing.Point(3, 23);
			groupControl1.Name = "groupControl1";
			groupControl1.Size = new System.Drawing.Size(596, 91);
			groupControl1.TabIndex = 4;
			groupControl1.Text = "Employee Details";
			// 
			// labelControl5
			// 
			labelControl5.Location = new System.Drawing.Point(484, 31);
			labelControl5.Name = "labelControl5";
			labelControl5.Size = new System.Drawing.Size(77, 13);
			labelControl5.TabIndex = 10;
			labelControl5.Text = "Name Extension";
			// 
			// labelControl4
			// 
			labelControl4.Location = new System.Drawing.Point(378, 31);
			labelControl4.Name = "labelControl4";
			labelControl4.Size = new System.Drawing.Size(50, 13);
			labelControl4.TabIndex = 9;
			labelControl4.Text = "Last Name";
			// 
			// teNameExtension
			// 
			teNameExtension.Location = new System.Drawing.Point(484, 51);
			teNameExtension.Name = "teNameExtension";
			teNameExtension.Size = new System.Drawing.Size(100, 28);
			teNameExtension.TabIndex = 8;
			// 
			// teLastName
			// 
			teLastName.Location = new System.Drawing.Point(378, 51);
			teLastName.Name = "teLastName";
			teLastName.Size = new System.Drawing.Size(100, 28);
			teLastName.TabIndex = 7;
			// 
			// labelControl3
			// 
			labelControl3.Location = new System.Drawing.Point(272, 32);
			labelControl3.Name = "labelControl3";
			labelControl3.Size = new System.Drawing.Size(60, 13);
			labelControl3.TabIndex = 6;
			labelControl3.Text = "Middle Name";
			// 
			// labelControl2
			// 
			labelControl2.Location = new System.Drawing.Point(166, 31);
			labelControl2.Name = "labelControl2";
			labelControl2.Size = new System.Drawing.Size(51, 13);
			labelControl2.TabIndex = 5;
			labelControl2.Text = "First Name";
			// 
			// labelControl1
			// 
			labelControl1.Location = new System.Drawing.Point(17, 31);
			labelControl1.Name = "labelControl1";
			labelControl1.Size = new System.Drawing.Size(60, 13);
			labelControl1.TabIndex = 4;
			labelControl1.Text = "Employee ID";
			// 
			// xtraTabControl1
			// 
			xtraTabControl1.Location = new System.Drawing.Point(-1, 1);
			xtraTabControl1.Name = "xtraTabControl1";
			xtraTabControl1.SelectedTabPage = xtraTabPage1;
			xtraTabControl1.Size = new System.Drawing.Size(600, 281);
			xtraTabControl1.TabIndex = 5;
			xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2 });
			// 
			// xtraTabPage1
			// 
			xtraTabPage1.Controls.Add(groupControl2);
			xtraTabPage1.Controls.Add(groupControl1);
			xtraTabPage1.Name = "xtraTabPage1";
			xtraTabPage1.Size = new System.Drawing.Size(598, 250);
			xtraTabPage1.Text = "Employee Details";
			// 
			// groupControl2
			// 
			groupControl2.Controls.Add(deDateOfBirth);
			groupControl2.Controls.Add(meAddress);
			groupControl2.Controls.Add(teContactNumber);
			groupControl2.Controls.Add(labelControl8);
			groupControl2.Controls.Add(labelControl9);
			groupControl2.Controls.Add(labelControl10);
			groupControl2.Location = new System.Drawing.Point(3, 129);
			groupControl2.Name = "groupControl2";
			groupControl2.Size = new System.Drawing.Size(595, 118);
			groupControl2.TabIndex = 11;
			groupControl2.Text = "Personal Details";
			// 
			// deDateOfBirth
			// 
			deDateOfBirth.EditValue = null;
			deDateOfBirth.Location = new System.Drawing.Point(9, 51);
			deDateOfBirth.Name = "deDateOfBirth";
			deDateOfBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			deDateOfBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			deDateOfBirth.Size = new System.Drawing.Size(100, 28);
			deDateOfBirth.TabIndex = 10;
			// 
			// meAddress
			// 
			meAddress.Location = new System.Drawing.Point(225, 49);
			meAddress.Name = "meAddress";
			meAddress.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
			meAddress.Size = new System.Drawing.Size(365, 64);
			meAddress.TabIndex = 9;
			// 
			// teContactNumber
			// 
			teContactNumber.Location = new System.Drawing.Point(119, 51);
			teContactNumber.Name = "teContactNumber";
			teContactNumber.Size = new System.Drawing.Size(100, 28);
			teContactNumber.TabIndex = 8;
			// 
			// labelControl8
			// 
			labelControl8.Location = new System.Drawing.Point(119, 32);
			labelControl8.Name = "labelControl8";
			labelControl8.Size = new System.Drawing.Size(78, 13);
			labelControl8.TabIndex = 6;
			labelControl8.Text = "Contact Number";
			// 
			// labelControl9
			// 
			labelControl9.Location = new System.Drawing.Point(227, 32);
			labelControl9.Name = "labelControl9";
			labelControl9.Size = new System.Drawing.Size(39, 13);
			labelControl9.TabIndex = 5;
			labelControl9.Text = "Address";
			// 
			// labelControl10
			// 
			labelControl10.Location = new System.Drawing.Point(17, 31);
			labelControl10.Name = "labelControl10";
			labelControl10.Size = new System.Drawing.Size(61, 13);
			labelControl10.TabIndex = 4;
			labelControl10.Text = "Date of Birth";
			// 
			// xtraTabPage2
			// 
			xtraTabPage2.Controls.Add(groupControl4);
			xtraTabPage2.Controls.Add(groupControl3);
			xtraTabPage2.Name = "xtraTabPage2";
			xtraTabPage2.Size = new System.Drawing.Size(598, 250);
			xtraTabPage2.Text = "Additional Details";
			// 
			// groupControl4
			// 
			groupControl4.Controls.Add(lpPositions);
			groupControl4.Controls.Add(labelControl13);
			groupControl4.Controls.Add(labelControl12);
			groupControl4.Controls.Add(lpDepartments);
			groupControl4.Location = new System.Drawing.Point(387, 12);
			groupControl4.Name = "groupControl4";
			groupControl4.Size = new System.Drawing.Size(200, 235);
			groupControl4.TabIndex = 7;
			groupControl4.Text = "Employee Department and Position";
			// 
			// lpPositions
			// 
			lpPositions.Location = new System.Drawing.Point(5, 132);
			lpPositions.Name = "lpPositions";
			lpPositions.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			lpPositions.Size = new System.Drawing.Size(190, 28);
			lpPositions.TabIndex = 6;
			// 
			// labelControl13
			// 
			labelControl13.Location = new System.Drawing.Point(5, 113);
			labelControl13.Name = "labelControl13";
			labelControl13.Size = new System.Drawing.Size(37, 13);
			labelControl13.TabIndex = 5;
			labelControl13.Text = "Position";
			// 
			// labelControl12
			// 
			labelControl12.Location = new System.Drawing.Point(5, 39);
			labelControl12.Name = "labelControl12";
			labelControl12.Size = new System.Drawing.Size(57, 13);
			labelControl12.TabIndex = 4;
			labelControl12.Text = "Department";
			// 
			// lpDepartments
			// 
			lpDepartments.Location = new System.Drawing.Point(5, 58);
			lpDepartments.Name = "lpDepartments";
			lpDepartments.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			lpDepartments.Size = new System.Drawing.Size(190, 28);
			lpDepartments.TabIndex = 0;
			// 
			// groupControl3
			// 
			groupControl3.Controls.Add(labelControl6);
			groupControl3.Controls.Add(labelControl11);
			groupControl3.Controls.Add(teEmployeeID2);
			groupControl3.Controls.Add(labelControl7);
			groupControl3.Controls.Add(teUsername);
			groupControl3.Controls.Add(tePassword);
			groupControl3.Location = new System.Drawing.Point(12, 12);
			groupControl3.Name = "groupControl3";
			groupControl3.Size = new System.Drawing.Size(200, 235);
			groupControl3.TabIndex = 6;
			groupControl3.Text = "Employee Account";
			// 
			// labelControl6
			// 
			labelControl6.Location = new System.Drawing.Point(8, 38);
			labelControl6.Name = "labelControl6";
			labelControl6.Size = new System.Drawing.Size(60, 13);
			labelControl6.TabIndex = 3;
			labelControl6.Text = "Employee ID";
			// 
			// labelControl11
			// 
			labelControl11.Location = new System.Drawing.Point(8, 147);
			labelControl11.Name = "labelControl11";
			labelControl11.Size = new System.Drawing.Size(88, 13);
			labelControl11.TabIndex = 5;
			labelControl11.Text = "Account Password";
			// 
			// teEmployeeID2
			// 
			teEmployeeID2.Location = new System.Drawing.Point(5, 58);
			teEmployeeID2.Name = "teEmployeeID2";
			teEmployeeID2.Size = new System.Drawing.Size(190, 28);
			teEmployeeID2.TabIndex = 0;
			// 
			// labelControl7
			// 
			labelControl7.Location = new System.Drawing.Point(8, 94);
			labelControl7.Name = "labelControl7";
			labelControl7.Size = new System.Drawing.Size(90, 13);
			labelControl7.TabIndex = 4;
			labelControl7.Text = "Account Username";
			// 
			// teUsername
			// 
			teUsername.Location = new System.Drawing.Point(5, 113);
			teUsername.Name = "teUsername";
			teUsername.Size = new System.Drawing.Size(190, 28);
			teUsername.TabIndex = 1;
			// 
			// tePassword
			// 
			tePassword.Location = new System.Drawing.Point(5, 163);
			tePassword.Name = "tePassword";
			tePassword.Size = new System.Drawing.Size(190, 28);
			tePassword.TabIndex = 2;
			// 
			// btnCancel
			// 
			btnCancel.Location = new System.Drawing.Point(303, 288);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new System.Drawing.Size(75, 23);
			btnCancel.TabIndex = 6;
			btnCancel.Text = "CANCEL";
			// 
			// EmployeeEditForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(599, 337);
			Controls.Add(btnCancel);
			Controls.Add(xtraTabControl1);
			Controls.Add(btnEdit);
			Name = "EmployeeEditForm";
			Text = "EmployeeEditForm";
			((System.ComponentModel.ISupportInitialize)teEmployeeID.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)teFirstName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)teMiddleName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
			groupControl1.ResumeLayout(false);
			groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)teNameExtension.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)teLastName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)xtraTabControl1).EndInit();
			xtraTabControl1.ResumeLayout(false);
			xtraTabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
			groupControl2.ResumeLayout(false);
			groupControl2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)deDateOfBirth.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)deDateOfBirth.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)meAddress.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)teContactNumber.Properties).EndInit();
			xtraTabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)groupControl4).EndInit();
			groupControl4.ResumeLayout(false);
			groupControl4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)lpPositions.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)lpDepartments.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
			groupControl3.ResumeLayout(false);
			groupControl3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)teEmployeeID2.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)teUsername.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)tePassword.Properties).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraEditors.TextEdit teEmployeeID;
		private DevExpress.XtraEditors.SimpleButton btnEdit;
		private DevExpress.XtraEditors.TextEdit teFirstName;
		private DevExpress.XtraEditors.TextEdit teMiddleName;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.TextEdit teNameExtension;
		private DevExpress.XtraEditors.TextEdit teLastName;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
		private DevExpress.XtraEditors.GroupControl groupControl2;
		private DevExpress.XtraEditors.TextEdit teContactNumber;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
		private DevExpress.XtraEditors.SimpleButton btnCancel;
		private DevExpress.XtraEditors.MemoEdit meAddress;
		private DevExpress.XtraEditors.DateEdit deDateOfBirth;
		private DevExpress.XtraEditors.LabelControl labelControl11;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.TextEdit tePassword;
		private DevExpress.XtraEditors.TextEdit teUsername;
		private DevExpress.XtraEditors.TextEdit teEmployeeID2;
		private DevExpress.XtraEditors.GroupControl groupControl3;
		private DevExpress.XtraEditors.GroupControl groupControl4;
		private DevExpress.XtraEditors.LookUpEdit lpPositions;
		private DevExpress.XtraEditors.LabelControl labelControl13;
		private DevExpress.XtraEditors.LabelControl labelControl12;
		private DevExpress.XtraEditors.LookUpEdit lpDepartments;
	}
}