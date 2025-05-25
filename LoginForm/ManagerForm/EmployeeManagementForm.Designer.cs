namespace LoginForm.ManagerForm
{
    partial class EmployeeManagementForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagementForm));
			ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
			barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
			ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
			SuspendLayout();
			// 
			// ribbon
			// 
			ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
			ribbon.ExpandCollapseItem.Id = 0;
			ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, barButtonItem1, barButtonItem2, barButtonItem3, barButtonItem4, barButtonItem5, barButtonItem6, barButtonItem7 });
			ribbon.Location = new System.Drawing.Point(0, 0);
			ribbon.MaxItemId = 8;
			ribbon.Name = "ribbon";
			ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage2 });
			ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
			ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
			ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
			ribbon.ShowToolbarCustomizeItem = false;
			ribbon.Size = new System.Drawing.Size(861, 181);
			ribbon.Toolbar.ShowCustomizeItem = false;
			// 
			// barButtonItem1
			// 
			barButtonItem1.Caption = "Add New Employee";
			barButtonItem1.Id = 1;
			barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
			barButtonItem1.Name = "barButtonItem1";
			barButtonItem1.ItemClick += barButtonItem1_ItemClick;
			// 
			// barButtonItem2
			// 
			barButtonItem2.Caption = "Inventory";
			barButtonItem2.Id = 2;
			barButtonItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
			barButtonItem2.Name = "barButtonItem2";
			barButtonItem2.ItemClick += barButtonItem2_ItemClick;
			// 
			// barButtonItem3
			// 
			barButtonItem3.Caption = "Sales";
			barButtonItem3.Id = 3;
			barButtonItem3.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem3.ImageOptions.SvgImage");
			barButtonItem3.Name = "barButtonItem3";
			barButtonItem3.ItemClick += barButtonItem3_ItemClick;
			// 
			// barButtonItem4
			// 
			barButtonItem4.Caption = "Employee List";
			barButtonItem4.Id = 4;
			barButtonItem4.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem4.ImageOptions.SvgImage");
			barButtonItem4.Name = "barButtonItem4";
			barButtonItem4.ItemClick += barButtonItem4_ItemClick;
			// 
			// barButtonItem5
			// 
			barButtonItem5.Caption = "List of Employee";
			barButtonItem5.Id = 5;
			barButtonItem5.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem5.ImageOptions.SvgImage");
			barButtonItem5.Name = "barButtonItem5";
			// 
			// barButtonItem6
			// 
			barButtonItem6.Caption = "Log Out";
			barButtonItem6.Id = 6;
			barButtonItem6.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem6.ImageOptions.SvgImage");
			barButtonItem6.Name = "barButtonItem6";
			barButtonItem6.ItemClick += barButtonItem6_ItemClick;
			// 
			// barButtonItem7
			// 
			barButtonItem7.Caption = "Transaction History";
			barButtonItem7.Id = 7;
			barButtonItem7.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem7.ImageOptions.SvgImage");
			barButtonItem7.Name = "barButtonItem7";
			barButtonItem7.ItemClick += barButtonItem7_ItemClick;
			// 
			// ribbonPage1
			// 
			ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup5, ribbonPageGroup1, ribbonPageGroup2, ribbonPageGroup3 });
			ribbonPage1.Name = "ribbonPage1";
			ribbonPage1.Text = "Main Menu";
			// 
			// ribbonPageGroup5
			// 
			ribbonPageGroup5.ItemLinks.Add(barButtonItem1);
			ribbonPageGroup5.Name = "ribbonPageGroup5";
			ribbonPageGroup5.Text = "ribbonPageGroup5";
			// 
			// ribbonPageGroup1
			// 
			ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			ribbonPageGroup1.ItemLinks.Add(barButtonItem2);
			ribbonPageGroup1.Name = "ribbonPageGroup1";
			ribbonPageGroup1.Text = "ribbonPageGroup1";
			// 
			// ribbonPageGroup2
			// 
			ribbonPageGroup2.ItemLinks.Add(barButtonItem3);
			ribbonPageGroup2.Name = "ribbonPageGroup2";
			ribbonPageGroup2.Text = "ribbonPageGroup2";
			// 
			// ribbonPageGroup3
			// 
			ribbonPageGroup3.ItemLinks.Add(barButtonItem6);
			ribbonPageGroup3.Name = "ribbonPageGroup3";
			ribbonPageGroup3.Text = "ribbonPageGroup3";
			// 
			// ribbonPage2
			// 
			ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup4, ribbonPageGroup6 });
			ribbonPage2.Name = "ribbonPage2";
			ribbonPage2.Text = "Lists";
			// 
			// ribbonPageGroup4
			// 
			ribbonPageGroup4.ItemLinks.Add(barButtonItem4, true);
			ribbonPageGroup4.Name = "ribbonPageGroup4";
			ribbonPageGroup4.Text = "ribbonPageGroup4";
			// 
			// ribbonPageGroup6
			// 
			ribbonPageGroup6.ItemLinks.Add(barButtonItem7);
			ribbonPageGroup6.Name = "ribbonPageGroup6";
			ribbonPageGroup6.Text = "ribbonPageGroup6";
			// 
			// EmployeeManagementForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(861, 449);
			Controls.Add(ribbon);
			Name = "EmployeeManagementForm";
			Ribbon = ribbon;
			Text = "EmployeeManagementForm";
			WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
		private DevExpress.XtraBars.BarButtonItem barButtonItem6;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}