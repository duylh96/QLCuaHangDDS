namespace QLCuaHangDDS.GUI.ManHinhChiTietHoaDonSuaChua
{
    partial class ManHinhHoaDonSuaChua1
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ChiTietHoaDonSuaChua_table = new DevExpress.XtraGrid.GridControl();
            this.ChiTietHoaDonSuaChua_gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonSuaChua_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonSuaChua_gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ChiTietHoaDonSuaChua_table);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(574, 306);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ChiTietHoaDonSuaChua_table
            // 
            this.ChiTietHoaDonSuaChua_table.Location = new System.Drawing.Point(12, 12);
            this.ChiTietHoaDonSuaChua_table.MainView = this.ChiTietHoaDonSuaChua_gv;
            this.ChiTietHoaDonSuaChua_table.Name = "ChiTietHoaDonSuaChua_table";
            this.ChiTietHoaDonSuaChua_table.Size = new System.Drawing.Size(550, 282);
            this.ChiTietHoaDonSuaChua_table.TabIndex = 8;
            this.ChiTietHoaDonSuaChua_table.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ChiTietHoaDonSuaChua_gv});
            // 
            // ChiTietHoaDonSuaChua_gv
            // 
            this.ChiTietHoaDonSuaChua_gv.GridControl = this.ChiTietHoaDonSuaChua_table;
            this.ChiTietHoaDonSuaChua_gv.Name = "ChiTietHoaDonSuaChua_gv";
            this.ChiTietHoaDonSuaChua_gv.OptionsFind.AlwaysVisible = true;
            this.ChiTietHoaDonSuaChua_gv.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ChiTietHoaDonSuaChua_gv_FocusedRowChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(574, 306);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ChiTietHoaDonSuaChua_table;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(554, 286);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // ManHinhHoaDonSuaChua1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 306);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ManHinhHoaDonSuaChua1";
            this.Text = "Chi Tiết Hoá Đơn Sửa Chữa";
            this.Load += new System.EventHandler(this.ManHinhHoaDonSuaChua1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonSuaChua_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonSuaChua_gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl ChiTietHoaDonSuaChua_table;
        private DevExpress.XtraGrid.Views.Grid.GridView ChiTietHoaDonSuaChua_gv;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}