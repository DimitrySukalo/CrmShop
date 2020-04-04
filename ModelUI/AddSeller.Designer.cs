namespace ModelUI
{
    partial class AddSeller
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
            this.AddSellerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SellerNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SellerSurname = new System.Windows.Forms.TextBox();
            this.SellerLastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SellerAgeNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SellerAgeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // AddSellerButton
            // 
            this.AddSellerButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddSellerButton.Location = new System.Drawing.Point(280, 415);
            this.AddSellerButton.Name = "AddSellerButton";
            this.AddSellerButton.Size = new System.Drawing.Size(75, 23);
            this.AddSellerButton.TabIndex = 0;
            this.AddSellerButton.Text = "Добавить";
            this.AddSellerButton.UseVisualStyleBackColor = true;
            this.AddSellerButton.Click += new System.EventHandler(this.AddSellerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // SellerNameTextBox
            // 
            this.SellerNameTextBox.Location = new System.Drawing.Point(95, 13);
            this.SellerNameTextBox.Name = "SellerNameTextBox";
            this.SellerNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.SellerNameTextBox.TabIndex = 2;
            this.SellerNameTextBox.TextChanged += new System.EventHandler(this.SellerNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // SellerSurname
            // 
            this.SellerSurname.Location = new System.Drawing.Point(95, 50);
            this.SellerSurname.Name = "SellerSurname";
            this.SellerSurname.Size = new System.Drawing.Size(260, 20);
            this.SellerSurname.TabIndex = 5;
            this.SellerSurname.TextChanged += new System.EventHandler(this.SellerSurname_TextChanged);
            // 
            // SellerLastname
            // 
            this.SellerLastname.Location = new System.Drawing.Point(95, 83);
            this.SellerLastname.Name = "SellerLastname";
            this.SellerLastname.Size = new System.Drawing.Size(260, 20);
            this.SellerLastname.TabIndex = 6;
            this.SellerLastname.TextChanged += new System.EventHandler(this.SellerLastname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Возраст";
            // 
            // SellerAgeNumeric
            // 
            this.SellerAgeNumeric.Location = new System.Drawing.Point(95, 120);
            this.SellerAgeNumeric.Name = "SellerAgeNumeric";
            this.SellerAgeNumeric.Size = new System.Drawing.Size(260, 20);
            this.SellerAgeNumeric.TabIndex = 8;
            // 
            // AddSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.SellerAgeNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SellerLastname);
            this.Controls.Add(this.SellerSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SellerNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddSellerButton);
            this.Name = "AddSeller";
            this.Text = "AddSeller";
            ((System.ComponentModel.ISupportInitialize)(this.SellerAgeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSellerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SellerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SellerSurname;
        private System.Windows.Forms.TextBox SellerLastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown SellerAgeNumeric;
    }
}