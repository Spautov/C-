using Authorization.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersDAL;
using UsersDAL.Repositories;

namespace Authorization
{
    public partial class MainForm : Form
    {

        private UsersRepository _usersRepository;
        private SessionsRepository _sessionsRepository;
        private User FoundUser { get; set; }



        public MainForm()
        {
            InitializeComponent();
            _usersRepository = new UsersRepository();
            _sessionsRepository = new SessionsRepository();

            tbLogin.GotFocus += new System.EventHandler(EventHandlerFoms.tb_GotFocus);
            tbLogin.LostFocus += new System.EventHandler(EventHandlerFoms.tb_LostFocus);

            tbPassword.GotFocus += new System.EventHandler(EventHandlerFoms.tb_GotFocus);
            tbPassword.LostFocus += new System.EventHandler(EventHandlerFoms.tb_LostFocus);

        }


        private void lbRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbErrorLogIn.Visible = false;
            if (!bgWorkerLogin.IsBusy)
            {
                RegistrationForm RegForm = new RegistrationForm();
                RegForm.Owner = this;

                DialogResult ResRegForm = RegForm.ShowDialog();
                if (ResRegForm == DialogResult.OK)
                {
                    tbErrorLogIn.Visible = true;
                    tbErrorLogIn.Text = "Пользователь " + RegForm.UserData.Login + " зарегистроирован";
                }
                else if (ResRegForm == DialogResult.Ignore)
                {
                    tbErrorLogIn.Visible = true;
                    tbErrorLogIn.Text = "Ошибка при подключении к базе данных";
                }
                else if (ResRegForm == DialogResult.No)
                {
                    tbErrorLogIn.Visible = true;
                    tbErrorLogIn.Text = "Пользователь не зарегестрирован, проверьте данные";
                }
            }

        }

        private void lbRecoveryPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbErrorLogIn.Visible = false;
            if (!bgWorkerLogin.IsBusy)
            {
                RecoveryPasswordForm RecPassForm = new RecoveryPasswordForm(_usersRepository);
                RecPassForm.Owner = this;
                DialogResult Res = RecPassForm.ShowDialog();
                if (Res == DialogResult.No)
                {
                    tbErrorLogIn.Visible = true;
                    tbErrorLogIn.Text = "Пароль не восстановлен";
                }
                else if (Res == DialogResult.OK)
                {
                    tbErrorLogIn.Visible = true;
                    tbErrorLogIn.Text = "Пароль восстановлен";
                }
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            tbErrorLogIn.Visible = false;
            tbErrorLogIn.Text = "";
            if (tbLogin.Text.Equals((string)tbLogin.Tag)
                || tbPassword.Text.Equals((string)tbPassword.Tag)
                || tbPassword.Text.Length < 8)
            {
                tbErrorLogIn.Visible = true;
                tbErrorLogIn.Text = "Проверте введенные данные";
            }
            else
            {
                if (!bgWorkerLogin.IsBusy)
                {
                    bgWorkerLogin.RunWorkerAsync();
                    prgLogin.Style = ProgressBarStyle.Marquee;
                    prgLogin.MarqueeAnimationSpeed = 2;
                    prgLogin.Value = 0;
                }
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e) // to do
        {
            FoundUser = null;
            try
            {
                FoundUser = _usersRepository.GetByLogin(tbLogin.Text);
            }
            catch (Exception ex)
            {
                tbErrorLogIn.Visible = true;
                tbErrorLogIn.Text = "Ошибка подключения к базе данных";
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            prgLogin.Style = ProgressBarStyle.Blocks;
            prgLogin.Value = 100;
            if (FoundUser != null)
            {
                if (FoundUser.Password.Equals(Service.GetHashString(tbPassword.Text)))
                {
                    AchievementForm AchevForm = new AchievementForm(FoundUser);
                    AchevForm.Owner = this;
                    AchevForm.Show();
                }
                else
                {
                    tbErrorLogIn.Visible = true;
                    tbErrorLogIn.Text = "Неверный пароль";
                }

            }
            else
            {
                tbErrorLogIn.Visible = true;
                tbErrorLogIn.Text = "Пользавотель с такими данными не зарегестрирован";
            }

        }
        

    }
}
