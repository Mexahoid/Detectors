using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detectors
{
    public class Logics
    {
        private static Logics instance;
        private int n;
        public static Logics Instance
        {
            get => instance ?? (instance = new Logics());
            set => instance = value;
        }

        private Logics()
        {

        }

        public double[] GetMathAndDisp(double[] dargs, int[] iargs)
        {
            double[] ans = new double[2];

            double D = 0, M = 0;
            double zi = dargs[0];
            double Ri = dargs[1];
            n = iargs[1];
            var values = new List<double>
            {
                Ri
            };
            M += Ri;
            int i;
            for (i = 1; i < iargs[0]; i++)
            {
                zi = NewZ(zi);
                Ri = NewR(Ri, zi);
                values.Add(Ri);
                M += Ri;
            }

            M /= i;

            foreach (double value in values)
            {
                D += (value - M) * (value - M);
            }
            D /= i;

            ans[0] = M;
            ans[1] = D;

            return ans;
        }

        public long[] GetPeriods(double[] dargs, int[] iargs)
        {
            long[] ans = new long[2];
            n = iargs[0];
            long i1 = iargs[1];
            double z0 = dargs[0];
            double R0 = dargs[1];
            long L = 0;
            long l = 0;


            double zi = z0, Ri = R0, R_ = 0;

            // Нахождение i1 элемента
            long i;
            for (i = 0; i < i1; i++)
            {
                zi = NewZ(zi);
                Ri = NewR(Ri, zi);
            }
            // Выдергивание его
            double Ri1 = Ri;

            // Запомнить i
            long i2 = i;
            zi = NewZ(zi);
            Ri = NewR(Ri, zi);
            i++;

            while (Math.Abs(Ri1 - Ri) > 0.00000001)
            {
                i++;
                zi = NewZ(zi);
                Ri = NewR(Ri, zi);
            }

            // Нашли l
            l = i - i2;

            // Берем первый (второй) элемент
            double z_ = NewZ(z0);
            R_ = NewR(R0, z_);

            // Находим, когда повторится
            while (Math.Abs(R_ - Ri) > 0.00000001)
            {
                zi = NewZ(zi);
                Ri = NewR(Ri, zi);
                z_ = NewZ(z0);
                R_ = NewR(R_, z_);
                i++;
            }

            L = i - l;

            ans[0] = L;
            ans[1] = l;

            return ans;
        }

        private double NewZ(double oldZ)
        {
            return oldZ + Math.Pow(10, -n);
        }

        private double NewR(double oldR, double z)
        {
            return (oldR / z + Math.PI) % 1;
        }
    }
}
