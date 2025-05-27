namespace LoginForm.Forms
{
    partial class SalesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
			StockStatus = new DevExpress.XtraGrid.Columns.GridColumn();
			btnSearch = new DevExpress.XtraEditors.SimpleButton();
			btnAddItem = new DevExpress.XtraEditors.SimpleButton();
			labelControl4 = new DevExpress.XtraEditors.LabelControl();
			labelControl3 = new DevExpress.XtraEditors.LabelControl();
			labelControl2 = new DevExpress.XtraEditors.LabelControl();
			labelControl1 = new DevExpress.XtraEditors.LabelControl();
			txtQuantity = new DevExpress.XtraEditors.TextEdit();
			labelControl7 = new DevExpress.XtraEditors.LabelControl();
			groupControl1 = new DevExpress.XtraEditors.GroupControl();
			labelControl9 = new DevExpress.XtraEditors.LabelControl();
			lueUnitPrice = new DevExpress.XtraEditors.LookUpEdit();
			labelControl8 = new DevExpress.XtraEditors.LabelControl();
			lueInventoryID = new DevExpress.XtraEditors.LookUpEdit();
			labelControl6 = new DevExpress.XtraEditors.LabelControl();
			teTransactionID = new DevExpress.XtraEditors.TextEdit();
			lueEmployee = new DevExpress.XtraEditors.LookUpEdit();
			cbStatus = new DevExpress.XtraEditors.ComboBoxEdit();
			labelControl5 = new DevExpress.XtraEditors.LabelControl();
			deDateDelivered = new DevExpress.XtraEditors.DateEdit();
			deDateOrdered = new DevExpress.XtraEditors.DateEdit();
			teSearch = new DevExpress.XtraEditors.TextEdit();
			gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
			btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			gvSales = new DevExpress.XtraGrid.Views.Grid.GridView();
			gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
			gcSales = new DevExpress.XtraGrid.GridControl();
			((System.ComponentModel.ISupportInitialize)txtQuantity.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
			groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)lueUnitPrice.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)lueInventoryID.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)teTransactionID.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)lueEmployee.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)cbStatus.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)deDateDelivered.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)deDateDelivered.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)deDateOrdered.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)deDateOrdered.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)teSearch.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
			((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).BeginInit();
			((System.ComponentModel.ISupportInitialize)gvSales).BeginInit();
			((System.ComponentModel.ISupportInitialize)gcSales).BeginInit();
			SuspendLayout();
			// 
			// StockStatus
			// 
			StockStatus.Caption = "Date Ordered";
			StockStatus.FieldName = "DateOrdered";
			StockStatus.Name = "StockStatus";
			StockStatus.Visible = true;
			StockStatus.VisibleIndex = 9;
			// 
			// btnSearch
			// 
			btnSearch.Appearance.BackColor = System.Drawing.Color.FromArgb(0, 103, 192);
			btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnSearch.Appearance.Options.UseBackColor = true;
			btnSearch.Appearance.Options.UseFont = true;
			btnSearch.Location = new System.Drawing.Point(647, 14);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new System.Drawing.Size(75, 23);
			btnSearch.TabIndex = 21;
			btnSearch.Text = "Search";
			// 
			// btnAddItem
			// 
			btnAddItem.Appearance.BackColor = System.Drawing.Color.FromArgb(0, 103, 192);
			btnAddItem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnAddItem.Appearance.Options.UseBackColor = true;
			btnAddItem.Appearance.Options.UseFont = true;
			btnAddItem.Location = new System.Drawing.Point(105, 336);
			btnAddItem.Name = "btnAddItem";
			btnAddItem.Size = new System.Drawing.Size(75, 23);
			btnAddItem.TabIndex = 17;
			btnAddItem.Text = "Add";
			btnAddItem.Click += btnAddItem_Click;
			// 
			// labelControl4
			// 
			labelControl4.Location = new System.Drawing.Point(14, 105);
			labelControl4.Name = "labelControl4";
			labelControl4.Size = new System.Drawing.Size(66, 13);
			labelControl4.TabIndex = 9;
			labelControl4.Text = "Date Ordered";
			// 
			// labelControl3
			// 
			labelControl3.Location = new System.Drawing.Point(14, 221);
			labelControl3.Name = "labelControl3";
			labelControl3.Size = new System.Drawing.Size(99, 13);
			labelControl3.TabIndex = 8;
			labelControl3.Text = "Employee-In-Charge";
			// 
			// labelControl2
			// 
			labelControl2.Location = new System.Drawing.Point(149, 105);
			labelControl2.Name = "labelControl2";
			labelControl2.Size = new System.Drawing.Size(71, 13);
			labelControl2.TabIndex = 7;
			labelControl2.Text = "Date Delivered";
			// 
			// labelControl1
			// 
			labelControl1.Location = new System.Drawing.Point(14, 51);
			labelControl1.Name = "labelControl1";
			labelControl1.Size = new System.Drawing.Size(42, 13);
			labelControl1.TabIndex = 1;
			labelControl1.Text = "Quantity";
			// 
			// txtQuantity
			// 
			txtQuantity.Location = new System.Drawing.Point(12, 70);
			txtQuantity.Name = "txtQuantity";
			txtQuantity.Size = new System.Drawing.Size(127, 28);
			txtQuantity.TabIndex = 0;
			// 
			// labelControl7
			// 
			labelControl7.Location = new System.Drawing.Point(314, 19);
			labelControl7.Name = "labelControl7";
			labelControl7.Size = new System.Drawing.Size(82, 13);
			labelControl7.TabIndex = 20;
			labelControl7.Text = "Search Keyword:";
			// 
			// groupControl1
			// 
			groupControl1.CaptionImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("groupControl1.CaptionImageOptions.SvgImage");
			groupControl1.Controls.Add(labelControl9);
			groupControl1.Controls.Add(lueUnitPrice);
			groupControl1.Controls.Add(labelControl8);
			groupControl1.Controls.Add(lueInventoryID);
			groupControl1.Controls.Add(labelControl6);
			groupControl1.Controls.Add(teTransactionID);
			groupControl1.Controls.Add(lueEmployee);
			groupControl1.Controls.Add(cbStatus);
			groupControl1.Controls.Add(labelControl5);
			groupControl1.Controls.Add(deDateDelivered);
			groupControl1.Controls.Add(deDateOrdered);
			groupControl1.Controls.Add(btnAddItem);
			groupControl1.Controls.Add(labelControl4);
			groupControl1.Controls.Add(labelControl3);
			groupControl1.Controls.Add(labelControl2);
			groupControl1.Controls.Add(labelControl1);
			groupControl1.Controls.Add(txtQuantity);
			groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
			groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
			groupControl1.Location = new System.Drawing.Point(0, 0);
			groupControl1.Name = "groupControl1";
			groupControl1.Size = new System.Drawing.Size(291, 664);
			groupControl1.TabIndex = 19;
			groupControl1.Text = "Item Details";
			// 
			// labelControl9
			// 
			labelControl9.Location = new System.Drawing.Point(150, 158);
			labelControl9.Name = "labelControl9";
			labelControl9.Size = new System.Drawing.Size(45, 13);
			labelControl9.TabIndex = 32;
			labelControl9.Text = "Unit Price";
			// 
			// lueUnitPrice
			// 
			lueUnitPrice.Location = new System.Drawing.Point(149, 177);
			lueUnitPrice.Name = "lueUnitPrice";
			lueUnitPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			lueUnitPrice.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("InventoryID", "InventoryID"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Item Name"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitPrice", "Unit Price") });
			lueUnitPrice.Properties.DisplayMember = "UnitPrice";
			lueUnitPrice.Properties.NullText = "";
			lueUnitPrice.Properties.ValueMember = "UnitPrice";
			lueUnitPrice.Size = new System.Drawing.Size(123, 28);
			lueUnitPrice.TabIndex = 31;
			// 
			// labelControl8
			// 
			labelControl8.Location = new System.Drawing.Point(14, 274);
			labelControl8.Name = "labelControl8";
			labelControl8.Size = new System.Drawing.Size(52, 13);
			labelControl8.TabIndex = 30;
			labelControl8.Text = "Item Name";
			// 
			// lueInventoryID
			// 
			lueInventoryID.Location = new System.Drawing.Point(12, 292);
			lueInventoryID.Name = "lueInventoryID";
			lueInventoryID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			lueInventoryID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("InventoryID", "InventoryID"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Item Name") });
			lueInventoryID.Properties.DisplayMember = "StockName";
			lueInventoryID.Properties.NullText = "";
			lueInventoryID.Properties.ValueMember = "InventoryID";
			lueInventoryID.Size = new System.Drawing.Size(260, 28);
			lueInventoryID.TabIndex = 29;
			// 
			// labelControl6
			// 
			labelControl6.Location = new System.Drawing.Point(14, 158);
			labelControl6.Name = "labelControl6";
			labelControl6.Size = new System.Drawing.Size(70, 13);
			labelControl6.TabIndex = 28;
			labelControl6.Text = "Transaction ID";
			// 
			// teTransactionID
			// 
			teTransactionID.Location = new System.Drawing.Point(12, 177);
			teTransactionID.Name = "teTransactionID";
			teTransactionID.Size = new System.Drawing.Size(127, 28);
			teTransactionID.TabIndex = 27;
			// 
			// lueEmployee
			// 
			lueEmployee.Location = new System.Drawing.Point(12, 240);
			lueEmployee.Name = "lueEmployee";
			lueEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			lueEmployee.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeID", "Employee ID"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name") });
			lueEmployee.Properties.DisplayMember = "FullName";
			lueEmployee.Properties.NullText = "";
			lueEmployee.Properties.ValueMember = "EmployeeID";
			lueEmployee.Size = new System.Drawing.Size(260, 28);
			lueEmployee.TabIndex = 26;
			// 
			// cbStatus
			// 
			cbStatus.Location = new System.Drawing.Point(149, 71);
			cbStatus.Name = "cbStatus";
			cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			cbStatus.Properties.Items.AddRange(new object[] { "Preparing", "Shipped", "Delivering", "Delivered" });
			cbStatus.Size = new System.Drawing.Size(125, 28);
			cbStatus.TabIndex = 25;
			// 
			// labelControl5
			// 
			labelControl5.Location = new System.Drawing.Point(149, 51);
			labelControl5.Name = "labelControl5";
			labelControl5.Size = new System.Drawing.Size(31, 13);
			labelControl5.TabIndex = 24;
			labelControl5.Text = "Status";
			// 
			// deDateDelivered
			// 
			deDateDelivered.EditValue = null;
			deDateDelivered.Location = new System.Drawing.Point(147, 124);
			deDateDelivered.Name = "deDateDelivered";
			deDateDelivered.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			deDateDelivered.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			deDateDelivered.Size = new System.Drawing.Size(125, 28);
			deDateDelivered.TabIndex = 22;
			// 
			// deDateOrdered
			// 
			deDateOrdered.EditValue = null;
			deDateOrdered.Location = new System.Drawing.Point(12, 124);
			deDateOrdered.Name = "deDateOrdered";
			deDateOrdered.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			deDateOrdered.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			deDateOrdered.Size = new System.Drawing.Size(125, 28);
			deDateOrdered.TabIndex = 21;
			// 
			// teSearch
			// 
			teSearch.Location = new System.Drawing.Point(402, 9);
			teSearch.Name = "teSearch";
			teSearch.Size = new System.Drawing.Size(239, 28);
			teSearch.TabIndex = 18;
			// 
			// gridColumn11
			// 
			gridColumn11.Caption = "Delete";
			gridColumn11.ColumnEdit = btnDelete;
			gridColumn11.Name = "gridColumn11";
			gridColumn11.Visible = true;
			gridColumn11.VisibleIndex = 12;
			// 
			// btnDelete
			// 
			btnDelete.AutoHeight = false;
			editorButtonImageOptions1.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editorButtonImageOptions1.SvgImage");
			btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
			btnDelete.HideSelection = false;
			btnDelete.Name = "btnDelete";
			btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			btnDelete.ButtonClick += btnDelete_ButtonClick;
			// 
			// repositoryItemButtonEdit1
			// 
			repositoryItemButtonEdit1.AutoHeight = false;
			editorButtonImageOptions2.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editorButtonImageOptions2.SvgImage");
			repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
			repositoryItemButtonEdit1.HideSelection = false;
			repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
			repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			// 
			// gridColumn8
			// 
			gridColumn8.Caption = "Status";
			gridColumn8.FieldName = "Status";
			gridColumn8.Name = "gridColumn8";
			gridColumn8.Visible = true;
			gridColumn8.VisibleIndex = 11;
			// 
			// gridColumn7
			// 
			gridColumn7.Caption = "Date Delivered";
			gridColumn7.FieldName = "DateDelivered";
			gridColumn7.Name = "gridColumn7";
			gridColumn7.Visible = true;
			gridColumn7.VisibleIndex = 10;
			// 
			// gridColumn5
			// 
			gridColumn5.Caption = "Employee In-Charge";
			gridColumn5.FieldName = "FullName";
			gridColumn5.Name = "gridColumn5";
			gridColumn5.Visible = true;
			gridColumn5.VisibleIndex = 4;
			// 
			// gridColumn4
			// 
			gridColumn4.Caption = "Quantity Order";
			gridColumn4.FieldName = "QuantityOrder";
			gridColumn4.Name = "gridColumn4";
			gridColumn4.Visible = true;
			gridColumn4.VisibleIndex = 2;
			// 
			// gridColumn3
			// 
			gridColumn3.Caption = "Transaction ID";
			gridColumn3.FieldName = "TransactionID";
			gridColumn3.Name = "gridColumn3";
			gridColumn3.Visible = true;
			gridColumn3.VisibleIndex = 1;
			// 
			// gridColumn1
			// 
			gridColumn1.Caption = "Order ID";
			gridColumn1.FieldName = "OrderID";
			gridColumn1.Name = "gridColumn1";
			gridColumn1.Visible = true;
			gridColumn1.VisibleIndex = 0;
			// 
			// gvSales
			// 
			gvSales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn3, gridColumn4, gridColumn10, gridColumn5, gridColumn2, gridColumn6, gridColumn12, gridColumn9, StockStatus, gridColumn7, gridColumn8, gridColumn11 });
			gridFormatRule1.Column = StockStatus;
			gridFormatRule1.Name = "Format0";
			formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
			gridFormatRule1.Rule = formatConditionRuleValue1;
			gvSales.FormatRules.Add(gridFormatRule1);
			gvSales.GridControl = gcSales;
			gvSales.GroupPanelText = " ";
			gvSales.Name = "gvSales";
			// 
			// gridColumn10
			// 
			gridColumn10.Caption = "Employee ID";
			gridColumn10.FieldName = "EmployeeID";
			gridColumn10.Name = "gridColumn10";
			gridColumn10.Visible = true;
			gridColumn10.VisibleIndex = 3;
			// 
			// gridColumn2
			// 
			gridColumn2.Caption = "Stock Name";
			gridColumn2.FieldName = "StockName";
			gridColumn2.Name = "gridColumn2";
			gridColumn2.Visible = true;
			gridColumn2.VisibleIndex = 5;
			// 
			// gridColumn6
			// 
			gridColumn6.Caption = "Unit Price";
			gridColumn6.FieldName = "UnitPrice";
			gridColumn6.Name = "gridColumn6";
			gridColumn6.Visible = true;
			gridColumn6.VisibleIndex = 6;
			// 
			// gridColumn12
			// 
			gridColumn12.Caption = "Total Price";
			gridColumn12.FieldName = "TotalPrice";
			gridColumn12.Name = "gridColumn12";
			gridColumn12.Visible = true;
			gridColumn12.VisibleIndex = 7;
			// 
			// gridColumn9
			// 
			gridColumn9.Caption = "Stock Status";
			gridColumn9.FieldName = "StockStatus";
			gridColumn9.Name = "gridColumn9";
			gridColumn9.Visible = true;
			gridColumn9.VisibleIndex = 8;
			// 
			// gcSales
			// 
			gcSales.Dock = System.Windows.Forms.DockStyle.Right;
			gcSales.Location = new System.Drawing.Point(297, 0);
			gcSales.MainView = gvSales;
			gcSales.Name = "gcSales";
			gcSales.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemButtonEdit1, btnDelete });
			gcSales.Size = new System.Drawing.Size(1067, 664);
			gcSales.TabIndex = 17;
			gcSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvSales });
			// 
			// SalesForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1364, 664);
			ControlBox = false;
			Controls.Add(btnSearch);
			Controls.Add(labelControl7);
			Controls.Add(groupControl1);
			Controls.Add(teSearch);
			Controls.Add(gcSales);
			IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("SalesForm.IconOptions.SvgImage");
			Name = "SalesForm";
			Text = "SalesForm";
			WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)txtQuantity.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
			groupControl1.ResumeLayout(false);
			groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)lueUnitPrice.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)lueInventoryID.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)teTransactionID.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)lueEmployee.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)cbStatus.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)deDateDelivered.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)deDateDelivered.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)deDateOrdered.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)deDateOrdered.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)teSearch.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
			((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).EndInit();
			((System.ComponentModel.ISupportInitialize)gvSales).EndInit();
			((System.ComponentModel.ISupportInitialize)gcSales).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnAddItem;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit teSearch;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSales;
        private DevExpress.XtraGrid.Columns.GridColumn StockStatus;
        private DevExpress.XtraGrid.GridControl gcSales;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit deDateDelivered;
        private DevExpress.XtraEditors.DateEdit deDateOrdered;
        private DevExpress.XtraEditors.ComboBoxEdit cbStatus;
        private DevExpress.XtraEditors.LookUpEdit lueEmployee;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.TextEdit teTransactionID;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.LookUpEdit lueInventoryID;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraEditors.LookUpEdit lueUnitPrice;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
	}
}