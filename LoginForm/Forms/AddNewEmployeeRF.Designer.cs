namespace LoginForm.Forms
{
    partial class AddNewEmployeeRF
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
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            EmployeeIDTe = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeIDTe.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 1;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new System.Drawing.Size(907, 49);
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // EmployeeIDTe
            // 
            EmployeeIDTe.Location = new System.Drawing.Point(114, 51);
            EmployeeIDTe.Name = "EmployeeIDTe";
            EmployeeIDTe.Size = new System.Drawing.Size(167, 28);
            EmployeeIDTe.TabIndex = 5;
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(32, 58);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(60, 13);
            labelControl5.TabIndex = 4;
            labelControl5.Text = "Employee ID";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(textEdit4);
            groupControl1.Controls.Add(textEdit3);
            groupControl1.Controls.Add(textEdit2);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Controls.Add(textEdit1);
            groupControl1.Location = new System.Drawing.Point(12, 96);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(883, 103);
            groupControl1.TabIndex = 3;
            groupControl1.Text = "Employee Name";
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(708, 39);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(77, 13);
            labelControl4.TabIndex = 9;
            labelControl4.Text = "Name Extension";
            // 
            // textEdit4
            // 
            textEdit4.Location = new System.Drawing.Point(708, 58);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new System.Drawing.Size(138, 28);
            textEdit4.TabIndex = 8;
            // 
            // textEdit3
            // 
            textEdit3.Location = new System.Drawing.Point(475, 58);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new System.Drawing.Size(222, 28);
            textEdit3.TabIndex = 7;
            // 
            // textEdit2
            // 
            textEdit2.Location = new System.Drawing.Point(245, 58);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new System.Drawing.Size(218, 28);
            textEdit2.TabIndex = 6;
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(475, 39);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(50, 13);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "Last Name";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(245, 39);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(60, 13);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "Middle Name";
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(20, 39);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(51, 13);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "First Name";
            // 
            // textEdit1
            // 
            textEdit1.Location = new System.Drawing.Point(20, 58);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new System.Drawing.Size(207, 28);
            textEdit1.TabIndex = 0;
            // 
            // AddNewEmployeeRF
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(907, 449);
            Controls.Add(EmployeeIDTe);
            Controls.Add(labelControl5);
            Controls.Add(groupControl1);
            Controls.Add(ribbon);
            Name = "AddNewEmployeeRF";
            Ribbon = ribbon;
            RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            Text = "AddNewEmployeeRF";
            Load += AddNewEmployeeRF_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeIDTe.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.TextEdit EmployeeIDTe;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}