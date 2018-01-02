using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHangDDS.DAO;

namespace QLCuaHangDDS.BUS
{
    public class MatHangBUS
    {
        public static List<string> LoadDanhSachPhanLoai()
        {
            return MatHangDAO.LoadDanhSachPhanLoai();
        }

        public static bool isValidNumber(string number)
        {
            try
            {
                int n = int.Parse(number);
                if (n > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool isValidFloat(string number)
        {
            try
            {
                float n = float.Parse(number);
                if (n > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ThemMatHang(MATHANG mh)
        {
            if (mh.TenMH.Equals("") || mh.TenLoaiMH.Equals("")
                || mh.TenHangSX.Equals("") || mh.DonGia.Equals(""))
                return false;
            return MatHangDAO.ThemMatHang(mh);
        }
    }
}
