using System;
using System.Collections.Generic;
using System.Text;

namespace Just_Trying_Somethink
{
    class CashConverter : IConvert
    {
        private double FirstNumber { get; set;}
        private double SecondNumber { get; set; }
        private string ConvertType1 { get; set; }
        private string ConvertType2 { get; set; }


        public CashConverter(string ConvertType1,double fNum,string ConvertType2)
        {
            this.ConvertType1 = ConvertType1;
            FirstNumber = fNum;
            this.ConvertType2 = ConvertType2;
            convert();
        }

        public CashConverter() { }


        public override string ToString()
        {
            String str = $"{ConvertType1} {FirstNumber} = {ConvertType2} {SecondNumber}";
            return str;
        }

        public void convert()
        {
            var rate = 67.3;
            if(ConvertType1 == "Рубль")
            {
                SecondNumber = FirstNumber * rate;
            } else if(ConvertType1 == "Доллар")
            {
                SecondNumber = FirstNumber / rate;
            }
        }
    }
}
