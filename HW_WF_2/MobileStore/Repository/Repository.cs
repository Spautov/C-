using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.Repository
{
    public class Repository<T>
    {
        private string _faileName;
        public Repository(string faileName)
        {
            _faileName = faileName;
        }
        
        public BindingList<T> GetInfo()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            BindingList<T> lstData;
            FileStream fs = new FileStream(_faileName, FileMode.OpenOrCreate);
            try
            {
                lstData = (BindingList<T>)formatter.Deserialize(fs);
            }
            catch (Exception)
            {
                lstData = new BindingList<T>();
            }
            finally
            {
                fs.Close();
            }

            return lstData;
        }
        public void Save(BindingList<T> lstData)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(_faileName, FileMode.OpenOrCreate))
            {
                if (lstData == null)
                {
                    lstData = new BindingList<T>();
                }
                formatter.Serialize(fs, lstData);
            }
        }
    }
}
