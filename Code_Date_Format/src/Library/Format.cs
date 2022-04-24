using System;

namespace TestDate.src.Library
{
    public class Format
    {
        public String ChangeFormat1(String year)
        {
            return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
        }
        public String ChangeFormat2(String year)
        {
            return year.Substring(0, 2) + "-" + year.Substring(3, 2) + "-" + year.Substring(6);
        }
    }
}