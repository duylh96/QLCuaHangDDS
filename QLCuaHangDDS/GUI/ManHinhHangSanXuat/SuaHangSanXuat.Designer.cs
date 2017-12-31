namespace QLCuaHangDDS.GUI.ManHinhHangSanXuat
{
    partial class SuaHangSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaHangSanXuat));
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btn_HuyThayDoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.edt_TenHangSanXuat = new DevExpress.XtraEditors.TextEdit();
            this.edt_MoTa = new System.Windows.Forms.TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_TenHangSanXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Luu.Appearance.Options.UseFont = true;
            this.btn_Luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.ImageOptions.Image")));
            this.btn_Luu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Luu.Location = new System.Drawing.Point(12, 289);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(298, 61);
            this.btn_Luu.TabIndex = 6;
            this.btn_Luu.Text = "Lưu";
            // 
            // btn_Huy
            // 
            this.btn_Huy.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Huy.Appearance.Options.UseFont = true;
            this.btn_Huy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huy.ImageOptions.Image")));
            this.btn_Huy.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Huy.Location = new System.Drawing.Point(314, 289);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(297, 61);
            this.btn_Huy.TabIndex = 7;
            this.btn_Huy.Text = "Hủy";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 354);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(456, 19);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Lưu ý : các trường có đánh dấu (*) không được bỏ trống!";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btn_HuyThayDoi);
            this.layoutControl1.Controls.Add(this.btn_CapNhat);
            this.layoutControl1.Controls.Add(this.labelControl2);
            this.layoutControl1.Controls.Add(this.edt_TenHangSanXuat);
            this.layoutControl1.Controls.Add(this.edt_MoTa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(690, 388);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btn_HuyThayDoi
            // 
            this.btn_HuyThayDoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_HuyThayDoi.ImageOptions.Image")));
            this.btn_HuyThayDoi.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_HuyThayDoi.Location = new System.Drawing.Point(347, 298);
            this.btn_HuyThayDoi.Name = "btn_HuyThayDoi";
            this.btn_HuyThayDoi.Size = new System.Drawing.Size(331, 55);
            this.btn_HuyThayDoi.StyleController = this.layoutControl1;
            this.btn_HuyThayDoi.TabIndex = 13;
            this.btn_HuyThayDoi.Text = "Đóng";
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.ImageOptions.Image")));
            this.btn_CapNhat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_CapNhat.Location = new System.Drawing.Point(12, 298);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(331, 55);
            this.btn_CapNhat.StyleController = this.layoutControl1;
            this.btn_CapNhat.TabIndex = 12;
            this.btn_CapNhat.Text = "Cập nhật";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 357);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(456, 19);
            this.labelControl2.StyleController = this.layoutControl1;
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Lưu ý : các trường có đánh dấu (*) không được bỏ trống!";
            // 
            // edt_TenHangSanXuat
            // 
            this.edt_TenHangSanXuat.Location = new System.Drawing.Point(129, 12);
            this.edt_TenHangSanXuat.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.edt_TenHangSanXuat.Name = "edt_TenHangSanXuat";
            this.edt_TenHangSanXuat.Size = new System.Drawing.Size(549, 20);
            this.edt_TenHangSanXuat.StyleController = this.layoutControl1;
            this.edt_TenHangSanXuat.TabIndex = 4;
            // 
            // edt_MoTa
            // 
            this.edt_MoTa.Location = new System.Drawing.Point(129, 36);
            this.edt_MoTa.Multiline = true;
            this.edt_MoTa.Name = "edt_MoTa";
            this.edt_MoTa.Size = new System.Drawing.Size(549, 258);
            this.edt_MoTa.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(690, 388);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.edt_TenHangSanXuat;
            this.layoutControlItem1.CustomizationFormText = "Tên hãng sản xuất (*) :";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlItem1.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Size = new System.Drawing.Size(670, 24);
            this.layoutControlItem1.Text = "Tên hãng sản xuất (*) :";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(114, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.edt_MoTa;
            this.layoutControlItem5.CustomizationFormText = "Mô tả (*) :";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlItem5.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Size = new System.Drawing.Size(670, 262);
            this.layoutControlItem5.Text = "Mô tả (*) :";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(114, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.labelControl2;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 345);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(670, 23);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btn_CapNhat;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 286);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(335, 59);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btn_HuyThayDoi;
            this.layoutControlItem3.Location = new System.Drawing.Point(335, 286);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(335, 59);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // SuaHangSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 388);
            this.Controls.Add(this.layoutControl1);
            this.Name = "SuaHangSanXuat";
            this.Text = "Sửa thông tin Hãng sản xuất";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edt_TenHangSanXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private DevExpress.XtraEditors.SimpleButton btn_Huy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit edt_TenHangSanXuat;
        private System.Windows.Forms.TextBox edt_MoTa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btn_HuyThayDoi;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}