using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeDAL
{
    [ComplexType]
    public class Сoordinate
    {
        //public int Id { get; set; }
        public double Latitude { get; set; } //широта
        public double Longitude { get; set; } //долгота
        //public virtual PointCurrencyExchange PointCurEx { get; set; }

        //public Сoordinate()
        //{
        //   //PointCurEx = new PointCurrencyExchange();
        //}
        //public Сoordinate(double latitude, double longitude)
        //{
        //    Latitude = latitude;
        //    Longitude = longitude;
        //   //PointCurEx = new PointCurrencyExchange();
        //}
    }
}
