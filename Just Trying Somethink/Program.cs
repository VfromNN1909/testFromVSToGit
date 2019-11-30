using System;
using System.IO;
using System.Net;

namespace Just_Trying_Somethink
{
    class Program
    {
        static string GetHTMLPageContext(string url)
        {
            WebClient webClient = new WebClient();
            using(Stream data = webClient.OpenRead(url))
            {
                using(StreamReader reader = new StreamReader(data))
                {
                    return reader.ReadToEnd();
                }
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите данные");
            //Console.Write("Начальная валюта > ");
            //string fValueType = Console.ReadLine();
            //Console.Write("Значение > ");
            //double fValue = double.Parse(Console.ReadLine());
            //Console.Write("Конечная валюта > ");
            //string fValueType2 = Console.ReadLine();
            //Console.WriteLine("Значение");
            //CashConverter cashConverter = new CashConverter(fValueType,fValue,fValueType2);

            //Console.WriteLine(cashConverter);
            string data = GetHTMLPageContext("https://yandex.ru/");
            Console.WriteLine(data);


        }
    }
}
