using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TimeSpan _timePlay;
        private OpenFileDialog _openDlg;
        private List<string> _fileNames;
        private int _countFilms;
        private int _nextFilm;
        private DispatcherTimer _dispatcherTimer;
        private bool _playFilm;
        private GridLength oldSize;
        public MainWindow()
        {
            InitializeComponent();
            InitOpenFileDialog();
            InitializeTimer();
            _timePlay = new TimeSpan();
            _fileNames = new List<string>();
            _nextFilm = -1;
            sldVolume.Minimum = 0;
            sldVolume.Maximum = 1;
            sldVolume.Value = 0.5;
            
            tbTimeBefor.Text = FormatTime(_timePlay);
            oldSize = grdMedia.ColumnDefinitions[1].Width;
        }

        private string FormatTime(TimeSpan timeSpan)
        {
            return String.Format("{0:00}:{1:00}:{2:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
        }
        private void InitializeTimer()
        {
            _dispatcherTimer = new DispatcherTimer();
            _dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            _dispatcherTimer.Tick += _dispatcherTimer_Tick;
        }

        private void _dispatcherTimer_Tick(object sender, EventArgs e)
        {
            tbTimeBefor.Text = FormatTime(melScreen.Position);
            sldVidio.Value = melScreen.Position.Ticks;
        }

        private void InitOpenFileDialog()
        {
            _openDlg = new OpenFileDialog();
            _openDlg.Multiselect = true;
            _openDlg.Filter = "Media Files|*.mpeg;*.3gp;*.avi;*.mp4";
        }
        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (_playFilm)
            {
                melScreen.Play();
                _dispatcherTimer.Start();
            }
            else
            if (_nextFilm > -1)
            {
                melScreen.Source = new Uri(_fileNames[_nextFilm]);
                if (melScreen.HasVideo || melScreen.HasAudio )
                {
                    melScreen.Play();
                    
                }
                NextFilmUp();
            }

        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            melScreen.Stop();
            _dispatcherTimer.Stop();
            sldVidio.Value = melScreen.Position.Ticks;
            tbTimeBefor.Text = FormatTime(melScreen.Position);
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            melScreen.Pause();
            _dispatcherTimer.Stop();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            if (_openDlg.ShowDialog() == true)
            {
                _fileNames.Clear();
                _fileNames.AddRange(_openDlg.FileNames);
                _countFilms = _fileNames.Count;

                melScreen.Stop();
                if (_countFilms > 0)
                {
                    _nextFilm = 0;
                    melScreen.Source = new Uri(_fileNames[0]);
                }
                else
                {
                    _nextFilm = -1;
                   
                }
                
                var elColl =  stpExpPlayList.Items;
                elColl.Clear();
                Label label;
                foreach (var item in _openDlg.SafeFileNames)
                {
                    label = new Label();
                    label.Content = item;
                    elColl.Add(label);
                }
            }
        }

        private void NextFilmUp()
        {
            if (_countFilms > 0)
            {
                if (_nextFilm < _countFilms - 1)
                {
                    ++_nextFilm;
                }
            }
        }

        

        private void melScreen_MediaEnded(object sender, RoutedEventArgs e)
        {
            _dispatcherTimer.Stop();
            _playFilm = false;
            Title = "Plaer";
            btnPlay_Click(sender, e);
        }

        private void stpExpPlayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            ListBox lstBox = (ListBox)sender;
            if (lstBox.SelectedItem!=null)
            {
                melScreen.Stop();
                _dispatcherTimer.Stop();
                _playFilm = false;
                Label lb = (Label)lstBox.SelectedItem;
                String elName = lb.Content.ToString();
                int index = _fileNames.FindIndex(p => p.Contains(elName));
                if(index>-1)
                {
                    _nextFilm = index;
                    btnPlay_Click(sender, (RoutedEventArgs)e);
                }
            }
        }

        private void melScreen_MediaOpened(object sender, RoutedEventArgs e)
        {
            melScreen.Volume = sldVolume.Value;
            Title = melScreen.Source.LocalPath;
            _dispatcherTimer.Start();
            _playFilm = true;
           
            Duration medLenght = melScreen.NaturalDuration;
            if (medLenght.HasTimeSpan)
            {
                sldVidio.Minimum = 0;
                sldVidio.Maximum = medLenght.TimeSpan.Ticks;
                tbTimeBefor.Text = FormatTime(medLenght.TimeSpan);
            }
        }

        private void sldVolume_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            melScreen.Volume = sldVolume.Value;
        }

        private void sldVidio_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            melScreen.Pause();
            _dispatcherTimer.Stop();
        }

        private void sldVidio_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {   
            melScreen.Position = new TimeSpan((long)sldVidio.Value);
            _dispatcherTimer.Start();
            melScreen.Play();
        }

        private void expPlayList_Expanded(object sender, RoutedEventArgs e)
        {
            oldSize = grdMedia.ColumnDefinitions[1].Width;
            double size = grdMedia.ColumnDefinitions[0].Width.Value;
            grdMedia.ColumnDefinitions[1].Width = new GridLength(200 * size);
        }

        private void expPlayList_Collapsed(object sender, RoutedEventArgs e)
        {
            grdMedia.ColumnDefinitions[1].Width = oldSize;
        }

        private void expPlayList_MouseLeave(object sender, MouseEventArgs e)
        {
            expPlayList.IsExpanded = false;
        }
        private void expPlayList_MouseMove(object sender, MouseEventArgs e)
        {
            expPlayList.IsExpanded = true;
        }

        private void melScreen_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            _dispatcherTimer.Stop();
            _playFilm = false;
            NextFilmUp();
        }
    }
}
