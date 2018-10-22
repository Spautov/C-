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
    public class OptionsRepository
    {
        public BindingList<string> GetOptionsInfo()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            BindingList<string> options;
            FileStream fs = new FileStream("phoneOptions.dat", FileMode.OpenOrCreate);
            try
            {
                options = (BindingList<string>)formatter.Deserialize(fs);
            }
            catch(Exception)
            {
                options = new BindingList<string>();
            }
            finally
            {
                fs.Close();
            }

            return options;
        }
        public void SaveOptions(BindingList<string> options)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("phoneOptions.dat", FileMode.OpenOrCreate))
            {
                if (options == null)
                {
                    options = new BindingList<string>();
                }
                formatter.Serialize(fs, options);
            }
        }
    }
}
