namespace HW_2
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
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.prgOrders = new System.Windows.Forms.ProgressBar();
            this.btnOrders = new System.Windows.Forms.Button();
            this.lbOrders = new System.Windows.Forms.Label();
            this.tabPageEmployees = new System.Windows.Forms.TabPage();
            this.dgEmployees = new System.Windows.Forms.DataGridView();
            this.prgEmployees = new System.Windows.Forms.ProgressBar();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.lbEmployees = new System.Windows.Forms.Label();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.prgProducts = new System.Windows.Forms.ProgressBar();
            this.btnProducts = new System.Windows.Forms.Button();
            this.lbProducts = new System.Windows.Forms.Label();
            this.tabPageCountClients = new System.Windows.Forms.TabPage();
            this.dgCountClients = new System.Windows.Forms.DataGridView();
            this.prgCountClients = new System.Windows.Forms.ProgressBar();
            this.btnCountClients = new System.Windows.Forms.Button();
            this.lbCountClients = new System.Windows.Forms.Label();
            this.tabPageClientOrderInfo = new System.Windows.Forms.TabPage();
            this.dgClientOrderInfo = new System.Windows.Forms.DataGridView();
            this.prgClientOrderInfo = new System.Windows.Forms.ProgressBar();
            this.btnClientOrderInfo = new System.Windows.Forms.Button();
            this.lbClientOrderInfo = new System.Windows.Forms.Label();
            this.tabCtrl.SuspendLayout();
            this.tabPageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            this.tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            this.tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.tabPageCountClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCountClients)).BeginInit();
            this.tabPageClientOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientOrderInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabPageOrders);
            this.tabCtrl.Controls.Add(this.tabPageEmployees);
            this.tabCtrl.Controls.Add(this.tabPageProducts);
            this.tabCtrl.Controls.Add(this.tabPageCountClients);
            this.tabCtrl.Controls.Add(this.tabPageClientOrderInfo);
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(800, 450);
            this.tabCtrl.TabIndex = 0;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Controls.Add(this.dgOrders);
            this.tabPageOrders.Controls.Add(this.prgOrders);
            this.tabPageOrders.Controls.Add(this.btnOrders);
            this.tabPageOrders.Controls.Add(this.lbOrders);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(792, 424);
            this.tabPageOrders.TabIndex = 0;
            this.tabPageOrders.Text = "Заказы ";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // dgOrders
            // 
            this.dgOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.Location = new System.Drawing.Point(13, 68);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.Size = new System.Drawing.Size(771, 348);
            this.dgOrders.TabIndex = 4;
            // 
            // prgOrders
            // 
            this.prgOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgOrders.Location = new System.Drawing.Point(457, 38);
            this.prgOrders.Name = "prgOrders";
            this.prgOrders.Size = new System.Drawing.Size(327, 23);
            this.prgOrders.TabIndex = 3;
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(293, 39);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(75, 23);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Получить";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.button_Click);
            // 
            // lbOrders
            // 
            this.lbOrders.AutoSize = true;
            this.lbOrders.Location = new System.Drawing.Point(10, 44);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(179, 13);
            this.lbOrders.TabIndex = 0;
            this.lbOrders.Text = "Информация о заказах клиентов ";
            // 
            // tabPageEmployees
            // 
            this.tabPageEmployees.Controls.Add(this.dgEmployees);
            this.tabPageEmployees.Controls.Add(this.prgEmployees);
            this.tabPageEmployees.Controls.Add(this.btnEmployees);
            this.tabPageEmployees.Controls.Add(this.lbEmployees);
            this.tabPageEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployees.Name = "tabPageEmployees";
            this.tabPageEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployees.Size = new System.Drawing.Size(792, 424);
            this.tabPageEmployees.TabIndex = 1;
            this.tabPageEmployees.Text = "Служащие";
            this.tabPageEmployees.UseVisualStyleBackColor = true;
            // 
            // dgEmployees
            // 
            this.dgEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployees.Location = new System.Drawing.Point(11, 68);
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.Size = new System.Drawing.Size(771, 348);
            this.dgEmployees.TabIndex = 8;
            // 
            // prgEmployees
            // 
            this.prgEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgEmployees.Location = new System.Drawing.Point(457, 38);
            this.prgEmployees.Name = "prgEmployees";
            this.prgEmployees.Size = new System.Drawing.Size(327, 23);
            this.prgEmployees.TabIndex = 7;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(293, 39);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(75, 23);
            this.btnEmployees.TabIndex = 5;
            this.btnEmployees.Text = "Получить";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.button_Click);
            // 
            // lbEmployees
            // 
            this.lbEmployees.AutoSize = true;
            this.lbEmployees.Location = new System.Drawing.Point(10, 44);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(136, 13);
            this.lbEmployees.TabIndex = 4;
            this.lbEmployees.Text = "Информация о служащих";
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.dgProducts);
            this.tabPageProducts.Controls.Add(this.prgProducts);
            this.tabPageProducts.Controls.Add(this.btnProducts);
            this.tabPageProducts.Controls.Add(this.lbProducts);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 22);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(792, 424);
            this.tabPageProducts.TabIndex = 2;
            this.tabPageProducts.Text = "Продукты";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // dgProducts
            // 
            this.dgProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Location = new System.Drawing.Point(11, 68);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.Size = new System.Drawing.Size(771, 348);
            this.dgProducts.TabIndex = 8;
            // 
            // prgProducts
            // 
            this.prgProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgProducts.Location = new System.Drawing.Point(457, 38);
            this.prgProducts.Name = "prgProducts";
            this.prgProducts.Size = new System.Drawing.Size(327, 23);
            this.prgProducts.TabIndex = 7;
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(293, 39);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(75, 23);
            this.btnProducts.TabIndex = 5;
            this.btnProducts.Text = "Получить";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.button_Click);
            // 
            // lbProducts
            // 
            this.lbProducts.AutoSize = true;
            this.lbProducts.Location = new System.Drawing.Point(10, 44);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(136, 13);
            this.lbProducts.TabIndex = 4;
            this.lbProducts.Text = "Информация о продуктах";
            // 
            // tabPageCountClients
            // 
            this.tabPageCountClients.Controls.Add(this.dgCountClients);
            this.tabPageCountClients.Controls.Add(this.prgCountClients);
            this.tabPageCountClients.Controls.Add(this.btnCountClients);
            this.tabPageCountClients.Controls.Add(this.lbCountClients);
            this.tabPageCountClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageCountClients.Name = "tabPageCountClients";
            this.tabPageCountClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCountClients.Size = new System.Drawing.Size(792, 424);
            this.tabPageCountClients.TabIndex = 3;
            this.tabPageCountClients.Text = "Количество клиентов в городе";
            this.tabPageCountClients.UseVisualStyleBackColor = true;
            // 
            // dgCountClients
            // 
            this.dgCountClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCountClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCountClients.Location = new System.Drawing.Point(11, 68);
            this.dgCountClients.Name = "dgCountClients";
            this.dgCountClients.Size = new System.Drawing.Size(771, 348);
            this.dgCountClients.TabIndex = 8;
            // 
            // prgCountClients
            // 
            this.prgCountClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgCountClients.Location = new System.Drawing.Point(457, 38);
            this.prgCountClients.Name = "prgCountClients";
            this.prgCountClients.Size = new System.Drawing.Size(327, 23);
            this.prgCountClients.TabIndex = 7;
            // 
            // btnCountClients
            // 
            this.btnCountClients.Location = new System.Drawing.Point(293, 39);
            this.btnCountClients.Name = "btnCountClients";
            this.btnCountClients.Size = new System.Drawing.Size(75, 23);
            this.btnCountClients.TabIndex = 5;
            this.btnCountClients.Text = "Получить";
            this.btnCountClients.UseVisualStyleBackColor = true;
            this.btnCountClients.Click += new System.EventHandler(this.button_Click);
            // 
            // lbCountClients
            // 
            this.lbCountClients.AutoSize = true;
            this.lbCountClients.Location = new System.Drawing.Point(10, 44);
            this.lbCountClients.Name = "lbCountClients";
            this.lbCountClients.Size = new System.Drawing.Size(178, 13);
            this.lbCountClients.TabIndex = 4;
            this.lbCountClients.Text = "Информация о клиентах в городе";
            // 
            // tabPageClientOrderInfo
            // 
            this.tabPageClientOrderInfo.Controls.Add(this.dgClientOrderInfo);
            this.tabPageClientOrderInfo.Controls.Add(this.prgClientOrderInfo);
            this.tabPageClientOrderInfo.Controls.Add(this.btnClientOrderInfo);
            this.tabPageClientOrderInfo.Controls.Add(this.lbClientOrderInfo);
            this.tabPageClientOrderInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageClientOrderInfo.Name = "tabPageClientOrderInfo";
            this.tabPageClientOrderInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClientOrderInfo.Size = new System.Drawing.Size(792, 424);
            this.tabPageClientOrderInfo.TabIndex = 4;
            this.tabPageClientOrderInfo.Text = "Клиенты общая информация";
            this.tabPageClientOrderInfo.UseVisualStyleBackColor = true;
            // 
            // dgClientOrderInfo
            // 
            this.dgClientOrderInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgClientOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientOrderInfo.Location = new System.Drawing.Point(11, 68);
            this.dgClientOrderInfo.Name = "dgClientOrderInfo";
            this.dgClientOrderInfo.Size = new System.Drawing.Size(771, 348);
            this.dgClientOrderInfo.TabIndex = 8;
            // 
            // prgClientOrderInfo
            // 
            this.prgClientOrderInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgClientOrderInfo.Location = new System.Drawing.Point(457, 38);
            this.prgClientOrderInfo.Name = "prgClientOrderInfo";
            this.prgClientOrderInfo.Size = new System.Drawing.Size(327, 23);
            this.prgClientOrderInfo.TabIndex = 7;
            // 
            // btnClientOrderInfo
            // 
            this.btnClientOrderInfo.Location = new System.Drawing.Point(293, 39);
            this.btnClientOrderInfo.Name = "btnClientOrderInfo";
            this.btnClientOrderInfo.Size = new System.Drawing.Size(75, 23);
            this.btnClientOrderInfo.TabIndex = 5;
            this.btnClientOrderInfo.Text = "Получить";
            this.btnClientOrderInfo.UseVisualStyleBackColor = true;
            this.btnClientOrderInfo.Click += new System.EventHandler(this.button_Click);
            // 
            // lbClientOrderInfo
            // 
            this.lbClientOrderInfo.AutoSize = true;
            this.lbClientOrderInfo.Location = new System.Drawing.Point(10, 44);
            this.lbClientOrderInfo.Name = "lbClientOrderInfo";
            this.lbClientOrderInfo.Size = new System.Drawing.Size(216, 13);
            this.lbClientOrderInfo.TabIndex = 4;
            this.lbClientOrderInfo.Text = "Информация о сумме заказов клиентов ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCtrl);
            this.Name = "MainForm";
            this.Text = "Технология ADO.NET";
            this.tabCtrl.ResumeLayout(false);
            this.tabPageOrders.ResumeLayout(false);
            this.tabPageOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            this.tabPageEmployees.ResumeLayout(false);
            this.tabPageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            this.tabPageProducts.ResumeLayout(false);
            this.tabPageProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.tabPageCountClients.ResumeLayout(false);
            this.tabPageCountClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCountClients)).EndInit();
            this.tabPageClientOrderInfo.ResumeLayout(false);
            this.tabPageClientOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientOrderInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.TabPage tabPageEmployees;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.TabPage tabPageCountClients;
        private System.Windows.Forms.TabPage tabPageClientOrderInfo;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Label lbOrders;
        private System.Windows.Forms.ProgressBar prgOrders;
        private System.Windows.Forms.ProgressBar prgEmployees;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Label lbEmployees;
        private System.Windows.Forms.ProgressBar prgProducts;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Label lbProducts;
        private System.Windows.Forms.ProgressBar prgCountClients;
        private System.Windows.Forms.Button btnCountClients;
        private System.Windows.Forms.Label lbCountClients;
        private System.Windows.Forms.ProgressBar prgClientOrderInfo;
        private System.Windows.Forms.Button btnClientOrderInfo;
        private System.Windows.Forms.Label lbClientOrderInfo;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.DataGridView dgEmployees;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.DataGridView dgCountClients;
        private System.Windows.Forms.DataGridView dgClientOrderInfo;
    }
}

