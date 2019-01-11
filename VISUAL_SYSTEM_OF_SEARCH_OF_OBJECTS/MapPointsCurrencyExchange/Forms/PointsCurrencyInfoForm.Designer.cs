namespace MapPointsCurrencyExchange.Forms
{
    partial class PointsCurrencyInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointsCurrencyInfoForm));
            this.lbCashierName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpCoordinates = new System.Windows.Forms.GroupBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.lbY = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.lbX = new System.Windows.Forms.Label();
            this.grpCashier = new System.Windows.Forms.GroupBox();
            this.tbCashierCategory = new System.Windows.Forms.TextBox();
            this.tbCashierLastName = new System.Windows.Forms.TextBox();
            this.tbCashierName = new System.Windows.Forms.TextBox();
            this.lbCashierCategory = new System.Windows.Forms.Label();
            this.lbCashierLastName = new System.Windows.Forms.Label();
            this.grpTimeWork = new System.Windows.Forms.GroupBox();
            this.tbTimeWork = new System.Windows.Forms.TextBox();
            this.grpComments = new System.Windows.Forms.GroupBox();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.lstComments = new System.Windows.Forms.ListBox();
            this.grpServises = new System.Windows.Forms.GroupBox();
            this.tbServes = new System.Windows.Forms.TextBox();
            this.btnAddServes = new System.Windows.Forms.Button();
            this.listServeses = new System.Windows.Forms.ListBox();
            this.grpAdditionalInfo = new System.Windows.Forms.GroupBox();
            this.tbAdditionalInfo = new System.Windows.Forms.TextBox();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.dtpOpenDate = new System.Windows.Forms.DateTimePicker();
            this.lbOpenDate = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.lbAdress = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.cmbBankName = new System.Windows.Forms.ComboBox();
            this.lbBankName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnRemouveServes = new System.Windows.Forms.Button();
            this.btnRemoveComent = new System.Windows.Forms.Button();
            this.tbComentsAuthor = new System.Windows.Forms.TextBox();
            this.grpCoordinates.SuspendLayout();
            this.grpCashier.SuspendLayout();
            this.grpTimeWork.SuspendLayout();
            this.grpComments.SuspendLayout();
            this.grpServises.SuspendLayout();
            this.grpAdditionalInfo.SuspendLayout();
            this.grpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCashierName
            // 
            this.lbCashierName.AutoSize = true;
            this.lbCashierName.Location = new System.Drawing.Point(6, 21);
            this.lbCashierName.Name = "lbCashierName";
            this.lbCashierName.Size = new System.Drawing.Size(29, 13);
            this.lbCashierName.TabIndex = 12;
            this.lbCashierName.Text = "Имя";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(848, 532);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(761, 532);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "Ок";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpCoordinates
            // 
            this.grpCoordinates.Controls.Add(this.tbY);
            this.grpCoordinates.Controls.Add(this.lbY);
            this.grpCoordinates.Controls.Add(this.tbX);
            this.grpCoordinates.Controls.Add(this.lbX);
            this.grpCoordinates.Location = new System.Drawing.Point(11, 486);
            this.grpCoordinates.Name = "grpCoordinates";
            this.grpCoordinates.Size = new System.Drawing.Size(523, 70);
            this.grpCoordinates.TabIndex = 22;
            this.grpCoordinates.TabStop = false;
            this.grpCoordinates.Text = "Координаты";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(151, 39);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(364, 20);
            this.tbY.TabIndex = 26;
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(6, 42);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(53, 13);
            this.lbY.TabIndex = 25;
            this.lbY.Text = "Долгота:";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(151, 13);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(364, 20);
            this.tbX.TabIndex = 24;
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(6, 16);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(48, 13);
            this.lbX.TabIndex = 23;
            this.lbX.Text = "Широта:";
            // 
            // grpCashier
            // 
            this.grpCashier.Controls.Add(this.tbCashierCategory);
            this.grpCashier.Controls.Add(this.tbCashierLastName);
            this.grpCashier.Controls.Add(this.tbCashierName);
            this.grpCashier.Controls.Add(this.lbCashierCategory);
            this.grpCashier.Controls.Add(this.lbCashierLastName);
            this.grpCashier.Controls.Add(this.lbCashierName);
            this.grpCashier.Location = new System.Drawing.Point(11, 188);
            this.grpCashier.Name = "grpCashier";
            this.grpCashier.Size = new System.Drawing.Size(523, 100);
            this.grpCashier.TabIndex = 24;
            this.grpCashier.TabStop = false;
            this.grpCashier.Text = "Кассир";
            // 
            // tbCashierCategory
            // 
            this.tbCashierCategory.Location = new System.Drawing.Point(235, 68);
            this.tbCashierCategory.Name = "tbCashierCategory";
            this.tbCashierCategory.Size = new System.Drawing.Size(280, 20);
            this.tbCashierCategory.TabIndex = 17;
            // 
            // tbCashierLastName
            // 
            this.tbCashierLastName.Location = new System.Drawing.Point(235, 41);
            this.tbCashierLastName.Name = "tbCashierLastName";
            this.tbCashierLastName.Size = new System.Drawing.Size(280, 20);
            this.tbCashierLastName.TabIndex = 16;
            // 
            // tbCashierName
            // 
            this.tbCashierName.Location = new System.Drawing.Point(235, 14);
            this.tbCashierName.Name = "tbCashierName";
            this.tbCashierName.Size = new System.Drawing.Size(280, 20);
            this.tbCashierName.TabIndex = 15;
            // 
            // lbCashierCategory
            // 
            this.lbCashierCategory.AutoSize = true;
            this.lbCashierCategory.Location = new System.Drawing.Point(6, 75);
            this.lbCashierCategory.Name = "lbCashierCategory";
            this.lbCashierCategory.Size = new System.Drawing.Size(60, 13);
            this.lbCashierCategory.TabIndex = 14;
            this.lbCashierCategory.Text = "Категория";
            // 
            // lbCashierLastName
            // 
            this.lbCashierLastName.AutoSize = true;
            this.lbCashierLastName.Location = new System.Drawing.Point(6, 48);
            this.lbCashierLastName.Name = "lbCashierLastName";
            this.lbCashierLastName.Size = new System.Drawing.Size(56, 13);
            this.lbCashierLastName.TabIndex = 13;
            this.lbCashierLastName.Text = "Фамилия";
            // 
            // grpTimeWork
            // 
            this.grpTimeWork.Controls.Add(this.tbTimeWork);
            this.grpTimeWork.Location = new System.Drawing.Point(545, 15);
            this.grpTimeWork.Name = "grpTimeWork";
            this.grpTimeWork.Size = new System.Drawing.Size(377, 145);
            this.grpTimeWork.TabIndex = 25;
            this.grpTimeWork.TabStop = false;
            this.grpTimeWork.Text = "Режим работы";
            // 
            // tbTimeWork
            // 
            this.tbTimeWork.Location = new System.Drawing.Point(7, 20);
            this.tbTimeWork.Multiline = true;
            this.tbTimeWork.Name = "tbTimeWork";
            this.tbTimeWork.Size = new System.Drawing.Size(364, 119);
            this.tbTimeWork.TabIndex = 0;
            // 
            // grpComments
            // 
            this.grpComments.Controls.Add(this.tbComentsAuthor);
            this.grpComments.Controls.Add(this.btnRemoveComent);
            this.grpComments.Controls.Add(this.btnAddComment);
            this.grpComments.Controls.Add(this.tbComments);
            this.grpComments.Controls.Add(this.lstComments);
            this.grpComments.Location = new System.Drawing.Point(546, 313);
            this.grpComments.Name = "grpComments";
            this.grpComments.Size = new System.Drawing.Size(377, 213);
            this.grpComments.TabIndex = 26;
            this.grpComments.TabStop = false;
            this.grpComments.Text = "Отзывы";
            // 
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point(265, 183);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(106, 23);
            this.btnAddComment.TabIndex = 2;
            this.btnAddComment.Text = "Добавить отзыв";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(7, 116);
            this.tbComments.MaxLength = 256;
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(364, 61);
            this.tbComments.TabIndex = 1;
            // 
            // lstComments
            // 
            this.lstComments.FormattingEnabled = true;
            this.lstComments.HorizontalScrollbar = true;
            this.lstComments.Location = new System.Drawing.Point(7, 16);
            this.lstComments.Name = "lstComments";
            this.lstComments.Size = new System.Drawing.Size(364, 95);
            this.lstComments.TabIndex = 0;
            // 
            // grpServises
            // 
            this.grpServises.Controls.Add(this.btnRemouveServes);
            this.grpServises.Controls.Add(this.tbServes);
            this.grpServises.Controls.Add(this.btnAddServes);
            this.grpServises.Controls.Add(this.listServeses);
            this.grpServises.Location = new System.Drawing.Point(11, 298);
            this.grpServises.Name = "grpServises";
            this.grpServises.Size = new System.Drawing.Size(523, 182);
            this.grpServises.TabIndex = 27;
            this.grpServises.TabStop = false;
            this.grpServises.Text = "Виды оказываемых услуг";
            // 
            // tbServes
            // 
            this.tbServes.Location = new System.Drawing.Point(247, 152);
            this.tbServes.Name = "tbServes";
            this.tbServes.Size = new System.Drawing.Size(268, 20);
            this.tbServes.TabIndex = 2;
            // 
            // btnAddServes
            // 
            this.btnAddServes.Location = new System.Drawing.Point(9, 149);
            this.btnAddServes.Name = "btnAddServes";
            this.btnAddServes.Size = new System.Drawing.Size(113, 24);
            this.btnAddServes.TabIndex = 1;
            this.btnAddServes.Text = "Добавить сервис";
            this.btnAddServes.UseVisualStyleBackColor = true;
            this.btnAddServes.Click += new System.EventHandler(this.btnAddServes_Click);
            // 
            // listServeses
            // 
            this.listServeses.FormattingEnabled = true;
            this.listServeses.Location = new System.Drawing.Point(9, 15);
            this.listServeses.Name = "listServeses";
            this.listServeses.Size = new System.Drawing.Size(506, 121);
            this.listServeses.TabIndex = 0;
            // 
            // grpAdditionalInfo
            // 
            this.grpAdditionalInfo.Controls.Add(this.tbAdditionalInfo);
            this.grpAdditionalInfo.Location = new System.Drawing.Point(545, 164);
            this.grpAdditionalInfo.Name = "grpAdditionalInfo";
            this.grpAdditionalInfo.Size = new System.Drawing.Size(377, 145);
            this.grpAdditionalInfo.TabIndex = 28;
            this.grpAdditionalInfo.TabStop = false;
            this.grpAdditionalInfo.Text = "Доболнительная информация";
            // 
            // tbAdditionalInfo
            // 
            this.tbAdditionalInfo.Location = new System.Drawing.Point(7, 20);
            this.tbAdditionalInfo.Multiline = true;
            this.tbAdditionalInfo.Name = "tbAdditionalInfo";
            this.tbAdditionalInfo.Size = new System.Drawing.Size(364, 119);
            this.tbAdditionalInfo.TabIndex = 0;
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.dtpOpenDate);
            this.grpMain.Controls.Add(this.lbOpenDate);
            this.grpMain.Controls.Add(this.tbAdress);
            this.grpMain.Controls.Add(this.lbAdress);
            this.grpMain.Controls.Add(this.tbPhone);
            this.grpMain.Controls.Add(this.lbPhone);
            this.grpMain.Controls.Add(this.cmbBankName);
            this.grpMain.Controls.Add(this.lbBankName);
            this.grpMain.Controls.Add(this.tbName);
            this.grpMain.Controls.Add(this.lbName);
            this.grpMain.Location = new System.Drawing.Point(11, 15);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(523, 167);
            this.grpMain.TabIndex = 29;
            this.grpMain.TabStop = false;
            // 
            // dtpOpenDate
            // 
            this.dtpOpenDate.Location = new System.Drawing.Point(235, 137);
            this.dtpOpenDate.Name = "dtpOpenDate";
            this.dtpOpenDate.Size = new System.Drawing.Size(280, 20);
            this.dtpOpenDate.TabIndex = 33;
            // 
            // lbOpenDate
            // 
            this.lbOpenDate.AutoSize = true;
            this.lbOpenDate.Location = new System.Drawing.Point(6, 141);
            this.lbOpenDate.Name = "lbOpenDate";
            this.lbOpenDate.Size = new System.Drawing.Size(84, 13);
            this.lbOpenDate.TabIndex = 32;
            this.lbOpenDate.Text = "Дата открытия";
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(235, 107);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(280, 20);
            this.tbAdress.TabIndex = 31;
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Location = new System.Drawing.Point(6, 110);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(38, 13);
            this.lbAdress.TabIndex = 30;
            this.lbAdress.Text = "Адрес";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(235, 77);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(280, 20);
            this.tbPhone.TabIndex = 29;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(6, 79);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(52, 13);
            this.lbPhone.TabIndex = 28;
            this.lbPhone.Text = "Телефон";
            // 
            // cmbBankName
            // 
            this.cmbBankName.FormattingEnabled = true;
            this.cmbBankName.Location = new System.Drawing.Point(235, 46);
            this.cmbBankName.Name = "cmbBankName";
            this.cmbBankName.Size = new System.Drawing.Size(280, 21);
            this.cmbBankName.TabIndex = 27;
            // 
            // lbBankName
            // 
            this.lbBankName.AutoSize = true;
            this.lbBankName.Location = new System.Drawing.Point(6, 48);
            this.lbBankName.Name = "lbBankName";
            this.lbBankName.Size = new System.Drawing.Size(116, 13);
            this.lbBankName.TabIndex = 26;
            this.lbBankName.Text = "Наименование банка";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(235, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(280, 20);
            this.tbName.TabIndex = 25;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(6, 17);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(203, 13);
            this.lbName.TabIndex = 24;
            this.lbName.Text = "Наименование пункта обмена валюты";
            // 
            // btnRemouveServes
            // 
            this.btnRemouveServes.Location = new System.Drawing.Point(128, 150);
            this.btnRemouveServes.Name = "btnRemouveServes";
            this.btnRemouveServes.Size = new System.Drawing.Size(113, 23);
            this.btnRemouveServes.TabIndex = 3;
            this.btnRemouveServes.Text = "Удалить сервис";
            this.btnRemouveServes.UseVisualStyleBackColor = true;
            this.btnRemouveServes.Click += new System.EventHandler(this.btnRemouveServes_Click);
            // 
            // btnRemoveComent
            // 
            this.btnRemoveComent.Location = new System.Drawing.Point(157, 183);
            this.btnRemoveComent.Name = "btnRemoveComent";
            this.btnRemoveComent.Size = new System.Drawing.Size(106, 23);
            this.btnRemoveComent.TabIndex = 3;
            this.btnRemoveComent.Text = "Удалить отзыв";
            this.btnRemoveComent.UseVisualStyleBackColor = true;
            this.btnRemoveComent.Click += new System.EventHandler(this.btnRemoveComent_Click);
            // 
            // tbComentsAuthor
            // 
            this.tbComentsAuthor.Location = new System.Drawing.Point(7, 186);
            this.tbComentsAuthor.Name = "tbComentsAuthor";
            this.tbComentsAuthor.Size = new System.Drawing.Size(144, 20);
            this.tbComentsAuthor.TabIndex = 4;
            this.tbComentsAuthor.Text = "Имя автора";
            // 
            // PointsCurrencyInfoForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(936, 565);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.grpAdditionalInfo);
            this.Controls.Add(this.grpServises);
            this.Controls.Add(this.grpComments);
            this.Controls.Add(this.grpTimeWork);
            this.Controls.Add(this.grpCashier);
            this.Controls.Add(this.grpCoordinates);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PointsCurrencyInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация о обменнике";
            this.grpCoordinates.ResumeLayout(false);
            this.grpCoordinates.PerformLayout();
            this.grpCashier.ResumeLayout(false);
            this.grpCashier.PerformLayout();
            this.grpTimeWork.ResumeLayout(false);
            this.grpTimeWork.PerformLayout();
            this.grpComments.ResumeLayout(false);
            this.grpComments.PerformLayout();
            this.grpServises.ResumeLayout(false);
            this.grpServises.PerformLayout();
            this.grpAdditionalInfo.ResumeLayout(false);
            this.grpAdditionalInfo.PerformLayout();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbCashierName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpCoordinates;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.GroupBox grpCashier;
        private System.Windows.Forms.TextBox tbCashierCategory;
        private System.Windows.Forms.TextBox tbCashierLastName;
        private System.Windows.Forms.TextBox tbCashierName;
        private System.Windows.Forms.Label lbCashierCategory;
        private System.Windows.Forms.Label lbCashierLastName;
        private System.Windows.Forms.GroupBox grpTimeWork;
        private System.Windows.Forms.TextBox tbTimeWork;
        private System.Windows.Forms.GroupBox grpComments;
        private System.Windows.Forms.GroupBox grpServises;
        private System.Windows.Forms.GroupBox grpAdditionalInfo;
        private System.Windows.Forms.TextBox tbAdditionalInfo;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.DateTimePicker dtpOpenDate;
        private System.Windows.Forms.Label lbOpenDate;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.ComboBox cmbBankName;
        private System.Windows.Forms.Label lbBankName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ListBox lstComments;
        private System.Windows.Forms.ListBox listServeses;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.TextBox tbServes;
        private System.Windows.Forms.Button btnAddServes;
        private System.Windows.Forms.Button btnRemoveComent;
        private System.Windows.Forms.Button btnRemouveServes;
        private System.Windows.Forms.TextBox tbComentsAuthor;
    }
}