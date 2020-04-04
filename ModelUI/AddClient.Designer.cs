namespace ModelUI
{
    partial class AddClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameClientTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgeClientNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.AgeClientNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(75, 10);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(248, 20);
            this.ClientNameTextBox.TabIndex = 1;
            this.ClientNameTextBox.TextChanged += new System.EventHandler(this.ClientNameTextBox_TextChanged);
            // 
            // AddCustomer
            // 
            this.AddCustomer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddCustomer.Location = new System.Drawing.Point(248, 415);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(75, 23);
            this.AddCustomer.TabIndex = 2;
            this.AddCustomer.Text = "Добавить";
            this.AddCustomer.UseVisualStyleBackColor = true;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // SurnameClientTextBox
            // 
            this.SurnameClientTextBox.Location = new System.Drawing.Point(75, 46);
            this.SurnameClientTextBox.Name = "SurnameClientTextBox";
            this.SurnameClientTextBox.Size = new System.Drawing.Size(248, 20);
            this.SurnameClientTextBox.TabIndex = 4;
            this.SurnameClientTextBox.TextChanged += new System.EventHandler(this.SurnameClientTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Возраст";
            // 
            // AgeClientNumeric
            // 
            this.AgeClientNumeric.Location = new System.Drawing.Point(75, 81);
            this.AgeClientNumeric.Name = "AgeClientNumeric";
            this.AgeClientNumeric.Size = new System.Drawing.Size(120, 20);
            this.AgeClientNumeric.TabIndex = 6;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.AgeClientNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SurnameClientTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddCustomer);
            this.Controls.Add(this.ClientNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddClient";
            this.Text = "AddClient";
            ((System.ComponentModel.ISupportInitialize)(this.AgeClientNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurnameClientTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AgeClientNumeric;
    }
}