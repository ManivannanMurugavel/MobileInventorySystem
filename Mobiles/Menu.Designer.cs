namespace Mobiles
{
	partial class Menu
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
            this.prdDetails = new System.Windows.Forms.Button();
            this.ordDetails = new System.Windows.Forms.Button();
            this.custDetails = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose";
            // 
            // prdDetails
            // 
            this.prdDetails.BackColor = System.Drawing.Color.White;
            this.prdDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prdDetails.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdDetails.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.prdDetails.Location = new System.Drawing.Point(381, 165);
            this.prdDetails.Name = "prdDetails";
            this.prdDetails.Size = new System.Drawing.Size(217, 73);
            this.prdDetails.TabIndex = 1;
            this.prdDetails.Text = "Product Details";
            this.prdDetails.UseVisualStyleBackColor = false;
            this.prdDetails.Click += new System.EventHandler(this.prdDetails_Click);
            // 
            // ordDetails
            // 
            this.ordDetails.BackColor = System.Drawing.Color.White;
            this.ordDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordDetails.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordDetails.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ordDetails.Location = new System.Drawing.Point(381, 370);
            this.ordDetails.Name = "ordDetails";
            this.ordDetails.Size = new System.Drawing.Size(217, 73);
            this.ordDetails.TabIndex = 2;
            this.ordDetails.Text = "Order Details";
            this.ordDetails.UseVisualStyleBackColor = false;
            this.ordDetails.Click += new System.EventHandler(this.ordDetails_Click);
            // 
            // custDetails
            // 
            this.custDetails.BackColor = System.Drawing.Color.White;
            this.custDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custDetails.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custDetails.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.custDetails.Location = new System.Drawing.Point(860, 165);
            this.custDetails.Name = "custDetails";
            this.custDetails.Size = new System.Drawing.Size(217, 73);
            this.custDetails.TabIndex = 3;
            this.custDetails.Text = "Customer Details";
            this.custDetails.UseVisualStyleBackColor = false;
            this.custDetails.Click += new System.EventHandler(this.custDetails_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(655, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(860, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 73);
            this.button2.TabIndex = 5;
            this.button2.Text = "Create User";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1362, 686);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.custDetails);
            this.Controls.Add(this.ordDetails);
            this.Controls.Add(this.prdDetails);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button prdDetails;
		private System.Windows.Forms.Button ordDetails;
		private System.Windows.Forms.Button custDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}