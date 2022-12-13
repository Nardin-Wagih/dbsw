namespace WindowsFormsApp4
{
    partial class MINI
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
            this.components = new System.ComponentModel.Container();
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
            this.CountrymanBT = new System.Windows.Forms.Button();
            this.ClubmanBT = new System.Windows.Forms.Button();
            this.MiniHatchBT = new System.Windows.Forms.Button();
            this.car_AgencyDataSet = new WindowsFormsApp4.Car_AgencyDataSet5();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new WindowsFormsApp4.Car_AgencyDataSet5TableAdapters.CarTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp4.Car_AgencyDataSet5TableAdapters.TableAdapterManager();
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
            this.SearchBT = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.car_AgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ModelLabel
            // 
            iD_ModelLabel.AutoSize = true;
            iD_ModelLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_ModelLabel.Location = new System.Drawing.Point(556, 36);
            iD_ModelLabel.Name = "iD_ModelLabel";
            iD_ModelLabel.Size = new System.Drawing.Size(106, 26);
            iD_ModelLabel.TabIndex = 75;
            iD_ModelLabel.Text = "ID Model:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(556, 87);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(64, 26);
            priceLabel.TabIndex = 77;
            priceLabel.Text = "Price:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorLabel.Location = new System.Drawing.Point(556, 135);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(68, 26);
            colorLabel.TabIndex = 79;
            colorLabel.Text = "Color:";
            // 
            // transmissionLabel
            // 
            transmissionLabel.AutoSize = true;
            transmissionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            transmissionLabel.Location = new System.Drawing.Point(556, 176);
            transmissionLabel.Name = "transmissionLabel";
            transmissionLabel.Size = new System.Drawing.Size(142, 26);
            transmissionLabel.TabIndex = 81;
            transmissionLabel.Text = "Transmission:";
            // 
            // engine_CapacityLabel
            // 
            engine_CapacityLabel.AutoSize = true;
            engine_CapacityLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            engine_CapacityLabel.Location = new System.Drawing.Point(556, 223);
            engine_CapacityLabel.Name = "engine_CapacityLabel";
            engine_CapacityLabel.Size = new System.Drawing.Size(171, 26);
            engine_CapacityLabel.TabIndex = 83;
            engine_CapacityLabel.Text = "Engine Capacity:";
            // 
            // horse_PowerLabel
            // 
            horse_PowerLabel.AutoSize = true;
            horse_PowerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horse_PowerLabel.Location = new System.Drawing.Point(556, 266);
            horse_PowerLabel.Name = "horse_PowerLabel";
            horse_PowerLabel.Size = new System.Drawing.Size(138, 26);
            horse_PowerLabel.TabIndex = 85;
            horse_PowerLabel.Text = "Horse Power:";
            // 
            // fuel_tanksLabel
            // 
            fuel_tanksLabel.AutoSize = true;
            fuel_tanksLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fuel_tanksLabel.Location = new System.Drawing.Point(556, 308);
            fuel_tanksLabel.Name = "fuel_tanksLabel";
            fuel_tanksLabel.Size = new System.Drawing.Size(114, 26);
            fuel_tanksLabel.TabIndex = 87;
            fuel_tanksLabel.Text = "Fuel tanks:";
            // 
            // manufacturing_YearLabel
            // 
            manufacturing_YearLabel.AutoSize = true;
            manufacturing_YearLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            manufacturing_YearLabel.Location = new System.Drawing.Point(556, 353);
            manufacturing_YearLabel.Name = "manufacturing_YearLabel";
            manufacturing_YearLabel.Size = new System.Drawing.Size(208, 26);
            manufacturing_YearLabel.TabIndex = 89;
            manufacturing_YearLabel.Text = "Manufacturing Year:";
            // 
            // maximum_SpeedLabel
            // 
            maximum_SpeedLabel.AutoSize = true;
            maximum_SpeedLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maximum_SpeedLabel.Location = new System.Drawing.Point(556, 407);
            maximum_SpeedLabel.Name = "maximum_SpeedLabel";
            maximum_SpeedLabel.Size = new System.Drawing.Size(180, 26);
            maximum_SpeedLabel.TabIndex = 91;
            maximum_SpeedLabel.Text = "Maximum Speed:";
            // 
            // kilometersLabel
            // 
            kilometersLabel.AutoSize = true;
            kilometersLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kilometersLabel.Location = new System.Drawing.Point(556, 448);
            kilometersLabel.Name = "kilometersLabel";
            kilometersLabel.Size = new System.Drawing.Size(120, 26);
            kilometersLabel.TabIndex = 93;
            kilometersLabel.Text = "Kilometers:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CountrymanBT);
            this.panel1.Controls.Add(this.ClubmanBT);
            this.panel1.Controls.Add(this.MiniHatchBT);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 531);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(185, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 449);
            this.panel2.TabIndex = 1;
            // 
            // CountrymanBT
            // 
            this.CountrymanBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CountrymanBT.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountrymanBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CountrymanBT.Location = new System.Drawing.Point(3, 405);
            this.CountrymanBT.Name = "CountrymanBT";
            this.CountrymanBT.Size = new System.Drawing.Size(179, 55);
            this.CountrymanBT.TabIndex = 2;
            this.CountrymanBT.Text = "Countryman";
            this.CountrymanBT.UseVisualStyleBackColor = true;
            // 
            // ClubmanBT
            // 
            this.ClubmanBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClubmanBT.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClubmanBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClubmanBT.Location = new System.Drawing.Point(0, 205);
            this.ClubmanBT.Name = "ClubmanBT";
            this.ClubmanBT.Size = new System.Drawing.Size(179, 55);
            this.ClubmanBT.TabIndex = 1;
            this.ClubmanBT.Text = "Clubman";
            this.ClubmanBT.UseVisualStyleBackColor = true;
            // 
            // MiniHatchBT
            // 
            this.MiniHatchBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MiniHatchBT.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiniHatchBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MiniHatchBT.Location = new System.Drawing.Point(0, 34);
            this.MiniHatchBT.Name = "MiniHatchBT";
            this.MiniHatchBT.Size = new System.Drawing.Size(179, 55);
            this.MiniHatchBT.TabIndex = 0;
            this.MiniHatchBT.Text = "Mini Hatch";
            this.MiniHatchBT.UseVisualStyleBackColor = true;
            this.MiniHatchBT.Click += new System.EventHandler(this.MiniHatchBT_Click);
            // 
            // car_AgencyDataSet
            // 
            this.car_AgencyDataSet.DataSetName = "Car_AgencyDataSet";
            this.car_AgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.car_AgencyDataSet;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            //this.tableAdapterManager.AdmineTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Car_BrandTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = this.carTableAdapter;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp4.Car_AgencyDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iD_ModelTextBox
            // 
            this.iD_ModelTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_ModelTextBox.Location = new System.Drawing.Point(770, 30);
            this.iD_ModelTextBox.Name = "iD_ModelTextBox";
            this.iD_ModelTextBox.Size = new System.Drawing.Size(256, 32);
            this.iD_ModelTextBox.TabIndex = 76;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(770, 81);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(256, 32);
            this.priceTextBox.TabIndex = 78;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorTextBox.Location = new System.Drawing.Point(770, 135);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(256, 32);
            this.colorTextBox.TabIndex = 80;
            // 
            // transmissionTextBox
            // 
            this.transmissionTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmissionTextBox.Location = new System.Drawing.Point(770, 176);
            this.transmissionTextBox.Name = "transmissionTextBox";
            this.transmissionTextBox.Size = new System.Drawing.Size(256, 32);
            this.transmissionTextBox.TabIndex = 82;
            // 
            // engine_CapacityTextBox
            // 
            this.engine_CapacityTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engine_CapacityTextBox.Location = new System.Drawing.Point(770, 214);
            this.engine_CapacityTextBox.Name = "engine_CapacityTextBox";
            this.engine_CapacityTextBox.Size = new System.Drawing.Size(256, 32);
            this.engine_CapacityTextBox.TabIndex = 84;
            // 
            // horse_PowerTextBox
            // 
            this.horse_PowerTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horse_PowerTextBox.Location = new System.Drawing.Point(770, 260);
            this.horse_PowerTextBox.Name = "horse_PowerTextBox";
            this.horse_PowerTextBox.Size = new System.Drawing.Size(256, 32);
            this.horse_PowerTextBox.TabIndex = 86;
            // 
            // fuel_tanksTextBox
            // 
            this.fuel_tanksTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuel_tanksTextBox.Location = new System.Drawing.Point(770, 302);
            this.fuel_tanksTextBox.Name = "fuel_tanksTextBox";
            this.fuel_tanksTextBox.Size = new System.Drawing.Size(256, 32);
            this.fuel_tanksTextBox.TabIndex = 88;
            // 
            // manufacturing_YearDateTimePicker
            // 
            this.manufacturing_YearDateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturing_YearDateTimePicker.Location = new System.Drawing.Point(770, 353);
            this.manufacturing_YearDateTimePicker.Name = "manufacturing_YearDateTimePicker";
            this.manufacturing_YearDateTimePicker.Size = new System.Drawing.Size(256, 32);
            this.manufacturing_YearDateTimePicker.TabIndex = 90;
            // 
            // maximum_SpeedTextBox
            // 
            this.maximum_SpeedTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximum_SpeedTextBox.Location = new System.Drawing.Point(770, 404);
            this.maximum_SpeedTextBox.Name = "maximum_SpeedTextBox";
            this.maximum_SpeedTextBox.Size = new System.Drawing.Size(256, 32);
            this.maximum_SpeedTextBox.TabIndex = 92;
            // 
            // kilometersTextBox
            // 
            this.kilometersTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilometersTextBox.Location = new System.Drawing.Point(770, 442);
            this.kilometersTextBox.Name = "kilometersTextBox";
            this.kilometersTextBox.Size = new System.Drawing.Size(256, 32);
            this.kilometersTextBox.TabIndex = 94;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._2014_MINI_Cooper_Hardtop_____NHTSA_test_8883___front__2_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(211, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 134);
            this.panel3.TabIndex = 95;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.damImage_narrow_768w_j_1664530765824__1_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(211, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 133);
            this.panel4.TabIndex = 96;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._2021_mini_cooper_s_countryman_all4_573_1626063857__1_;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(211, 373);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(247, 149);
            this.panel5.TabIndex = 97;
            // 
            // SearchBT
            // 
            this.SearchBT.Font = new System.Drawing.Font("Microsoft JhengHei Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBT.Location = new System.Drawing.Point(702, 490);
            this.SearchBT.Name = "SearchBT";
            this.SearchBT.Size = new System.Drawing.Size(122, 43);
            this.SearchBT.TabIndex = 98;
            this.SearchBT.Text = "Search";
            this.SearchBT.UseVisualStyleBackColor = true;
            this.SearchBT.Click += new System.EventHandler(this.SearchBT_Click);
            // 
            // MINI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 553);
            this.Controls.Add(this.SearchBT);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
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
            this.Name = "MINI";
            this.Text = "MINI";
            this.Load += new System.EventHandler(this.MINI_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.car_AgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CountrymanBT;
        private System.Windows.Forms.Button ClubmanBT;
        private System.Windows.Forms.Button MiniHatchBT;
        private Car_AgencyDataSet5 car_AgencyDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private Car_AgencyDataSet5TableAdapters.CarTableAdapter carTableAdapter;
        private Car_AgencyDataSet5TableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.Button SearchBT;
    }
}