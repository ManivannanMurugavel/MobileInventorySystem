namespace Mobiles
{
	partial class ProductDetails
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
            this.addProduct = new System.Windows.Forms.Button();
            this.showProduct = new System.Windows.Forms.Button();
            this.productLists = new System.Windows.Forms.DataGridView();
            this.updateProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productLists)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(531, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Details";
            // 
            // addProduct
            // 
            this.addProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addProduct.Location = new System.Drawing.Point(92, 153);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(215, 57);
            this.addProduct.TabIndex = 1;
            this.addProduct.Text = "ADD PRODUCT";
            this.addProduct.UseVisualStyleBackColor = false;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // showProduct
            // 
            this.showProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.showProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.showProduct.Location = new System.Drawing.Point(1068, 153);
            this.showProduct.Name = "showProduct";
            this.showProduct.Size = new System.Drawing.Size(213, 57);
            this.showProduct.TabIndex = 2;
            this.showProduct.Text = "SHOW PRODUCT";
            this.showProduct.UseVisualStyleBackColor = false;
            this.showProduct.Click += new System.EventHandler(this.showProduct_Click);
            // 
            // productLists
            // 
            this.productLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productLists.Location = new System.Drawing.Point(189, 258);
            this.productLists.Name = "productLists";
            this.productLists.Size = new System.Drawing.Size(961, 391);
            this.productLists.TabIndex = 3;
            // 
            // updateProduct
            // 
            this.updateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.updateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.updateProduct.Location = new System.Drawing.Point(418, 153);
            this.updateProduct.Name = "updateProduct";
            this.updateProduct.Size = new System.Drawing.Size(244, 57);
            this.updateProduct.TabIndex = 4;
            this.updateProduct.Text = "UPDATE PRODUCT";
            this.updateProduct.UseVisualStyleBackColor = false;
            this.updateProduct.Click += new System.EventHandler(this.updateProduct_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deleteProduct.Location = new System.Drawing.Point(752, 153);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(246, 57);
            this.deleteProduct.TabIndex = 5;
            this.deleteProduct.Text = "DELETE PRODUCT";
            this.deleteProduct.UseVisualStyleBackColor = false;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(1205, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1362, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.updateProduct);
            this.Controls.Add(this.productLists);
            this.Controls.Add(this.showProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.label1);
            this.Name = "ProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productLists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button addProduct;
		private System.Windows.Forms.Button showProduct;
		private System.Windows.Forms.DataGridView productLists;
		private System.Windows.Forms.Button updateProduct;
		private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button button1;
    }
}