namespace WindowsFormsApp4
{
    partial class BMW
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
            this.BMWM3BT = new System.Windows.Forms.Button();
            this.BMWX6BT = new System.Windows.Forms.Button();
            this.BMWX7BT = new System.Windows.Forms.Button();
            this.car_AgencyDataSet1 = new WindowsFormsApp4.Car_AgencyDataSet5();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new WindowsFormsApp4.Car_AgencyDataSet5TableAdapters.CarTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp4.Car_AgencyDataSet5TableAdapters.TableAdapterManager();
            this.car_BrandTableAdapter = new WindowsFormsApp4.Car_AgencyDataSet5TableAdapters.Car_BrandTableAdapter();
            this.car_BrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_AgencyDataSet = new WindowsFormsApp4.Car_AgencyDataSet5();
            this.carBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter1 = new WindowsFormsApp4.Car_AgencyDataSet5TableAdapters.CarTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp4.Car_AgencyDataSet5TableAdapters.TableAdapterManager();
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
            ((System.ComponentModel.ISupportInitialize)(this.car_AgencyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_BrandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_AgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ModelLabel
            // 
            iD_ModelLabel.AutoSize = true;
            iD_ModelLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_ModelLabel.Location = new System.Drawing.Point(550, 38);
            iD_ModelLabel.Name = "iD_ModelLabel";
            iD_ModelLabel.Size = new System.Drawing.Size(106, 26);
            iD_ModelLabel.TabIndex = 120;
            iD_ModelLabel.Text = "ID Model:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(550, 89);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(64, 26);
            priceLabel.TabIndex = 122;
            priceLabel.Text = "Price:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorLabel.Location = new System.Drawing.Point(550, 137);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(68, 26);
            colorLabel.TabIndex = 124;
            colorLabel.Text = "Color:";
            // 
            // transmissionLabel
            // 
            transmissionLabel.AutoSize = true;
            transmissionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            transmissionLabel.Location = new System.Drawing.Point(550, 178);
            transmissionLabel.Name = "transmissionLabel";
            transmissionLabel.Size = new System.Drawing.Size(142, 26);
            transmissionLabel.TabIndex = 126;
            transmissionLabel.Text = "Transmission:";
            // 
            // engine_CapacityLabel
            // 
            engine_CapacityLabel.AutoSize = true;
            engine_CapacityLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            engine_CapacityLabel.Location = new System.Drawing.Point(550, 225);
            engine_CapacityLabel.Name = "engine_CapacityLabel";
            engine_CapacityLabel.Size = new System.Drawing.Size(171, 26);
            engine_CapacityLabel.TabIndex = 128;
            engine_CapacityLabel.Text = "Engine Capacity:";
            // 
            // horse_PowerLabel
            // 
            horse_PowerLabel.AutoSize = true;
            horse_PowerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horse_PowerLabel.Location = new System.Drawing.Point(550, 268);
            horse_PowerLabel.Name = "horse_PowerLabel";
            horse_PowerLabel.Size = new System.Drawing.Size(138, 26);
            horse_PowerLabel.TabIndex = 130;
            horse_PowerLabel.Text = "Horse Power:";
            // 
            // fuel_tanksLabel
            // 
            fuel_tanksLabel.AutoSize = true;
            fuel_tanksLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fuel_tanksLabel.Location = new System.Drawing.Point(550, 310);
            fuel_tanksLabel.Name = "fuel_tanksLabel";
            fuel_tanksLabel.Size = new System.Drawing.Size(114, 26);
            fuel_tanksLabel.TabIndex = 132;
            fuel_tanksLabel.Text = "Fuel tanks:";
            // 
            // manufacturing_YearLabel
            // 
            manufacturing_YearLabel.AutoSize = true;
            manufacturing_YearLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            manufacturing_YearLabel.Location = new System.Drawing.Point(550, 355);
            manufacturing_YearLabel.Name = "manufacturing_YearLabel";
            manufacturing_YearLabel.Size = new System.Drawing.Size(208, 26);
            manufacturing_YearLabel.TabIndex = 134;
            manufacturing_YearLabel.Text = "Manufacturing Year:";
            // 
            // maximum_SpeedLabel
            // 
            maximum_SpeedLabel.AutoSize = true;
            maximum_SpeedLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maximum_SpeedLabel.Location = new System.Drawing.Point(550, 409);
            maximum_SpeedLabel.Name = "maximum_SpeedLabel";
            maximum_SpeedLabel.Size = new System.Drawing.Size(180, 26);
            maximum_SpeedLabel.TabIndex = 136;
            maximum_SpeedLabel.Text = "Maximum Speed:";
            // 
            // kilometersLabel
            // 
            kilometersLabel.AutoSize = true;
            kilometersLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kilometersLabel.Location = new System.Drawing.Point(550, 450);
            kilometersLabel.Name = "kilometersLabel";
            kilometersLabel.Size = new System.Drawing.Size(120, 26);
            kilometersLabel.TabIndex = 138;
            kilometersLabel.Text = "Kilometers:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BMWM3BT);
            this.panel1.Controls.Add(this.BMWX6BT);
            this.panel1.Controls.Add(this.BMWX7BT);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 531);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(185, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 449);
            this.panel2.TabIndex = 1;
            // 
            // BMWM3BT
            // 
            this.BMWM3BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BMWM3BT.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMWM3BT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BMWM3BT.Location = new System.Drawing.Point(0, 430);
            this.BMWM3BT.Name = "BMWM3BT";
            this.BMWM3BT.Size = new System.Drawing.Size(179, 55);
            this.BMWM3BT.TabIndex = 2;
            this.BMWM3BT.Text = "BMW M3";
            this.BMWM3BT.UseVisualStyleBackColor = true;
            this.BMWM3BT.Click += new System.EventHandler(this.BMWM3BT_Click);
            // 
            // BMWX6BT
            // 
            this.BMWX6BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BMWX6BT.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMWX6BT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BMWX6BT.Location = new System.Drawing.Point(0, 248);
            this.BMWX6BT.Name = "BMWX6BT";
            this.BMWX6BT.Size = new System.Drawing.Size(179, 55);
            this.BMWX6BT.TabIndex = 1;
            this.BMWX6BT.Text = "BMW X6";
            this.BMWX6BT.UseVisualStyleBackColor = true;
            this.BMWX6BT.Click += new System.EventHandler(this.BMWX6BT_Click);
            // 
            // BMWX7BT
            // 
            this.BMWX7BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BMWX7BT.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMWX7BT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BMWX7BT.Location = new System.Drawing.Point(0, 57);
            this.BMWX7BT.Name = "BMWX7BT";
            this.BMWX7BT.Size = new System.Drawing.Size(179, 55);
            this.BMWX7BT.TabIndex = 0;
            this.BMWX7BT.Text = "BMW X7";
            this.BMWX7BT.UseVisualStyleBackColor = true;
            this.BMWX7BT.Click += new System.EventHandler(this.BMWX7BT_Click);
            // 
            // car_AgencyDataSet1
            // 
            this.car_AgencyDataSet1.DataSetName = "Car_AgencyDataSet1";
            this.car_AgencyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.car_AgencyDataSet1;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.A_AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Car_BrandTableAdapter = this.car_BrandTableAdapter;
            this.tableAdapterManager.CarTableAdapter = this.carTableAdapter;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp4.Car_AgencyDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // car_BrandTableAdapter
            // 
            this.car_BrandTableAdapter.ClearBeforeFill = true;
            // 
            // car_BrandBindingSource
            // 
            this.car_BrandBindingSource.DataMember = "Car_Brand";
            this.car_BrandBindingSource.DataSource = this.car_AgencyDataSet1;
            // 
            // car_AgencyDataSet
            // 
            this.car_AgencyDataSet.DataSetName = "Car_AgencyDataSet";
            this.car_AgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource1
            // 
            this.carBindingSource1.DataMember = "Car";
            this.carBindingSource1.DataSource = this.car_AgencyDataSet;
            // 
            // carTableAdapter1
            // 
            this.carTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.A_AdminTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Car_BrandTableAdapter = null;
            this.tableAdapterManager1.CarTableAdapter = this.carTableAdapter1;
            this.tableAdapterManager1.CustomerTableAdapter = null;
            this.tableAdapterManager1.EmployeeTableAdapter = null;
            this.tableAdapterManager1.InventoryTableAdapter = null;
            this.tableAdapterManager1.ManagerTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp4.Car_AgencyDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SearchBT
            // 
            this.SearchBT.Font = new System.Drawing.Font("Microsoft JhengHei Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBT.Location = new System.Drawing.Point(696, 492);
            this.SearchBT.Name = "SearchBT";
            this.SearchBT.Size = new System.Drawing.Size(122, 43);
            this.SearchBT.TabIndex = 140;
            this.SearchBT.Text = "Search";
            this.SearchBT.UseVisualStyleBackColor = true;
            this.SearchBT.Click += new System.EventHandler(this.SearchBT_Click);
            // 
            // iD_ModelTextBox
            // 
            this.iD_ModelTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_ModelTextBox.Location = new System.Drawing.Point(764, 32);
            this.iD_ModelTextBox.Name = "iD_ModelTextBox";
            this.iD_ModelTextBox.Size = new System.Drawing.Size(256, 32);
            this.iD_ModelTextBox.TabIndex = 121;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(764, 83);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(256, 32);
            this.priceTextBox.TabIndex = 123;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorTextBox.Location = new System.Drawing.Point(764, 137);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(256, 32);
            this.colorTextBox.TabIndex = 125;
            // 
            // transmissionTextBox
            // 
            this.transmissionTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmissionTextBox.Location = new System.Drawing.Point(764, 178);
            this.transmissionTextBox.Name = "transmissionTextBox";
            this.transmissionTextBox.Size = new System.Drawing.Size(256, 32);
            this.transmissionTextBox.TabIndex = 127;
            // 
            // engine_CapacityTextBox
            // 
            this.engine_CapacityTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engine_CapacityTextBox.Location = new System.Drawing.Point(764, 216);
            this.engine_CapacityTextBox.Name = "engine_CapacityTextBox";
            this.engine_CapacityTextBox.Size = new System.Drawing.Size(256, 32);
            this.engine_CapacityTextBox.TabIndex = 129;
            // 
            // horse_PowerTextBox
            // 
            this.horse_PowerTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horse_PowerTextBox.Location = new System.Drawing.Point(764, 262);
            this.horse_PowerTextBox.Name = "horse_PowerTextBox";
            this.horse_PowerTextBox.Size = new System.Drawing.Size(256, 32);
            this.horse_PowerTextBox.TabIndex = 131;
            // 
            // fuel_tanksTextBox
            // 
            this.fuel_tanksTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuel_tanksTextBox.Location = new System.Drawing.Point(764, 304);
            this.fuel_tanksTextBox.Name = "fuel_tanksTextBox";
            this.fuel_tanksTextBox.Size = new System.Drawing.Size(256, 32);
            this.fuel_tanksTextBox.TabIndex = 133;
            // 
            // manufacturing_YearDateTimePicker
            // 
            this.manufacturing_YearDateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturing_YearDateTimePicker.Location = new System.Drawing.Point(764, 355);
            this.manufacturing_YearDateTimePicker.Name = "manufacturing_YearDateTimePicker";
            this.manufacturing_YearDateTimePicker.Size = new System.Drawing.Size(256, 32);
            this.manufacturing_YearDateTimePicker.TabIndex = 135;
            // 
            // maximum_SpeedTextBox
            // 
            this.maximum_SpeedTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximum_SpeedTextBox.Location = new System.Drawing.Point(764, 406);
            this.maximum_SpeedTextBox.Name = "maximum_SpeedTextBox";
            this.maximum_SpeedTextBox.Size = new System.Drawing.Size(256, 32);
            this.maximum_SpeedTextBox.TabIndex = 137;
            // 
            // kilometersTextBox
            // 
            this.kilometersTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilometersTextBox.Location = new System.Drawing.Point(764, 444);
            this.kilometersTextBox.Name = "kilometersTextBox";
            this.kilometersTextBox.Size = new System.Drawing.Size(256, 32);
            this.kilometersTextBox.TabIndex = 139;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.BMW_X6_xDrive40i_2021__1_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(208, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 144);
            this.panel3.TabIndex = 141;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.BMW_X7_M50i_2021__1_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(208, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 159);
            this.panel4.TabIndex = 163;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.bmw_3_series_sedan_m_automobiles_gallery_impressions_m3_competition_02_mobile__1_;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(208, 382);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(251, 152);
            this.panel5.TabIndex = 190;
            // 
            // BMW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 554);
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
            this.Name = "BMW";
            this.ShowIcon = false;
            this.Text = "BMW";
            this.Load += new System.EventHandler(this.BMW_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.car_AgencyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_BrandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_AgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BMWM3BT;
        private System.Windows.Forms.Button BMWX6BT;
        private System.Windows.Forms.Button BMWX7BT;
        private Car_AgencyDataSet5 car_AgencyDataSet1;
        private System.Windows.Forms.BindingSource carBindingSource;
        private Car_AgencyDataSet5TableAdapters.CarTableAdapter carTableAdapter;
        private Car_AgencyDataSet5TableAdapters.TableAdapterManager tableAdapterManager;
        private Car_AgencyDataSet5TableAdapters.Car_BrandTableAdapter car_BrandTableAdapter;
        private System.Windows.Forms.BindingSource car_BrandBindingSource;
        private Car_AgencyDataSet5 car_AgencyDataSet;
        private System.Windows.Forms.BindingSource carBindingSource1;
        private Car_AgencyDataSet5TableAdapters.CarTableAdapter carTableAdapter1;
        private Car_AgencyDataSet5TableAdapters.TableAdapterManager tableAdapterManager1;
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