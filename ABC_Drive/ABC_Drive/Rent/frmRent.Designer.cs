namespace ABC_Drive.Rent
{
    partial class frmRent
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
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.rbDriverNo = new System.Windows.Forms.RadioButton();
            this.rbDriverYes = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpReturnedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRentedDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotMonths = new System.Windows.Forms.Label();
            this.lblTotWeeks = new System.Windows.Forms.Label();
            this.lblTotDays = new System.Windows.Forms.Label();
            this.lblTotDriverCost = new System.Windows.Forms.Label();
            this.lblTotRent = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotDaysAmnt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotWeeksAmnt = new System.Windows.Forms.TextBox();
            this.txtTotMonthsAmnt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvVehicleList = new System.Windows.Forms.DataGridView();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnAddDriver);
            this.panel1.Controls.Add(this.btnAddVehicle);
            this.panel1.Controls.Add(this.rbDriverNo);
            this.panel1.Controls.Add(this.rbDriverYes);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpReturnedDate);
            this.panel1.Controls.Add(this.dtpRentedDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtVehicleNo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 195);
            this.panel1.TabIndex = 0;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicle.Location = new System.Drawing.Point(238, 61);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(32, 27);
            this.btnAddVehicle.TabIndex = 12;
            this.btnAddVehicle.Text = "+";
            this.btnAddVehicle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // rbDriverNo
            // 
            this.rbDriverNo.AutoSize = true;
            this.rbDriverNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDriverNo.Location = new System.Drawing.Point(530, 152);
            this.rbDriverNo.Name = "rbDriverNo";
            this.rbDriverNo.Size = new System.Drawing.Size(46, 22);
            this.rbDriverNo.TabIndex = 11;
            this.rbDriverNo.TabStop = true;
            this.rbDriverNo.Text = "No";
            this.rbDriverNo.UseVisualStyleBackColor = true;
            this.rbDriverNo.CheckedChanged += new System.EventHandler(this.rbDriverNo_CheckedChanged);
            // 
            // rbDriverYes
            // 
            this.rbDriverYes.AutoSize = true;
            this.rbDriverYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDriverYes.Location = new System.Drawing.Point(472, 152);
            this.rbDriverYes.Name = "rbDriverYes";
            this.rbDriverYes.Size = new System.Drawing.Size(51, 22);
            this.rbDriverYes.TabIndex = 10;
            this.rbDriverYes.TabStop = true;
            this.rbDriverYes.Text = "Yes";
            this.rbDriverYes.UseVisualStyleBackColor = true;
            this.rbDriverYes.CheckedChanged += new System.EventHandler(this.rbDriverYes_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Rented Date:";
            // 
            // dtpReturnedDate
            // 
            this.dtpReturnedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnedDate.Location = new System.Drawing.Point(288, 146);
            this.dtpReturnedDate.Name = "dtpReturnedDate";
            this.dtpReturnedDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpReturnedDate.Size = new System.Drawing.Size(129, 26);
            this.dtpReturnedDate.TabIndex = 8;
            this.dtpReturnedDate.ValueChanged += new System.EventHandler(this.dtpReturnedDate_ValueChanged);
            // 
            // dtpRentedDate
            // 
            this.dtpRentedDate.CustomFormat = "";
            this.dtpRentedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRentedDate.Location = new System.Drawing.Point(102, 146);
            this.dtpRentedDate.Name = "dtpRentedDate";
            this.dtpRentedDate.Size = new System.Drawing.Size(129, 26);
            this.dtpRentedDate.TabIndex = 7;
            this.dtpRentedDate.ValueChanged += new System.EventHandler(this.dtpRentedDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Driver:";
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleNo.Location = new System.Drawing.Point(53, 62);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(184, 26);
            this.txtVehicleNo.TabIndex = 4;
            this.txtVehicleNo.TextChanged += new System.EventHandler(this.txtVehicleNo_TextChanged);
            this.txtVehicleNo.Leave += new System.EventHandler(this.txtVehicleNo_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Returned Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vehicle No:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 211);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotMonths);
            this.groupBox1.Controls.Add(this.lblTotWeeks);
            this.groupBox1.Controls.Add(this.lblTotDays);
            this.groupBox1.Controls.Add(this.lblTotDriverCost);
            this.groupBox1.Controls.Add(this.lblTotRent);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTotDaysAmnt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTotWeeksAmnt);
            this.groupBox1.Controls.Add(this.txtTotMonthsAmnt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 184);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rates info";
            // 
            // lblTotMonths
            // 
            this.lblTotMonths.AutoSize = true;
            this.lblTotMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotMonths.Location = new System.Drawing.Point(594, 34);
            this.lblTotMonths.Name = "lblTotMonths";
            this.lblTotMonths.Size = new System.Drawing.Size(18, 20);
            this.lblTotMonths.TabIndex = 15;
            this.lblTotMonths.Text = "0";
            // 
            // lblTotWeeks
            // 
            this.lblTotWeeks.AutoSize = true;
            this.lblTotWeeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotWeeks.Location = new System.Drawing.Point(399, 34);
            this.lblTotWeeks.Name = "lblTotWeeks";
            this.lblTotWeeks.Size = new System.Drawing.Size(18, 20);
            this.lblTotWeeks.TabIndex = 14;
            this.lblTotWeeks.Text = "0";
            // 
            // lblTotDays
            // 
            this.lblTotDays.AutoSize = true;
            this.lblTotDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotDays.Location = new System.Drawing.Point(179, 34);
            this.lblTotDays.Name = "lblTotDays";
            this.lblTotDays.Size = new System.Drawing.Size(18, 20);
            this.lblTotDays.TabIndex = 13;
            this.lblTotDays.Text = "0";
            // 
            // lblTotDriverCost
            // 
            this.lblTotDriverCost.AutoSize = true;
            this.lblTotDriverCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotDriverCost.Location = new System.Drawing.Point(531, 118);
            this.lblTotDriverCost.Name = "lblTotDriverCost";
            this.lblTotDriverCost.Size = new System.Drawing.Size(18, 20);
            this.lblTotDriverCost.TabIndex = 12;
            this.lblTotDriverCost.Text = "0";
            // 
            // lblTotRent
            // 
            this.lblTotRent.AutoSize = true;
            this.lblTotRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotRent.Location = new System.Drawing.Point(531, 147);
            this.lblTotRent.Name = "lblTotRent";
            this.lblTotRent.Size = new System.Drawing.Size(18, 20);
            this.lblTotRent.TabIndex = 11;
            this.lblTotRent.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(399, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total Driver Cost:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(399, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total Rent:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Days:";
            // 
            // txtTotDaysAmnt
            // 
            this.txtTotDaysAmnt.Enabled = false;
            this.txtTotDaysAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotDaysAmnt.Location = new System.Drawing.Point(66, 61);
            this.txtTotDaysAmnt.Name = "txtTotDaysAmnt";
            this.txtTotDaysAmnt.Size = new System.Drawing.Size(170, 26);
            this.txtTotDaysAmnt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Weeks:";
            // 
            // txtTotWeeksAmnt
            // 
            this.txtTotWeeksAmnt.Enabled = false;
            this.txtTotWeeksAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotWeeksAmnt.Location = new System.Drawing.Point(273, 61);
            this.txtTotWeeksAmnt.Name = "txtTotWeeksAmnt";
            this.txtTotWeeksAmnt.Size = new System.Drawing.Size(170, 26);
            this.txtTotWeeksAmnt.TabIndex = 4;
            // 
            // txtTotMonthsAmnt
            // 
            this.txtTotMonthsAmnt.Enabled = false;
            this.txtTotMonthsAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotMonthsAmnt.Location = new System.Drawing.Point(469, 61);
            this.txtTotMonthsAmnt.Name = "txtTotMonthsAmnt";
            this.txtTotMonthsAmnt.Size = new System.Drawing.Size(170, 26);
            this.txtTotMonthsAmnt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(465, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Months:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 412);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 68);
            this.panel3.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(423, 29);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 30);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(544, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvVehicleList
            // 
            this.dgvVehicleList.AllowUserToResizeColumns = false;
            this.dgvVehicleList.AllowUserToResizeRows = false;
            this.dgvVehicleList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVehicleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleList.ColumnHeadersVisible = false;
            this.dgvVehicleList.Location = new System.Drawing.Point(55, 89);
            this.dgvVehicleList.Name = "dgvVehicleList";
            this.dgvVehicleList.ShowCellErrors = false;
            this.dgvVehicleList.ShowCellToolTips = false;
            this.dgvVehicleList.Size = new System.Drawing.Size(237, 71);
            this.dgvVehicleList.TabIndex = 13;
            this.dgvVehicleList.Visible = false;
            this.dgvVehicleList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicleList_CellClick);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDriver.Location = new System.Drawing.Point(525, 113);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(25, 23);
            this.btnAddDriver.TabIndex = 13;
            this.btnAddDriver.Text = "+";
            this.btnAddDriver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // frmRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 480);
            this.Controls.Add(this.dgvVehicleList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Rent";
            this.Load += new System.EventHandler(this.frmRent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVehicleNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotDaysAmnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotWeeksAmnt;
        private System.Windows.Forms.TextBox txtTotMonthsAmnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpReturnedDate;
        private System.Windows.Forms.DateTimePicker dtpRentedDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbDriverNo;
        private System.Windows.Forms.RadioButton rbDriverYes;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotDriverCost;
        private System.Windows.Forms.Label lblTotRent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotMonths;
        private System.Windows.Forms.Label lblTotWeeks;
        private System.Windows.Forms.Label lblTotDays;
        private System.Windows.Forms.DataGridView dgvVehicleList;
        private System.Windows.Forms.Button btnAddDriver;
    }
}