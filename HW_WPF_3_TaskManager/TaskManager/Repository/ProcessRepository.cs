using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace TaskManager.Repository
{
    class ProcessRepository 
    {
        private ObservableCollection<Process> _processes;
        public ObservableCollection<Process> Processes => _processes;
        private string _findProcessName;
        public ProcessRepository()
        {
            _processes = new ObservableCollection<Process>(Process.GetProcesses());
        }

        public bool FindProcessByName(string name)
        {
            if (!String.IsNullOrEmpty(name) && !String.IsNullOrWhiteSpace(name))
            {
                var ProcColl = Process.GetProcessesByName(name);
                if (ProcColl.Count()>0)
                {
                    _findProcessName = name;
                    _processes.Clear();
                    foreach (var item in ProcColl)
                    {
                        _processes.Add(item);
                    }
                    return true;
                }
            }
            return false;
        }
        
        public void Reset()
        {
            _findProcessName = "";
            Refresh();
        }


        public void Refresh()
        {
            Process[] procColl = null;
            if (!String.IsNullOrEmpty(_findProcessName) && !String.IsNullOrWhiteSpace(_findProcessName))
            {
                procColl = Process.GetProcessesByName(_findProcessName);
            }
            else
            {
                procColl = Process.GetProcesses();
            }
            _processes.Clear();
            if (procColl != null)
            {
                foreach (var item in procColl)
                {
                    _processes.Add(item);
                }
            }

        }
    }
}
