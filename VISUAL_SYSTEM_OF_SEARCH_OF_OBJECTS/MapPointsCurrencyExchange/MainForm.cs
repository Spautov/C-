using CurrencyExchangeDAL;
using DBWorker;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Gmap_Markers;
using MapPointsCurrencyExchange.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkWithMap;
using WorkWithXML;
using static WorkWithMap.MapWorker;

namespace MapPointsCurrencyExchange
{
    public partial class MainForm : Form
    {
        
        List<PointCurrencyExchange> lstCurrPoint;
        private PointsCurExchDbContext dbContext;
        private MapWorker mapWorker;
        private int X;
        private int Y;
        private GMapMarker selectMarker;
        public MainForm()
        {
            InitializeComponent();
            SetRefToolStripItemAtMnuIteam();
            gMapCtrlMainInitializeComponent();
            mapWorker = new MapWorker(gMapCtrlMain);
            try
            {
                dbContext = new PointsCurExchDbContext();
                dbContext.RefreshCurses();
                lstCurrPoint = dbContext.PointsCurExchanges.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка подключения к БД " + Environment.NewLine + e.Message);
                lstCurrPoint = new List<PointCurrencyExchange>();
            }
            mapWorker.ShowListCurrencyExchange(lstCurrPoint, CheckSettings());

        }

        //функуция проверяет включение фильтров для передачи битовой маски в mapWorker.ShowListCurrencyExchange()
        private SettingsShow CheckSettings()
        {
            SettingsShow settings;
            settings = SettingsShow.None;

            if (NameFilterBtnToolStrip.Checked)
            {
                settings |= SettingsShow.Name;
            }
            if (BanekNameFilterBtnToolStrip.Checked)
            {
                settings |= SettingsShow.BankName;
            }
            if (TimeWorkFilterBtnToolStrip.Checked)
            {
                settings |= SettingsShow.TimeWork;
            }
            if (PhoneFilterBtnToolStrip.Checked)
            {
                settings |= SettingsShow.Phone;
            }
            if (AdressFilterBtnToolStrip.Checked)
            {
                settings |= SettingsShow.Adress;
            }
            if (ServisesFilterBtnToolStrip.Checked)
            {
                settings |= SettingsShow.Servises;
            }
            if (CyrrencyFilterBtnToolStrip.Checked)
            {
                settings |= SettingsShow.Currency;
            }
            return settings;
        }

        //настройка элемента gMapCtrlMain
        private void gMapCtrlMainInitializeComponent()
        {
            gMapCtrlMain.Bearing = 0;
            gMapCtrlMain.CanDragMap = true;
            gMapCtrlMain.DragButton = MouseButtons.Left;

            gMapCtrlMain.GrayScaleMode = true;
            gMapCtrlMain.MarkersEnabled = true;
            gMapCtrlMain.MaxZoom = 22;
            gMapCtrlMain.MinZoom = 1;
            gMapCtrlMain.MouseWheelZoomType =
                GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            gMapCtrlMain.NegativeMode = false;
            gMapCtrlMain.PolygonsEnabled = true;
            gMapCtrlMain.RoutesEnabled = true;
            gMapCtrlMain.ShowTileGridLines = false;
            gMapCtrlMain.Zoom = 12;
            gMapCtrlMain.Dock = DockStyle.Fill;
           
            gMapCtrlMain.Position = new PointLatLng(53.902173, 27.562063);
            gMapCtrlMain.MapProvider =
            GMap.NET.MapProviders.GMapProviders.GoogleMap;
            GMaps.Instance.Mode =
                AccessMode.ServerOnly;
            GMap.NET.MapProviders.GMapProvider.WebProxy =
                System.Net.WebRequest.GetSystemWebProxy();
            GMap.NET.MapProviders.GMapProvider.WebProxy.Credentials =
                System.Net.CredentialCache.DefaultCredentials;
        }

