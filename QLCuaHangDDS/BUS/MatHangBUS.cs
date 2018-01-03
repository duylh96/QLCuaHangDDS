using QLCuaHangDDS.DAO;
using System;
using System.Collections.Generic;

namespace QLCuaHangDDS.BUS
{
    public class MatHangBUS
    {
        public static List<string> LoadDanhSachPhanLoai()
        {
            return MatHangDAO.LoadDanhSachPhanLoai();
        }

        public static bool isValidNumber(object number)
        {
            try
            {
                int n = int.Parse(number.ToString());
                if (n > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool isValidFloat(object number)
        {
            try
            {
                float n = float.Parse(number.ToString());
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
                || mh.TenHangSX.Equals(""))
                return false;
            return MatHangDAO.ThemMatHang(mh);
        }

        public static bool SuaMatHang(int id, MATHANG mh)
        {
            if (mh.TenMH.Equals("") || mh.TenLoaiMH.Equals("")
                || mh.TenHangSX.Equals(""))
                return false;
            return MatHangDAO.SuaMatHang(id, mh);
        }
    }
}
