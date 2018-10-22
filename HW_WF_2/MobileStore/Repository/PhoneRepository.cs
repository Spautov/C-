using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using MobileStore.Entities;

namespace MobileStore.Repository
{
    public class PhoneRepository
    {
        public BindingList<Phone> GetPhoneInfo()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            BindingList<Phone> phones;
            FileStream fs = new FileStream("phone.dat", FileMode.OpenOrCreate);
            try
            {
                phones = (BindingList<Phone>)formatter.Deserialize(fs);
            }
            catch (Exception)
            {
                phones = new BindingList<Phone>();
            }
            finally
            {
                fs.Close();
            }

            return phones;
        }
        public void SavePhone(BindingList<Phone> phones)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("phone.dat", FileMode.OpenOrCreate))
            {
                if (phones == null)
                {
                    phones = new BindingList<Phone>();
                }
                formatter.Serialize(fs, phones);
            }
        }
    }
}
