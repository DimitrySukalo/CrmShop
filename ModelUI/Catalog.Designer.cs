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
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 436);
            this.Controls.Add(this.CatalogDataGrig);
            this.Name = "Catalog";
            this.Text = "Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.CatalogDataGrig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CatalogDataGrig;
    }
}