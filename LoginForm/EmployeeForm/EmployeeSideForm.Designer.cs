namespace LoginForm.EmployeeForm
{
    partial class EmployeeSideForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSideForm));
			ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
			InventoryBtn = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
			ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
			SuspendLayout();
			// 
			// ribbon
			// 
			ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
			ribbon.ExpandCollapseItem.Id = 0;
			ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, InventoryBtn, barButtonItem1, barButtonItem2, barButtonItem4, barButtonItem5 });
			ribbon.Location = new System.Drawing.Point(0, 0);
			ribbon.MaxItemId = 6;
			ribbon.Name = "ribbon";
			ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
			ribbon.Size = new System.Drawing.Size(851, 181);
			// 
			// InventoryBtn
			// 
			InventoryBtn.Caption = "Inventory";
			InventoryBtn.Id = 1;
			InventoryBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("InventoryBtn.ImageOptions.SvgImage");
			InventoryBtn.Name = "InventoryBtn";
			InventoryBtn.ItemClick += InventoryBtn_ItemClick;
			// 
			// barButtonItem1
			// 
			barButtonItem1.Caption = "Sales";
			barButtonItem1.Id = 2;
			barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
			barButtonItem1.Name = "barButtonItem1";
			// 
			// barButtonItem2
			// 
			barButtonItem2.Caption = "Log Out";
			barButtonItem2.Id = 3;
			barButtonItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
			barButtonItem2.Name = "barButtonItem2";
			// 
			// ribbonPage1
			// 
			ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2, ribbonPageGroup3, ribbonPageGroup4 });
			ribbonPage1.Name = "ribbonPage1";
			ribbonPage1.Text = "Main Menu";
			// 
			// ribbonPageGroup1
			// 
			ribbonPageGroup1.ItemLinks.Add(InventoryBtn);
			ribbonPageGroup1.Name = "ribbonPageGroup1";
			ribbonPageGroup1.Text = "ribbonPageGroup1";
			// 
			// ribbonPageGroup2
			// 
			ribbonPageGroup2.ItemLinks.Add(barButtonItem1);
			ribbonPageGroup2.Name = "ribbonPageGroup2";
			ribbonPageGroup2.Text = "ribbonPageGroup2";
			// 
			// ribbonPageGroup3
			// 
			ribbonPageGroup3.ItemLinks.Add(barButtonItem5);
			ribbonPageGroup3.Name = "ribbonPageGroup3";
			ribbonPageGroup3.Text = "ribbonPageGroup3";
			// 
			// barButtonItem3
			// 
			barButtonItem3.Caption = "Inventory";
			barButtonItem3.Id = 2;
			barButtonItem3.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem3.ImageOptions.SvgImage");
			barButtonItem3.Name = "barButtonItem3";
			// 
			// ribbonPageGroup4
			// 
			ribbonPageGroup4.ItemLinks.Add(barButtonItem4);
			ribbonPageGroup4.Name = "ribbonPageGroup4";
			ribbonPageGroup4.Text = "ribbonPageGroup4";
			// 
			// barButtonItem4
			// 
			barButtonItem4.Caption = "Log Out";
			barButtonItem4.Id = 4;
			barButtonItem4.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem4.ImageOptions.SvgImage");
			barButtonItem4.Name = "barButtonItem4";
			barButtonItem4.ItemClick += barButtonItem4_ItemClick;
			// 
			// barButtonItem5
			// 
			barButtonItem5.Caption = "Transaction History";
			barButtonItem5.Id = 5;
			barButtonItem5.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem5.ImageOptions.SvgImage");
			barButtonItem5.Name = "barButtonItem5";
			// 
			// EmployeeSideForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(851, 541);
			Controls.Add(ribbon);
			Name = "EmployeeSideForm";
			Ribbon = ribbon;
			Text = "EmployeeSideForm";
			WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.BarButtonItem InventoryBtn;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
		private DevExpress.XtraBars.BarButtonItem barButtonItem3;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
		private DevExpress.XtraBars.BarButtonItem barButtonItem4;
		private DevExpress.XtraBars.BarButtonItem barButtonItem5;
	}
}