        private void NameFilterBtnToolStrip_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;
            btn.Checked = !btn.Checked;
            ToolStripMenuItem toolIteam = (ToolStripMenuItem)btn.Tag;
            toolIteam.Checked = btn.Checked;
            mapWorker.ShowListCurrencyExchange(lstCurrPoint, CheckSettings());
        }

        private void NameFilterIteamMnuMain_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem send = (ToolStripMenuItem)sender;
            send.Checked = !send.Checked;
            ToolStripButton btn = (ToolStripButton)send.Tag;
            btn.Checked = send.Checked;
            mapWorker.ShowListCurrencyExchange(lstCurrPoint, CheckSettings());
        }

        private void SetRefToolStripItemAtMnuIteam()
        {
            NameFilterBtnToolStrip.Tag = NameFilterIteamMnuMain;
            BanekNameFilterBtnToolStrip.Tag = BankNameFilterIteamMnuMain;
            TimeWorkFilterBtnToolStrip.Tag = TimeWorkFilterIteamMnuMain;
            PhoneFilterBtnToolStrip.Tag = PhoneFilterIteamMnuMain;
            AdressFilterBtnToolStrip.Tag = AdressFilterIteamMnuMain;
            ServisesFilterBtnToolStrip.Tag = ServisesFilterIteamMnuMain;
            CyrrencyFilterBtnToolStrip.Tag = CourseFilterIteamMnuMain;

            NameFilterIteamMnuMain.Tag = NameFilterBtnToolStrip;
            BankNameFilterIteamMnuMain.Tag = BanekNameFilterBtnToolStrip;
            TimeWorkFilterIteamMnuMain.Tag = TimeWorkFilterBtnToolStrip;
            PhoneFilterIteamMnuMain.Tag = PhoneFilterBtnToolStrip;
            AdressFilterIteamMnuMain.Tag = AdressFilterBtnToolStrip;
            ServisesFilterIteamMnuMain.Tag = ServisesFilterBtnToolStrip;
            CourseFilterIteamMnuMain.Tag = CyrrencyFilterBtnToolStrip;
        }

        private void RefreschBtnToolStrip_Click(object sender, EventArgs e)
        {
            if (selectMarker != null)
            {
                selectMarker.Size = new Size(32, 32);
                selectMarker = null;
            }
            
            try
            {
                dbContext.RefreshCurses();
                lstCurrPoint = dbContext.PointsCurExchanges.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД " + Environment.NewLine + ex.Message);
            }
            

            mapWorker.ShowListCurrencyExchange(lstCurrPoint, CheckSettings());
        }

        private void AddCmnuIteamGMap_Click(object sender, EventArgs e) 
        {
            PointLatLng Glob = gMapCtrlMain.FromLocalToLatLng(X, Y);
            PointCurrencyExchange pointCurr = new PointCurrencyExchange();
            pointCurr.Coordinates = new Сoordinate() { Latitude = Glob.Lat, Longitude = Glob.Lng };

            PointsCurrencyInfoForm PCIF = new PointsCurrencyInfoForm(pointCurr, true);

            if (PCIF.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dbContext.PointsCurExchanges.Add(PCIF.PointCurrency);
                    dbContext.SaveChanges();
                    lstCurrPoint = dbContext.PointsCurExchanges.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к БД " + Environment.NewLine + ex.Message);
                }
               
                mapWorker.ShowListCurrencyExchange(lstCurrPoint, CheckSettings());
            }

        }

        private void gMapCtrlMain_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (selectMarker != null)
            {
                selectMarker.Size = new Size(32, 32);
                selectMarker = null;
            }
            selectMarker = item;
            selectMarker.Size = new Size(40, 40);
            if (e.Button == MouseButtons.Right)
            {
                X = e.X;
                Y = e.Y;
                cmnuGMapEditDel.Tag = item;
                cmnuGMapEditDel.Show(gMapCtrlMain, new Point(e.X, e.Y));
            }
        }

        private void gMapCtrlMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectMarker != null)
            {
                selectMarker.Size = new Size(32, 32);
            }
            if (e.Button == MouseButtons.Right)
            {
                X = e.X;
                Y = e.Y;
                cmnuGMapAdd.Show(gMapCtrlMain, new Point(e.X, e.Y));
            }
        }

        private void EditCmnuIteamGMapEditDel_Click(object sender, EventArgs e)
        {

            GMapMarker marker = (GMapMarker)cmnuGMapEditDel.Tag;
            PointCurrencyExchange checkPoint =
                lstCurrPoint.Find
                (el =>
                    Math.Abs(el.Coordinates.Latitude - marker.Position.Lat) <= 0.000001
                 && Math.Abs(el.Coordinates.Longitude - marker.Position.Lng) <= 0.000001
                );

            if (checkPoint != null)
            {
                PointsCurrencyInfoForm PCIF = new PointsCurrencyInfoForm(checkPoint, false);

                if (PCIF.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        dbContext.SaveChanges();
                        lstCurrPoint = dbContext.PointsCurExchanges.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка подключения к БД " + Environment.NewLine + ex.Message);
                    }
                    mapWorker.ShowListCurrencyExchange(lstCurrPoint, CheckSettings());
                }
            }
            if (selectMarker != null)
            {
                selectMarker.Size = new Size(32, 32);
                selectMarker = null;
            }
        }

        private void DelCmnuIteamGMapEditDel_Click(object sender, EventArgs e)
        {

            GMapMarker marker = (GMapMarker)cmnuGMapEditDel.Tag;
            PointCurrencyExchange checkPoint =
                lstCurrPoint.Find
                (el =>
                    Math.Abs(el.Coordinates.Latitude - marker.Position.Lat) <= 0.000001
                 && Math.Abs(el.Coordinates.Longitude - marker.Position.Lng) <= 0.000001

                );

            if (checkPoint != null)
            {
                try
                {
                    dbContext.PointsCurExchanges.Remove(checkPoint);
                    dbContext.SaveChanges();
                    lstCurrPoint = dbContext.PointsCurExchanges.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к БД " + Environment.NewLine + ex.Message);
                }
                mapWorker.ShowListCurrencyExchange(lstCurrPoint, CheckSettings());
            }
            if (selectMarker != null)
            {
                selectMarker.Size = new Size(32, 32);
                selectMarker = null;
            }

        }

        private void FoundCmnuIteamGMapAdd_Click(object sender, EventArgs e)
        {
            PointLatLng HierPoint = gMapCtrlMain.FromLocalToLatLng(X, Y);

            var Lenght = lstCurrPoint.Select(el =>
            new
            {
                pointCurr = el,
                lenght = lenghtBetweenPoint(new PointLatLng(el.Coordinates.Latitude, el.Coordinates.Longitude), HierPoint)
            }
            );
            var min = Lenght.Min(el => el.lenght);
            var FindPoint = Lenght.Where(el => Math.Abs(el.lenght - min) < 0.000000001)
                .Select(el => el.pointCurr);
            lstCurrPoint = FindPoint.ToList();
            mapWorker.ShowListCurrencyExchange(lstCurrPoint, CheckSettings());

        }

        private double lenghtBetweenPoint(PointLatLng p1, PointLatLng p2)
        {
            double lenght = 0;
            double numerator = 0;
            double denominator = 0;
            double DLng = Math.Abs(p1.Lng - p2.Lng);

            numerator = Math.Sqrt(Math.Pow(Math.Cos(p2.Lat) * Math.Sin(DLng), 2)
                + Math.Pow(Math.Cos(p1.Lat) * Math.Sin(p2.Lat) - Math.Sin(p1.Lat) * Math.Cos(p2.Lat) * Math.Cos(DLng), 2));

            denominator = Math.Sin(p1.Lat) * Math.Sin(p2.Lat)
                + Math.Cos(p1.Lat) * Math.Cos(p2.Lat) * Math.Cos(DLng);
            lenght = Math.Atan2(numerator, denominator);

            return lenght;
        }

        private void maxUSDcnmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem mnuIteam = (ToolStripMenuItem)sender;
                List<PointCurrencyExchange> maxSellLst = new List<PointCurrencyExchange>();
                string currency = (string)mnuIteam.Tag;

                var ListCurr = dbContext.PointsCurExchanges
                    .Where(p => p.Bank != null && p.Bank.CurrencyExchangeInfo != null)
                    .Select(el => el.Bank.CurrencyExchangeInfo);

                List<Currency> lstCurr = new List<Currency>();

                foreach (var curColl in ListCurr)
                {
                    if (curColl.Currencys.Count > 0)
                    {
                        foreach (var curr in curColl.Currencys)
                        {
                            if (curr.Name.Equals(currency))
                            {
                                lstCurr.Add(curr);
                                break;
                            }
                        }
                    }
                }

                var maxCurrValue = lstCurr.Select(el => el.Sell).Max();
                var lstPointsWithMaxSell = dbContext.PointsCurExchanges
                    .Where(el => el.Bank != null
                    && el.Bank.CurrencyExchangeInfo != null)
                    .Select(p => p);

                foreach (var pointCurr in lstPointsWithMaxSell.ToList())
                {

                    foreach (var curr in pointCurr.Bank.CurrencyExchangeInfo.Currencys)
                    {
                        if (curr.Name.Equals(currency) && Math.Abs(curr.Sell - maxCurrValue) < 0.00000001)
                        {
                            maxSellLst.Add(pointCurr);
                            break;
                        }
                    }

                }
                lstCurrPoint = maxSellLst;
                mapWorker.ShowListCurrencyExchange(lstCurrPoint, CheckSettings());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД " + Environment.NewLine + ex.Message);
            }
            
        }

        private void minUSDcnmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem mnuIteam = (ToolStripMenuItem)sender;
                List<PointCurrencyExchange> minBuyLst = new List<PointCurrencyExchange>();
                string currency = (string)mnuIteam.Tag;
                var ListCurr = dbContext.PointsCurExchanges
                    .Where(p => p.Bank != null && p.Bank.CurrencyExchangeInfo != null)
                    .Select(el => el.Bank.CurrencyExchangeInfo);

                List<Currency> lstCurr = new List<Currency>();

                foreach (var curColl in ListCurr)
                {
                    if (curColl.Currencys.Count > 0)
                    {
                        foreach (var curr in curColl.Currencys)
                        {
                            if (curr.Name.Equals(currency))
                            {
                                lstCurr.Add(curr);
                                break;
                            }
                        }
                    }
                }

                var minCurrValue = lstCurr.Select(el => el.Buy).Min();
                var lstPointsWithMinBuy = dbContext.PointsCurExchanges
                    .Where(el => el.Bank != null
                    && el.Bank.CurrencyExchangeInfo != null)
                    .Select(p => p);

                foreach (var pointCurr in lstPointsWithMinBuy.ToList())
                {

                    foreach (var curr in pointCurr.Bank.CurrencyExchangeInfo.Currencys)
                    {
                        if (curr.Name.Equals(currency) && Math.Abs(curr.Buy - minCurrValue) < 0.00000001)
                        {
                            minBuyLst.Add(pointCurr);
                            break;
                        }
                    }

                }
                lstCurrPoint = minBuyLst;
                mapWorker.ShowListCurrencyExchange(lstCurrPoint, CheckSettings());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД " + Environment.NewLine + ex.Message);
            }
        }

        private void AddEditIteamMnuMain_Click(object sender, EventArgs e)
        {
            try
            {
                PointCurrencyExchange pointCurr = new PointCurrencyExchange();
                pointCurr.Coordinates = new Сoordinate() { Latitude = gMapCtrlMain.Position.Lat, Longitude = gMapCtrlMain.Position.Lng };

                PointsCurrencyInfoForm PCIF = new PointsCurrencyInfoForm(pointCurr, true);

                if (PCIF.ShowDialog() == DialogResult.OK)
                {
                    dbContext.PointsCurExchanges.Add(PCIF.PointCurrency);
                    dbContext.SaveChanges();
                    lstCurrPoint = dbContext.PointsCurExchanges.ToList();
                    mapWorker.ShowListCurrencyExchange(lstCurrPoint, CheckSettings());
                }
                if (selectMarker != null)
                {
                    selectMarker.Size = new Size(32, 32);
                    selectMarker = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД " + Environment.NewLine + ex.Message);
                if (selectMarker != null)
                {
                    selectMarker.Size = new Size(32, 32);
                    selectMarker = null;
                }
            }
            
        }

        private void EditEditIteamMnuMain_Click(object sender, EventArgs e)
        {
            try
            {
                GMapMarker marker = (GMapMarker)selectMarker;
                PointCurrencyExchange checkPoint =
                    lstCurrPoint.Find
                    (el =>
                        Math.Abs(el.Coordinates.Latitude - marker.Position.Lat) <= 0.000001
                     && Math.Abs(el.Coordinates.Longitude - marker.Position.Lng) <= 0.000001

                    );

                if (checkPoint != null)
                {
                    PointsCurrencyInfoForm PCIF = new PointsCurrencyInfoForm(checkPoint, false);

                    if (PCIF.ShowDialog() == DialogResult.OK)
                    {
                        dbContext.SaveChanges();
                        lstCurrPoint = dbContext.PointsCurExchanges.ToList();
                        mapWorker.ShowListCurrencyExchange(lstCurrPoint, CheckSettings());
                    }
                }
                if (selectMarker != null)
                {
                    selectMarker.Size = new Size(32, 32);
                    selectMarker = null;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Для редактирования выберите объект");
            }

        }

        private void DelEditIteamMnuMain_Click(object sender, EventArgs e)
        {
            try
            {
                GMapMarker marker = (GMapMarker)selectMarker;
                PointCurrencyExchange checkPoint =
                    lstCurrPoint.Find
                    (el =>
                        Math.Abs(el.Coordinates.Latitude - marker.Position.Lat) <= 0.000001
                     && Math.Abs(el.Coordinates.Longitude - marker.Position.Lng) <= 0.000001

                    );

                if (checkPoint != null)
                {
                    dbContext.PointsCurExchanges.Remove(checkPoint);
                    dbContext.SaveChanges();
                    lstCurrPoint = dbContext.PointsCurExchanges.ToList();
                    mapWorker.ShowListCurrencyExchange(lstCurrPoint, CheckSettings());
                }
                if (selectMarker != null)
                {
                    selectMarker.Size = new Size(32, 32);
                    selectMarker = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите объект для удаления");
            }
        }

        private void NextSearchIteamMnuMain_Click(object sender, EventArgs e)
        {
            PointLatLng HierPoint = gMapCtrlMain.Position;

            var Lenght = lstCurrPoint.Select(el =>
            new
            {
                pointCurr = el,
                lenght = lenghtBetweenPoint(new PointLatLng(el.Coordinates.Latitude, el.Coordinates.Longitude), HierPoint)
            }
            );
            var min = Lenght.Min(el => el.lenght);
            var FindPoint = Lenght.Where(el => Math.Abs(el.lenght - min) < 0.000000001)
                .Select(el => el.pointCurr);

            mapWorker.ShowListCurrencyExchange(FindPoint.ToList(), CheckSettings());
        }

        private void ExitFileIteamMnuMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutBtnToolStrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Экзаменационное задание по WinForms" + Environment.NewLine + 
                "Автор: Паутов Сергей");
           
        }

        private void gMapCtrlMain_MouseMove(object sender, MouseEventArgs e)
        {
            PointLatLng Point = gMapCtrlMain.FromLocalToLatLng(e.X, e.Y);
            lbLatStsStripMain.Text = String.Format("Широта: {0:N6}", Point.Lat);
            lbLngStsStripMain.Text = String.Format("Долгота: {0:N6}", Point.Lng);
        }
    }
}
