using CurrencyExchangeDAL;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithMap
{
    public class MapWorker
    {
        [Flags]
        public enum SettingsShow
        {
            None = 0,
            Name = 1,
            BankName = 2,
            Currency = 4,
            TimeWork = 8,
            Phone = 16,
            Adress = 32,
            Servises = 64
        }

        private GMapControl _gMapCtrl;
        private GMapOverlay _markersOverlay;
        public MapWorker(GMapControl MapCtrl)
        {
            _gMapCtrl = MapCtrl;
            //Создаем новый список маркеров, с указанием компонента 
            //в котором они будут использоваться и названием списка
            _markersOverlay = new GMapOverlay();
            //Добавляем в компонент, список маркеров 
            _gMapCtrl.Overlays.Add(_markersOverlay);
        }

        private string BuildToolTripText(PointCurrencyExchange PointCurEx, SettingsShow settings)
        {
            string outstr = "";
            if (settings.HasFlag(SettingsShow.Name))
            {
                if (!String.IsNullOrEmpty(PointCurEx.Name) && !String.IsNullOrWhiteSpace(PointCurEx.Name))
                {
                    outstr += PointCurEx.Name + Environment.NewLine;
                }
            }
            if (settings.HasFlag(SettingsShow.BankName))
            {
                if (PointCurEx.Bank != null &&
                    !String.IsNullOrEmpty(PointCurEx.Bank.Name) &&
                    !String.IsNullOrWhiteSpace(PointCurEx.Bank.Name))
                {
                    outstr += PointCurEx.Bank.Name + Environment.NewLine;
                }
            }
            if (settings.HasFlag(SettingsShow.Currency))
            {
                if (PointCurEx.Bank != null && PointCurEx.Bank.CurrencyExchangeInfo != null)
                {
                    if (PointCurEx.Bank.CurrencyExchangeInfo.Date != null && PointCurEx.Bank.CurrencyExchangeInfo.Currencys.Count > 0)
                    {
                        DateTime date = PointCurEx.Bank.CurrencyExchangeInfo.Date;
                        outstr += String.Format("Курсы валют с {0} :", date.ToString()) + Environment.NewLine;

                        foreach (var item in PointCurEx.Bank.CurrencyExchangeInfo.Currencys)
                        {
                            outstr += String.Format("{0}: покупка - {1:N4}  продажа - {2:N4}", item.Name, item.Sell, item.Buy) + Environment.NewLine;
                        }
                    }
                }

            }
            if (settings.HasFlag(SettingsShow.TimeWork))
            {
                if (!String.IsNullOrEmpty(PointCurEx.TimeOfWork) && !String.IsNullOrWhiteSpace(PointCurEx.TimeOfWork))
                {
                    outstr += "Режим работы: " + PointCurEx.TimeOfWork + Environment.NewLine;
                }
            }
            if (settings.HasFlag(SettingsShow.Phone))
            {
                if (!String.IsNullOrEmpty(PointCurEx.TelephonNumber) && !String.IsNullOrWhiteSpace(PointCurEx.TelephonNumber))
                {
                    outstr += "Телефон: " + PointCurEx.TelephonNumber + Environment.NewLine;
                }
            }
            if (settings.HasFlag(SettingsShow.Adress))
            {
                if (!String.IsNullOrEmpty(PointCurEx.Address) && !String.IsNullOrWhiteSpace(PointCurEx.Address))
                {
                    outstr += "Адрес: " + PointCurEx.Address + Environment.NewLine;
                }
            }
            if (settings.HasFlag(SettingsShow.Servises))
            {
                if (PointCurEx.ServicesType != null && PointCurEx.ServicesType.Count > 0)
                {
                    outstr += "Виды услуг: " + Environment.NewLine;
                    foreach (var item in PointCurEx.ServicesType)
                    {
                        outstr += "  " + item.Name + Environment.NewLine;
                    }
                }

            }
            return outstr;
        }

        private void Clear()
        {
            _markersOverlay.Markers.Clear();
        }
        private void ShowCurrencyExchange(PointCurrencyExchange PointCurEx, SettingsShow settings)
        {
            //Инициализация нового ЗЕЛЕНОГО маркера, с указанием его координат
            GMarkerGoogle marker = new GMarkerGoogle
                (
                 new PointLatLng(PointCurEx.Coordinates.Latitude, PointCurEx.Coordinates.Longitude),
                 GMarkerGoogleType.green
                 );
            marker.ToolTip = new GMapRoundedToolTip(marker);

            //Текст отображаемый при наведении на маркер
            marker.ToolTipText = BuildToolTripText(PointCurEx, settings);
            //Добавляем маркеры в список маркеров
            _markersOverlay.Markers.Add(marker);
        }

        public void ShowListCurrencyExchange(List<PointCurrencyExchange> LstPointCurEx, SettingsShow settings)
        {
            Clear();
            if (LstPointCurEx != null)
            {
                foreach (var item in LstPointCurEx)
                {
                    ShowCurrencyExchange(item, settings);
                }
            }
        }
    }
}
