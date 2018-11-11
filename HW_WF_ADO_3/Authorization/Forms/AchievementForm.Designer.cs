namespace Authorization.Forms
{
    partial class AchievementForm
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
            this.tbInfoAchievement = new System.Windows.Forms.TextBox();
            this.lbAchievement = new System.Windows.Forms.Label();
            this.lbInfoAchievement = new System.Windows.Forms.Label();
            this.btnOKAchievement = new System.Windows.Forms.Button();
            this.pctAchievement = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctAchievement)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInfoAchievement
            // 
            this.tbInfoAchievement.Location = new System.Drawing.Point(12, 64);
            this.tbInfoAchievement.Multiline = true;
            this.tbInfoAchievement.Name = "tbInfoAchievement";
            this.tbInfoAchievement.Size = new System.Drawing.Size(163, 195);
            this.tbInfoAchievement.TabIndex = 1;
            // 
            // lbAchievement
            // 
            this.lbAchievement.AutoSize = true;
            this.lbAchievement.Location = new System.Drawing.Point(12, 9);
            this.lbAchievement.Name = "lbAchievement";
            this.lbAchievement.Size = new System.Drawing.Size(159, 17);
            this.lbAchievement.TabIndex = 2;
            this.lbAchievement.Text = "Вы вошли в систему";
            // 
            // lbInfoAchievement
            // 
            this.lbInfoAchievement.AutoSize = true;
            this.lbInfoAchievement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfoAchievement.Location = new System.Drawing.Point(12, 37);
            this.lbInfoAchievement.Name = "lbInfoAchievement";
            this.lbInfoAchievement.Size = new System.Drawing.Size(88, 15);
            this.lbInfoAchievement.TabIndex = 3;
            this.lbInfoAchievement.Text = "Ваши данные:";
            // 
            // btnOKAchievement
            // 
            this.btnOKAchievement.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOKAchievement.Location = new System.Drawing.Point(342, 289);
            this.btnOKAchievement.Name = "btnOKAchievement";
            this.btnOKAchievement.Size = new System.Drawing.Size(96, 27);
            this.btnOKAchievement.TabIndex = 4;
            this.btnOKAchievement.Text = "ОК";
            this.btnOKAchievement.UseVisualStyleBackColor = true;
            this.btnOKAchievement.Click += new System.EventHandler(this.btnOKAchievement_Click);
            // 
            // pctAchievement
            // 
            this.pctAchievement.Image = global::Authorization.Properties.Resources.picture_png;
            this.pctAchievement.Location = new System.Drawing.Point(181, 12);
            this.pctAchievement.Name = "pctAchievement";
            this.pctAchievement.Size = new System.Drawing.Size(264, 247);
            this.pctAchievement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctAchievement.TabIndex = 0;
            this.pctAchievement.TabStop = false;
            // 
            // AchievementForm
            // 
            this.AcceptButton = this.btnOKAchievement;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.btnOKAchievement;
            this.ClientSize = new System.Drawing.Size(457, 328);
            this.Controls.Add(this.btnOKAchievement);
            this.Controls.Add(this.lbInfoAchievement);
            this.Controls.Add(this.lbAchievement);
            this.Controls.Add(this.tbInfoAchievement);
            this.Controls.Add(this.pctAchievement);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AchievementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Главное окно приложения";
            this.Load += new System.EventHandler(this.AchievementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctAchievement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctAchievement;
        private System.Windows.Forms.TextBox tbInfoAchievement;
        private System.Windows.Forms.Label lbAchievement;
        private System.Windows.Forms.Label lbInfoAchievement;
        private System.Windows.Forms.Button btnOKAchievement;
    }
}