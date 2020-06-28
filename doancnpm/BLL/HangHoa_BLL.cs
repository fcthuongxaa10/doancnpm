using doancnpm.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doancnpm.BLL
{
    class HangHoa_BLL
    {
        private static HangHoa_BLL _Instance;

        public static HangHoa_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new HangHoa_BLL();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private HangHoa_BLL()
        {
        }
        public List<MatHang> GetMH()
        {
            Model1 db = new Model1();
            var li = db.MatHangs.Select(p => p);
            return li.ToList();
        }
        public List<MatHang> GetMH_search(string txtSearch)
        {
            var db = new Model1();
            List<MatHang> l = new List<MatHang>();

            foreach (MatHang i in db.MatHangs)
            {
                if (i.TenHang.ToString().Contains(txtSearch))
                {
                    l.Add(i);
                }
            }
            return l;
        }
        public bool Dell(DataGridViewSelectedRowCollection r)
        {
            try
            {
                Model1 db = new Model1();
                foreach (MatHang i in db.MatHangs)
                {
                    foreach (DataGridViewRow j in r)
                    {
                        if (i.MaHang == j.Cells["MaHang"].Value.ToString())
                        {
                            db.MatHangs.Remove(i);
                        }
                    }
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public List<MatHang> Check(string MH)
        {
            Model1 db = new Model1();
            return db.MatHangs.Where(p => p.MaHang == MH).Select(p => p).ToList();
        }
        public bool ADDorEDIT(string a, string MaHang, MatHang mh, string MH, string TH, string SL, string Gia, DateTime NNK, object DVT)
        {
            Model1 db = new Model1();
            if (a == "add")
            {
                try
                {

                    db.MatHangs.Add(mh);

                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công!");
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhập sai định dạng!");
                    return false;
                }
            }
            else
            {
                try
                {
                    var l = db.MatHangs.Where(p => p.MaHang == MaHang).FirstOrDefault();
                    l.MaHang = MH;
                    l.TenHang = TH;
                    l.SoLuongSp = Convert.ToInt32(SL.ToString());
                    l.Gia = Convert.ToDecimal(Gia.ToString());
                    l.NgayNhapKho = NNK;
                    l.IDDonViTinh = (DVT as CBBItems).Values;
                    db.SaveChanges();
                    MessageBox.Show("Chỉnh sửa thành công!");
                    return true;

                }
                catch (Exception)
                {
                    MessageBox.Show("Nhập sai");
                    return false;
                }
            }


        }
    }
}