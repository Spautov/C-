namespace MobileStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splGeneral = new System.Windows.Forms.SplitContainer();
            this.grpListOfPhones = new System.Windows.Forms.GroupBox();
            this.splListPhone = new System.Windows.Forms.SplitContainer();
            this.lstListOfPhones = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.tabPhones = new System.Windows.Forms.TabControl();
            this.tabPhoneInfo = new System.Windows.Forms.TabPage();
            this.tbPricePhoneInfo = new System.Windows.Forms.TextBox();
            this.tbCPUPhoneInfo = new System.Windows.Forms.TextBox();
            this.tbOsPhoneInfo = new System.Windows.Forms.TextBox();
            this.tbModelPhoneInfo = new System.Windows.Forms.TextBox();
            this.lbPricePhoneInfo = new System.Windows.Forms.Label();
            this.lbCPUPhoneInfo = new System.Windows.Forms.Label();
            this.lbOsPhoneInfo = new System.Windows.Forms.Label();
            this.lbModelPhoneInfo = new System.Windows.Forms.Label();
            this.grpOptionsInfo = new System.Windows.Forms.GroupBox();
            this.lstOtionsInfo = new System.Windows.Forms.ListBox();
            this.pctImagePhoneInfo = new System.Windows.Forms.PictureBox();
            this.tabEditPhoneInfo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelPhoneEdit = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearEdit = new System.Windows.Forms.Button();
            this.btnAddNewPhoneEdit = new System.Windows.Forms.Button();
            this.grpPhoneOptionEdit = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelOptionsEdit = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddOptionEdit = new System.Windows.Forms.Button();
            this.btnDeleteOptionEdit = new System.Windows.Forms.Button();
            this.tbNameOptionEdit = new System.Windows.Forms.TextBox();
            this.lbNameOptionEdit = new System.Windows.Forms.Label();
            this.btnSaveChangesEdit = new System.Windows.Forms.Button();
            this.lstOptionsEdit = new System.Windows.Forms.CheckedListBox();
            this.grpPhoneInfoEdit = new System.Windows.Forms.GroupBox();
            this.tbPricePhoneEdit = new System.Windows.Forms.TextBox();
            this.lbPricePhoneEdit = new System.Windows.Forms.Label();
            this.tbImagePhoneEdit = new System.Windows.Forms.TextBox();
            this.tbCPUPhoneEdit = new System.Windows.Forms.TextBox();
            this.tbOsPhoneEdit = new System.Windows.Forms.TextBox();
            this.tbModelPhoneEdit = new System.Windows.Forms.TextBox();
            this.lbImagePhoneEdit = new System.Windows.Forms.Label();
            this.lbCPUPhoneEdit = new System.Windows.Forms.Label();
            this.lbOsPhoneEdit = new System.Windows.Forms.Label();
            this.lbModelPhoneEdit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splGeneral)).BeginInit();
            this.splGeneral.Panel1.SuspendLayout();
            this.splGeneral.Panel2.SuspendLayout();
            this.splGeneral.SuspendLayout();
            this.grpListOfPhones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splListPhone)).BeginInit();
            this.splListPhone.Panel1.SuspendLayout();
            this.splListPhone.Panel2.SuspendLayout();
            this.splListPhone.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.tabPhones.SuspendLayout();
            this.tabPhoneInfo.SuspendLayout();
            this.grpOptionsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagePhoneInfo)).BeginInit();
            this.tabEditPhoneInfo.SuspendLayout();
            this.tableLayoutPanelPhoneEdit.SuspendLayout();
            this.grpPhoneOptionEdit.SuspendLayout();
            this.tableLayoutPanelOptionsEdit.SuspendLayout();
            this.grpPhoneInfoEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // splGeneral
            // 
            this.splGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splGeneral.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splGeneral.Location = new System.Drawing.Point(0, 0);
            this.splGeneral.Name = "splGeneral";
            // 
            // splGeneral.Panel1
            // 
            this.splGeneral.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splGeneral.Panel1.Controls.Add(this.grpListOfPhones);
            // 
            // splGeneral.Panel2
            // 
            this.splGeneral.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.splGeneral.Panel2.Controls.Add(this.tabPhones);
            this.splGeneral.Size = new System.Drawing.Size(721, 510);
            this.splGeneral.SplitterDistance = 266;
            this.splGeneral.TabIndex = 0;
            // 
            // grpListOfPhones
            // 
            this.grpListOfPhones.BackColor = System.Drawing.Color.LightGray;
            this.grpListOfPhones.Controls.Add(this.splListPhone);
            this.grpListOfPhones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpListOfPhones.Location = new System.Drawing.Point(0, 0);
            this.grpListOfPhones.Name = "grpListOfPhones";
            this.grpListOfPhones.Size = new System.Drawing.Size(266, 510);
            this.grpListOfPhones.TabIndex = 0;
            this.grpListOfPhones.TabStop = false;
            this.grpListOfPhones.Text = "Список телефонов магазина";
            // 
            // splListPhone
            // 
            this.splListPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splListPhone.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splListPhone.Location = new System.Drawing.Point(3, 16);
            this.splListPhone.Name = "splListPhone";
            this.splListPhone.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splListPhone.Panel1
            // 
            this.splListPhone.Panel1.Controls.Add(this.lstListOfPhones);
            // 
            // splListPhone.Panel2
            // 
            this.splListPhone.Panel2.Controls.Add(this.tableLayoutPanelButtons);
            this.splListPhone.Size = new System.Drawing.Size(260, 491);
            this.splListPhone.SplitterDistance = 393;
            this.splListPhone.TabIndex = 0;
            // 
            // lstListOfPhones
            // 
            this.lstListOfPhones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListOfPhones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstListOfPhones.FormattingEnabled = true;
            this.lstListOfPhones.ItemHeight = 16;
            this.lstListOfPhones.Location = new System.Drawing.Point(0, 0);
            this.lstListOfPhones.Name = "lstListOfPhones";
            this.lstListOfPhones.Size = new System.Drawing.Size(260, 393);
            this.lstListOfPhones.TabIndex = 0;
            this.lstListOfPhones.SelectedIndexChanged += new System.EventHandler(this.lstListOfPhones_SelectedIndexChanged);
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 2;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Controls.Add(this.btnDeleteRecord, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnClearList, 1, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnSaveFile, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.btnLoadFile, 1, 1);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 2;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(260, 94);
            this.tableLayoutPanelButtons.TabIndex = 0;
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteRecord.Location = new System.Drawing.Point(3, 3);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(124, 41);
            this.btnDeleteRecord.TabIndex = 0;
            this.btnDeleteRecord.Text = "Удалить текущую запись";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearList.Location = new System.Drawing.Point(133, 3);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(124, 41);
            this.btnClearList.TabIndex = 1;
            this.btnClearList.Text = "Очистить список";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSaveFile.Location = new System.Drawing.Point(3, 50);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(124, 41);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "Сохранить в файл";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLoadFile.Location = new System.Drawing.Point(133, 50);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(124, 41);
            this.btnLoadFile.TabIndex = 3;
            this.btnLoadFile.Text = "Загрузить из файла";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // tabPhones
            // 
            this.tabPhones.Controls.Add(this.tabPhoneInfo);
            this.tabPhones.Controls.Add(this.tabEditPhoneInfo);
            this.tabPhones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPhones.Location = new System.Drawing.Point(0, 0);
            this.tabPhones.Name = "tabPhones";
            this.tabPhones.SelectedIndex = 0;
            this.tabPhones.Size = new System.Drawing.Size(451, 510);
            this.tabPhones.TabIndex = 0;
            // 
            // tabPhoneInfo
            // 
            this.tabPhoneInfo.Controls.Add(this.tbPricePhoneInfo);
            this.tabPhoneInfo.Controls.Add(this.tbCPUPhoneInfo);
            this.tabPhoneInfo.Controls.Add(this.tbOsPhoneInfo);
            this.tabPhoneInfo.Controls.Add(this.tbModelPhoneInfo);
            this.tabPhoneInfo.Controls.Add(this.lbPricePhoneInfo);
            this.tabPhoneInfo.Controls.Add(this.lbCPUPhoneInfo);
            this.tabPhoneInfo.Controls.Add(this.lbOsPhoneInfo);
            this.tabPhoneInfo.Controls.Add(this.lbModelPhoneInfo);
            this.tabPhoneInfo.Controls.Add(this.grpOptionsInfo);
            this.tabPhoneInfo.Controls.Add(this.pctImagePhoneInfo);
            this.tabPhoneInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPhoneInfo.Name = "tabPhoneInfo";
            this.tabPhoneInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhoneInfo.Size = new System.Drawing.Size(443, 484);
            this.tabPhoneInfo.TabIndex = 0;
            this.tabPhoneInfo.Text = "Информация о телефоне";
            this.tabPhoneInfo.UseVisualStyleBackColor = true;
            // 
            // tbPricePhoneInfo
            // 
            this.tbPricePhoneInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPricePhoneInfo.Enabled = false;
            this.tbPricePhoneInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPricePhoneInfo.Location = new System.Drawing.Point(137, 324);
            this.tbPricePhoneInfo.Name = "tbPricePhoneInfo";
            this.tbPricePhoneInfo.Size = new System.Drawing.Size(298, 23);
            this.tbPricePhoneInfo.TabIndex = 9;
            // 
            // tbCPUPhoneInfo
            // 
            this.tbCPUPhoneInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCPUPhoneInfo.Enabled = false;
            this.tbCPUPhoneInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCPUPhoneInfo.Location = new System.Drawing.Point(137, 294);
            this.tbCPUPhoneInfo.Name = "tbCPUPhoneInfo";
            this.tbCPUPhoneInfo.Size = new System.Drawing.Size(298, 23);
            this.tbCPUPhoneInfo.TabIndex = 8;
            // 
            // tbOsPhoneInfo
            // 
            this.tbOsPhoneInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOsPhoneInfo.Enabled = false;
            this.tbOsPhoneInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOsPhoneInfo.Location = new System.Drawing.Point(137, 260);
            this.tbOsPhoneInfo.Name = "tbOsPhoneInfo";
            this.tbOsPhoneInfo.Size = new System.Drawing.Size(298, 23);
            this.tbOsPhoneInfo.TabIndex = 7;
            // 
            // tbModelPhoneInfo
            // 
            this.tbModelPhoneInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModelPhoneInfo.Enabled = false;
            this.tbModelPhoneInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbModelPhoneInfo.Location = new System.Drawing.Point(137, 226);
            this.tbModelPhoneInfo.Name = "tbModelPhoneInfo";
            this.tbModelPhoneInfo.Size = new System.Drawing.Size(298, 23);
            this.tbModelPhoneInfo.TabIndex = 6;
            // 
            // lbPricePhoneInfo
            // 
            this.lbPricePhoneInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPricePhoneInfo.AutoSize = true;
            this.lbPricePhoneInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPricePhoneInfo.ForeColor = System.Drawing.Color.Red;
            this.lbPricePhoneInfo.Location = new System.Drawing.Point(14, 324);
            this.lbPricePhoneInfo.Name = "lbPricePhoneInfo";
            this.lbPricePhoneInfo.Size = new System.Drawing.Size(52, 17);
            this.lbPricePhoneInfo.TabIndex = 5;
            this.lbPricePhoneInfo.Text = "Цена:";
            // 
            // lbCPUPhoneInfo
            // 
            this.lbCPUPhoneInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCPUPhoneInfo.AutoSize = true;
            this.lbCPUPhoneInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCPUPhoneInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbCPUPhoneInfo.Location = new System.Drawing.Point(14, 294);
            this.lbCPUPhoneInfo.Name = "lbCPUPhoneInfo";
            this.lbCPUPhoneInfo.Size = new System.Drawing.Size(94, 17);
            this.lbCPUPhoneInfo.TabIndex = 4;
            this.lbCPUPhoneInfo.Text = "Процессор:";
            // 
            // lbOsPhoneInfo
            // 
            this.lbOsPhoneInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbOsPhoneInfo.AutoSize = true;
            this.lbOsPhoneInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOsPhoneInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbOsPhoneInfo.Location = new System.Drawing.Point(14, 260);
            this.lbOsPhoneInfo.Name = "lbOsPhoneInfo";
            this.lbOsPhoneInfo.Size = new System.Drawing.Size(35, 17);
            this.lbOsPhoneInfo.TabIndex = 3;
            this.lbOsPhoneInfo.Text = "ОС:";
            // 
            // lbModelPhoneInfo
            // 
            this.lbModelPhoneInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbModelPhoneInfo.AutoSize = true;
            this.lbModelPhoneInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbModelPhoneInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbModelPhoneInfo.Location = new System.Drawing.Point(14, 226);
            this.lbModelPhoneInfo.Name = "lbModelPhoneInfo";
            this.lbModelPhoneInfo.Size = new System.Drawing.Size(69, 17);
            this.lbModelPhoneInfo.TabIndex = 2;
            this.lbModelPhoneInfo.Text = "Модель:";
            // 
            // grpOptionsInfo
            // 
            this.grpOptionsInfo.Controls.Add(this.lstOtionsInfo);
            this.grpOptionsInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpOptionsInfo.Location = new System.Drawing.Point(3, 344);
            this.grpOptionsInfo.Name = "grpOptionsInfo";
            this.grpOptionsInfo.Size = new System.Drawing.Size(437, 137);
            this.grpOptionsInfo.TabIndex = 1;
            this.grpOptionsInfo.TabStop = false;
            this.grpOptionsInfo.Text = "Опции";
            // 
            // lstOtionsInfo
            // 
            this.lstOtionsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstOtionsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstOtionsInfo.FormattingEnabled = true;
            this.lstOtionsInfo.ItemHeight = 16;
            this.lstOtionsInfo.Location = new System.Drawing.Point(3, 16);
            this.lstOtionsInfo.Name = "lstOtionsInfo";
            this.lstOtionsInfo.Size = new System.Drawing.Size(431, 118);
            this.lstOtionsInfo.TabIndex = 0;
            // 
            // pctImagePhoneInfo
            // 
            this.pctImagePhoneInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pctImagePhoneInfo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pctImagePhoneInfo.ErrorImage")));
            this.pctImagePhoneInfo.ImageLocation = "";
            this.pctImagePhoneInfo.InitialImage = null;
            this.pctImagePhoneInfo.Location = new System.Drawing.Point(197, 1);
            this.pctImagePhoneInfo.Name = "pctImagePhoneInfo";
            this.pctImagePhoneInfo.Size = new System.Drawing.Size(220, 220);
            this.pctImagePhoneInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctImagePhoneInfo.TabIndex = 0;
            this.pctImagePhoneInfo.TabStop = false;
            // 
            // tabEditPhoneInfo
            // 
            this.tabEditPhoneInfo.Controls.Add(this.tableLayoutPanelPhoneEdit);
            this.tabEditPhoneInfo.Controls.Add(this.grpPhoneOptionEdit);
            this.tabEditPhoneInfo.Controls.Add(this.grpPhoneInfoEdit);
            this.tabEditPhoneInfo.Location = new System.Drawing.Point(4, 22);
            this.tabEditPhoneInfo.Name = "tabEditPhoneInfo";
            this.tabEditPhoneInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditPhoneInfo.Size = new System.Drawing.Size(443, 484);
            this.tabEditPhoneInfo.TabIndex = 1;
            this.tabEditPhoneInfo.Text = "Редактирование информации о телефоне";
            this.tabEditPhoneInfo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelPhoneEdit
            // 
            this.tableLayoutPanelPhoneEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelPhoneEdit.ColumnCount = 2;
            this.tableLayoutPanelPhoneEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPhoneEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPhoneEdit.Controls.Add(this.btnClearEdit, 0, 0);
            this.tableLayoutPanelPhoneEdit.Controls.Add(this.btnAddNewPhoneEdit, 1, 0);
            this.tableLayoutPanelPhoneEdit.Location = new System.Drawing.Point(6, 436);
            this.tableLayoutPanelPhoneEdit.Name = "tableLayoutPanelPhoneEdit";
            this.tableLayoutPanelPhoneEdit.RowCount = 1;
            this.tableLayoutPanelPhoneEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPhoneEdit.Size = new System.Drawing.Size(431, 39);
            this.tableLayoutPanelPhoneEdit.TabIndex = 2;
            // 
            // btnClearEdit
            // 
            this.btnClearEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearEdit.ForeColor = System.Drawing.Color.Red;
            this.btnClearEdit.Location = new System.Drawing.Point(3, 3);
            this.btnClearEdit.Name = "btnClearEdit";
            this.btnClearEdit.Size = new System.Drawing.Size(209, 33);
            this.btnClearEdit.TabIndex = 0;
            this.btnClearEdit.Text = "Очистить поля";
            this.btnClearEdit.UseVisualStyleBackColor = true;
            this.btnClearEdit.Click += new System.EventHandler(this.btnClearEdit_Click);
            // 
            // btnAddNewPhoneEdit
            // 
            this.btnAddNewPhoneEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewPhoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewPhoneEdit.ForeColor = System.Drawing.Color.Red;
            this.btnAddNewPhoneEdit.Location = new System.Drawing.Point(218, 3);
            this.btnAddNewPhoneEdit.Name = "btnAddNewPhoneEdit";
            this.btnAddNewPhoneEdit.Size = new System.Drawing.Size(210, 33);
            this.btnAddNewPhoneEdit.TabIndex = 1;
            this.btnAddNewPhoneEdit.Text = "Добавить новый телефон";
            this.btnAddNewPhoneEdit.UseVisualStyleBackColor = true;
            this.btnAddNewPhoneEdit.Click += new System.EventHandler(this.btnAddNewPhoneEdit_Click);
            // 
            // grpPhoneOptionEdit
            // 
            this.grpPhoneOptionEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPhoneOptionEdit.Controls.Add(this.tableLayoutPanelOptionsEdit);
            this.grpPhoneOptionEdit.Controls.Add(this.tbNameOptionEdit);
            this.grpPhoneOptionEdit.Controls.Add(this.lbNameOptionEdit);
            this.grpPhoneOptionEdit.Controls.Add(this.btnSaveChangesEdit);
            this.grpPhoneOptionEdit.Controls.Add(this.lstOptionsEdit);
            this.grpPhoneOptionEdit.Location = new System.Drawing.Point(6, 193);
            this.grpPhoneOptionEdit.Name = "grpPhoneOptionEdit";
            this.grpPhoneOptionEdit.Size = new System.Drawing.Size(431, 237);
            this.grpPhoneOptionEdit.TabIndex = 1;
            this.grpPhoneOptionEdit.TabStop = false;
            // 
            // tableLayoutPanelOptionsEdit
            // 
            this.tableLayoutPanelOptionsEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelOptionsEdit.ColumnCount = 2;
            this.tableLayoutPanelOptionsEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOptionsEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOptionsEdit.Controls.Add(this.btnAddOptionEdit, 0, 0);
            this.tableLayoutPanelOptionsEdit.Controls.Add(this.btnDeleteOptionEdit, 1, 0);
            this.tableLayoutPanelOptionsEdit.Location = new System.Drawing.Point(6, 204);
            this.tableLayoutPanelOptionsEdit.Name = "tableLayoutPanelOptionsEdit";
            this.tableLayoutPanelOptionsEdit.RowCount = 1;
            this.tableLayoutPanelOptionsEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOptionsEdit.Size = new System.Drawing.Size(423, 31);
            this.tableLayoutPanelOptionsEdit.TabIndex = 1;
            // 
            // btnAddOptionEdit
            // 
            this.btnAddOptionEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddOptionEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddOptionEdit.Location = new System.Drawing.Point(3, 3);
            this.btnAddOptionEdit.Name = "btnAddOptionEdit";
            this.btnAddOptionEdit.Size = new System.Drawing.Size(205, 25);
            this.btnAddOptionEdit.TabIndex = 5;
            this.btnAddOptionEdit.Text = "Добавить опцию";
            this.btnAddOptionEdit.UseVisualStyleBackColor = true;
            this.btnAddOptionEdit.Click += new System.EventHandler(this.btnAddOptionEdit_Click);
            // 
            // btnDeleteOptionEdit
            // 
            this.btnDeleteOptionEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteOptionEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteOptionEdit.Location = new System.Drawing.Point(214, 3);
            this.btnDeleteOptionEdit.Name = "btnDeleteOptionEdit";
            this.btnDeleteOptionEdit.Size = new System.Drawing.Size(206, 25);
            this.btnDeleteOptionEdit.TabIndex = 4;
            this.btnDeleteOptionEdit.Text = "Удалить опцию";
            this.btnDeleteOptionEdit.UseVisualStyleBackColor = true;
            this.btnDeleteOptionEdit.Click += new System.EventHandler(this.btnDeleteOptionEdit_Click);
            // 
            // tbNameOptionEdit
            // 
            this.tbNameOptionEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNameOptionEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameOptionEdit.Location = new System.Drawing.Point(224, 178);
            this.tbNameOptionEdit.Name = "tbNameOptionEdit";
            this.tbNameOptionEdit.Size = new System.Drawing.Size(202, 23);
            this.tbNameOptionEdit.TabIndex = 3;
            // 
            // lbNameOptionEdit
            // 
            this.lbNameOptionEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNameOptionEdit.AutoSize = true;
            this.lbNameOptionEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNameOptionEdit.ForeColor = System.Drawing.Color.Red;
            this.lbNameOptionEdit.Location = new System.Drawing.Point(6, 178);
            this.lbNameOptionEdit.Name = "lbNameOptionEdit";
            this.lbNameOptionEdit.Size = new System.Drawing.Size(130, 17);
            this.lbNameOptionEdit.TabIndex = 2;
            this.lbNameOptionEdit.Text = "Название опции";
            // 
            // btnSaveChangesEdit
            // 
            this.btnSaveChangesEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveChangesEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveChangesEdit.Location = new System.Drawing.Point(9, 140);
            this.btnSaveChangesEdit.Name = "btnSaveChangesEdit";
            this.btnSaveChangesEdit.Size = new System.Drawing.Size(417, 31);
            this.btnSaveChangesEdit.TabIndex = 1;
            this.btnSaveChangesEdit.Text = "Сохранить изменения";
            this.btnSaveChangesEdit.UseVisualStyleBackColor = true;
            this.btnSaveChangesEdit.Click += new System.EventHandler(this.btnSaveChangesEdit_Click);
            // 
            // lstOptionsEdit
            // 
            this.lstOptionsEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOptionsEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstOptionsEdit.FormattingEnabled = true;
            this.lstOptionsEdit.Location = new System.Drawing.Point(9, 19);
            this.lstOptionsEdit.Name = "lstOptionsEdit";
            this.lstOptionsEdit.Size = new System.Drawing.Size(417, 94);
            this.lstOptionsEdit.TabIndex = 0;
            // 
            // grpPhoneInfoEdit
            // 
            this.grpPhoneInfoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPhoneInfoEdit.Controls.Add(this.tbPricePhoneEdit);
            this.grpPhoneInfoEdit.Controls.Add(this.lbPricePhoneEdit);
            this.grpPhoneInfoEdit.Controls.Add(this.tbImagePhoneEdit);
            this.grpPhoneInfoEdit.Controls.Add(this.tbCPUPhoneEdit);
            this.grpPhoneInfoEdit.Controls.Add(this.tbOsPhoneEdit);
            this.grpPhoneInfoEdit.Controls.Add(this.tbModelPhoneEdit);
            this.grpPhoneInfoEdit.Controls.Add(this.lbImagePhoneEdit);
            this.grpPhoneInfoEdit.Controls.Add(this.lbCPUPhoneEdit);
            this.grpPhoneInfoEdit.Controls.Add(this.lbOsPhoneEdit);
            this.grpPhoneInfoEdit.Controls.Add(this.lbModelPhoneEdit);
            this.grpPhoneInfoEdit.Location = new System.Drawing.Point(6, 6);
            this.grpPhoneInfoEdit.Name = "grpPhoneInfoEdit";
            this.grpPhoneInfoEdit.Size = new System.Drawing.Size(431, 181);
            this.grpPhoneInfoEdit.TabIndex = 0;
            this.grpPhoneInfoEdit.TabStop = false;
            // 
            // tbPricePhoneEdit
            // 
            this.tbPricePhoneEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPricePhoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPricePhoneEdit.Location = new System.Drawing.Point(128, 147);
            this.tbPricePhoneEdit.Name = "tbPricePhoneEdit";
            this.tbPricePhoneEdit.Size = new System.Drawing.Size(298, 23);
            this.tbPricePhoneEdit.TabIndex = 19;
            this.tbPricePhoneEdit.TextChanged += new System.EventHandler(this.tbPricePhoneEdit_TextChanged);
            // 
            // lbPricePhoneEdit
            // 
            this.lbPricePhoneEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPricePhoneEdit.AutoSize = true;
            this.lbPricePhoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPricePhoneEdit.ForeColor = System.Drawing.Color.Red;
            this.lbPricePhoneEdit.Location = new System.Drawing.Point(5, 147);
            this.lbPricePhoneEdit.Name = "lbPricePhoneEdit";
            this.lbPricePhoneEdit.Size = new System.Drawing.Size(52, 17);
            this.lbPricePhoneEdit.TabIndex = 18;
            this.lbPricePhoneEdit.Text = "Цена:";
            // 
            // tbImagePhoneEdit
            // 
            this.tbImagePhoneEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbImagePhoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbImagePhoneEdit.Location = new System.Drawing.Point(128, 113);
            this.tbImagePhoneEdit.Name = "tbImagePhoneEdit";
            this.tbImagePhoneEdit.Size = new System.Drawing.Size(298, 23);
            this.tbImagePhoneEdit.TabIndex = 17;
            this.tbImagePhoneEdit.Click += new System.EventHandler(this.tbImagePhoneEdit_Click);
            // 
            // tbCPUPhoneEdit
            // 
            this.tbCPUPhoneEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCPUPhoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCPUPhoneEdit.Location = new System.Drawing.Point(128, 83);
            this.tbCPUPhoneEdit.Name = "tbCPUPhoneEdit";
            this.tbCPUPhoneEdit.Size = new System.Drawing.Size(298, 23);
            this.tbCPUPhoneEdit.TabIndex = 16;
            // 
            // tbOsPhoneEdit
            // 
            this.tbOsPhoneEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOsPhoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOsPhoneEdit.Location = new System.Drawing.Point(128, 49);
            this.tbOsPhoneEdit.Name = "tbOsPhoneEdit";
            this.tbOsPhoneEdit.Size = new System.Drawing.Size(298, 23);
            this.tbOsPhoneEdit.TabIndex = 15;
            // 
            // tbModelPhoneEdit
            // 
            this.tbModelPhoneEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModelPhoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbModelPhoneEdit.Location = new System.Drawing.Point(128, 15);
            this.tbModelPhoneEdit.Name = "tbModelPhoneEdit";
            this.tbModelPhoneEdit.Size = new System.Drawing.Size(298, 23);
            this.tbModelPhoneEdit.TabIndex = 14;
            // 
            // lbImagePhoneEdit
            // 
            this.lbImagePhoneEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbImagePhoneEdit.AutoSize = true;
            this.lbImagePhoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbImagePhoneEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbImagePhoneEdit.Location = new System.Drawing.Point(5, 113);
            this.lbImagePhoneEdit.Name = "lbImagePhoneEdit";
            this.lbImagePhoneEdit.Size = new System.Drawing.Size(114, 17);
            this.lbImagePhoneEdit.TabIndex = 13;
            this.lbImagePhoneEdit.Text = "Изображение:";
            // 
            // lbCPUPhoneEdit
            // 
            this.lbCPUPhoneEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCPUPhoneEdit.AutoSize = true;
            this.lbCPUPhoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCPUPhoneEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbCPUPhoneEdit.Location = new System.Drawing.Point(5, 83);
            this.lbCPUPhoneEdit.Name = "lbCPUPhoneEdit";
            this.lbCPUPhoneEdit.Size = new System.Drawing.Size(94, 17);
            this.lbCPUPhoneEdit.TabIndex = 12;
            this.lbCPUPhoneEdit.Text = "Процессор:";
            // 
            // lbOsPhoneEdit
            // 
            this.lbOsPhoneEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbOsPhoneEdit.AutoSize = true;
            this.lbOsPhoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOsPhoneEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbOsPhoneEdit.Location = new System.Drawing.Point(5, 49);
            this.lbOsPhoneEdit.Name = "lbOsPhoneEdit";
            this.lbOsPhoneEdit.Size = new System.Drawing.Size(35, 17);
            this.lbOsPhoneEdit.TabIndex = 11;
            this.lbOsPhoneEdit.Text = "ОС:";
            // 
            // lbModelPhoneEdit
            // 
            this.lbModelPhoneEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbModelPhoneEdit.AutoSize = true;
            this.lbModelPhoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbModelPhoneEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbModelPhoneEdit.Location = new System.Drawing.Point(5, 15);
            this.lbModelPhoneEdit.Name = "lbModelPhoneEdit";
            this.lbModelPhoneEdit.Size = new System.Drawing.Size(69, 17);
            this.lbModelPhoneEdit.TabIndex = 10;
            this.lbModelPhoneEdit.Text = "Модель:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 510);
            this.Controls.Add(this.splGeneral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(730, 540);
            this.Name = "MainForm";
            this.Text = "Mobile Store";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splGeneral.Panel1.ResumeLayout(false);
            this.splGeneral.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splGeneral)).EndInit();
            this.splGeneral.ResumeLayout(false);
            this.grpListOfPhones.ResumeLayout(false);
            this.splListPhone.Panel1.ResumeLayout(false);
            this.splListPhone.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splListPhone)).EndInit();
            this.splListPhone.ResumeLayout(false);
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.tabPhones.ResumeLayout(false);
            this.tabPhoneInfo.ResumeLayout(false);
            this.tabPhoneInfo.PerformLayout();
            this.grpOptionsInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctImagePhoneInfo)).EndInit();
            this.tabEditPhoneInfo.ResumeLayout(false);
            this.tableLayoutPanelPhoneEdit.ResumeLayout(false);
            this.grpPhoneOptionEdit.ResumeLayout(false);
            this.grpPhoneOptionEdit.PerformLayout();
            this.tableLayoutPanelOptionsEdit.ResumeLayout(false);
            this.grpPhoneInfoEdit.ResumeLayout(false);
            this.grpPhoneInfoEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splGeneral;
        private System.Windows.Forms.GroupBox grpListOfPhones;
        private System.Windows.Forms.SplitContainer splListPhone;
        private System.Windows.Forms.TabControl tabPhones;
        private System.Windows.Forms.TabPage tabPhoneInfo;
        private System.Windows.Forms.TabPage tabEditPhoneInfo;
        private System.Windows.Forms.GroupBox grpOptionsInfo;
        private System.Windows.Forms.ListBox lstOtionsInfo;
        private System.Windows.Forms.PictureBox pctImagePhoneInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.ListBox lstListOfPhones;
        private System.Windows.Forms.TextBox tbPricePhoneInfo;
        private System.Windows.Forms.TextBox tbCPUPhoneInfo;
        private System.Windows.Forms.TextBox tbOsPhoneInfo;
        private System.Windows.Forms.TextBox tbModelPhoneInfo;
        private System.Windows.Forms.Label lbPricePhoneInfo;
        private System.Windows.Forms.Label lbCPUPhoneInfo;
        private System.Windows.Forms.Label lbOsPhoneInfo;
        private System.Windows.Forms.Label lbModelPhoneInfo;
        private System.Windows.Forms.GroupBox grpPhoneOptionEdit;
        private System.Windows.Forms.TextBox tbNameOptionEdit;
        private System.Windows.Forms.Label lbNameOptionEdit;
        private System.Windows.Forms.Button btnSaveChangesEdit;
        private System.Windows.Forms.CheckedListBox lstOptionsEdit;
        private System.Windows.Forms.GroupBox grpPhoneInfoEdit;
        private System.Windows.Forms.TextBox tbPricePhoneEdit;
        private System.Windows.Forms.Label lbPricePhoneEdit;
        private System.Windows.Forms.TextBox tbImagePhoneEdit;
        private System.Windows.Forms.TextBox tbCPUPhoneEdit;
        private System.Windows.Forms.TextBox tbOsPhoneEdit;
        private System.Windows.Forms.TextBox tbModelPhoneEdit;
        private System.Windows.Forms.Label lbImagePhoneEdit;
        private System.Windows.Forms.Label lbCPUPhoneEdit;
        private System.Windows.Forms.Label lbOsPhoneEdit;
        private System.Windows.Forms.Label lbModelPhoneEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPhoneEdit;
        private System.Windows.Forms.Button btnClearEdit;
        private System.Windows.Forms.Button btnAddNewPhoneEdit;
        private System.Windows.Forms.Button btnAddOptionEdit;
        private System.Windows.Forms.Button btnDeleteOptionEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOptionsEdit;
    }
}

