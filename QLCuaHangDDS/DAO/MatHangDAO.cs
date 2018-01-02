using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDDS.DAO
{
    public class MatHangDAO
    {
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
    }
}
