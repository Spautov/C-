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
    public partial class RecoveryPasswordForm : Form
    {
        private UsersRepository _usersRepository;

        public RecoveryPasswordForm(IRepository<User> usersRepository)
        {
            _usersRepository = (UsersRepository)usersRepository;
            InitializeComponent();

            tbEmailRecoveryPassword.GotFocus += new System.EventHandler(EventHandlerFoms.tb_GotFocus);
            tbEmailRecoveryPassword.LostFocus += new System.EventHandler(EventHandlerFoms.tb_LostFocus);

            tbNewPasswordRecoveryPassword.GotFocus += new System.EventHandler(EventHandlerFoms.tb_GotFocus);
            tbNewPasswordRecoveryPassword.LostFocus += new System.EventHandler(EventHandlerFoms.tb_LostFocus);

            tbRepeatPasswordRecoveryPassword.GotFocus += new System.EventHandler(EventHandlerFoms.tb_GotFocus);
            tbRepeatPasswordRecoveryPassword.LostFocus += new System.EventHandler(EventHandlerFoms.tb_LostFocus);

        }

        private bool CheckFields()
        {
            if (String.IsNullOrEmpty(tbEmailRecoveryPassword.Text) ||
                String.IsNullOrWhiteSpace(tbEmailRecoveryPassword.Text) ||
                !Service.isValidEmail(tbEmailRecoveryPassword.Text))
                return false;

            if (String.IsNullOrEmpty(tbNewPasswordRecoveryPassword.Text) ||
                String.IsNullOrWhiteSpace(tbNewPasswordRecoveryPassword.Text) ||
                tbNewPasswordRecoveryPassword.Text.Length < 8)
                return false;

            if (String.IsNullOrEmpty(tbRepeatPasswordRecoveryPassword.Text) ||
                String.IsNullOrWhiteSpace(tbRepeatPasswordRecoveryPassword.Text))
                return false;

            if (!tbNewPasswordRecoveryPassword.Text.Equals(tbRepeatPasswordRecoveryPassword.Text))
                return false;

            return true;
        }

        private void btnOKRecoveryPassword_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                try
                {
                    User TmpUser = _usersRepository.GetByEmail(tbEmailRecoveryPassword.Text);
                    if (TmpUser != null)
                    {
                        TmpUser.Password = Service.GetHashString(tbNewPasswordRecoveryPassword.Text);
                        _usersRepository.Save();
                        this.Owner.Visible = true;
                        DialogResult = DialogResult.OK;
                    }//to do
                }
                catch (Exception ex)
                {
                    this.Owner.Visible = true;
                    DialogResult = DialogResult.No;
                }
            }
            else
            {
                this.Owner.Visible = true;
                DialogResult = DialogResult.No;
            }
        }

        private void btnCancelRecoveryPassword_Click(object sender, EventArgs e)
        {
            this.Owner.Visible = true;
            DialogResult = DialogResult.Cancel;
        }

        private void RecoveryPasswordForm_Load(object sender, EventArgs e)
        {
            this.Owner.Visible = false;
        }
    }
}
