using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_QLĐ
{
    class xuli
    {
        private  double ChuyenCan, GiuaKi, CuoiKi;

        public  double CHUYENCAN
        {
            get { return ChuyenCan; }
            set { ChuyenCan = value; }
        }
        public  double GIUAKI
        {
            get { return GiuaKi; }
            set { GiuaKi = value; }
        }
        public  double CUOIKI
        {
            get { return CuoiKi; }
            set { CuoiKi = value; }
        }
        
        public  double TinhDiemThang10()
        {
            return (0.6 * CuoiKi + 0.2 * GiuaKi + 0.2 * ChuyenCan);
        }
        public int diemso(Double diem)
        {
            int d;
            if (diem >= 8.5)
                d = 4;
            else if (diem >= 7)
                d = 3;
            else if (diem >= 5.5)
                d = 2;
            else if (diem >= 4)
                d = 1;
            else
                d = 0;
            return d;

        }
        public String diemchu(Double diem)
        {
            String d;
            if (diem >= 8.5)
                d = "A";
            else if (diem >= 7)
                d = "B";
            else if (diem >= 5.5)
                d = "C";
            else if (diem >= 4)
                d = "D";
            else
                d = "F";
            return d;
        }
        public String xeploai(Double a)
        {
            String x;
            if (a >= 3.6)
                x = "Xuất sắc";
            else if (a >=3.2)
                x = "Giỏi";
            else if (a >= 2.5)
                x = "Khá";
            else if (a >= 2)
                x = "TB";
            else
                x = "Yếu";
            return x;
        }
    }
}
