using QLCuaHangDDS.DAO;

namespace QLCuaHangDDS.BUS
{
    public class ChiTietHoaDonBanHangBUS
    {
        public static dynamic loadAllCTHDBHById(long id)
        {
            return ChiTietHoaDonBanHangDAO.loadAllCTHDBHById(id);
        }

        public static bool ThemCTHDBH(CHITIETHOADONBANHANG ct)
        {
            return ChiTietHoaDonBanHangDAO.ThemCTHDBH(ct);
        }

        public static bool XoaCTHDBH(long id)
        {
            return ChiTietHoaDonBanHangDAO.XoaCTHDBH(id);
        }

        public static bool CapNhatCTHDBH(long id, int sl, ref int deltaSoLuong, ref decimal deltaThanhTien)
        {
            return ChiTietHoaDonBanHangDAO.CapNhatCTHDBH(id, sl, ref deltaSoLuong, ref deltaThanhTien);
        }
    }
}
