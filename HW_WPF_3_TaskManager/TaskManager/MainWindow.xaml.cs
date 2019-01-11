using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using TaskManager.Repository;

namespace TaskManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        private DispatcherTimer _timer;
        private Process _selectedProcess;
        private ProcessRepository _processRepository;
        private bool _focusOnDg;
       
        public MainWindow()
        {
            InitializeComponent();
            _processRepository = (ProcessRepository)this.TryFindResource("processis");
            _timer = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 1) };
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _processRepository.Refresh();
            if (_selectedProcess != null)
            {
                foreach (var item in dgProcesses.Items)
                {
                    Process tmpItem = (Process)item;
                    if (tmpItem.Id == _selectedProcess.Id)
                    {
                        dgProcesses.SelectedItem = item;
                        if (_focusOnDg)
                        {
                            dgProcesses.Focus();
                        }
                        break;
                    }
                }
            }
        }

        private void dgProcesses_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _timer.Stop();
            _focusOnDg = true;
            if (dgProcesses.SelectedItem != null)
            {
                _selectedProcess = (Process)dgProcesses.SelectedItem;
            }
            _timer.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (dgProcesses.SelectedItem != null)
            {
                Process kill = (Process)dgProcesses.SelectedItem;
                kill.Kill();
            }
        }

        private void btnMainFindProcess_Click(object sender, RoutedEventArgs e)
        {
            if (!_processRepository.FindProcessByName(tbMainFindProcess.Text))
            {
                MessageBox.Show(String.Format("Процесса с именем: {0} не найдено", tbMainFindProcess.Text));
            }
           
        }

        private void btnMainRefresh_Click(object sender, RoutedEventArgs e)
        {
            _processRepository.Reset();
        }
        

        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (!String.IsNullOrEmpty(tbMainFindProcess.Text) && !String.IsNullOrWhiteSpace(tbMainFindProcess.Text))
            {
                try
                {
                    Process.Start(tbMainFindProcess.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введите имя процесса");
            }
            
        }

        private void tbMainFindProcess_GotFocus(object sender, RoutedEventArgs e)
        {
            tbMainFindProcess.Text = "";
            _timer.Stop();
            _focusOnDg = false;
            tbMainFindProcess.Focus();
            _timer.Start();
        }

        private void tbMainFindProcess_MouseUp(object sender, MouseEventArgs e)
        {
            _timer.Stop();
            _focusOnDg = false;
            tbMainFindProcess.Focus();
            tbMainFindProcess.Text = "";
            _timer.Start();
        }

        private void AddTheme(Uri uri)
        {
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }


        private void BtnViewRed_Click(object sender, RoutedEventArgs e)
        {
            var uri = new Uri(@"Themes\ShinyRed.xaml", UriKind.Relative);
            AddTheme(uri);
        }

        private void BtnViewBlue_Click(object sender, RoutedEventArgs e)
        {
            var uri = new Uri(@"Themes\ShinyBlue.xaml", UriKind.Relative);
            AddTheme(uri);
        }

        private void BtnViewGrey_Click(object sender, RoutedEventArgs e)
        {
            var uri = new Uri(@"Themes\ExpressionLight.xaml", UriKind.Relative);
            AddTheme(uri);
        }
        private void RibbonApplicationMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
