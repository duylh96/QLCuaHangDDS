using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLCuaHangDDS.DAO
{
    public class ChiTietHoaDonBanHangDAO
    {
        public static DataTable loadChiTietToDataTable(long id)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            var query = from ct in db.CHITIETHOADONBANHANGs
                        join mh in db.MATHANGs
                        on ct.MaMH equals mh.MaMH
                        where ct.MaHD == id
                        select new { ct.MaChiTietHD, ct.MaHD, ct.MaMH, mh.TenMH, ct.SoLuong, ct.DonGia, ct.ThanhTien };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaChiTietHD", typeof(int));
            dataTable.Columns.Add("MaHD", typeof(int));
            dataTable.Columns.Add("MaMH", typeof(int));
            dataTable.Columns.Add("TenMH", typeof(string));
            dataTable.Columns.Add("SoLuong", typeof(int));
            dataTable.Columns.Add("DonGia", typeof(decimal));
            dataTable.Columns.Add("ThanhTien", typeof(decimal));

            foreach (var item in query)
            {
                var row = dataTable.NewRow();
                row["MaChiTietHD"] = item.MaChiTietHD;
                row["MaHD"] = item.MaHD;
                row["MaMH"] = item.MaMH;
                row["TenMH"] = item.TenMH;
                row["SoLuong"] = item.SoLuong;
                row["DonGia"] = item.DonGia;
                row["ThanhTien"] = item.ThanhTien;

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        public static dynamic loadAllCTHDBHById(long id)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            var query = (from ct in db.CHITIETHOADONBANHANGs
                         join mh in db.MATHANGs
                         on ct.MaMH equals mh.MaMH
                         where ct.MaHD == id
                         select new { ct.MaChiTietHD, ct.MaHD, ct.MaMH, mh.TenMH, ct.SoLuong, ct.DonGia, ct.ThanhTien }).ToList();

            return query;
        }

        public static bool ThemCTHDBH(CHITIETHOADONBANHANG ct)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            db.CHITIETHOADONBANHANGs.InsertOnSubmit(ct);

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                XtraMessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool XoaCTHDBH(long id)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            var ct = db.CHITIETHOADONBANHANGs.Single(p => p.MaChiTietHD == id);
            db.CHITIETHOADONBANHANGs.DeleteOnSubmit(ct);

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                XtraMessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool CapNhatCTHDBH(long id, int sl, ref int deltaSoLuong, ref decimal deltaThanhTien)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            var ct = db.CHITIETHOADONBANHANGs.Single(p => p.MaChiTietHD == id);

            deltaSoLuong = sl - ct.SoLuong.Value;
            deltaThanhTien = sl * ct.DonGia.Value - ct.ThanhTien.Value;


            ct.SoLuong = sl;
            ct.ThanhTien = ct.SoLuong * ct.DonGia;


            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                XtraMessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
