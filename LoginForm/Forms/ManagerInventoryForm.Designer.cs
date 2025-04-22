namespace LoginForm.Forms
{
    partial class ManagerInventoryForm
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerInventoryForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            gcInventory = new DevExpress.XtraGrid.GridControl();
            gvInventory = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            StockStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            teSearch = new DevExpress.XtraEditors.TextEdit();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            lpeCategory = new DevExpress.XtraEditors.LookUpEdit();
            teQuantity = new DevExpress.XtraEditors.TextEdit();
            btnAddItem = new DevExpress.XtraEditors.SimpleButton();
            meDescription = new DevExpress.XtraEditors.MemoEdit();
            cbStockStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            teUnitPrice = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            teStockName = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            btnSearch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gcInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teSearch.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lpeCategory.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teQuantity.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)meDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbStockStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teUnitPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teStockName.Properties).BeginInit();
            SuspendLayout();
            // 
            // gcInventory
            // 
            gcInventory.Dock = System.Windows.Forms.DockStyle.Right;
            gcInventory.Location = new System.Drawing.Point(297, 0);
            gcInventory.MainView = gvInventory;
            gcInventory.Name = "gcInventory";
            gcInventory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemButtonEdit1, repositoryItemButtonEdit2 });
            gcInventory.Size = new System.Drawing.Size(1067, 672);
            gcInventory.TabIndex = 0;
            gcInventory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvInventory });
            // 
            // gvInventory
            // 
            gvInventory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, StockStatus, gridColumn7, gridColumn8, gridColumn9, gridColumn10, gridColumn11 });
            gridFormatRule1.Column = StockStatus;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gvInventory.FormatRules.Add(gridFormatRule1);
            gvInventory.GridControl = gcInventory;
            gvInventory.GroupPanelText = " ";
            gvInventory.Name = "gvInventory";
            gvInventory.RowCellStyle += gvInventory_RowCellStyle;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Item ID";
            gridColumn1.FieldName = "InventoryID";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Category";
            gridColumn2.FieldName = "CategoryName";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "Unit Price";
            gridColumn3.FieldName = "UnitPrice";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "Stock Name";
            gridColumn4.FieldName = "StockName";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "Description";
            gridColumn5.FieldName = "Description";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            // 
            // StockStatus
            // 
            StockStatus.Caption = "Stock Status";
            StockStatus.FieldName = "StockStatus";
            StockStatus.Name = "StockStatus";
            StockStatus.Visible = true;
            StockStatus.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "Quantity";
            gridColumn7.FieldName = "Quantity";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            gridColumn8.Caption = "Last Updated";
            gridColumn8.FieldName = "LastUpdated";
            gridColumn8.Name = "gridColumn8";
            gridColumn8.Visible = true;
            gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            gridColumn9.Caption = "Date Added";
            gridColumn9.FieldName = "DateAdded";
            gridColumn9.Name = "gridColumn9";
            gridColumn9.Visible = true;
            gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            gridColumn10.Caption = "Edit";
            gridColumn10.ColumnEdit = repositoryItemButtonEdit1;
            gridColumn10.Name = "gridColumn10";
            gridColumn10.Visible = true;
            gridColumn10.VisibleIndex = 9;
            // 
            // repositoryItemButtonEdit1
            // 
            repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editorButtonImageOptions1.SvgImage");
            repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            repositoryItemButtonEdit1.HideSelection = false;
            repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn11
            // 
            gridColumn11.Caption = "Delete";
            gridColumn11.ColumnEdit = repositoryItemButtonEdit2;
            gridColumn11.Name = "gridColumn11";
            gridColumn11.Visible = true;
            gridColumn11.VisibleIndex = 10;
            // 
            // repositoryItemButtonEdit2
            // 
            repositoryItemButtonEdit2.AutoHeight = false;
            editorButtonImageOptions2.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editorButtonImageOptions2.SvgImage");
            repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            repositoryItemButtonEdit2.HideSelection = false;
            repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // teSearch
            // 
            teSearch.Location = new System.Drawing.Point(402, 9);
            teSearch.Name = "teSearch";
            teSearch.Size = new System.Drawing.Size(239, 28);
            teSearch.TabIndex = 1;
            teSearch.EditValueChanging += teSearch_EditValueChanging;
            // 
            // groupControl1
            // 
            groupControl1.CaptionImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("groupControl1.CaptionImageOptions.SvgImage");
            groupControl1.Controls.Add(lpeCategory);
            groupControl1.Controls.Add(teQuantity);
            groupControl1.Controls.Add(btnAddItem);
            groupControl1.Controls.Add(meDescription);
            groupControl1.Controls.Add(cbStockStatus);
            groupControl1.Controls.Add(labelControl6);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(teUnitPrice);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Controls.Add(teStockName);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            groupControl1.Location = new System.Drawing.Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(291, 672);
            groupControl1.TabIndex = 2;
            groupControl1.Text = "Item Details";
            // 
            // lpeCategory
            // 
            lpeCategory.Location = new System.Drawing.Point(147, 70);
            lpeCategory.Name = "lpeCategory";
            lpeCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lpeCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryID", "Category ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Category Name") });
            lpeCategory.Properties.DisplayMember = "CategoryName";
            lpeCategory.Properties.NullText = "";
            lpeCategory.Properties.ValueMember = "CategoryID";
            lpeCategory.Size = new System.Drawing.Size(125, 28);
            lpeCategory.TabIndex = 22;
            // 
            // teQuantity
            // 
            teQuantity.Location = new System.Drawing.Point(12, 187);
            teQuantity.Name = "teQuantity";
            teQuantity.Size = new System.Drawing.Size(125, 28);
            teQuantity.TabIndex = 19;
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
            // meDescription
            // 
            meDescription.Location = new System.Drawing.Point(12, 240);
            meDescription.Name = "meDescription";
            meDescription.Size = new System.Drawing.Size(260, 77);
            meDescription.TabIndex = 13;
            // 
            // cbStockStatus
            // 
            cbStockStatus.Location = new System.Drawing.Point(147, 134);
            cbStockStatus.Name = "cbStockStatus";
            cbStockStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbStockStatus.Properties.Items.AddRange(new object[] { "Expired", "Close to Expiration", "Good Condition", "Non-Perishable" });
            cbStockStatus.Size = new System.Drawing.Size(127, 28);
            cbStockStatus.TabIndex = 12;
            // 
            // labelControl6
            // 
            labelControl6.Location = new System.Drawing.Point(14, 168);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(42, 13);
            labelControl6.TabIndex = 11;
            labelControl6.Text = "Quantity";
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(14, 221);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(53, 13);
            labelControl5.TabIndex = 10;
            labelControl5.Text = "Description";
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(147, 115);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(60, 13);
            labelControl4.TabIndex = 9;
            labelControl4.Text = "Stock Status";
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(147, 51);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(45, 13);
            labelControl3.TabIndex = 8;
            labelControl3.Text = "Category";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(14, 115);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(45, 13);
            labelControl2.TabIndex = 7;
            labelControl2.Text = "Unit Price";
            // 
            // teUnitPrice
            // 
            teUnitPrice.Location = new System.Drawing.Point(14, 134);
            teUnitPrice.Name = "teUnitPrice";
            teUnitPrice.Size = new System.Drawing.Size(125, 28);
            teUnitPrice.TabIndex = 2;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(14, 51);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(56, 13);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Stock Name";
            // 
            // teStockName
            // 
            teStockName.Location = new System.Drawing.Point(12, 70);
            teStockName.Name = "teStockName";
            teStockName.Size = new System.Drawing.Size(127, 28);
            teStockName.TabIndex = 0;
            // 
            // labelControl7
            // 
            labelControl7.Location = new System.Drawing.Point(314, 19);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(82, 13);
            labelControl7.TabIndex = 15;
            labelControl7.Text = "Search Keyword:";
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
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            // 
            // ManagerInventoryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1364, 672);
            Controls.Add(btnSearch);
            Controls.Add(labelControl7);
            Controls.Add(groupControl1);
            Controls.Add(teSearch);
            Controls.Add(gcInventory);
            Name = "ManagerInventoryForm";
            Text = "Inventory";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)gcInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)teSearch.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lpeCategory.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)teQuantity.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)meDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbStockStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)teUnitPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)teStockName.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcInventory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInventory;
        private DevExpress.XtraEditors.TextEdit teSearch;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit teUnitPrice;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teStockName;
        private DevExpress.XtraEditors.MemoEdit meDescription;
        private DevExpress.XtraEditors.ComboBoxEdit cbStockStatus;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnAddItem;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn StockStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.TextEdit teQuantity;
        public DevExpress.XtraEditors.LookUpEdit lpeCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
    }
}