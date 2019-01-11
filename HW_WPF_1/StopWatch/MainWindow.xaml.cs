using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace StopWatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Windows.Forms.NotifyIcon MyNotifyIcon;
        private DispatcherTimer _dispatcherTimer;
        private TimeSpan _timer;
        private DateTime _startTime;
        private int _round;
       
        public MainWindow()
        {
            InitializeComponent();
            InitMyNotofy();
            InitializeTimer();
        }

        private void InitMyNotofy()
        {
            MyNotifyIcon = new System.Windows.Forms.NotifyIcon();
            MyNotifyIcon.Icon = new System.Drawing.Icon(
                            @"stopwatchhd.ico");
            MyNotifyIcon.MouseDoubleClick +=
                new System.Windows.Forms.MouseEventHandler
                    (MyNotifyIcon_MouseDoubleClick);

        }

        private void MyNotifyIcon_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.WindowState = WindowState.Normal;
        }

        private void InitializeTimer()
        {
            _dispatcherTimer = new DispatcherTimer();
            _dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            _dispatcherTimer.Tick += _dispatcherTimer_Tick;
            _timer = new TimeSpan();
            tblStopWatch.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:000}", _timer.Hours, _timer.Minutes,
                                                          _timer.Seconds, _timer.Milliseconds);
        }

        private void _dispatcherTimer_Tick(object sender, EventArgs e)
        {            
            _timer = DateTime.Now - _startTime;
            tblStopWatch.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:000}", _timer.Hours, _timer.Minutes,
                                                          _timer.Seconds, _timer.Milliseconds);
             
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (!_dispatcherTimer.IsEnabled)
            {
                _round = 0;
                tbTablo.Text = "";
                _startTime = DateTime.Now;
                _dispatcherTimer.Start();
                lbState.Content = "Состояние: Запуск";
                btnRound.IsEnabled = mnuItemRound.IsEnabled = true;
                btnStop.IsEnabled = mnuItemStop.IsEnabled = true;
                btnRefresh.IsEnabled = mnuItemRefresh.IsEnabled = false;
            }
            
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            if (_dispatcherTimer.IsEnabled)
            {               
                _dispatcherTimer.Stop();
                lbState.Content = "Состояние: Стоп";
                btnRound.IsEnabled = mnuItemRound.IsEnabled = false;
                btnStop.IsEnabled = mnuItemStop.IsEnabled = false;
                btnRefresh.IsEnabled = mnuItemRefresh.IsEnabled = true;
            }
        }

        private void btnRound_Click(object sender, RoutedEventArgs e)
        {
            ++_round;
            tbTablo.Text += String.Format("{4}-й круг| Время: {0:00}:{1:00}:{2:00}:{3:000}", _timer.Hours, _timer.Minutes,
                                                          _timer.Seconds, _timer.Milliseconds, _round)
                                                          + Environment.NewLine;
            lbState.Content = String.Format("Состояние: Всего кругов {0}", _round);
        }

        private void mnuItemHelp_Click(object sender, RoutedEventArgs e)
        {
            if (!_dispatcherTimer.IsEnabled)
            {
                tbTablo.Text = "Программа секундомер. Автор: Паутов Сергей Михалович.";
            }
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                
                MyNotifyIcon.Visible = true;
            }
            else if (this.WindowState == WindowState.Normal)
            {
                MyNotifyIcon.Visible = false;
                this.ShowInTaskbar = true;
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            btnRefresh.IsEnabled = mnuItemRefresh.IsEnabled = false;
            tbTablo.Text = "";
            _timer = new TimeSpan();
            tblStopWatch.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:000}", _timer.Hours, _timer.Minutes,
                                                          _timer.Seconds, _timer.Milliseconds);
            _round = 0;
        }
    }
}
