using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Module
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Input quantity: ");
            n = Convert.ToInt16(Console.ReadLine());
            Date[] date = new Date[n];

            int[] k = new int[12];
            for (int i = 0; i < 12; i++)
            {
                k[i] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input day: ");
                int d = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Input mounth: ");
                int m = Convert.ToInt16(Console.ReadLine());
                k[m]++;
                Console.WriteLine("Input year: ");
                int y = Convert.ToInt16(Console.ReadLine());
                date[i] = new Date(d, m, y);
            }
            for (int j = 0; j < n - 1; j++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    Date tmp = new Date();
                    if (date[i].dd > date[i + 1].dd)
                    {
                        tmp = date[i];
                        date[i] = date[i + 1];
                        date[i + 1] = tmp;
                    }
                    if (date[i].mm > date[i + 1].mm)
                    {
                        tmp = date[i];
                        date[i] = date[i + 1];
                        date[i + 1] = tmp;
                    }
                    if (date[i].yy > date[i + 1].yy)
                    {
                        tmp = date[i];
                        date[i] = date[i + 1];
                        date[i + 1] = tmp;
                    }
                }
            }
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                if (date[i].mm >= 6 && date[i].mm <= 8)
                {
                    c++;
                }
            }
            int m1 = 0, m2 = 0, m3 = 0;
            Date[] summer = new Date[c];
            int o = 0;
            for (int i = 0; i < n; i++)
            {
                if (date[i].mm >= 6 && date[i].mm <= 8)
                {
                    if (date[i].mm == 6)
                    {
                        m1++;
                    }
                    if (date[i].mm == 7)
                    {
                        m2++;
                    }
                    if (date[i].mm == 8)
                    {
                        m3++;
                    }
                    summer[o] = date[i];
                    o++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                date[i].print();
            }
            Console.WriteLine("Summer mounth: ");
            for (int i = 0; i < c; i++)
            {
                summer[i].print();
            }
            if (m1 != 0)
            {
                Console.WriteLine("Contains June");
            }
            if (m2 != 0)
            {
                Console.WriteLine("Contains July");
            }
            if (m3 != 0)
            {
                Console.WriteLine("Contains August");
            }
            int max = k[0];
            for (int i = 1; i < 12; i++)
            {
                if (max < k[i])
                {
                    max = k[i];
                }
            }
            Console.WriteLine("Most common mouth {0}", max);
            Console.ReadKey();
        }
    }
    public class Date
    {
        public int dd;
        public int mm;
        public int yy;

        public Date()
        {
            dd = 1;
            mm = 1;
            yy = 2000;
        }
        public Date(int d, int m, int y)
        {
            dd = d;
            if (dd > 31 || dd < 1)
            {
                Console.WriteLine("Error");
                Console.ReadKey();
                return;
            }
            mm = m;
            if (mm > 12 || mm < 1)
            {
                Console.WriteLine("Error");
                Console.ReadKey();
                return;

            }
            yy = y;
        }
        public void print()
        {

            string m = "";
            switch (mm)
            {
                case 1:
                    m = "January";
                    break;
                case 2:
                    m = "February";
                    break;
                case 3:
                    m = "March";
                    break;
                case 4:
                    m = "April";
                    break;
                case 5:
                    m = "May";
                    break;
                case 6:
                    m = "June";
                    break;
                case 7:
                    m = "July";
                    break;
                case 8:
                    m = "August";
                    break;
                case 9:
                    m = "September";
                    break;
                case 10:
                    m = "October";
                    break;
                case 11:
                    m = "November";
                    break;
                case 12:
                    m = "December";
                    break;
            }
            Console.WriteLine("{0} {1} {2}", dd, m, yy);
        }
    }
}