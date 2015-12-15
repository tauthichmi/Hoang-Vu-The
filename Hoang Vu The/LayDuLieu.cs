using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Bai_Tap_vn
{
    class LayDuLieu
    {
        private string soBD, hoTen, ngaySinh, khuVuc, danToc, uuTien;
        private string[] tenNV = new string[4];
        private string[] nguyenVong = new string[4];
        private double[] diemMon = new double[13];

        public string SoBD
        {
            get { return soBD; }
        }

        public string HoTen
        {
            get { return hoTen; }
        }

        public string NgaySinh
        {
            get { return ngaySinh; }
        }

        public string KhuVuc
        {
            get { return khuVuc; }
        }
        public string DanToc
        {
            get { return danToc; }
        }
        public string UuTien
        {
            get { return uuTien; }
        }
        public string[] TenNV
        {
            get { return tenNV; }
        }
        public string[] NguyenVong
        {
            get { return nguyenVong; }
        }

        public double[] DiemMon
        {
            get { return diemMon; }
        }

        static string xuLy(string a)
        {
            string[] A = a.Split('"');
            a = A[1];
            return a;
        }

        public void du_lieu(int stt)
        {
            string file1 = "csdl_bk.txt";
            string[] csdl_bk = File.ReadAllLines(file1);
            string[] s = csdl_bk[stt].Split(',');

            SoBD = xuLy(s[0]);
            HoTen = xuLy(s[1]);
            NgaySinh = xuLy(s[2]);
            KhuVuc = xuLy(s[3]);
            DanToc = xuLy(s[4]);
            UuTien = xuLy(s[5]);
            for (int i = 0; i < 13; i++)
            {
                if (s[i + 6] == "NA")
                    DiemMon[i] = -1;
                else DiemMon[i] = double.Parse(s[i + 6]);
            }


            string file2 = "nv_sv.txt";
            string[] nv_sv = File.ReadAllLines(file2);
            string[] Ss = nv_sv[stt].Split('"');
            int n = Ss.Length;
            int m = 0;

            for (int i = 1; i < n; )
            {
                Ss[(i - 1) / 2] = Ss[i];
                i += 2;
                m++;
            }

            for (int i = 0; i < (m - 1) / 2; i++)
            {
                nguyenVong[i] = Ss[2 * i + 2];
            }

            for (int i = 0; i < (m - 1) / 2; i++)
            {
                tenNV[i] = Ss[2 * i + 1];
            }
        }
    }
}
