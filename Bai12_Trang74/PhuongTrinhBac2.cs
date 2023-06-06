using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12_Trang74
{
    class PhuongTrinhBac2
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public PhuongTrinhBac2() {}
        public string GiaiPT()
        {
            
            if(a==0)
            {
                if (b == 0)
                {
                    return (c == 0 ? "Phương trình có vô số nghiệm" : "Phương trình vô nghiệm");
                }
                else
                    return "Phương trình có nghiệm: x = " + ((float)-c/b);    
            }
            float denta = b * b - 4 * a * c;
            if (denta < 0) return "Phương trình vô nghiệm";
            if (denta == 0) return "Phương trình có nghiệm kép x = " + (-b / 2 / a);
            return (("Phương trình có 2 nghiệm phân biệt:"+"\nx1 = "+(-b + Math.Sqrt(denta))/2/a) +"\nx2 = " + (-b - Math.Sqrt(denta))/2/a );
        }
    }
}
