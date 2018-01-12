namespace QLCuaHangDDS.GUI.ManHinhHoaDonSuaChua
{
    partial class HoaDonSuaChua
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
            this.HoaDonSuaChua_table = new DevExpress.XtraGrid.GridControl();
            this.HoaDonSuaChua_gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonSuaChua_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonSuaChua_gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.HoaDonSuaChua_table);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(491, 319);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // HoaDonSuaChua_table
            // 
            this.HoaDonSuaChua_table.Location = new System.Drawing.Point(12, 12);
            this.HoaDonSuaChua_table.MainView = this.HoaDonSuaChua_gv;
            this.HoaDonSuaChua_table.Name = "HoaDonSuaChua_table";
            this.HoaDonSuaChua_table.Size = new System.Drawing.Size(467, 295);
            this.HoaDonSuaChua_table.TabIndex = 6;
            this.HoaDonSuaChua_table.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.HoaDonSuaChua_gv});
            this.HoaDonSuaChua_table.Click += new System.EventHandler(this.HoaDonSuaChua_tabl_Click);
            // 
            // HoaDonSuaChua_gv
            // 
            this.HoaDonSuaChua_gv.GridControl = this.HoaDonSuaChua_table;
            this.HoaDonSuaChua_gv.Name = "HoaDonSuaChua_gv";
            this.HoaDonSuaChua_gv.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.HoaDonSuaChua_gv_FocusedRowChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(491, 319);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.HoaDonSuaChua_table;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(471, 299);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // HoaDonSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 319);
            this.Controls.Add(this.layoutControl1);
            this.Name = "HoaDonSuaChua";
            this.Text = "Hoá Đơn Sửa Chữa";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonSuaChua_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonSuaChua_gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl HoaDonSuaChua_table;
        private DevExpress.XtraGrid.Views.Grid.GridView HoaDonSuaChua_gv;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}