using System;
using System.Collections.Generic;
using System.Text;
using AngleSharp;
using AngleSharp.Html.Parser;
namespace Just_Trying_Somethink
{
    class AngleSharpParser
    {
        async void parse()
        {
            // дефолтные конфигурации
            var config = Configuration.Default;
            // контекст для оценки веб-страниц заданной кофигурации
            var context = BrowsingContext.New(config);

        }
    }
}
