using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authorization.Forms
{
    public static class EventHandlerFoms
    {
        public static void tb_LostFocus(object sender, EventArgs e)
        {
            TextBox tbSender = (TextBox)sender;
            if (String.IsNullOrEmpty(tbSender.Text) || String.IsNullOrWhiteSpace(tbSender.Text))
            {
                tbSender.Text = (string)tbSender.Tag;
                tbSender.PasswordChar = '\0';
                tbSender.ForeColor = Color.LightGray;
            }
            else
            {
                tbSender.Text = tbSender.Text.Trim();
            }
        }

        public static void tb_GotFocus(object sender, EventArgs e)
        {
            TextBox tbSender = (TextBox)sender;
            if (tbSender.Text.Equals((string)tbSender.Tag))
            {
                tbSender.Text = "";
                tbSender.ForeColor = Color.Black;
                if (tbSender.Name == "tbPassword" ||
                    tbSender.Name == "tbNewPasswordRecoveryPassword" || 
                    tbSender.Name == "tbRepeatPasswordRecoveryPassword" ||
                    tbSender.Name == "tbPassRegistration" || 
                    tbSender.Name == "tbRepeatPassRegistration")
                {
                    tbSender.PasswordChar = '*';
                }
            }
        }

    }
}
