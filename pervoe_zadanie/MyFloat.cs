using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pervoe_zadanie
{
    internal class MyFloat
    {
        private double chisl;
        private double znam;
        private double qwefloat;

        public MyFloat(double chisl, double znam)
        {
            this.chisl = chisl;
            this.znam = znam;
            qwefloat = chisl / znam;
        }


        public double Sum(MyFloat other)
        {
            //MyFloat res = new MyFloat(chisl, znam);
            double res = 0;
            res = qwefloat + other.qwefloat;
            return res;
        }

        //public static MyFloat operator +(MyFloat a, MyFloat b)
        //{
        //    MyFloat newTemp = a.Sum(b);
        //    return newTemp;
        //}

        public void Visualize(Label label)
        {
            label.Text = Convert.ToString(qwefloat);
        }
        public double Div(MyFloat other)
        {
            double res = 0;
            res = qwefloat / other.qwefloat;
            return res;
        }
        public double Mult(MyFloat other)
        {
            double res = 0;
            res = qwefloat * other.qwefloat;
            return res;
        }
        public double Sub(MyFloat other)
        {
            double res = 0;
            res = qwefloat - other.qwefloat;
            return res;
        }

    }
}
