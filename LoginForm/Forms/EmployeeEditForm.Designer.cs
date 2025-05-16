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
			((System.ComponentModel.ISupportInitialize)teEmployeeID.Properties).BeginInit();
			SuspendLayout();
			// 
			// teEmployeeID
			// 
			teEmployeeID.Location = new System.Drawing.Point(23, 22);
			teEmployeeID.Name = "teEmployeeID";
			teEmployeeID.Size = new System.Drawing.Size(100, 28);
			teEmployeeID.TabIndex = 0;
			// 
			// EmployeeEditForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(298, 266);
			Controls.Add(teEmployeeID);
			Name = "EmployeeEditForm";
			Text = "EmployeeEditForm";
			((System.ComponentModel.ISupportInitialize)teEmployeeID.Properties).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraEditors.TextEdit teEmployeeID;
	}
}