using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersDAL;
using UsersDAL.Repositories;

namespace Authorization.Forms
{
    public partial class RegistrationForm : Form
    {

        public User UserData { get; private set; }

        private UsersRepository _usersRepository; 

        public RegistrationForm()
        {
            InitializeComponent();
            UserData = new User();
            _usersRepository = new UsersRepository();

            tbLoginRegistration.GotFocus += new System.EventHandler(EventHandlerFoms.tb_GotFocus);
            tbLoginRegistration.LostFocus += new System.EventHandler(EventHandlerFoms.tb_LostFocus);

            tbPassRegistration.GotFocus += new System.EventHandler(EventHandlerFoms.tb_GotFocus);
            tbPassRegistration.LostFocus += new System.EventHandler(EventHandlerFoms.tb_LostFocus);

            tbRepeatPassRegistration.GotFocus += new System.EventHandler(EventHandlerFoms.tb_GotFocus);
            tbRepeatPassRegistration.LostFocus += new System.EventHandler(EventHandlerFoms.tb_LostFocus);

            tbSurnameRegistration.GotFocus += new System.EventHandler(EventHandlerFoms.tb_GotFocus);
            tbSurnameRegistration.LostFocus += new System.EventHandler(EventHandlerFoms.tb_LostFocus);

            tbNameRegistration.GotFocus += new System.EventHandler(EventHandlerFoms.tb_GotFocus);
            tbNameRegistration.LostFocus += new System.EventHandler(EventHandlerFoms.tb_LostFocus);

            tbEmailRegistration.GotFocus += new System.EventHandler(EventHandlerFoms.tb_GotFocus);
            tbEmailRegistration.LostFocus += new System.EventHandler(EventHandlerFoms.tb_LostFocus);

        }

        private bool CheckFields()
        {
            User TmpUser = null;
            if (String.IsNullOrEmpty(tbLoginRegistration.Text) ||
                String.IsNullOrWhiteSpace(tbLoginRegistration.Text) ||
                tbLoginRegistration.Text.Equals((string)tbLoginRegistration.Tag))
                return false;
            TmpUser = _usersRepository.GetByLogin(tbLoginRegistration.Text);
            if (TmpUser != null)
                return false;

            if (String.IsNullOrEmpty(tbEmailRegistration.Text) ||
                String.IsNullOrWhiteSpace(tbEmailRegistration.Text) ||
                tbEmailRegistration.Text.Equals((string)tbEmailRegistration.Tag) ||
                !Service.isValidEmail(tbEmailRegistration.Text))
                return false;
            TmpUser = _usersRepository.GetByEmail(tbEmailRegistration.Text);
            if (TmpUser != null)
                return false;

            if (String.IsNullOrEmpty(tbPassRegistration.Text) ||
                String.IsNullOrWhiteSpace(tbPassRegistration.Text) ||
                tbPassRegistration.Text.Equals((string)tbPassRegistration.Tag) ||
                tbPassRegistration.Text.Length < 8)
                return false;
            if (String.IsNullOrEmpty(tbRepeatPassRegistration.Text) ||
                String.IsNullOrWhiteSpace(tbRepeatPassRegistration.Text) ||
                tbRepeatPassRegistration.Text.Equals((string)tbRepeatPassRegistration.Tag) ||
                !tbRepeatPassRegistration.Text.Equals(tbPassRegistration.Text))
                return false;
            if (tbSurnameRegistration.Text.Equals((string)tbSurnameRegistration.Tag))
                return false;
            if (tbNameRegistration.Text.Equals((string)tbNameRegistration.Tag))
                return false;
            return true;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            this.Owner.Visible = false;
        }

        private void btnOKRegistration_Click(object sender, EventArgs e) //to do
        {
            try
            {
                if (CheckFields())
                {
                    UserData.Login = tbLoginRegistration.Text;
                    UserData.Password = Service.GetHashString(tbPassRegistration.Text);
                    UserData.Surname = tbSurnameRegistration.Text;
                    UserData.Name = tbNameRegistration.Text;
                    UserData.Email = tbEmailRegistration.Text;
                    _usersRepository.Add(UserData);
                    this.Owner.Visible = true;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    this.Owner.Visible = true;
                    DialogResult = DialogResult.No;
                }
            }
            catch (Exception)
            {
                CleanFields();
                this.Owner.Visible = true;
                DialogResult = DialogResult.Ignore;
            }
        }

        private void btnCancelRegistration_Click(object sender, EventArgs e)
        {
            CleanFields();
            this.Owner.Visible = true;
            DialogResult = DialogResult.Cancel;
        }

        private void CleanFields()
        {
            UserData.Login = "";
            UserData.Password = "";
            UserData.Surname = "";
            UserData.Name = "";
            UserData.Email = "";
        }
    }
}
