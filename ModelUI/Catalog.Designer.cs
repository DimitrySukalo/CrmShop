namespace ModelUI
{
    partial class Catalog<T>
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
            this.CatalogDataGrig = new System.Windows.Forms.DataGridView();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ChangeItemButton = new System.Windows.Forms.Button();
            this.DeleteItemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogDataGrig)).BeginInit();
            this.SuspendLayout();
            // 
            // CatalogDataGrig
            // 
            this.CatalogDataGrig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatalogDataGrig.Location = new System.Drawing.Point(13, 13);
            this.CatalogDataGrig.Name = "CatalogDataGrig";
            this.CatalogDataGrig.Size = new System.Drawing.Size(819, 413);
            this.CatalogDataGrig.TabIndex = 0;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(252, 438);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(97, 23);
            this.AddItemButton.TabIndex = 1;
            this.AddItemButton.Text = "Добавить";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // ChangeItemButton
            // 
            this.ChangeItemButton.Location = new System.Drawing.Point(368, 438);
            this.ChangeItemButton.Name = "ChangeItemButton";
            this.ChangeItemButton.Size = new System.Drawing.Size(97, 23);
            this.ChangeItemButton.TabIndex = 2;
            this.ChangeItemButton.Text = "Изменить";
            this.ChangeItemButton.UseVisualStyleBackColor = true;
            this.ChangeItemButton.Click += new System.EventHandler(this.ChangeItemButton_Click);
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.Location = new System.Drawing.Point(481, 438);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(97, 23);
            this.DeleteItemButton.TabIndex = 3;
            this.DeleteItemButton.Text = "Удалить";
            this.DeleteItemButton.UseVisualStyleBackColor = true;
            this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 473);
            this.Controls.Add(this.DeleteItemButton);
            this.Controls.Add(this.ChangeItemButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.CatalogDataGrig);
            this.Name = "Catalog";
            this.Text = "Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.CatalogDataGrig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CatalogDataGrig;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button ChangeItemButton;
        private System.Windows.Forms.Button DeleteItemButton;
    }
}