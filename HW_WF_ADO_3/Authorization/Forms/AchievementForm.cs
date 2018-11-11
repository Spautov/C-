using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersDAL;
using UsersDAL.Repositories;

namespace Authorization.Forms
{
    public partial class AchievementForm : Form
    {
        public User UserData { get; set; }
        private System.DateTime SessionBegin { get; set; }
        
        private IRepository<Session> _sessionsRepository;

        

        public AchievementForm(User userData)
        {
            InitializeComponent();
            SessionBegin = System.DateTime.Now;
            _sessionsRepository = new SessionsRepository();
            UserData = userData;
            tbInfoAchievement.Text =
                  "Логин: " + UserData.Login + Environment.NewLine
                + "Фамилия: " + UserData.Surname + Environment.NewLine
                + "Имя: " + UserData.Name + Environment.NewLine
                + "E-mail: " + UserData.Email;
        }

        private void btnOKAchievement_Click(object sender, EventArgs e)
        {
            Session NewSession = new Session();
            NewSession.UserId = UserData.UserId;
            NewSession.SessionBegin = SessionBegin;
            NewSession.SessionEnd = System.DateTime.Now;
            try
            {
                _sessionsRepository.Add(NewSession);//to do 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к базе данных. Данные не записаны в базу данных.");
                
            }
            
            this.Owner.Visible = true;
            DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void AchievementForm_Load(object sender, EventArgs e)
        {
            this.Owner.Visible = false;
        }
    }
}
