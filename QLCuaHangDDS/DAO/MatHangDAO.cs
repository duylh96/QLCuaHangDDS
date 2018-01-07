using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLCuaHangDDS.DAO
{
    public class MatHangDAO
    {

        public static MATHANG getMatHangById(long id)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            return db.MATHANGs.Single(p => p.MaMH == id);
        }

        public static List<string> LoadDanhSachPhanLoai()
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            List<string> results = new List<string>();
            var query = from pl in db.LOAIMATHANGs
                        select pl;

            foreach (var pl in query)
            {
                results.Add(pl.TenLoaiMH.ToString());
            }

            return results;
        }

        public static bool ThemMatHang(MATHANG mh)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            db.MATHANGs.InsertOnSubmit(mh);

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

        public static bool SuaMatHang(int id, MATHANG mh)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            var q = db.MATHANGs.Single(p => p.MaMH == id);
            q.TenMH = mh.TenMH;
            q.TenLoaiMH = mh.TenLoaiMH;
            q.TenHangSX = mh.TenHangSX;
            q.SoLuong = mh.SoLuong;
            q.NamSX = mh.NamSX;
            q.Mota = mh.Mota;
            q.DonGia = mh.DonGia;
            q.KinhDoanh = mh.KinhDoanh;

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

        public static bool CapNhatSoLuongMatHang(long id, int sl)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            var mh = db.MATHANGs.Single(p => p.MaMH == id);
            mh.SoLuong -= sl;

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
