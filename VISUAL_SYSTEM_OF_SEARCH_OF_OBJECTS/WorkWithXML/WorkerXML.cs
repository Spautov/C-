using CurrencyExchangeDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace WorkWithXML
{
    public class WorkerXML
    {
        private string _fileName;
        public WorkerXML()
        {
            _fileName = @"Data\banks.xml";
        }
        public List<Bank> GetBanks()
        {
            List<Bank> lstBanksOut = new List<Bank>();
            NumberFormatInfo formatSepar = new NumberFormatInfo();
            formatSepar.NumberDecimalSeparator = ".";
            try
            {
                XDocument xmlDoc = XDocument.Load("http://www.obmennik.by/xml/kurs.xml");
                XElement root = xmlDoc.Root;
                var bankCurses = root.Elements("bank-id").
                    Select(el =>
                    new
                    {
                        BankId = int.Parse(el.Element("idbank").Value),
                        CurrExInfo =
                        new CurrencyExchangeInfo()
                        {
                            Date = DateTime.Parse(el.Element("date").Value + " " + el.Element("time").Value),
                            Currencys = new List<Currency>()
                            {
                                new Currency()
                                {
                                    Name = "USD",
                                    Buy = double.Parse(el.Element("usd").Element("buy").Value, formatSepar),
                                    Sell = double.Parse(el.Element("usd").Element("sell").Value, formatSepar)
                                },
                                new Currency()
                                {
                                    Name = "EUR",
                                    Buy = double.Parse(el.Element("eur").Element("buy").Value, formatSepar),
                                    Sell = double.Parse(el.Element("eur").Element("sell").Value, formatSepar)
                                },
                                new Currency()
                                {
                                    Name = "RUR",
                                    Buy = double.Parse(el.Element("rur").Element("buy").Value, formatSepar),
                                    Sell = double.Parse(el.Element("rur").Element("sell").Value, formatSepar)
                                }
                            }
                        }
                    }
                    );

                XDocument xmlDocId = XDocument.Load(@"Data\IdBanks.xml");
                XElement rootId = xmlDocId.Root;
                var bankNames = rootId.Elements("bank").Select(el =>
                    new
                    {
                        id = int.Parse(el.Element("id").Value),
                        Name = el.Element("name").Value
                    });
                var BankCurrWithName = bankCurses.Join(bankNames, f => f.BankId, s => s.id,
                    (f, s) => new Bank
                    {
                        Id = f.BankId,
                        Name = s.Name,
                        CurrencyExchangeInfo = f.CurrExInfo
                    });
                lstBanksOut = BankCurrWithName.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return lstBanksOut;
        }

        private List<PointCurrencyExchange> SetCurses(List<PointCurrencyExchange> LstPCE)
        {
            List<Bank> lstBanks = GetBanks();
            foreach (var pce in LstPCE)
            {
                foreach (var bank in lstBanks)
                {
                    if (pce.Bank.Name.Equals(bank.Name))
                    {
                        pce.Bank = bank;
                    }
                }
            }
            return LstPCE;
        }

        public List<PointCurrencyExchange> GetPointsCurrencyExchange()
        {
            List<PointCurrencyExchange> lstOut = new List<PointCurrencyExchange>();
            // установка разделитя в дробных суммах (зависит от настройки локализации)
            NumberFormatInfo formatSepar = new NumberFormatInfo();
            formatSepar.NumberDecimalSeparator = ",";
            try
            {
                // Загрузка документа в память
                XDocument xmlDoc = XDocument.Load(_fileName);
                XElement root = xmlDoc.Root;
                var banksCollext = root.Elements("bank").
                    Select(el => new
                    {
                        Name = el.Attribute("name").Value,
                        Departmen = el.Elements("departmen").Select(del => new
                        {
                            id = int.Parse(del.Element("id").Value),
                            adress = del.Element("address").Value,
                            latitude = double.Parse(del.Element("latitude").Value, formatSepar),
                            longitude = double.Parse(del.Element("longitude").Value, formatSepar)
                        })
                    });
                foreach (var bank in banksCollext)
                {
                    foreach (var dep in bank.Departmen)
                    {
                        PointCurrencyExchange PCE = new PointCurrencyExchange();
                        PCE.Address = dep.adress;
                        PCE.Coordinates = new Сoordinate() {Latitude = dep.latitude, Longitude = dep.longitude };
                        var bankadd = new Bank() { Name = bank.Name };
                        bankadd.AddPointCurrEx(PCE);
                        PCE.Bank = bankadd;
                        lstOut.Add(PCE);
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return SetCurses(lstOut);
        }

        public List<string> GetBankName()
        {
            List<string> listOut = new List<string>();
            try
            {
                XDocument xmlDoc = XDocument.Load(_fileName);
                XElement root = xmlDoc.Root;
                var banks = root.Elements("bank").
                    Select(el => el.Attribute("name").Value);
                listOut = banks.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return listOut;
        }
    }
}
