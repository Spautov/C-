using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReadWeatherOfXML
{
    public struct DataWeather
    {
        public string nameCity;
        public string data;
        public int temperature;
    }
    public class ReadXML
    {
        private List<KeyValuePair<string, string>> _citiesList;

        public ReadXML()
        {
            _citiesList = new List<KeyValuePair<string, string>>();
            FileStream file;
            try
            {
                file = new FileStream("cities.txt", FileMode.Open);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            StreamReader readstrim = new StreamReader(file);
            string strOut;
            try
            {
                string Key;
                string City;
                do
                {
                    strOut = readstrim.ReadLine();
                    if (strOut != null)
                    {
                        Key = strOut.Substring(0, 5);
                        City = strOut.Substring(6);
                        _citiesList.Add(new KeyValuePair<string, string>(Key, City));
                    }
                } while (strOut != null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (readstrim != null)
                {
                    readstrim.Close();
                }

            }
        }

        public int ShowMenu()
        {
            int select = -1;
            string strOut;
            if (_citiesList.Count > 0)
            {

                Console.WriteLine("Для вывода погоды введите цифру соответствующую выбранному городу:");
                for (int i = 0; i < _citiesList.Count; i++)
                {
                    strOut = String.Format("{0} - {1}", i, _citiesList[i].Value);
                    Console.WriteLine(strOut);
                }
                Console.Write(": ");
                try
                {
                    select = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
            return select;
        }


        public string ShowWeather(int cityNum)
        {
            string strOut;
            DataWeather tmp;
            string fileName = String.Format("http://informer.gismeteo.by/rss/{0}.xml", _citiesList[cityNum].Key);
            tmp = ReceiveData(fileName);
            strOut = String.Format("Погода в г. {0} на {1} температура воздуха {2} С", tmp.nameCity, tmp.data, tmp.temperature);

            return strOut;
        }

        private DataWeather ReceiveData(string fileName)
        {
            DataWeather tmp = new DataWeather();
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(fileName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            XmlNodeList nodes = doc.GetElementsByTagName("item");
            string work;
            string cityName;
            string strtmp;
            int foundInd = -1;
            foreach (XmlNode item in nodes)
            {
                work = item["title"].InnerText;
                if (work.IndexOf("День") != -1)
                {
                    foundInd = item["description"].InnerText.IndexOf("температура");
                    strtmp = item["title"].InnerText;
                    cityName = strtmp.Substring(0, strtmp.IndexOf(' '));
                    int firstInd = -1;
                    for (int i = 0; i < strtmp.Length; i++)
                    {
                        if (Char.IsDigit(strtmp, i))
                        {
                            firstInd = i;
                            break;
                        }
                        else
                        {
                            firstInd = -1;
                        }
                    }
                    tmp.data = strtmp.Substring(firstInd);
                    tmp.nameCity = cityName;
                    tmp.temperature = Convert.ToInt32(item["description"].InnerText.Substring(foundInd + 16, 2));
                }
            }
            return tmp;
        }

        public string GetWeryHot()
        {
            StringBuilder strOut = new StringBuilder();
            string fileName;
            DataWeather tmpDatWeath;
            int maxTemp = 0;
            List<DataWeather> dataWeath = new List<DataWeather>();
            for (int i = 0; i < _citiesList.Count; i++)
            {
                fileName = String.Format("http://informer.gismeteo.by/rss/{0}.xml", _citiesList[i].Key);
                tmpDatWeath = ReceiveData(fileName);
                if (i == 0)
                {
                    maxTemp = tmpDatWeath.temperature;
                }
                else
                {
                    if (maxTemp < tmpDatWeath.temperature)
                    {
                        maxTemp = tmpDatWeath.temperature;
                    }
                }
                dataWeath.Add(tmpDatWeath);
            }
            strOut.AppendFormat("Максимальная температура равная {0} C наблюдается в:" + Environment.NewLine, maxTemp);
            foreach (var item in dataWeath)
            {
                if (item.temperature == maxTemp)
                {
                    strOut.AppendFormat("г. {0} " + Environment.NewLine, item.nameCity);
                }
            }
            return strOut.ToString();
        }
    }
}
