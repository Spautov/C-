using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ReadWeatherOfXML;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream file = null;
            //List<KeyValuePair<string, string>> citiesList = new List<KeyValuePair<string, string>>();
            //try
            //{
            //    file = new FileStream("cities.txt", FileMode.Open);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //
            //StreamReader readstrim = new StreamReader(file);
            //string strOut;
            //try
            //{
            //   
            //    string Key;
            //    string City;
            //    do
            //    {
            //        strOut = readstrim.ReadLine();
            //        if (strOut != null)
            //        {
            //            Key = strOut.Substring(0, 5);
            //            City = strOut.Substring(6);
            //            citiesList.Add(new KeyValuePair<string, string>(Key, City));
            //            //Console.WriteLine(City + " " + Key);
            //        }
            //    } while (strOut != null);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if (readstrim != null)
            //    {
            //        readstrim.Close();
            //    }
            //
            //}
            ////--------------------- работаю здесь
            //int select = 0;
            //
            //if (citiesList.Count >0)
            //{
            //
            //    Console.WriteLine("Для вывода погоды введите цифру соответствующую выбранному городу:");
            //    for (int i = 0; i < citiesList.Count; i++)
            //    {
            //        strOut = String.Format("{0} - {1}", i, citiesList[i].Value);
            //        Console.WriteLine(strOut);
            //    }
            //    Console.Write(": ");
            //    try
            //    {
            //        select = Convert.ToInt32(Console.ReadLine());
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //        throw;
            //    }
            //}
            ////-------------------------------------------------------------------------------------
            //XmlDocument doc = new XmlDocument();
            //string fileName = String.Format("http://informer.gismeteo.by/rss/{0}.xml", citiesList[select].Key);
            //try
            //{
            //    doc.Load(fileName);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    throw;
            //}
            //
            ////doc.Save("Myyyyyy.xml");
            ////Console.WriteLine(doc.InnerText);
            //Console.WriteLine("======================================================");
            ////Console.WriteLine(doc.InnerXml);
            //XmlNodeList nodes = doc.GetElementsByTagName("item");
            ////Console.WriteLine("---------------------------");
            ////Console.WriteLine(nodes.Count);
            //string work;
            //int foundInd = -1;
            //foreach (XmlNode item in nodes)
            //{
            //    //Console.WriteLine("---------------------------");
            //    //Console.WriteLine(item.Name);
            //    work = item["title"].InnerText;
            //    if (work.IndexOf("День") != -1)
            //    {
            //        Console.WriteLine(item["title"].InnerText);
            //        foundInd = item["description"].InnerText.IndexOf("температура");
            //        Console.WriteLine("{0} - {1} C", 
            //            item["description"].InnerText.Substring(foundInd,11),
            //            item["description"].InnerText.Substring(foundInd+16, 2));
            //    }
            //
            //}
            //
            //
            //----------------- сохранение погоды
            //fileName = String.Format("{0}.xml", citiesList[select].Key);
            //doc.Save(fileName);
            //--------------------------------------------------------------------------------------
            ReadXML CityWeather = new ReadXML();
            int Select = CityWeather.ShowMenu();
            Console.WriteLine(CityWeather.ShowWeather(Select));
            Console.WriteLine(CityWeather.GetWeryHot());
            Console.ReadKey();
        }
    }
}
