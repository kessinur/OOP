using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.OOP
{
    class HitungLuasPersegi : Bangun2D
    {
        private double sisi;

        public HitungLuasPersegi(double s)
        {
            this.sisi = s;
        }

        public override double HitungLuas()
        {
            return (sisi * sisi);
        }
    }
}
