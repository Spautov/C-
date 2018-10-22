using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BestOil.Entities;
using BestOil.Repository;

namespace BestOil
{
    public partial class AZSForm : Form
    {
        AZSRepository _repository;
        double _allDaySumm;
        double _FuelCount;
        double _FuelSumm;
        double _CafePriceHotDog;
        int _CafeCountHotDog;
        double _CafePriceGamb;
        int _CafeCountGamb;
        double _CafePriceCheesb;
        int _CafeCountCheesb;
        double _CafePriceCocacola;
        int _CafeCountCocacola;
      
        public AZSForm()
        {
            _repository = new AZSRepository();
            InitializeComponent();
        }

        private void AZSForm_Load(object sender, EventArgs e)
        {
            cmbFuelType.DisplayMember = "Name";
            cmbFuelType.DataSource = _repository.GetFuelInfo();
        }

        private void cmbFuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFuelType.SelectedItem != null)
            {
                FuelInfo select = (FuelInfo)cmbFuelType.SelectedItem;
                tbFuelPrice.Text = select.Price.ToString("N2");
            }
        }

        private void radFuelCount_CheckedChanged(object sender, EventArgs e)
        {
            if(radFuelCount.Checked)
            {
                tbFuelCount.Enabled = true;
                tbFuelSumm.Enabled = false;
                tbFuelSumm.Clear();
                lbFuelForPayment.Text = "К оплате";
                lbFuelBYNForPayment.Text = "руб.";
            }
        }

        private void radFuelSumm_CheckedChanged(object sender, EventArgs e)
        {
            if (radFuelSumm.Checked)
            {
                tbFuelCount.Enabled = false;
                tbFuelCount.Clear();
                tbFuelSumm.Enabled = true;
                lbFuelForPayment.Text = "К выдаче";
                lbFuelBYNForPayment.Text = "л.";
            }

        }

        
        private void tbFuelCount_TextChanged(object sender, EventArgs e)
        {
            TextBox tbTmp = (TextBox)sender;
            try
            {
                _FuelCount = double.Parse(tbTmp.Text);

            }
            catch (Exception)
            {
                tbTmp.Clear();
                _FuelCount = 0;
            }
        }

        private void tbFuelSumm_TextChanged(object sender, EventArgs e)
        {
            TextBox tbTmp = (TextBox)sender;
            try
            {
                _FuelSumm = double.Parse(tbTmp.Text);

            }
            catch (Exception)
            {
                tbTmp.Clear();
                _FuelSumm = 0;
            }
        }

        private void chkCafeHotDog_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCafeHotDog.Checked)
            {
                tbCafePriceHotDog.Enabled = true;
                tbCafeCountHotDog.Enabled = true;
            }
            else
            {
                tbCafePriceHotDog.Enabled = false;
                tbCafePriceHotDog.Clear();
                tbCafeCountHotDog.Enabled = false;
                tbCafeCountHotDog.Clear();
            }
        }

        private void chkCafeGamb_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCafeGamb.Checked)
            {
                tbCafePriceGamb.Enabled = true;
                tbCafeCountGamb.Enabled = true;
            }
            else
            {
                tbCafePriceGamb.Enabled = false;
                tbCafePriceGamb.Clear();
                tbCafeCountGamb.Enabled = false;
                tbCafeCountGamb.Clear();
            }
        }

        private void chkCafeCheesb_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCafeCheesb.Checked)
            {
                tbCafePriceCheesb.Enabled = true;
                tbCafeCountCheesb.Enabled = true;
            }
            else
            {
                tbCafePriceCheesb.Enabled = false;
                tbCafePriceCheesb.Clear();
                tbCafeCountCheesb.Enabled = false;
                tbCafeCountCheesb.Clear();
            }
        }

        private void chkCafeCocacola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCafeCocacola.Checked)
            {
                tbCafePriceCocacola.Enabled = true;
                tbCafeCountCocacola.Enabled = true;
            }
            else
            {
                tbCafePriceCocacola.Enabled = false;
                tbCafePriceCocacola.Clear();
                tbCafeCountCocacola.Enabled = false;
                tbCafeCountCocacola.Clear();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double valueFuelForPayment = 0;
            double valueCafeForPayment = 0;
            double AllSumm = 0;

            FuelInfo fuelInfo = (FuelInfo)cmbFuelType.SelectedItem;
            if (radFuelCount.Checked && fuelInfo != null)
            {
                valueFuelForPayment = _FuelCount * fuelInfo.Price;
                AllSumm = valueFuelForPayment;
                tbFuelForPayment.Text = String.Format("{0:N2}", valueFuelForPayment);//fuelSumm.ToString();
            }
            else if (radFuelSumm.Checked && fuelInfo != null)
            {
                valueFuelForPayment = _FuelSumm / fuelInfo.Price;
                AllSumm = _FuelSumm;
                tbFuelForPayment.Text = String.Format("{0:N2}", valueFuelForPayment);//countFuel.ToString();
            }
            valueCafeForPayment = (_CafePriceHotDog * _CafeCountHotDog) +
                                    (_CafePriceGamb * _CafeCountGamb) +
                                    (_CafePriceCheesb * _CafeCountCheesb) +
                                    (_CafePriceCocacola * _CafeCountCocacola);
            tbCafeForPayment.Text = String.Format("{0:N2}", valueCafeForPayment);
            AllSumm += valueCafeForPayment;
            tbTotal.Text = String.Format("{0:N2}", AllSumm);
            _allDaySumm += AllSumm;
           

        }

        private void tbCafePriceHotDog_TextChanged(object sender, EventArgs e)
        {
            TextBox tbTmp = (TextBox)sender;
            try
            {
                _CafePriceHotDog = double.Parse(tbTmp.Text);
            }
            catch (Exception)
            {
                tbTmp.Clear();
                _CafePriceHotDog = 0;
            }

        }

        private void tbCafeCountHotDog_TextChanged(object sender, EventArgs e)
        {
            TextBox tbTmp = (TextBox)sender;
            try
            {
                _CafeCountHotDog = int.Parse(tbTmp.Text);

            }
            catch (Exception)
            {
                tbTmp.Clear();
                _CafeCountHotDog = 0;
            }
        }

        private void tbCafePriceGamb_TextChanged(object sender, EventArgs e)
        {
            TextBox tbTmp = (TextBox)sender;
            try
            {
                _CafePriceGamb = double.Parse(tbTmp.Text);

            }
            catch (Exception)
            {
                tbTmp.Clear();
                _CafePriceGamb = 0;
            }

        }

        private void tbCafeCountGamb_TextChanged(object sender, EventArgs e)
        {
            TextBox tbTmp = (TextBox)sender;
            try
            {
                _CafeCountGamb = int.Parse(tbTmp.Text);

            }
            catch (Exception)
            {
                tbTmp.Clear();
                _CafeCountGamb = 0;
            }
        }

        private void tbCafePriceCheesb_TextChanged(object sender, EventArgs e)
        {
            TextBox tbTmp = (TextBox)sender;
            try
            {
                _CafePriceCheesb = double.Parse(tbTmp.Text);

            }
            catch (Exception)
            {
                tbTmp.Clear();
                _CafePriceCheesb = 0;
            }
        }

        private void tbCafeCountCheesb_TextChanged(object sender, EventArgs e)
        {
            TextBox tbTmp = (TextBox)sender;
            try
            {
                _CafeCountCheesb = int.Parse(tbTmp.Text);

            }
            catch (Exception)
            {
                tbTmp.Clear();
                _CafeCountCheesb = 0;
            }
        }

        private void tbCafePriceCocacola_TextChanged(object sender, EventArgs e)
        {
            TextBox tbTmp = (TextBox)sender;
            try
            {
                _CafePriceCocacola = double.Parse(tbTmp.Text);

            }
            catch (Exception)
            {
                tbTmp.Clear();
                _CafePriceCocacola = 0;
            }
        }

        private void tbCafeCountCocacola_TextChanged(object sender, EventArgs e)
        {
            TextBox tbTmp = (TextBox)sender;
            try
            {
                _CafeCountCocacola = int.Parse(tbTmp.Text);

            }
            catch (Exception)
            {
                tbTmp.Clear();
                _CafeCountCocacola = 0;
            }
        }

        private void AZSForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string message = String.Format("Выручка за день составила {0:N2} руб.", _allDaySumm);
            MessageBox.Show(message, "Дневная выручка", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
