using QLCuaHangDDS.DAO;
using System;

namespace QLCuaHangDDS.BUS
{
    public class HoaDonBanHangBUS
    {

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
        public static bool ThemHoaDon(HOADONBANHANG hd, ref long id)
        {
            if (hd.TenKH.Equals(""))
                return false;
            return HoaDonBanHangDAO.ThemHoaDon(hd, ref id);
        }

        public static bool CapNhatTongTienHD(long id, decimal ThanhTien, ref decimal result)
        {
            return HoaDonBanHangDAO.CapNhatTongTienHD(id, ThanhTien, ref result);
        }
    }
}
