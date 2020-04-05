namespace ModelUI
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сущностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductListForChoose = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductListForSale = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.SumPayLabel = new System.Windows.Forms.Label();
            this.PayButton = new System.Windows.Forms.Button();
            this.LoginLinkLabel = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сущностиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сущностиToolStripMenuItem
            // 
            this.сущностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientToolStripMenuItem,
            this.SellerToolStripMenuItem,
            this.ProductToolStripMenuItem,
            this.CheckToolStripMenuItem});
            this.сущностиToolStripMenuItem.Name = "сущностиToolStripMenuItem";
            this.сущностиToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.сущностиToolStripMenuItem.Text = "Сущности";
            // 
            // ClientToolStripMenuItem
            // 
            this.ClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem});
            this.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
            this.ClientToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ClientToolStripMenuItem.Text = "Клиенты";
            this.ClientToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // SellerToolStripMenuItem
            // 
            this.SellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem1});
            this.SellerToolStripMenuItem.Name = "SellerToolStripMenuItem";
            this.SellerToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.SellerToolStripMenuItem.Text = "Продавцы";
            this.SellerToolStripMenuItem.Click += new System.EventHandler(this.SellerToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem1
            // 
            this.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1";
            this.AddToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.AddToolStripMenuItem1.Text = "Добавить";
            this.AddToolStripMenuItem1.Click += new System.EventHandler(this.AddToolStripMenuItem1_Click);
            // 
            // ProductToolStripMenuItem
            // 
            this.ProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem2});
            this.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
            this.ProductToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ProductToolStripMenuItem.Text = "Продукты";
            this.ProductToolStripMenuItem.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem2
            // 
            this.AddToolStripMenuItem2.Name = "AddToolStripMenuItem2";
            this.AddToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.AddToolStripMenuItem2.Text = "Добавить";
            this.AddToolStripMenuItem2.Click += new System.EventHandler(this.AddToolStripMenuItem2_Click);
            // 
            // CheckToolStripMenuItem
            // 
            this.CheckToolStripMenuItem.Name = "CheckToolStripMenuItem";
            this.CheckToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.CheckToolStripMenuItem.Text = "Чеки";
            this.CheckToolStripMenuItem.Click += new System.EventHandler(this.CheckToolStripMenuItem_Click);
            // 
            // ProductListForChoose
            // 
            this.ProductListForChoose.FormattingEnabled = true;
            this.ProductListForChoose.Location = new System.Drawing.Point(13, 55);
            this.ProductListForChoose.Name = "ProductListForChoose";
            this.ProductListForChoose.Size = new System.Drawing.Size(241, 446);
            this.ProductListForChoose.TabIndex = 1;
            this.ProductListForChoose.DoubleClick += new System.EventHandler(this.ProductListForChoose_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Продукты в базе:";
            // 
            // ProductListForSale
            // 
            this.ProductListForSale.FormattingEnabled = true;
            this.ProductListForSale.Location = new System.Drawing.Point(291, 55);
            this.ProductListForSale.Name = "ProductListForSale";
            this.ProductListForSale.Size = new System.Drawing.Size(252, 394);
            this.ProductListForSale.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выбраные продукты для покупки:";
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(288, 452);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(91, 13);
            this.SumLabel.TabIndex = 5;
            this.SumLabel.Text = "Сумма к оплате:";
            // 
            // SumPayLabel
            // 
            this.SumPayLabel.AutoSize = true;
            this.SumPayLabel.Location = new System.Drawing.Point(385, 452);
            this.SumPayLabel.Name = "SumPayLabel";
            this.SumPayLabel.Size = new System.Drawing.Size(28, 13);
            this.SumPayLabel.TabIndex = 6;
            this.SumPayLabel.Text = "0.00";
            // 
            // PayButton
            // 
            this.PayButton.Location = new System.Drawing.Point(464, 480);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(75, 23);
            this.PayButton.TabIndex = 7;
            this.PayButton.Text = "Оплатить";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // LoginLinkLabel
            // 
            this.LoginLinkLabel.AutoSize = true;
            this.LoginLinkLabel.Location = new System.Drawing.Point(601, 28);
            this.LoginLinkLabel.Name = "LoginLinkLabel";
            this.LoginLinkLabel.Size = new System.Drawing.Size(83, 13);
            this.LoginLinkLabel.TabIndex = 8;
            this.LoginLinkLabel.TabStop = true;
            this.LoginLinkLabel.Text = "Авторизуйтесь";
            this.LoginLinkLabel.Click += new System.EventHandler(this.LoginLinkLabel_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 515);
            this.Controls.Add(this.LoginLinkLabel);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.SumPayLabel);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductListForSale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductListForChoose);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сущностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem2;
        private System.Windows.Forms.ListBox ProductListForChoose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ProductListForSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label SumPayLabel;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.LinkLabel LoginLinkLabel;
    }
}

