using MobileStore.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using MobileStore.Entities;
using System.Windows.Forms;


namespace MobileStore
{
    public partial class MainForm : Form
    {
        
        private Repository<Phone> _phoneRepository;
        private Repository<String> _optionsRepository;
       
        public MainForm()
        {
            _phoneRepository = new Repository<Phone>("phone.dat");
            _optionsRepository = new Repository<String>("phoneOptions.dat");
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lstListOfPhones.DataSource = _phoneRepository.GetInfo();
            
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            BindingList<Phone> lstPhone = (BindingList<Phone>)lstListOfPhones.DataSource;
            _phoneRepository.Save(lstPhone);
            BindingList<string> lstOptions = (BindingList<string>) lstOptionsEdit.DataSource;
            _optionsRepository.Save(lstOptions);
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            lstListOfPhones.DataSource = _phoneRepository.GetInfo();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (lstListOfPhones.SelectedItem != null)
            {
                BindingList<Phone> lstPhone = (BindingList<Phone>)lstListOfPhones.DataSource;
                Phone tmpPhone = (Phone)lstListOfPhones.SelectedItem;
                lstPhone.Remove(tmpPhone);
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            BindingList<Phone> lstPhone = (BindingList<Phone>)lstListOfPhones.DataSource;
            lstPhone.Clear();
        }

        private void lstListOfPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingList<Phone> lstPhone = (BindingList<Phone>)lstListOfPhones.DataSource;
           
            Phone tmpPhone = (Phone)lstListOfPhones.SelectedItem;
            if (tmpPhone != null)
            {
                tbModelPhoneEdit.Text = tbModelPhoneInfo.Text = tmpPhone.Model;
                tbOsPhoneEdit.Text = tbOsPhoneInfo.Text = tmpPhone.Os;
                tbCPUPhoneEdit.Text = tbCPUPhoneInfo.Text = tmpPhone.CPU;
                tbPricePhoneEdit.Text = tbPricePhoneInfo.Text = String.Format("{0:N2}", tmpPhone.Price);
                if (String.IsNullOrEmpty(tmpPhone.ImagePath) || String.IsNullOrWhiteSpace(tmpPhone.ImagePath))
                {
                    tmpPhone.ImagePath = @"nophoto.jpeg";

                }
                if (tmpPhone.ImagePath.Equals("nophoto.jpeg"))
                {
                    tbImagePhoneEdit.Text = "";
                }
                else
                {
                    tbImagePhoneEdit.Text = tmpPhone.ImagePath;
                }
                pctImagePhoneInfo.ImageLocation = tmpPhone.ImagePath;

                lstOptionsEdit.DataSource = _optionsRepository.GetInfo();
                lstOtionsInfo.DataSource = tmpPhone.Options;
                BindingList<string> lstOptionsEd = (BindingList<string>)lstOptionsEdit.DataSource;
                BindingList<string> lstOptionsInf = (BindingList<string>)lstOtionsInfo.DataSource;
                for (int i = 0; i < lstOptionsEd.Count; i++)
                {
                    lstOptionsEdit.SetItemChecked(i, false);
                }
                foreach (string item in lstOptionsInf)
                {
                    int Ind = lstOptionsEd.IndexOf(item);
                    if (Ind == -1)
                    {
                        lstOptionsEd.Add(item);
                    }
                }
                foreach (string item in lstOptionsInf)
                {
                    int Ind = lstOptionsEd.IndexOf(item);
                    if (Ind > -1)
                    {
                        lstOptionsEdit.SetItemChecked(Ind, true);
                    }
                }
            }
            else
            {
                tbModelPhoneInfo.Text = "";
                tbOsPhoneInfo.Text = "";
                tbCPUPhoneInfo.Text = "";
                tbPricePhoneInfo.Text = "";
                pctImagePhoneInfo.ImageLocation = "nophoto.jpeg";
            }
            
        }

