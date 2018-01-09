namespace QLCuaHangDDS.GUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_BanHang = new DevExpress.XtraBars.BarButtonItem();
            this.btn_HangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PhanLoai = new DevExpress.XtraBars.BarButtonItem();
            this.btn_HangSanXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_BangSuaChua = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_BanHang,
            this.btn_HangHoa,
            this.btn_PhanLoai,
            this.btn_HangSanXuat,
            this.btnDV,
            this.btn_BangSuaChua,
            this.skinRibbonGalleryBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 19;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage3});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(904, 116);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btn_BanHang
            // 
            this.btn_BanHang.Caption = "Bán hàng";
            this.btn_BanHang.Id = 2;
            this.btn_BanHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_BanHang.ImageOptions.Image")));
            this.btn_BanHang.ImageOptions.LargeImage = global::QLCuaHangDDS.Properties.Resources._009_laptop;
            this.btn_BanHang.Name = "btn_BanHang";
            this.btn_BanHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_BanHang_ItemClick);
            // 
            // btn_HangHoa
            // 
            this.btn_HangHoa.Caption = "Hàng hóa";
            this.btn_HangHoa.Id = 9;
            this.btn_HangHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_HangHoa.ImageOptions.Image")));
            this.btn_HangHoa.ImageOptions.LargeImage = global::QLCuaHangDDS.Properties.Resources._004_networking;
            this.btn_HangHoa.Name = "btn_HangHoa";
            this.btn_HangHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_HangHoa_ItemClick);
            // 
            // btn_PhanLoai
            // 
            this.btn_PhanLoai.Caption = "Phân loại";
            this.btn_PhanLoai.Id = 10;
            this.btn_PhanLoai.ImageOptions.Image = global::QLCuaHangDDS.Properties.Resources._001_resume;
            this.btn_PhanLoai.ImageOptions.LargeImage = global::QLCuaHangDDS.Properties.Resources._001_resume;
            this.btn_PhanLoai.Name = "btn_PhanLoai";
            this.btn_PhanLoai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_PhanLoai_ItemClick);
            // 
            // btn_HangSanXuat
            // 
            this.btn_HangSanXuat.Caption = "Hãng sản xuất";
            this.btn_HangSanXuat.Id = 11;
            this.btn_HangSanXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_HangSanXuat.ImageOptions.Image")));
            this.btn_HangSanXuat.ImageOptions.LargeImage = global::QLCuaHangDDS.Properties.Resources._007_laptop_1;
            this.btn_HangSanXuat.Name = "btn_HangSanXuat";
            this.btn_HangSanXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_HangSanXuat_ItemClick);
            // 
            // btnDV
            // 
            this.btnDV.Caption = "Dịch Vụ";
            this.btnDV.Id = 14;
            this.btnDV.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnDV.ImageOptions.LargeImage = global::QLCuaHangDDS.Properties.Resources.service_icon;
            this.btnDV.Name = "btnDV";
            this.btnDV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btn_BangSuaChua
            // 
            this.btn_BangSuaChua.Caption = "Bảng sửa chữa";
            this.btn_BangSuaChua.Id = 15;
            this.btn_BangSuaChua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_BangSuaChua.ImageOptions.Image")));
            this.btn_BangSuaChua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_BangSuaChua.ImageOptions.LargeImage")));
            this.btn_BangSuaChua.Name = "btn_BangSuaChua";
            this.btn_BangSuaChua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_BangSuaChua_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Nghiệp vụ chính";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_BanHang);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Bán hàng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_HangHoa);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_PhanLoai);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_HangSanXuat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý hàng";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Nghiệp vụ hỗ trợ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDV);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_BangSuaChua);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Sửa chữa";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Báo cáo";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Báo cáo";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Thay đổi quy định";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Thay đổi quy định";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "About";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Thay đổi Giao diện";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 18;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 462);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Quản lý cửa hàng DDS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btn_BanHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.BarButtonItem btn_HangHoa;
        private DevExpress.XtraBars.BarButtonItem btn_PhanLoai;
        private DevExpress.XtraBars.BarButtonItem btn_HangSanXuat;
        private DevExpress.XtraBars.BarButtonItem btnDV;
        private DevExpress.XtraBars.BarButtonItem btn_BangSuaChua;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
    }
}