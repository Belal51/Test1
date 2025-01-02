using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int Nomber = 56789;
            Console.WriteLine(Nomber); 
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            long BigNom = 89765243443L;
            Console.WriteLine(BigNom);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            double NomD = 5.878D;
            Console.WriteLine(NomD);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            float NomF = 7.00005F;
            Console.WriteLine(NomF);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            decimal NomM = 6.555M;
            Console.WriteLine(NomM);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            // String and Char
            //string value can empty value but char cant.
            string name = "Ahmed";
            char letter = 'H';
            Console.Write(name);
            Console.WriteLine(letter);*/
     
            // Convert string into int or any other no format.
            string hh = "-65";
            int hg = Convert.ToInt32(hh);
            Console.WriteLine(hg);

            string ha = "89765243443";
            long hb = Convert.ToInt64(ha);
            Console.WriteLine(hb);
            string hf = "5.878";
            double hf2 = Convert.ToDouble(hf);
            Console.WriteLine(hf2);
            string gg = "7.000001";
            float gf = Convert.ToSingle(gg);
            Console.WriteLine(gf);
            string jk = "6.5555";
            decimal jk1 = Convert.ToDecimal(jk);
            Console.WriteLine(jk1);
            //Operators +,-,*,/
            int hd = 1;
            hd++; // This add 1 and only one
             hd += 12; // can add any figure to the variable
             hd = hd + 12;
            Console.WriteLine(hd);
            // the 3 cases can be applied for all Operators
            Console.ReadLine();
            /*This is the new line
             *nnn
             * mncbh
             * knzcj
             */
        }
    }
}
