namespace EmployeeManagementSystem.Forms
{
	partial class TransactionsForm
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
			gcTransaction = new DevExpress.XtraGrid.GridControl();
			gvTransaction = new DevExpress.XtraGrid.Views.Grid.GridView();
			gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
			labelControl1 = new DevExpress.XtraEditors.LabelControl();
			teSearch = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)gcTransaction).BeginInit();
			((System.ComponentModel.ISupportInitialize)gvTransaction).BeginInit();
			((System.ComponentModel.ISupportInitialize)teSearch.Properties).BeginInit();
			SuspendLayout();
			// 
			// gcTransaction
			// 
			gcTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
			gcTransaction.Location = new System.Drawing.Point(0, 0);
			gcTransaction.MainView = gvTransaction;
			gcTransaction.Name = "gcTransaction";
			gcTransaction.Size = new System.Drawing.Size(832, 416);
			gcTransaction.TabIndex = 0;
			gcTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvTransaction });
			// 
			// gvTransaction
			// 
			gvTransaction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7, gridColumn8, gridColumn9, gridColumn10, gridColumn11, gridColumn12 });
			gvTransaction.GridControl = gcTransaction;
			gvTransaction.GroupPanelText = " ";
			gvTransaction.Name = "gvTransaction";
			// 
			// gridColumn2
			// 
			gridColumn2.Caption = "Transaction ID";
			gridColumn2.FieldName = "TransactionID";
			gridColumn2.Name = "gridColumn2";
			gridColumn2.Visible = true;
			gridColumn2.VisibleIndex = 0;
			// 
			// gridColumn3
			// 
			gridColumn3.Caption = "Employee ID";
			gridColumn3.FieldName = "EmployeeID";
			gridColumn3.Name = "gridColumn3";
			gridColumn3.Visible = true;
			gridColumn3.VisibleIndex = 1;
			// 
			// gridColumn4
			// 
			gridColumn4.Caption = "Order ID";
			gridColumn4.FieldName = "OrderID";
			gridColumn4.Name = "gridColumn4";
			gridColumn4.Visible = true;
			gridColumn4.VisibleIndex = 2;
			// 
			// gridColumn5
			// 
			gridColumn5.Caption = "Full Name";
			gridColumn5.FieldName = "FullName";
			gridColumn5.Name = "gridColumn5";
			gridColumn5.Visible = true;
			gridColumn5.VisibleIndex = 3;
			// 
			// gridColumn6
			// 
			gridColumn6.Caption = "Quantity Order";
			gridColumn6.FieldName = "QuantityOrder";
			gridColumn6.Name = "gridColumn6";
			gridColumn6.Visible = true;
			gridColumn6.VisibleIndex = 4;
			// 
			// gridColumn7
			// 
			gridColumn7.Caption = "Unit Price";
			gridColumn7.FieldName = "UnitPrice";
			gridColumn7.Name = "gridColumn7";
			gridColumn7.Visible = true;
			gridColumn7.VisibleIndex = 5;
			// 
			// gridColumn8
			// 
			gridColumn8.Caption = "Stock Name";
			gridColumn8.FieldName = "StockName";
			gridColumn8.Name = "gridColumn8";
			gridColumn8.Visible = true;
			gridColumn8.VisibleIndex = 6;
			// 
			// gridColumn9
			// 
			gridColumn9.Caption = "Stock Status";
			gridColumn9.FieldName = "StockStatus";
			gridColumn9.Name = "gridColumn9";
			gridColumn9.Visible = true;
			gridColumn9.VisibleIndex = 7;
			// 
			// gridColumn10
			// 
			gridColumn10.Caption = "DateDelivered";
			gridColumn10.FieldName = "DateDelivered";
			gridColumn10.Name = "gridColumn10";
			gridColumn10.Visible = true;
			gridColumn10.VisibleIndex = 8;
			// 
			// gridColumn11
			// 
			gridColumn11.Caption = "DateOrdered";
			gridColumn11.FieldName = "DateOrdered";
			gridColumn11.Name = "gridColumn11";
			gridColumn11.Visible = true;
			gridColumn11.VisibleIndex = 9;
			// 
			// gridColumn12
			// 
			gridColumn12.Caption = "Status";
			gridColumn12.FieldName = "Status";
			gridColumn12.Name = "gridColumn12";
			gridColumn12.Visible = true;
			gridColumn12.VisibleIndex = 10;
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			labelControl1.Appearance.Options.UseFont = true;
			labelControl1.Location = new System.Drawing.Point(12, 13);
			labelControl1.Name = "labelControl1";
			labelControl1.Size = new System.Drawing.Size(71, 23);
			labelControl1.TabIndex = 1;
			labelControl1.Text = "Search: ";
			// 
			// teSearch
			// 
			teSearch.Location = new System.Drawing.Point(79, 12);
			teSearch.Name = "teSearch";
			teSearch.Size = new System.Drawing.Size(261, 28);
			teSearch.TabIndex = 2;
			teSearch.EditValueChanging += teSearch_EditValueChanging;
			// 
			// TransactionsForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(832, 416);
			ControlBox = false;
			Controls.Add(teSearch);
			Controls.Add(labelControl1);
			Controls.Add(gcTransaction);
			Name = "TransactionsForm";
			Text = "TransactionsForm";
			WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)gcTransaction).EndInit();
			((System.ComponentModel.ISupportInitialize)gvTransaction).EndInit();
			((System.ComponentModel.ISupportInitialize)teSearch.Properties).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gcTransaction;
		private DevExpress.XtraGrid.Views.Grid.GridView gvTransaction;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit teSearch;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
	}
}