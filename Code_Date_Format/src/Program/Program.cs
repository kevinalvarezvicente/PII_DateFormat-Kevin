using System;
using TestDate.src.Library;

namespace TestDate.src.Program
{
    public class Program
    {

        public static void Main(string[] args)
        {
            string testDate = "10/11/1977";
            Format FormatClass = new Format();
            Console.WriteLine("{0} se convierte a: {1} ", testDate, FormatClass.ChangeFormat1(testDate));
            Console.WriteLine("{0} se convierte a: {1} ", testDate, FormatClass.ChangeFormat2(testDate));
        }
    }
}