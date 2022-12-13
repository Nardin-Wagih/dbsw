namespace WindowsFormsApp4
{
    partial class Peugeot
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
            System.Windows.Forms.Label iD_ModelLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label transmissionLabel;
            System.Windows.Forms.Label engine_CapacityLabel;
            System.Windows.Forms.Label horse_PowerLabel;
            System.Windows.Forms.Label fuel_tanksLabel;
            System.Windows.Forms.Label manufacturing_YearLabel;
            System.Windows.Forms.Label maximum_SpeedLabel;
            System.Windows.Forms.Label kilometersLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.C2008BT = new System.Windows.Forms.Button();
            this.C508BT = new System.Windows.Forms.Button();
            this.C3008BT = new System.Windows.Forms.Button();
            this.SearchBT = new System.Windows.Forms.Button();
            this.iD_ModelTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.transmissionTextBox = new System.Windows.Forms.TextBox();
            this.engine_CapacityTextBox = new System.Windows.Forms.TextBox();
            this.horse_PowerTextBox = new System.Windows.Forms.TextBox();
            this.fuel_tanksTextBox = new System.Windows.Forms.TextBox();
            this.manufacturing_YearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maximum_SpeedTextBox = new System.Windows.Forms.TextBox();
            this.kilometersTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            iD_ModelLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            transmissionLabel = new System.Windows.Forms.Label();
            engine_CapacityLabel = new System.Windows.Forms.Label();
            horse_PowerLabel = new System.Windows.Forms.Label();
            fuel_tanksLabel = new System.Windows.Forms.Label();
            manufacturing_YearLabel = new System.Windows.Forms.Label();
            maximum_SpeedLabel = new System.Windows.Forms.Label();
            kilometersLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.C2008BT);
            this.panel1.Controls.Add(this.C508BT);
            this.panel1.Controls.Add(this.C3008BT);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 531);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(185, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 449);
            this.panel2.TabIndex = 1;
            // 
            // C2008BT
            // 
            this.C2008BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C2008BT.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2008BT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C2008BT.Location = new System.Drawing.Point(0, 410);
            this.C2008BT.Name = "C2008BT";
            this.C2008BT.Size = new System.Drawing.Size(179, 55);
            this.C2008BT.TabIndex = 2;
            this.C2008BT.Text = "2008";
            this.C2008BT.UseVisualStyleBackColor = true;
            // 
            // C508BT
            // 
            this.C508BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C508BT.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C508BT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C508BT.Location = new System.Drawing.Point(0, 228);
            this.C508BT.Name = "C508BT";
            this.C508BT.Size = new System.Drawing.Size(179, 55);
            this.C508BT.TabIndex = 1;
            this.C508BT.Text = "508";
            this.C508BT.UseVisualStyleBackColor = true;
            // 
            // C3008BT
            // 
            this.C3008BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C3008BT.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3008BT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C3008BT.Location = new System.Drawing.Point(0, 61);
            this.C3008BT.Name = "C3008BT";
            this.C3008BT.Size = new System.Drawing.Size(179, 55);
            this.C3008BT.TabIndex = 0;
            this.C3008BT.Text = "3008";
            this.C3008BT.UseVisualStyleBackColor = true;
            // 
            // SearchBT
            // 
            this.SearchBT.Font = new System.Drawing.Font("Microsoft JhengHei Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBT.Location = new System.Drawing.Point(717, 483);
            this.SearchBT.Name = "SearchBT";
            this.SearchBT.Size = new System.Drawing.Size(122, 43);
            this.SearchBT.TabIndex = 119;
            this.SearchBT.Text = "Search";
            this.SearchBT.UseVisualStyleBackColor = true;
            this.SearchBT.Click += new System.EventHandler(this.SearchBT_Click);
            // 
            // iD_ModelLabel
            // 
            iD_ModelLabel.AutoSize = true;
            iD_ModelLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_ModelLabel.Location = new System.Drawing.Point(571, 29);
            iD_ModelLabel.Name = "iD_ModelLabel";
            iD_ModelLabel.Size = new System.Drawing.Size(106, 26);
            iD_ModelLabel.TabIndex = 99;
            iD_ModelLabel.Text = "ID Model:";
            // 
            // iD_ModelTextBox
            // 
            this.iD_ModelTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_ModelTextBox.Location = new System.Drawing.Point(785, 23);
            this.iD_ModelTextBox.Name = "iD_ModelTextBox";
            this.iD_ModelTextBox.Size = new System.Drawing.Size(256, 32);
            this.iD_ModelTextBox.TabIndex = 100;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(571, 80);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(64, 26);
            priceLabel.TabIndex = 101;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(785, 74);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(256, 32);
            this.priceTextBox.TabIndex = 102;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorLabel.Location = new System.Drawing.Point(571, 128);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(68, 26);
            colorLabel.TabIndex = 103;
            colorLabel.Text = "Color:";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorTextBox.Location = new System.Drawing.Point(785, 128);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(256, 32);
            this.colorTextBox.TabIndex = 104;
            // 
            // transmissionLabel
            // 
            transmissionLabel.AutoSize = true;
            transmissionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            transmissionLabel.Location = new System.Drawing.Point(571, 169);
            transmissionLabel.Name = "transmissionLabel";
            transmissionLabel.Size = new System.Drawing.Size(142, 26);
            transmissionLabel.TabIndex = 105;
            transmissionLabel.Text = "Transmission:";
            // 
            // transmissionTextBox
            // 
            this.transmissionTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmissionTextBox.Location = new System.Drawing.Point(785, 169);
            this.transmissionTextBox.Name = "transmissionTextBox";
            this.transmissionTextBox.Size = new System.Drawing.Size(256, 32);
            this.transmissionTextBox.TabIndex = 106;
            // 
            // engine_CapacityLabel
            // 
            engine_CapacityLabel.AutoSize = true;
            engine_CapacityLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            engine_CapacityLabel.Location = new System.Drawing.Point(571, 216);
            engine_CapacityLabel.Name = "engine_CapacityLabel";
            engine_CapacityLabel.Size = new System.Drawing.Size(171, 26);
            engine_CapacityLabel.TabIndex = 107;
            engine_CapacityLabel.Text = "Engine Capacity:";
            // 
            // engine_CapacityTextBox
            // 
            this.engine_CapacityTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engine_CapacityTextBox.Location = new System.Drawing.Point(785, 207);
            this.engine_CapacityTextBox.Name = "engine_CapacityTextBox";
            this.engine_CapacityTextBox.Size = new System.Drawing.Size(256, 32);
            this.engine_CapacityTextBox.TabIndex = 108;
            // 
            // horse_PowerLabel
            // 
            horse_PowerLabel.AutoSize = true;
            horse_PowerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horse_PowerLabel.Location = new System.Drawing.Point(571, 259);
            horse_PowerLabel.Name = "horse_PowerLabel";
            horse_PowerLabel.Size = new System.Drawing.Size(138, 26);
            horse_PowerLabel.TabIndex = 109;
            horse_PowerLabel.Text = "Horse Power:";
            // 
            // horse_PowerTextBox
            // 
            this.horse_PowerTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horse_PowerTextBox.Location = new System.Drawing.Point(785, 253);
            this.horse_PowerTextBox.Name = "horse_PowerTextBox";
            this.horse_PowerTextBox.Size = new System.Drawing.Size(256, 32);
            this.horse_PowerTextBox.TabIndex = 110;
            // 
            // fuel_tanksLabel
            // 
            fuel_tanksLabel.AutoSize = true;
            fuel_tanksLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fuel_tanksLabel.Location = new System.Drawing.Point(571, 301);
            fuel_tanksLabel.Name = "fuel_tanksLabel";
            fuel_tanksLabel.Size = new System.Drawing.Size(114, 26);
            fuel_tanksLabel.TabIndex = 111;
            fuel_tanksLabel.Text = "Fuel tanks:";
            // 
            // fuel_tanksTextBox
            // 
            this.fuel_tanksTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuel_tanksTextBox.Location = new System.Drawing.Point(785, 295);
            this.fuel_tanksTextBox.Name = "fuel_tanksTextBox";
            this.fuel_tanksTextBox.Size = new System.Drawing.Size(256, 32);
            this.fuel_tanksTextBox.TabIndex = 112;
            // 
            // manufacturing_YearLabel
            // 
            manufacturing_YearLabel.AutoSize = true;
            manufacturing_YearLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            manufacturing_YearLabel.Location = new System.Drawing.Point(571, 346);
            manufacturing_YearLabel.Name = "manufacturing_YearLabel";
            manufacturing_YearLabel.Size = new System.Drawing.Size(208, 26);
            manufacturing_YearLabel.TabIndex = 113;
            manufacturing_YearLabel.Text = "Manufacturing Year:";
            // 
            // manufacturing_YearDateTimePicker
            // 
            this.manufacturing_YearDateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturing_YearDateTimePicker.Location = new System.Drawing.Point(785, 346);
            this.manufacturing_YearDateTimePicker.Name = "manufacturing_YearDateTimePicker";
            this.manufacturing_YearDateTimePicker.Size = new System.Drawing.Size(256, 32);
            this.manufacturing_YearDateTimePicker.TabIndex = 114;
            // 
            // maximum_SpeedLabel
            // 
            maximum_SpeedLabel.AutoSize = true;
            maximum_SpeedLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maximum_SpeedLabel.Location = new System.Drawing.Point(571, 400);
            maximum_SpeedLabel.Name = "maximum_SpeedLabel";
            maximum_SpeedLabel.Size = new System.Drawing.Size(180, 26);
            maximum_SpeedLabel.TabIndex = 115;
            maximum_SpeedLabel.Text = "Maximum Speed:";
            // 
            // maximum_SpeedTextBox
            // 
            this.maximum_SpeedTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximum_SpeedTextBox.Location = new System.Drawing.Point(785, 397);
            this.maximum_SpeedTextBox.Name = "maximum_SpeedTextBox";
            this.maximum_SpeedTextBox.Size = new System.Drawing.Size(256, 32);
            this.maximum_SpeedTextBox.TabIndex = 116;
            // 
            // kilometersLabel
            // 
            kilometersLabel.AutoSize = true;
            kilometersLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kilometersLabel.Location = new System.Drawing.Point(571, 441);
            kilometersLabel.Name = "kilometersLabel";
            kilometersLabel.Size = new System.Drawing.Size(120, 26);
            kilometersLabel.TabIndex = 117;
            kilometersLabel.Text = "Kilometers:";
            // 
            // kilometersTextBox
            // 
            this.kilometersTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilometersTextBox.Location = new System.Drawing.Point(785, 435);
            this.kilometersTextBox.Name = "kilometersTextBox";
            this.kilometersTextBox.Size = new System.Drawing.Size(256, 32);
            this.kilometersTextBox.TabIndex = 118;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.PEUGEOT_2__1_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(202, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 133);
            this.panel3.TabIndex = 120;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.big_up_06e184ed21d080a6370b00793409e4fc__1_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(202, 169);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 170);
            this.panel4.TabIndex = 121;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.images__2___1_;
            this.panel5.Location = new System.Drawing.Point(202, 369);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 145);
            this.panel5.TabIndex = 122;
            // 
            // Peugeot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 536);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SearchBT);
            this.Controls.Add(iD_ModelLabel);
            this.Controls.Add(this.iD_ModelTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(transmissionLabel);
            this.Controls.Add(this.transmissionTextBox);
            this.Controls.Add(engine_CapacityLabel);
            this.Controls.Add(this.engine_CapacityTextBox);
            this.Controls.Add(horse_PowerLabel);
            this.Controls.Add(this.horse_PowerTextBox);
            this.Controls.Add(fuel_tanksLabel);
            this.Controls.Add(this.fuel_tanksTextBox);
            this.Controls.Add(manufacturing_YearLabel);
            this.Controls.Add(this.manufacturing_YearDateTimePicker);
            this.Controls.Add(maximum_SpeedLabel);
            this.Controls.Add(this.maximum_SpeedTextBox);
            this.Controls.Add(kilometersLabel);
            this.Controls.Add(this.kilometersTextBox);
            this.Controls.Add(this.panel1);
            this.Name = "Peugeot";
            this.Text = "Peugeot";
            this.Load += new System.EventHandler(this.Peugeot_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button C2008BT;
        private System.Windows.Forms.Button C508BT;
        private System.Windows.Forms.Button C3008BT;
        private System.Windows.Forms.Button SearchBT;
        private System.Windows.Forms.TextBox iD_ModelTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox transmissionTextBox;
        private System.Windows.Forms.TextBox engine_CapacityTextBox;
        private System.Windows.Forms.TextBox horse_PowerTextBox;
        private System.Windows.Forms.TextBox fuel_tanksTextBox;
        private System.Windows.Forms.DateTimePicker manufacturing_YearDateTimePicker;
        private System.Windows.Forms.TextBox maximum_SpeedTextBox;
        private System.Windows.Forms.TextBox kilometersTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}