        private void btnAddNewPhoneEdit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbModelPhoneEdit.Text)&& !String.IsNullOrWhiteSpace(tbModelPhoneEdit.Text))
            {
                Phone newPhone = new Phone();
                newPhone.CPU = tbCPUPhoneEdit.Text;
                newPhone.Model = tbModelPhoneEdit.Text;
                newPhone.Os = tbOsPhoneEdit.Text;
                newPhone.ImagePath = tbImagePhoneEdit.Text;
                if (!String.IsNullOrEmpty(tbPricePhoneEdit.Text) && !String.IsNullOrWhiteSpace(tbPricePhoneEdit.Text))
                {
                    newPhone.Price = Double.Parse(tbPricePhoneEdit.Text);
                }
                else
                {
                    newPhone.Price = 0.0;
                }
                BindingList<Phone> lstPhone = (BindingList<Phone>)lstListOfPhones.DataSource;
                lstPhone.Add(newPhone);
            }
            else
            {
                MessageBox.Show("Поле \"Модель\" телефона должно быть заполнено", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnClearEdit_Click(object sender, EventArgs e)
        {
            tbCPUPhoneEdit.Clear();
            tbModelPhoneEdit.Clear();
            tbOsPhoneEdit.Clear();
            tbImagePhoneEdit.Clear();
            tbPricePhoneEdit.Clear();
        }

        private void btnSaveChangesEdit_Click(object sender, EventArgs e)
        {
            BindingList<Phone> lstPhone = (BindingList<Phone>)lstListOfPhones.DataSource;
            Phone tmpPhone = (Phone)lstListOfPhones.SelectedItem;
            tbModelPhoneInfo.Text = tmpPhone.Model = tbModelPhoneEdit.Text;
            tbOsPhoneInfo.Text = tmpPhone.Os = tbOsPhoneEdit.Text;
            tbCPUPhoneInfo.Text = tmpPhone.CPU = tbCPUPhoneEdit.Text;
            tbPricePhoneInfo.Text = tbPricePhoneEdit.Text;
            tmpPhone.Price = Double.Parse(tbPricePhoneEdit.Text);
            tmpPhone.ImagePath = tbImagePhoneEdit.Text;
            tmpPhone.Options.Clear();
            foreach (string item in lstOptionsEdit.CheckedItems)
            {
                tmpPhone.Options.Add(item);
            }
            
            _phoneRepository.Save(lstPhone);
            lstPhone.ResetBindings();

        }

        private void tbImagePhoneEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpg|*.jpg|bmp|*.bmp|jpeg|*.jpeg|png|*.png";
            openFileDialog.Title = "Выберите изображение";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbImagePhoneEdit.Text = openFileDialog.SafeFileName;
            }
            pctImagePhoneInfo.ImageLocation = tbImagePhoneEdit.Text;
        }

        private void btnAddOptionEdit_Click(object sender, EventArgs e)
        {
            BindingList<string> lstOptionsEd = (BindingList<string>)lstOptionsEdit.DataSource;
            if (!String.IsNullOrEmpty(tbNameOptionEdit.Text) && !String.IsNullOrWhiteSpace(tbNameOptionEdit.Text))
            {
                lstOptionsEd.Add(tbNameOptionEdit.Text);
            }
        }

        private void btnDeleteOptionEdit_Click(object sender, EventArgs e)
        {
            if (lstOptionsEdit.SelectedItem != null)
            {
                BindingList<string> lstOptions = (BindingList<string>)lstOptionsEdit.DataSource;
                string tmpOption = (string)lstOptionsEdit.SelectedItem;
                lstOptions.Remove(tmpOption);
            }
        }

        private void tbPricePhoneEdit_TextChanged(object sender, EventArgs e)
        {
            TextBox tbTmp = (TextBox)sender;

            decimal count;
            try
            {
                count = decimal.Parse(tbTmp.Text);

            }
            catch (Exception)
            {
                tbTmp.Clear();
            }
        }
    }
}
