namespace WindowsFormsApp4
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SignUpBT = new System.Windows.Forms.Button();
            this.SignInBT = new System.Windows.Forms.Button();
            this.CarBrandsBT = new System.Windows.Forms.Button();
            this.signIn1 = new WindowsFormsApp4.SignIn();
            this.carBrand1 = new WindowsFormsApp4.CarBrand();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.SignUpBT);
            this.panel1.Controls.Add(this.SignInBT);
            this.panel1.Controls.Add(this.CarBrandsBT);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 531);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(185, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 449);
            this.panel2.TabIndex = 1;
            // 
            // SignUpBT
            // 
            this.SignUpBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignUpBT.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignUpBT.Location = new System.Drawing.Point(0, 266);
            this.SignUpBT.Name = "SignUpBT";
            this.SignUpBT.Size = new System.Drawing.Size(179, 55);
            this.SignUpBT.TabIndex = 2;
            this.SignUpBT.Text = "Sign Up";
            this.SignUpBT.UseVisualStyleBackColor = true;
            this.SignUpBT.Click += new System.EventHandler(this.SignUpBT_Click);
            // 
            // SignInBT
            // 
            this.SignInBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignInBT.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignInBT.Location = new System.Drawing.Point(0, 205);
            this.SignInBT.Name = "SignInBT";
            this.SignInBT.Size = new System.Drawing.Size(179, 55);
            this.SignInBT.TabIndex = 1;
            this.SignInBT.Text = "Sign In";
            this.SignInBT.UseVisualStyleBackColor = true;
            this.SignInBT.Click += new System.EventHandler(this.SignInBT_Click);
            // 
            // CarBrandsBT
            // 
            this.CarBrandsBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CarBrandsBT.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarBrandsBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CarBrandsBT.Location = new System.Drawing.Point(0, 144);
            this.CarBrandsBT.Name = "CarBrandsBT";
            this.CarBrandsBT.Size = new System.Drawing.Size(179, 55);
            this.CarBrandsBT.TabIndex = 0;
            this.CarBrandsBT.Text = "Car Brands";
            this.CarBrandsBT.UseVisualStyleBackColor = true;
            this.CarBrandsBT.Click += new System.EventHandler(this.CarBrandsBT_Click);
            // 
            // signIn1
            // 
            this.signIn1.Location = new System.Drawing.Point(212, 6);
            this.signIn1.Name = "signIn1";
            this.signIn1.Size = new System.Drawing.Size(817, 531);
            this.signIn1.TabIndex = 2;
            // 
            // carBrand1
            // 
            this.carBrand1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carBrand1.Location = new System.Drawing.Point(199, 3);
            this.carBrand1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.carBrand1.Name = "carBrand1";
            this.carBrand1.Size = new System.Drawing.Size(863, 531);
            this.carBrand1.TabIndex = 1;
            this.carBrand1.Load += new System.EventHandler(this.carBrand1_Load);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 536);
            this.Controls.Add(this.signIn1);
            this.Controls.Add(this.carBrand1);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Car Agency";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SignUpBT;
        private System.Windows.Forms.Button SignInBT;
        private System.Windows.Forms.Button CarBrandsBT;
        private System.Windows.Forms.Panel panel2;
        private CarBrand carBrand1;
        private SignIn signIn1;
    }
}

