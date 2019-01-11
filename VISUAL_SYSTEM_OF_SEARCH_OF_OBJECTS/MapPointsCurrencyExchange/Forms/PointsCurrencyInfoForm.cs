using CurrencyExchangeDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkWithXML;

namespace MapPointsCurrencyExchange.Forms
{
    public partial class PointsCurrencyInfoForm : Form
    {
        public PointCurrencyExchange PointCurrency { get; private set; }
        private bool IsAdd;
        private WorkerXML XMLWorker;
        private BindingList<ServiceType> _oldService;
        private BindingList<Comment> _oldComments;
       

        public PointsCurrencyInfoForm(PointCurrencyExchange PointCur, bool AddOrEdit)
        {
            InitializeComponent();
           
            XMLWorker = new WorkerXML();
            if (PointCur != null)
            {
                PointCurrency = PointCur;
            }
            else
            {
                PointCurrency = new PointCurrencyExchange();
            }
            _oldService = new BindingList<ServiceType>();
            
            _oldComments = new BindingList<Comment>();
            IsAdd = AddOrEdit;
            InitField();
            
        }

        private void InitField()
        {
            cmbBankName.DataSource = XMLWorker.GetBankName();
            if (IsAdd)
            {
                btnOK.Text = "Добавить";
                this.Text = "Добавить новый обменник";
            }
            else
            {
                btnOK.Text = "Сохранить";
                int index = cmbBankName.FindString(PointCurrency.Bank.Name);
                if (index > -1)
                {
                    cmbBankName.SelectedIndex = index;
                }

                if (!String.IsNullOrEmpty(PointCurrency.Name) && !String.IsNullOrWhiteSpace(PointCurrency.Name))
                {
                    this.Text += ": " + PointCurrency.Name;
                    tbName.Text = PointCurrency.Name;
                }
                if (!String.IsNullOrEmpty(PointCurrency.TelephonNumber) && !String.IsNullOrWhiteSpace(PointCurrency.TelephonNumber))
                {
                    tbPhone.Text = PointCurrency.TelephonNumber;
                }
                if (PointCurrency.Сashier != null)
                {
                    tbCashierName.Text = PointCurrency.Сashier.Name;
                    tbCashierLastName.Text = PointCurrency.Сashier.Surname;
                    if (PointCurrency.Сashier.Сategory>0)
                    {
                        tbCashierCategory.Text = PointCurrency.Сashier.Сategory.ToString();
                    }
                }
                if (!String.IsNullOrEmpty(PointCurrency.TimeOfWork) && !String.IsNullOrWhiteSpace(PointCurrency.TimeOfWork))
                {
                    tbTimeWork.Text = PointCurrency.TimeOfWork;
                }
                if (!String.IsNullOrEmpty(PointCurrency.AdditionalInfo) && !String.IsNullOrWhiteSpace(PointCurrency.AdditionalInfo))
                {
                    tbAdditionalInfo.Text = PointCurrency.AdditionalInfo;
                }
                if (!String.IsNullOrEmpty(PointCurrency.Address) && !String.IsNullOrWhiteSpace(PointCurrency.Address))
                {
                    tbAdress.Text = PointCurrency.Address;
                }

            }
            if (PointCurrency.OpenDate.Equals(new DateTime()))
            {
                dtpOpenDate.Value = DateTime.Now;
            }
            else
            {
                dtpOpenDate.Value = PointCurrency.OpenDate;
            }
            listServeses.DataSource = PointCurrency.ServicesType;
            lstComments.DataSource = PointCurrency.Comments;
            tbX.Text = String.Format("{0}",PointCurrency.Coordinates.Latitude);
            tbY.Text = String.Format("{0}", PointCurrency.Coordinates.Longitude);
            foreach (var item in PointCurrency.Comments)
            {
                _oldComments.Add(new Comment
                {
                    Id = item.Id,
                    Author = String.Copy(item.Author),
                    Contents = String.Copy(item.Contents),
                    Data = new DateTime(item.Data.Ticks)
                });
            }
            foreach (var item in PointCurrency.ServicesType)
            {
                _oldService.Add(new ServiceType { Id = item.Id, Name = String.Copy(item.Name) });
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            PointCurrency.Name = tbName.Text;
            if (cmbBankName.SelectedItem != null)
            {
                string Item = cmbBankName.SelectedItem as string;
                List<Bank> lstBanks = XMLWorker.GetBanks();
                int ind = lstBanks.FindIndex(el => el.Name.Equals(Item));
                if (ind > -1)
                {
                    PointCurrency.Bank = lstBanks[ind];
                }
                else
                {
                    PointCurrency.Bank = new Bank()
                    { Name = Item };
                }
            }
            else
            {
                MessageBox.Show("Выберите банк");
                return;
            }
            PointCurrency.TelephonNumber = tbPhone.Text;
            PointCurrency.Address = tbAdress.Text;
            PointCurrency.OpenDate = dtpOpenDate.Value;
            if (PointCurrency.Сashier == null)
            {
                PointCurrency.Сashier = new Сashier();
            }
            PointCurrency.Сashier.Name = tbCashierName.Text;
            PointCurrency.Сashier.Surname = tbCashierLastName.Text;
            try
            {
                PointCurrency.Сashier.Сategory = int.Parse(tbCashierCategory.Text);
            }
            catch (Exception)
            {
                PointCurrency.Сashier.Сategory = 0;
            }

            if (!String.IsNullOrEmpty(tbX.Text)
                && !String.IsNullOrWhiteSpace(tbX.Text))
            {
                try
                {
                    PointCurrency.Coordinates.Latitude = Double.Parse(tbX.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректная широта");
                    return;
                }

            }
            else
            {
                PointCurrency.Coordinates.Latitude = 0;
            }

            if (!String.IsNullOrEmpty(tbY.Text)
                && !String.IsNullOrWhiteSpace(tbY.Text))
            {
                try
                {
                    PointCurrency.Coordinates.Longitude = Double.Parse(tbY.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректная долгота");
                    return;
                }
            }
            else
            {
                PointCurrency.Coordinates.Longitude = 0;
            }

            PointCurrency.TimeOfWork = tbTimeWork.Text;
            PointCurrency.AdditionalInfo = tbAdditionalInfo.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnAddServes_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbServes.Text) 
                && !String.IsNullOrWhiteSpace(tbServes.Text))
            {
                PointCurrency.ServicesType.Add(new ServiceType() { Name = tbServes.Text });

                tbServes.Text = "";
            }
        }

        private void btnRemouveServes_Click(object sender, EventArgs e)
        {
            if (listServeses.SelectedItem != null)
            {
                ServiceType removeItem = listServeses.SelectedItem as ServiceType;
                BindingList<ServiceType> serviceTypes = (BindingList<ServiceType>)PointCurrency.ServicesType;
                serviceTypes.Remove(removeItem);
                serviceTypes.ResetBindings();
            }
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            bool Iscontinue = false;
            Comment newComment = new Comment();
            if (!String.IsNullOrEmpty(tbComments.Text)
                && !String.IsNullOrWhiteSpace(tbComments.Text))
            {
                newComment.Contents = tbComments.Text;
                tbComments.Text = "";
                Iscontinue = true;
            }
            if (!String.IsNullOrEmpty(tbComentsAuthor.Text)
                && !String.IsNullOrWhiteSpace(tbComentsAuthor.Text))
            {
                newComment.Author = tbComments.Text;
                tbComentsAuthor.Text = "Имя автора";
                Iscontinue = true;
            }
            if (Iscontinue)
            {
                newComment.Data = DateTime.Now;
                PointCurrency.Comments.Add(newComment);
            }
        }

        private void btnRemoveComent_Click(object sender, EventArgs e)
        {
            if (lstComments.SelectedItem != null)
            {
                Comment removeItem = lstComments.SelectedItem as Comment;
                BindingList<Comment> comments = (BindingList<Comment>)PointCurrency.Comments;
                comments.Remove(removeItem);
                comments.ResetBindings();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PointCurrency.ServicesType = new BindingList<ServiceType>(_oldService);
            PointCurrency.Comments = new BindingList<Comment>(_oldComments);
        }
    }
}
