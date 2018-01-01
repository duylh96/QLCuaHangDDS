using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLCuaHangDDS.DAO;

namespace QLCuaHangDDS.BUS
{
    public class LoaiMatHangBUS
    {
        public static bool ThemLoaiMatHang(LOAIMATHANG lmh)
        {
            if (lmh.TenLoaiMH.Equals(""))
            {
                XtraMessageBox.Show("Các trường (*) không được bỏ trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return LoaiMatHangDAO.ThemLoaiMatHang(lmh);
        }

        public static bool SuaLoaiMatHang(String tenLmh, LOAIMATHANG lmh)
        {
            if (lmh.TenLoaiMH.Equals(""))
            {
                XtraMessageBox.Show("Tên Phân Loại không được bỏ trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return LoaiMatHangDAO.SuaLoaiMatHang(tenLmh, lmh);
        }

        public static bool XoaLoaiMatHang(String tenLmh)
        {
            return true;
        }
    }
}
