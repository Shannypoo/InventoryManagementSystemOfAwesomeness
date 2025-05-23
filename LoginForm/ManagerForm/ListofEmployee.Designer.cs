namespace LoginForm.ManagerForm
{
    partial class ListofEmployee
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
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListofEmployee));
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
			gcEmployees = new DevExpress.XtraGrid.GridControl();
			gvEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
			gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			Picture = new DevExpress.XtraGrid.Columns.GridColumn();
			employeePicture = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
			gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
			Edit = new DevExpress.XtraGrid.Columns.GridColumn();
			EditButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			Delete = new DevExpress.XtraGrid.Columns.GridColumn();
			DeleteButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			ReportButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			labelControl1 = new DevExpress.XtraEditors.LabelControl();
			teSearch = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)gcEmployees).BeginInit();
			((System.ComponentModel.ISupportInitialize)gvEmployees).BeginInit();
			((System.ComponentModel.ISupportInitialize)employeePicture).BeginInit();
			((System.ComponentModel.ISupportInitialize)EditButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)DeleteButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)ReportButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)teSearch.Properties).BeginInit();
			SuspendLayout();
			// 
			// gcEmployees
			// 
			gcEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
			gcEmployees.Location = new System.Drawing.Point(0, 0);
			gcEmployees.MainView = gvEmployees;
			gcEmployees.Name = "gcEmployees";
			gcEmployees.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { EditButton, DeleteButton, ReportButton, employeePicture });
			gcEmployees.Size = new System.Drawing.Size(840, 438);
			gcEmployees.TabIndex = 0;
			gcEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvEmployees });
			// 
			// gvEmployees
			// 
			gvEmployees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, Picture, gridColumn2, gridColumn4, gridColumn5, gridColumn6, gridColumn7, gridColumn8, gridColumn9, gridColumn10, Edit, Delete });
			gvEmployees.GridControl = gcEmployees;
			gvEmployees.GroupPanelText = " ";
			gvEmployees.Name = "gvEmployees";
			gvEmployees.OptionsFind.AllowFindPanel = false;
			// 
			// gridColumn1
			// 
			gridColumn1.Caption = "Employee ID";
			gridColumn1.FieldName = "EmployeeID";
			gridColumn1.Name = "gridColumn1";
			gridColumn1.Visible = true;
			gridColumn1.VisibleIndex = 0;
			// 
			// Picture
			// 
			Picture.Caption = "Employee Picture";
			Picture.ColumnEdit = employeePicture;
			Picture.FieldName = "EmployeePicture";
			Picture.Name = "Picture";
			Picture.Visible = true;
			Picture.VisibleIndex = 1;
			// 
			// employeePicture
			// 
			employeePicture.Name = "employeePicture";
			employeePicture.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
			// 
			// gridColumn2
			// 
			gridColumn2.Caption = "Full Name";
			gridColumn2.FieldName = "FullName";
			gridColumn2.Name = "gridColumn2";
			gridColumn2.Visible = true;
			gridColumn2.VisibleIndex = 2;
			// 
			// gridColumn4
			// 
			gridColumn4.Caption = "Date of Birth";
			gridColumn4.FieldName = "DateOfBirth";
			gridColumn4.Name = "gridColumn4";
			gridColumn4.Visible = true;
			gridColumn4.VisibleIndex = 3;
			// 
			// gridColumn5
			// 
			gridColumn5.Caption = "Address";
			gridColumn5.FieldName = "Address";
			gridColumn5.Name = "gridColumn5";
			gridColumn5.Visible = true;
			gridColumn5.VisibleIndex = 4;
			// 
			// gridColumn6
			// 
			gridColumn6.Caption = "Contact Number";
			gridColumn6.FieldName = "ContactNo";
			gridColumn6.Name = "gridColumn6";
			gridColumn6.Visible = true;
			gridColumn6.VisibleIndex = 5;
			// 
			// gridColumn7
			// 
			gridColumn7.Caption = "Department";
			gridColumn7.FieldName = "DepartmentName";
			gridColumn7.Name = "gridColumn7";
			gridColumn7.Visible = true;
			gridColumn7.VisibleIndex = 6;
			// 
			// gridColumn8
			// 
			gridColumn8.Caption = "Position";
			gridColumn8.FieldName = "PositionName";
			gridColumn8.Name = "gridColumn8";
			gridColumn8.Visible = true;
			gridColumn8.VisibleIndex = 7;
			// 
			// gridColumn9
			// 
			gridColumn9.Caption = "Username";
			gridColumn9.FieldName = "AccountUsername";
			gridColumn9.Name = "gridColumn9";
			gridColumn9.Visible = true;
			gridColumn9.VisibleIndex = 8;
			// 
			// gridColumn10
			// 
			gridColumn10.Caption = "Password";
			gridColumn10.FieldName = "AccountPassword";
			gridColumn10.Name = "gridColumn10";
			gridColumn10.Visible = true;
			gridColumn10.VisibleIndex = 9;
			// 
			// Edit
			// 
			Edit.Caption = "Edit";
			Edit.ColumnEdit = EditButton;
			Edit.Name = "Edit";
			Edit.Visible = true;
			Edit.VisibleIndex = 10;
			// 
			// EditButton
			// 
			EditButton.AutoHeight = false;
			editorButtonImageOptions1.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editorButtonImageOptions1.SvgImage");
			EditButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
			EditButton.Name = "EditButton";
			EditButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			EditButton.ButtonClick += EditButton_ButtonClick;
			// 
			// Delete
			// 
			Delete.Caption = "Delete";
			Delete.ColumnEdit = DeleteButton;
			Delete.Name = "Delete";
			Delete.Visible = true;
			Delete.VisibleIndex = 11;
			// 
			// DeleteButton
			// 
			DeleteButton.AutoHeight = false;
			editorButtonImageOptions2.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editorButtonImageOptions2.SvgImage");
			DeleteButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
			DeleteButton.Name = "DeleteButton";
			DeleteButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			DeleteButton.ButtonClick += DeleteButton_ButtonClick;
			// 
			// ReportButton
			// 
			ReportButton.AutoHeight = false;
			ReportButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
			ReportButton.Name = "ReportButton";
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			labelControl1.Appearance.Options.UseFont = true;
			labelControl1.Location = new System.Drawing.Point(12, 13);
			labelControl1.Name = "labelControl1";
			labelControl1.Size = new System.Drawing.Size(149, 23);
			labelControl1.TabIndex = 1;
			labelControl1.Text = "Search Keyword: ";
			// 
			// teSearch
			// 
			teSearch.Location = new System.Drawing.Point(158, 12);
			teSearch.Name = "teSearch";
			teSearch.Size = new System.Drawing.Size(359, 28);
			teSearch.TabIndex = 2;
			teSearch.EditValueChanging += teSearch_EditValueChanging;
			// 
			// ListofEmployee
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(840, 438);
			ControlBox = false;
			Controls.Add(teSearch);
			Controls.Add(labelControl1);
			Controls.Add(gcEmployees);
			Name = "ListofEmployee";
			Text = "ListofEmployee";
			WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)gcEmployees).EndInit();
			((System.ComponentModel.ISupportInitialize)gvEmployees).EndInit();
			((System.ComponentModel.ISupportInitialize)employeePicture).EndInit();
			((System.ComponentModel.ISupportInitialize)EditButton).EndInit();
			((System.ComponentModel.ISupportInitialize)DeleteButton).EndInit();
			((System.ComponentModel.ISupportInitialize)ReportButton).EndInit();
			((System.ComponentModel.ISupportInitialize)teSearch.Properties).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gcEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployees;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teSearch;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit EditButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit DeleteButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ReportButton;
		private DevExpress.XtraGrid.Columns.GridColumn Edit;
		private DevExpress.XtraGrid.Columns.GridColumn Delete;
		private DevExpress.XtraGrid.Columns.GridColumn Picture;
		private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit employeePicture;
	}
}