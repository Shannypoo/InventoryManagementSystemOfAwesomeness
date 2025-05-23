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
            lueEmployee = new DevExpress.XtraEditors.LookUpEdit();
            cbStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            deDateDelivered = new DevExpress.XtraEditors.DateEdit();
            deDateOrdered = new DevExpress.XtraEditors.DateEdit();
            teSearch = new DevExpress.XtraEditors.TextEdit();
            gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gvInventory = new DevExpress.XtraGrid.Views.Grid.GridView();
            gcInventory = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)txtQuantity.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lueEmployee.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deDateDelivered.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deDateDelivered.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deDateOrdered.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deDateOrdered.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teSearch.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcInventory).BeginInit();
            SuspendLayout();
            // 
            // StockStatus
            // 
            StockStatus.Caption = "Date Ordered";
            StockStatus.FieldName = "DateOrdered";
            StockStatus.Name = "StockStatus";
            StockStatus.Visible = true;
            StockStatus.VisibleIndex = 4;
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
            btnAddItem.Location = new System.Drawing.Point(104, 323);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new System.Drawing.Size(75, 23);
            btnAddItem.TabIndex = 17;
            btnAddItem.Text = "Add";
            btnAddItem.Click += btnAddItem_Click;
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(12, 105);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(66, 13);
            labelControl4.TabIndex = 9;
            labelControl4.Text = "Date Ordered";
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(14, 171);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(46, 13);
            labelControl3.TabIndex = 8;
            labelControl3.Text = "Employee";
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
            labelControl1.Location = new System.Drawing.Point(14, 47);
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
            groupControl1.Size = new System.Drawing.Size(291, 666);
            groupControl1.TabIndex = 19;
            groupControl1.Text = "Item Details";
            // 
            // lueEmployee
            // 
            lueEmployee.Location = new System.Drawing.Point(12, 190);
            lueEmployee.Name = "lueEmployee";
            lueEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lueEmployee.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeID", "Name3"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name2", "Name2") });
            lueEmployee.Size = new System.Drawing.Size(260, 28);
            lueEmployee.TabIndex = 26;
            // 
            // cbStatus
            // 
            cbStatus.Location = new System.Drawing.Point(147, 70);
            cbStatus.Name = "cbStatus";
            cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbStatus.Properties.Items.AddRange(new object[] { "Preparing", "Shipped", "Delivering", "Delivered" });
            cbStatus.Size = new System.Drawing.Size(127, 28);
            cbStatus.TabIndex = 25;
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(147, 51);
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
            gridColumn11.ColumnEdit = repositoryItemButtonEdit2;
            gridColumn11.Name = "gridColumn11";
            gridColumn11.Visible = true;
            gridColumn11.VisibleIndex = 7;
            // 
            // repositoryItemButtonEdit2
            // 
            repositoryItemButtonEdit2.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editorButtonImageOptions1.SvgImage");
            repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            repositoryItemButtonEdit2.HideSelection = false;
            repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            gridColumn8.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "Date Delivered";
            gridColumn7.FieldName = "DateDelivered";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "Employee In-Charge";
            gridColumn5.FieldName = "EmployeeInCharge";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 3;
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
            // gvInventory
            // 
            gvInventory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn3, gridColumn4, gridColumn5, StockStatus, gridColumn7, gridColumn8, gridColumn11 });
            gridFormatRule1.Column = StockStatus;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gvInventory.FormatRules.Add(gridFormatRule1);
            gvInventory.GridControl = gcInventory;
            gvInventory.GroupPanelText = " ";
            gvInventory.Name = "gvInventory";
            // 
            // gcInventory
            // 
            gcInventory.Dock = System.Windows.Forms.DockStyle.Right;
            gcInventory.Location = new System.Drawing.Point(297, 0);
            gcInventory.MainView = gvInventory;
            gcInventory.Name = "gcInventory";
            gcInventory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemButtonEdit1, repositoryItemButtonEdit2 });
            gcInventory.Size = new System.Drawing.Size(1067, 666);
            gcInventory.TabIndex = 17;
            gcInventory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvInventory });
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1364, 666);
            Controls.Add(btnSearch);
            Controls.Add(labelControl7);
            Controls.Add(groupControl1);
            Controls.Add(teSearch);
            Controls.Add(gcInventory);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("SalesForm.IconOptions.SvgImage");
            Name = "SalesForm";
            Text = "SalesForm";
            ((System.ComponentModel.ISupportInitialize)txtQuantity.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lueEmployee.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deDateDelivered.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deDateDelivered.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deDateOrdered.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deDateOrdered.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)teSearch.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcInventory).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInventory;
        private DevExpress.XtraGrid.Columns.GridColumn StockStatus;
        private DevExpress.XtraGrid.GridControl gcInventory;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit deDateDelivered;
        private DevExpress.XtraEditors.DateEdit deDateOrdered;
        private DevExpress.XtraEditors.ComboBoxEdit cbStatus;
        private DevExpress.XtraEditors.LookUpEdit lueEmployee;
    }
}