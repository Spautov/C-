namespace Authorization.Forms
{
    partial class RecoveryPasswordForm
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
            this.grpRecoveryPassword = new System.Windows.Forms.GroupBox();
            this.tbRepeatPasswordRecoveryPassword = new System.Windows.Forms.TextBox();
            this.lbRepeatPasswordRecoveryPassword = new System.Windows.Forms.Label();
            this.tbNewPasswordRecoveryPassword = new System.Windows.Forms.TextBox();
            this.lbNewPasswordRecoveryPassword = new System.Windows.Forms.Label();
            this.tbEmailRecoveryPassword = new System.Windows.Forms.TextBox();
            this.lbEmailRecoveryPassword = new System.Windows.Forms.Label();
            this.btnCancelRecoveryPassword = new System.Windows.Forms.Button();
            this.btnOKRecoveryPassword = new System.Windows.Forms.Button();
            this.grpRecoveryPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRecoveryPassword
            // 
            this.grpRecoveryPassword.Controls.Add(this.tbRepeatPasswordRecoveryPassword);
            this.grpRecoveryPassword.Controls.Add(this.lbRepeatPasswordRecoveryPassword);
            this.grpRecoveryPassword.Controls.Add(this.tbNewPasswordRecoveryPassword);
            this.grpRecoveryPassword.Controls.Add(this.lbNewPasswordRecoveryPassword);
            this.grpRecoveryPassword.Controls.Add(this.tbEmailRecoveryPassword);
            this.grpRecoveryPassword.Controls.Add(this.lbEmailRecoveryPassword);
            this.grpRecoveryPassword.Location = new System.Drawing.Point(19, 16);
            this.grpRecoveryPassword.Margin = new System.Windows.Forms.Padding(4);
            this.grpRecoveryPassword.Name = "grpRecoveryPassword";
            this.grpRecoveryPassword.Padding = new System.Windows.Forms.Padding(4);
            this.grpRecoveryPassword.Size = new System.Drawing.Size(290, 292);
            this.grpRecoveryPassword.TabIndex = 0;
            this.grpRecoveryPassword.TabStop = false;
            // 
            // tbRepeatPasswordRecoveryPassword
            // 
            this.tbRepeatPasswordRecoveryPassword.ForeColor = System.Drawing.Color.LightGray;
            this.tbRepeatPasswordRecoveryPassword.Location = new System.Drawing.Point(10, 153);
            this.tbRepeatPasswordRecoveryPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbRepeatPasswordRecoveryPassword.Name = "tbRepeatPasswordRecoveryPassword";
            this.tbRepeatPasswordRecoveryPassword.Size = new System.Drawing.Size(262, 23);
            this.tbRepeatPasswordRecoveryPassword.TabIndex = 5;
            this.tbRepeatPasswordRecoveryPassword.Tag = "Введите пароль еще раз";
            this.tbRepeatPasswordRecoveryPassword.Text = "Введите пароль еще раз";
            // 
            // lbRepeatPasswordRecoveryPassword
            // 
            this.lbRepeatPasswordRecoveryPassword.AutoSize = true;
            this.lbRepeatPasswordRecoveryPassword.Location = new System.Drawing.Point(10, 130);
            this.lbRepeatPasswordRecoveryPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRepeatPasswordRecoveryPassword.Name = "lbRepeatPasswordRecoveryPassword";
            this.lbRepeatPasswordRecoveryPassword.Size = new System.Drawing.Size(197, 17);
            this.lbRepeatPasswordRecoveryPassword.TabIndex = 4;
            this.lbRepeatPasswordRecoveryPassword.Text = "Повторите новый пароль";
            // 
            // tbNewPasswordRecoveryPassword
            // 
            this.tbNewPasswordRecoveryPassword.ForeColor = System.Drawing.Color.LightGray;
            this.tbNewPasswordRecoveryPassword.Location = new System.Drawing.Point(10, 100);
            this.tbNewPasswordRecoveryPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewPasswordRecoveryPassword.Name = "tbNewPasswordRecoveryPassword";
            this.tbNewPasswordRecoveryPassword.Size = new System.Drawing.Size(262, 23);
            this.tbNewPasswordRecoveryPassword.TabIndex = 3;
            this.tbNewPasswordRecoveryPassword.Tag = "Введие пароль";
            this.tbNewPasswordRecoveryPassword.Text = "Введие пароль";
            // 
            // lbNewPasswordRecoveryPassword
            // 
            this.lbNewPasswordRecoveryPassword.AutoSize = true;
            this.lbNewPasswordRecoveryPassword.Location = new System.Drawing.Point(10, 78);
            this.lbNewPasswordRecoveryPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNewPasswordRecoveryPassword.Name = "lbNewPasswordRecoveryPassword";
            this.lbNewPasswordRecoveryPassword.Size = new System.Drawing.Size(179, 17);
            this.lbNewPasswordRecoveryPassword.TabIndex = 2;
            this.lbNewPasswordRecoveryPassword.Text = "Введите новый пароль";
            // 
            // tbEmailRecoveryPassword
            // 
            this.tbEmailRecoveryPassword.ForeColor = System.Drawing.Color.LightGray;
            this.tbEmailRecoveryPassword.Location = new System.Drawing.Point(10, 47);
            this.tbEmailRecoveryPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmailRecoveryPassword.Name = "tbEmailRecoveryPassword";
            this.tbEmailRecoveryPassword.Size = new System.Drawing.Size(262, 23);
            this.tbEmailRecoveryPassword.TabIndex = 1;
            this.tbEmailRecoveryPassword.Tag = "Введие ваш e-mail";
            this.tbEmailRecoveryPassword.Text = "Введие ваш e-mail";
            // 
            // lbEmailRecoveryPassword
            // 
            this.lbEmailRecoveryPassword.AutoSize = true;
            this.lbEmailRecoveryPassword.Location = new System.Drawing.Point(10, 25);
            this.lbEmailRecoveryPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmailRecoveryPassword.Name = "lbEmailRecoveryPassword";
            this.lbEmailRecoveryPassword.Size = new System.Drawing.Size(153, 17);
            this.lbEmailRecoveryPassword.TabIndex = 0;
            this.lbEmailRecoveryPassword.Text = "Введите ваш e-mail";
            // 
            // btnCancelRecoveryPassword
            // 
            this.btnCancelRecoveryPassword.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelRecoveryPassword.Location = new System.Drawing.Point(197, 431);
            this.btnCancelRecoveryPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelRecoveryPassword.Name = "btnCancelRecoveryPassword";
            this.btnCancelRecoveryPassword.Size = new System.Drawing.Size(112, 28);
            this.btnCancelRecoveryPassword.TabIndex = 1;
            this.btnCancelRecoveryPassword.Text = "Отмена";
            this.btnCancelRecoveryPassword.UseVisualStyleBackColor = true;
            this.btnCancelRecoveryPassword.Click += new System.EventHandler(this.btnCancelRecoveryPassword_Click);
            // 
            // btnOKRecoveryPassword
            // 
            this.btnOKRecoveryPassword.Location = new System.Drawing.Point(46, 431);
            this.btnOKRecoveryPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnOKRecoveryPassword.Name = "btnOKRecoveryPassword";
            this.btnOKRecoveryPassword.Size = new System.Drawing.Size(112, 28);
            this.btnOKRecoveryPassword.TabIndex = 2;
            this.btnOKRecoveryPassword.Text = "ОК";
            this.btnOKRecoveryPassword.UseVisualStyleBackColor = true;
            this.btnOKRecoveryPassword.Click += new System.EventHandler(this.btnOKRecoveryPassword_Click);
            // 
            // RecoveryPasswordForm
            // 
            this.AcceptButton = this.btnOKRecoveryPassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.btnCancelRecoveryPassword;
            this.ClientSize = new System.Drawing.Size(323, 474);
            this.Controls.Add(this.btnOKRecoveryPassword);
            this.Controls.Add(this.btnCancelRecoveryPassword);
            this.Controls.Add(this.grpRecoveryPassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecoveryPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Восстановление пароля";
            this.Load += new System.EventHandler(this.RecoveryPasswordForm_Load);
            this.grpRecoveryPassword.ResumeLayout(false);
            this.grpRecoveryPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRecoveryPassword;
        private System.Windows.Forms.TextBox tbRepeatPasswordRecoveryPassword;
        private System.Windows.Forms.Label lbRepeatPasswordRecoveryPassword;
        private System.Windows.Forms.TextBox tbNewPasswordRecoveryPassword;
        private System.Windows.Forms.Label lbNewPasswordRecoveryPassword;
        private System.Windows.Forms.TextBox tbEmailRecoveryPassword;
        private System.Windows.Forms.Label lbEmailRecoveryPassword;
        private System.Windows.Forms.Button btnCancelRecoveryPassword;
        private System.Windows.Forms.Button btnOKRecoveryPassword;
    }
}