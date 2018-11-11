namespace Authorization
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAuthorizationParameters = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.pctAuthorization = new System.Windows.Forms.PictureBox();
            this.lbRecoveryPassword = new System.Windows.Forms.LinkLabel();
            this.lbRegistration = new System.Windows.Forms.LinkLabel();
            this.tbErrorLogIn = new System.Windows.Forms.TextBox();
            this.prgLogin = new System.Windows.Forms.ProgressBar();
            this.bgWorkerLogin = new System.ComponentModel.BackgroundWorker();
            this.grpAuthorizationParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAuthorization)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAuthorizationParameters
            // 
            this.grpAuthorizationParameters.Controls.Add(this.btnEnter);
            this.grpAuthorizationParameters.Controls.Add(this.tbPassword);
            this.grpAuthorizationParameters.Controls.Add(this.lbPassword);
            this.grpAuthorizationParameters.Controls.Add(this.tbLogin);
            this.grpAuthorizationParameters.Controls.Add(this.lbLogin);
            this.grpAuthorizationParameters.Location = new System.Drawing.Point(296, 15);
            this.grpAuthorizationParameters.Margin = new System.Windows.Forms.Padding(4);
            this.grpAuthorizationParameters.Name = "grpAuthorizationParameters";
            this.grpAuthorizationParameters.Padding = new System.Windows.Forms.Padding(4);
            this.grpAuthorizationParameters.Size = new System.Drawing.Size(330, 215);
            this.grpAuthorizationParameters.TabIndex = 0;
            this.grpAuthorizationParameters.TabStop = false;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(199, 176);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(112, 28);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.ForeColor = System.Drawing.Color.LightGray;
            this.tbPassword.Location = new System.Drawing.Point(15, 111);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(295, 23);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Tag = "Введите пароль";
            this.tbPassword.Text = "Введите пароль";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(10, 79);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(63, 17);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.ForeColor = System.Drawing.Color.LightGray;
            this.tbLogin.Location = new System.Drawing.Point(15, 46);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(4);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(295, 23);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Tag = "Введите логин";
            this.tbLogin.Text = "Введите логин";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(10, 25);
            this.lbLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(52, 17);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Логин";
            // 
            // pctAuthorization
            // 
            this.pctAuthorization.Image = global::Authorization.Properties.Resources._280;
            this.pctAuthorization.Location = new System.Drawing.Point(18, 15);
            this.pctAuthorization.Margin = new System.Windows.Forms.Padding(4);
            this.pctAuthorization.Name = "pctAuthorization";
            this.pctAuthorization.Size = new System.Drawing.Size(269, 215);
            this.pctAuthorization.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAuthorization.TabIndex = 1;
            this.pctAuthorization.TabStop = false;
            // 
            // lbRecoveryPassword
            // 
            this.lbRecoveryPassword.AutoSize = true;
            this.lbRecoveryPassword.Location = new System.Drawing.Point(22, 363);
            this.lbRecoveryPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRecoveryPassword.Name = "lbRecoveryPassword";
            this.lbRecoveryPassword.Size = new System.Drawing.Size(132, 17);
            this.lbRecoveryPassword.TabIndex = 2;
            this.lbRecoveryPassword.TabStop = true;
            this.lbRecoveryPassword.Text = "Забыли пароль?";
            this.lbRecoveryPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbRecoveryPassword_LinkClicked);
            // 
            // lbRegistration
            // 
            this.lbRegistration.AutoSize = true;
            this.lbRegistration.Location = new System.Drawing.Point(518, 363);
            this.lbRegistration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRegistration.Name = "lbRegistration";
            this.lbRegistration.Size = new System.Drawing.Size(103, 17);
            this.lbRegistration.TabIndex = 3;
            this.lbRegistration.TabStop = true;
            this.lbRegistration.Text = "Регистрация";
            this.lbRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbRegistration_LinkClicked);
            // 
            // tbErrorLogIn
            // 
            this.tbErrorLogIn.BackColor = System.Drawing.Color.Silver;
            this.tbErrorLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbErrorLogIn.ForeColor = System.Drawing.Color.Red;
            this.tbErrorLogIn.Location = new System.Drawing.Point(22, 271);
            this.tbErrorLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.tbErrorLogIn.Name = "tbErrorLogIn";
            this.tbErrorLogIn.Size = new System.Drawing.Size(601, 23);
            this.tbErrorLogIn.TabIndex = 4;
            this.tbErrorLogIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbErrorLogIn.Visible = false;
            // 
            // prgLogin
            // 
            this.prgLogin.Location = new System.Drawing.Point(22, 318);
            this.prgLogin.Name = "prgLogin";
            this.prgLogin.Size = new System.Drawing.Size(601, 23);
            this.prgLogin.TabIndex = 5;
            // 
            // bgWorkerLogin
            // 
            this.bgWorkerLogin.WorkerSupportsCancellation = true;
            this.bgWorkerLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorkerLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(644, 409);
            this.Controls.Add(this.prgLogin);
            this.Controls.Add(this.tbErrorLogIn);
            this.Controls.Add(this.lbRegistration);
            this.Controls.Add(this.lbRecoveryPassword);
            this.Controls.Add(this.pctAuthorization);
            this.Controls.Add(this.grpAuthorizationParameters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Авторизация";
            this.grpAuthorizationParameters.ResumeLayout(false);
            this.grpAuthorizationParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAuthorization)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAuthorizationParameters;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.PictureBox pctAuthorization;
        private System.Windows.Forms.LinkLabel lbRecoveryPassword;
        private System.Windows.Forms.LinkLabel lbRegistration;
        private System.Windows.Forms.TextBox tbErrorLogIn;
        private System.Windows.Forms.ProgressBar prgLogin;
        private System.ComponentModel.BackgroundWorker bgWorkerLogin;
    }
}

