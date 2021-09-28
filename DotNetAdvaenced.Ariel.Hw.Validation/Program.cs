using System;

namespace DotNetAdvaenced.Ariel.Hw.Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            string matche = "foacv";
            string longchack = "J123456_NM";
            string zzz = "aayyyeee";
            string firstAndLastName = "Ariel Naim";
            double decimalNumber = 31.56;
            string mail = "137@gmail.com";
            //matche.IsSratD();
            //matche.StartWithDFJ();
            //Console.WriteLine(matche.IsSratD()); // chack for targil 1 
            //Console.WriteLine(longchack.StartWithDFJ()); // chack for targil 2 +3
            //Console.WriteLine(zzz.ExchangeYyy());// check for targil 4
            //Console.WriteLine(matche.StartWitCapital()); // check for targil 5
            //Console.WriteLine(matche.ContaionAbc()); // check for targil 6
            //Console.WriteLine(firstAndLastName.FirsAndLastName()); // check for targil 7
            //Console.WriteLine(decimalNumber.IsDecimalNumber()); // check for targil 8 + 9
            Console.WriteLine(mail.IsValidEmail()); // check for targil 10


        }
    }
}
