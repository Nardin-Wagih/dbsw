namespace WindowsFormsApp4
{
    partial class CarBrand
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarBrand));
            this.MINIBT = new System.Windows.Forms.Button();
            this.BMWBT = new System.Windows.Forms.Button();
            this.PEUGEOTBT = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MINIBT
            // 
            this.MINIBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MINIBT.BackgroundImage")));
            this.MINIBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MINIBT.Location = new System.Drawing.Point(89, 72);
            this.MINIBT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MINIBT.Name = "MINIBT";
            this.MINIBT.Size = new System.Drawing.Size(191, 143);
            this.MINIBT.TabIndex = 0;
            this.MINIBT.UseVisualStyleBackColor = true;
            this.MINIBT.Click += new System.EventHandler(this.MINIBT_Click);
            // 
            // BMWBT
            // 
            this.BMWBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BMWBT.BackgroundImage")));
            this.BMWBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BMWBT.Location = new System.Drawing.Point(524, 57);
            this.BMWBT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BMWBT.Name = "BMWBT";
            this.BMWBT.Size = new System.Drawing.Size(191, 143);
            this.BMWBT.TabIndex = 1;
            this.BMWBT.UseVisualStyleBackColor = true;
            this.BMWBT.Click += new System.EventHandler(this.BMWBT_Click);
            // 
            // PEUGEOTBT
            // 
            this.PEUGEOTBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PEUGEOTBT.BackgroundImage")));
            this.PEUGEOTBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PEUGEOTBT.Location = new System.Drawing.Point(321, 268);
            this.PEUGEOTBT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PEUGEOTBT.Name = "PEUGEOTBT";
            this.PEUGEOTBT.Size = new System.Drawing.Size(191, 143);
            this.PEUGEOTBT.TabIndex = 2;
            this.PEUGEOTBT.UseVisualStyleBackColor = true;
            this.PEUGEOTBT.Click += new System.EventHandler(this.PEUGEOTBT_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(114, 221);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 37);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "MINI";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(548, 221);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 37);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "BMW";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(347, 417);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 37);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Peugeot";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CarBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PEUGEOTBT);
            this.Controls.Add(this.BMWBT);
            this.Controls.Add(this.MINIBT);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CarBrand";
            this.Size = new System.Drawing.Size(817, 531);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MINIBT;
        private System.Windows.Forms.Button BMWBT;
        private System.Windows.Forms.Button PEUGEOTBT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}
