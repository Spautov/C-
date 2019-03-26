using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLParserTo2D;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ParserXMLTo2D Parser;
            try
            {
                Parser = new ParserXMLTo2D("BeerPack.xml");
                Parser.ToDo();
                Console.WriteLine("Данные сохранены в файле OutFileFromXML.jpg");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Для завершения работы программы нажмите Enter");
            Console.Read();
        }
    }
}
