namespace ModelUI
{
    partial class AddProduct
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
            this.AddProductButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductPriceNumberic = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.DateOfCreatingProduct = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNumberic)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductButton
            // 
            this.AddProductButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddProductButton.Location = new System.Drawing.Point(255, 415);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(75, 23);
            this.AddProductButton.TabIndex = 0;
            this.AddProductButton.Text = "Добавить";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(85, 10);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(245, 20);
            this.ProductNameTextBox.TabIndex = 2;
            this.ProductNameTextBox.TextChanged += new System.EventHandler(this.ProductNameTextBox_TextChanged);
            // 
            // ProductPriceNumberic
            // 
            this.ProductPriceNumberic.DecimalPlaces = 2;
            this.ProductPriceNumberic.Location = new System.Drawing.Point(85, 45);
            this.ProductPriceNumberic.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.ProductPriceNumberic.Name = "ProductPriceNumberic";
            this.ProductPriceNumberic.Size = new System.Drawing.Size(245, 20);
            this.ProductPriceNumberic.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена";
            // 
            // DateOfCreatingProduct
            // 
            this.DateOfCreatingProduct.Location = new System.Drawing.Point(85, 81);
            this.DateOfCreatingProduct.Name = "DateOfCreatingProduct";
            this.DateOfCreatingProduct.Size = new System.Drawing.Size(245, 20);
            this.DateOfCreatingProduct.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Создан";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateOfCreatingProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductPriceNumberic);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddProductButton);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceNumberic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.NumericUpDown ProductPriceNumberic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateOfCreatingProduct;
        private System.Windows.Forms.Label label3;
    }
}