namespace Scada_opc_client_DB_writer
{
    partial class ConfigForm
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
            cfgTxtTagName = new TextBox();
            label2 = new Label();
            cfgTxtOpcServer = new TextBox();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbSensorType = new ComboBox();
            cmbProcessVariable = new ComboBox();
            cmbProcessUnit = new ComboBox();
            btnSave = new Button();
            groupBoxProcessUnit = new GroupBox();
            lblUnitName = new Label();
            txtProcessName = new TextBox();
            lblUnitType = new Label();
            txtProcessType = new TextBox();
            lblUnitDescription = new Label();
            txtProcessDescription = new TextBox();
            lblManufacturer = new Label();
            txtManufacturer = new TextBox();
            lblModel = new Label();
            txtModel = new TextBox();
            lblSerialNumber = new Label();
            txtSerialNumber = new TextBox();
            lblInstallationDate = new Label();
            dtpInstallationDate = new DateTimePicker();
            groupBoxProcessVariable = new GroupBox();
            label9 = new Label();
            txtVariableName = new TextBox();
            label10 = new Label();
            txtEngineeringUnit = new TextBox();
            label11 = new Label();
            txtVariableDescription = new TextBox();
            groupBoxSensorType = new GroupBox();
            label12 = new Label();
            txtTypeName = new TextBox();
            label14 = new Label();
            txtSensorTypeDescription = new TextBox();
            groupBoxSensor = new GroupBox();
            label3 = new Label();
            txtSensorName = new TextBox();
            label15 = new Label();
            txtSensorModel = new TextBox();
            label17 = new Label();
            txtSensorSerial = new TextBox();
            label18 = new Label();
            txtSensorInstallDate = new TextBox();
            label13 = new Label();
            txtSensorManufacturer = new TextBox();
            cmbSensor = new ComboBox();
            label16 = new Label();
            groupBox1 = new GroupBox();
            label19 = new Label();
            txtBuilding = new TextBox();
            label20 = new Label();
            txtFloor = new TextBox();
            label21 = new Label();
            txtRoom = new TextBox();
            label22 = new Label();
            txtLocationName = new TextBox();
            cmbLocation = new ComboBox();
            label23 = new Label();
            btnCancel = new Button();
            groupBoxProcessUnit.SuspendLayout();
            groupBoxProcessVariable.SuspendLayout();
            groupBoxSensorType.SuspendLayout();
            groupBoxSensor.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cfgTxtTagName
            // 
            cfgTxtTagName.Location = new Point(474, 38);
            cfgTxtTagName.Name = "cfgTxtTagName";
            cfgTxtTagName.Size = new Size(245, 27);
            cfgTxtTagName.TabIndex = 8;
            cfgTxtTagName.Text = "ns=2;s=Tag1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(474, 15);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 7;
            label2.Text = "Tag Name:";
            // 
            // cfgTxtOpcServer
            // 
            cfgTxtOpcServer.Location = new Point(28, 38);
            cfgTxtOpcServer.Name = "cfgTxtOpcServer";
            cfgTxtOpcServer.Size = new Size(395, 27);
            cfgTxtOpcServer.TabIndex = 6;
            cfgTxtOpcServer.Text = "opc.tcp://deskbook:62640";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 15);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 5;
            label1.Text = "Opc Server:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 368);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 31;
            label6.Text = "Sensor Type:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(920, 80);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 30;
            label7.Text = "Process Variable:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(474, 80);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 29;
            label8.Text = "Process Unit:";
            // 
            // cmbSensorType
            // 
            cmbSensorType.FormattingEnabled = true;
            cmbSensorType.Location = new Point(28, 391);
            cmbSensorType.Name = "cmbSensorType";
            cmbSensorType.Size = new Size(400, 28);
            cmbSensorType.TabIndex = 34;
            cmbSensorType.SelectedIndexChanged += cmbSensorType_SelectedIndexChanged;
            // 
            // cmbProcessVariable
            // 
            cmbProcessVariable.FormattingEnabled = true;
            cmbProcessVariable.Location = new Point(920, 103);
            cmbProcessVariable.Name = "cmbProcessVariable";
            cmbProcessVariable.Size = new Size(400, 28);
            cmbProcessVariable.TabIndex = 33;
            cmbProcessVariable.SelectedIndexChanged += cmbProcessVariable_SelectedIndexChanged;
            // 
            // cmbProcessUnit
            // 
            cmbProcessUnit.FormattingEnabled = true;
            cmbProcessUnit.Location = new Point(474, 103);
            cmbProcessUnit.Name = "cmbProcessUnit";
            cmbProcessUnit.Size = new Size(400, 28);
            cmbProcessUnit.TabIndex = 32;
            cmbProcessUnit.SelectedIndexChanged += cmbProcessUnit_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1154, 529);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 31);
            btnSave.TabIndex = 35;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // groupBoxProcessUnit
            // 
            groupBoxProcessUnit.Controls.Add(lblUnitName);
            groupBoxProcessUnit.Controls.Add(txtProcessName);
            groupBoxProcessUnit.Controls.Add(lblUnitType);
            groupBoxProcessUnit.Controls.Add(txtProcessType);
            groupBoxProcessUnit.Controls.Add(lblUnitDescription);
            groupBoxProcessUnit.Controls.Add(txtProcessDescription);
            groupBoxProcessUnit.Location = new Point(474, 149);
            groupBoxProcessUnit.Name = "groupBoxProcessUnit";
            groupBoxProcessUnit.Size = new Size(400, 179);
            groupBoxProcessUnit.TabIndex = 50;
            groupBoxProcessUnit.TabStop = false;
            groupBoxProcessUnit.Text = "Process Unit Details";
            // 
            // lblUnitName
            // 
            lblUnitName.AutoSize = true;
            lblUnitName.Location = new Point(20, 33);
            lblUnitName.Name = "lblUnitName";
            lblUnitName.Size = new Size(105, 20);
            lblUnitName.TabIndex = 0;
            lblUnitName.Text = "Process Name:";
            // 
            // txtProcessName
            // 
            txtProcessName.Location = new Point(131, 30);
            txtProcessName.Name = "txtProcessName";
            txtProcessName.Size = new Size(239, 27);
            txtProcessName.TabIndex = 1;
            // 
            // lblUnitType
            // 
            lblUnitType.AutoSize = true;
            lblUnitType.Location = new Point(20, 68);
            lblUnitType.Name = "lblUnitType";
            lblUnitType.Size = new Size(96, 20);
            lblUnitType.TabIndex = 0;
            lblUnitType.Text = "Process Type:";
            // 
            // txtProcessType
            // 
            txtProcessType.Location = new Point(131, 65);
            txtProcessType.Name = "txtProcessType";
            txtProcessType.Size = new Size(239, 27);
            txtProcessType.TabIndex = 2;
            // 
            // lblUnitDescription
            // 
            lblUnitDescription.AutoSize = true;
            lblUnitDescription.Location = new Point(20, 103);
            lblUnitDescription.Name = "lblUnitDescription";
            lblUnitDescription.Size = new Size(88, 20);
            lblUnitDescription.TabIndex = 0;
            lblUnitDescription.Text = "Description:";
            // 
            // txtProcessDescription
            // 
            txtProcessDescription.Location = new Point(131, 100);
            txtProcessDescription.Name = "txtProcessDescription";
            txtProcessDescription.Size = new Size(239, 27);
            txtProcessDescription.TabIndex = 3;
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(28, 280);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(99, 20);
            lblManufacturer.TabIndex = 36;
            lblManufacturer.Text = "Manufacturer:";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(28, 303);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(170, 27);
            txtManufacturer.TabIndex = 37;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(293, 280);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(55, 20);
            lblModel.TabIndex = 38;
            lblModel.Text = "Model:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(293, 303);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(170, 27);
            txtModel.TabIndex = 39;
            // 
            // lblSerialNumber
            // 
            lblSerialNumber.AutoSize = true;
            lblSerialNumber.Location = new Point(549, 280);
            lblSerialNumber.Name = "lblSerialNumber";
            lblSerialNumber.Size = new Size(107, 20);
            lblSerialNumber.TabIndex = 40;
            lblSerialNumber.Text = "Serial Number:";
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Location = new Point(549, 303);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(170, 27);
            txtSerialNumber.TabIndex = 41;
            // 
            // lblInstallationDate
            // 
            lblInstallationDate.AutoSize = true;
            lblInstallationDate.Location = new Point(28, 350);
            lblInstallationDate.Name = "lblInstallationDate";
            lblInstallationDate.Size = new Size(120, 20);
            lblInstallationDate.TabIndex = 42;
            lblInstallationDate.Text = "Installation Date:";
            // 
            // dtpInstallationDate
            // 
            dtpInstallationDate.Format = DateTimePickerFormat.Short;
            dtpInstallationDate.Location = new Point(28, 373);
            dtpInstallationDate.Name = "dtpInstallationDate";
            dtpInstallationDate.Size = new Size(170, 27);
            dtpInstallationDate.TabIndex = 43;
            // 
            // groupBoxProcessVariable
            // 
            groupBoxProcessVariable.Controls.Add(label9);
            groupBoxProcessVariable.Controls.Add(txtVariableName);
            groupBoxProcessVariable.Controls.Add(label10);
            groupBoxProcessVariable.Controls.Add(txtEngineeringUnit);
            groupBoxProcessVariable.Controls.Add(label11);
            groupBoxProcessVariable.Controls.Add(txtVariableDescription);
            groupBoxProcessVariable.Location = new Point(920, 149);
            groupBoxProcessVariable.Name = "groupBoxProcessVariable";
            groupBoxProcessVariable.Size = new Size(400, 179);
            groupBoxProcessVariable.TabIndex = 51;
            groupBoxProcessVariable.TabStop = false;
            groupBoxProcessVariable.Text = "Process Variable Details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 33);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 0;
            label9.Text = "Variable Name:";
            // 
            // txtVariableName
            // 
            txtVariableName.Location = new Point(148, 30);
            txtVariableName.Name = "txtVariableName";
            txtVariableName.Size = new Size(222, 27);
            txtVariableName.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 68);
            label10.Name = "label10";
            label10.Size = new Size(122, 20);
            label10.TabIndex = 0;
            label10.Text = "Engineering Unit:";
            // 
            // txtEngineeringUnit
            // 
            txtEngineeringUnit.Location = new Point(148, 65);
            txtEngineeringUnit.Name = "txtEngineeringUnit";
            txtEngineeringUnit.Size = new Size(222, 27);
            txtEngineeringUnit.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 103);
            label11.Name = "label11";
            label11.Size = new Size(88, 20);
            label11.TabIndex = 0;
            label11.Text = "Description:";
            // 
            // txtVariableDescription
            // 
            txtVariableDescription.Location = new Point(148, 100);
            txtVariableDescription.Name = "txtVariableDescription";
            txtVariableDescription.Size = new Size(222, 27);
            txtVariableDescription.TabIndex = 3;
            // 
            // groupBoxSensorType
            // 
            groupBoxSensorType.Controls.Add(label12);
            groupBoxSensorType.Controls.Add(txtTypeName);
            groupBoxSensorType.Controls.Add(label14);
            groupBoxSensorType.Controls.Add(txtSensorTypeDescription);
            groupBoxSensorType.Location = new Point(28, 437);
            groupBoxSensorType.Name = "groupBoxSensorType";
            groupBoxSensorType.Size = new Size(400, 215);
            groupBoxSensorType.TabIndex = 52;
            groupBoxSensorType.TabStop = false;
            groupBoxSensorType.Text = "Sensor Type Details";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 33);
            label12.Name = "label12";
            label12.Size = new Size(87, 20);
            label12.TabIndex = 0;
            label12.Text = "Type Name:";
            // 
            // txtTypeName
            // 
            txtTypeName.Location = new Point(148, 30);
            txtTypeName.Name = "txtTypeName";
            txtTypeName.Size = new Size(222, 27);
            txtTypeName.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 103);
            label14.Name = "label14";
            label14.Size = new Size(88, 20);
            label14.TabIndex = 0;
            label14.Text = "Description:";
            // 
            // txtSensorTypeDescription
            // 
            txtSensorTypeDescription.Location = new Point(148, 100);
            txtSensorTypeDescription.Name = "txtSensorTypeDescription";
            txtSensorTypeDescription.Size = new Size(222, 27);
            txtSensorTypeDescription.TabIndex = 3;
            // 
            // groupBoxSensor
            // 
            groupBoxSensor.Controls.Add(label3);
            groupBoxSensor.Controls.Add(txtSensorName);
            groupBoxSensor.Controls.Add(label15);
            groupBoxSensor.Controls.Add(txtSensorModel);
            groupBoxSensor.Controls.Add(label17);
            groupBoxSensor.Controls.Add(txtSensorSerial);
            groupBoxSensor.Controls.Add(label18);
            groupBoxSensor.Controls.Add(txtSensorInstallDate);
            groupBoxSensor.Controls.Add(label13);
            groupBoxSensor.Controls.Add(txtSensorManufacturer);
            groupBoxSensor.Location = new Point(474, 439);
            groupBoxSensor.Name = "groupBoxSensor";
            groupBoxSensor.Size = new Size(400, 213);
            groupBoxSensor.TabIndex = 55;
            groupBoxSensor.TabStop = false;
            groupBoxSensor.Text = "Sensor Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 36);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 10;
            label3.Text = "Sensor Name:";
            // 
            // txtSensorName
            // 
            txtSensorName.Location = new Point(148, 33);
            txtSensorName.Name = "txtSensorName";
            txtSensorName.Size = new Size(222, 27);
            txtSensorName.TabIndex = 11;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 109);
            label15.Name = "label15";
            label15.Size = new Size(55, 20);
            label15.TabIndex = 4;
            label15.Text = "Model:";
            // 
            // txtSensorModel
            // 
            txtSensorModel.Location = new Point(148, 106);
            txtSensorModel.Name = "txtSensorModel";
            txtSensorModel.Size = new Size(222, 27);
            txtSensorModel.TabIndex = 7;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(20, 144);
            label17.Name = "label17";
            label17.Size = new Size(107, 20);
            label17.TabIndex = 5;
            label17.Text = "Serial Number:";
            // 
            // txtSensorSerial
            // 
            txtSensorSerial.Location = new Point(148, 141);
            txtSensorSerial.Name = "txtSensorSerial";
            txtSensorSerial.Size = new Size(222, 27);
            txtSensorSerial.TabIndex = 8;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(20, 179);
            label18.Name = "label18";
            label18.Size = new Size(121, 20);
            label18.TabIndex = 6;
            label18.Text = "Installation Date:";
            // 
            // txtSensorInstallDate
            // 
            txtSensorInstallDate.Location = new Point(148, 176);
            txtSensorInstallDate.Name = "txtSensorInstallDate";
            txtSensorInstallDate.Size = new Size(222, 27);
            txtSensorInstallDate.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 73);
            label13.Name = "label13";
            label13.Size = new Size(100, 20);
            label13.TabIndex = 0;
            label13.Text = "Manufacturer:";
            // 
            // txtSensorManufacturer
            // 
            txtSensorManufacturer.Location = new Point(148, 70);
            txtSensorManufacturer.Name = "txtSensorManufacturer";
            txtSensorManufacturer.Size = new Size(222, 27);
            txtSensorManufacturer.TabIndex = 1;
            // 
            // cmbSensor
            // 
            cmbSensor.FormattingEnabled = true;
            cmbSensor.Location = new Point(474, 393);
            cmbSensor.Name = "cmbSensor";
            cmbSensor.Size = new Size(400, 28);
            cmbSensor.TabIndex = 54;
            cmbSensor.SelectedIndexChanged += cmbSensor_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(474, 368);
            label16.Name = "label16";
            label16.Size = new Size(56, 20);
            label16.TabIndex = 53;
            label16.Text = "Sensor:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(txtBuilding);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(txtFloor);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(txtRoom);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(txtLocationName);
            groupBox1.Location = new Point(28, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 177);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "Location Details";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(20, 69);
            label19.Name = "label19";
            label19.Size = new Size(67, 20);
            label19.TabIndex = 4;
            label19.Text = "Building:";
            // 
            // txtBuilding
            // 
            txtBuilding.Location = new Point(148, 66);
            txtBuilding.Name = "txtBuilding";
            txtBuilding.Size = new Size(222, 27);
            txtBuilding.TabIndex = 7;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(20, 104);
            label20.Name = "label20";
            label20.Size = new Size(46, 20);
            label20.TabIndex = 5;
            label20.Text = "Floor:";
            // 
            // txtFloor
            // 
            txtFloor.Location = new Point(148, 101);
            txtFloor.Name = "txtFloor";
            txtFloor.Size = new Size(222, 27);
            txtFloor.TabIndex = 8;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(20, 139);
            label21.Name = "label21";
            label21.Size = new Size(52, 20);
            label21.TabIndex = 6;
            label21.Text = "Room:";
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(148, 136);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(222, 27);
            txtRoom.TabIndex = 9;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(20, 33);
            label22.Name = "label22";
            label22.Size = new Size(113, 20);
            label22.TabIndex = 0;
            label22.Text = "Location Name:";
            // 
            // txtLocationName
            // 
            txtLocationName.Location = new Point(148, 30);
            txtLocationName.Name = "txtLocationName";
            txtLocationName.Size = new Size(222, 27);
            txtLocationName.TabIndex = 1;
            // 
            // cmbLocation
            // 
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(28, 105);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(400, 28);
            cmbLocation.TabIndex = 57;
            cmbLocation.SelectedIndexChanged += cmbLocation_SelectedIndexChanged;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(28, 80);
            label23.Name = "label23";
            label23.Size = new Size(69, 20);
            label23.TabIndex = 56;
            label23.Text = "Location:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(990, 529);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 31);
            btnCancel.TabIndex = 59;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 721);
            Controls.Add(btnCancel);
            Controls.Add(groupBox1);
            Controls.Add(cmbLocation);
            Controls.Add(label23);
            Controls.Add(groupBoxSensor);
            Controls.Add(cmbSensor);
            Controls.Add(label16);
            Controls.Add(groupBoxSensorType);
            Controls.Add(groupBoxProcessVariable);
            Controls.Add(groupBoxProcessUnit);
            Controls.Add(btnSave);
            Controls.Add(cmbSensorType);
            Controls.Add(cmbProcessVariable);
            Controls.Add(cmbProcessUnit);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(cfgTxtTagName);
            Controls.Add(label2);
            Controls.Add(cfgTxtOpcServer);
            Controls.Add(label1);
            Name = "ConfigForm";
            Text = "ConfigForm";
            groupBoxProcessUnit.ResumeLayout(false);
            groupBoxProcessUnit.PerformLayout();
            groupBoxProcessVariable.ResumeLayout(false);
            groupBoxProcessVariable.PerformLayout();
            groupBoxSensorType.ResumeLayout(false);
            groupBoxSensorType.PerformLayout();
            groupBoxSensor.ResumeLayout(false);
            groupBoxSensor.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cfgTxtTagName;
            private Label label2;
            private TextBox cfgTxtOpcServer;
            private Label label1;
            private Label label6;
            private Label label7;
            private Label label8;
            private ComboBox cmbSensorType;
            private ComboBox cmbProcessVariable;
            private ComboBox cmbProcessUnit;
            private Button btnSave;
            private System.Windows.Forms.Label lblManufacturer;
            private System.Windows.Forms.TextBox txtManufacturer;
            private System.Windows.Forms.Label lblModel;
            private System.Windows.Forms.TextBox txtModel;
            private System.Windows.Forms.Label lblSerialNumber;
            private System.Windows.Forms.TextBox txtSerialNumber;
            private System.Windows.Forms.Label lblInstallationDate;
            private System.Windows.Forms.DateTimePicker dtpInstallationDate;
            private System.Windows.Forms.GroupBox groupBoxProcessUnit;
            private System.Windows.Forms.TextBox txtProcessName;
            private System.Windows.Forms.Label lblUnitName;
            private System.Windows.Forms.TextBox txtProcessType;
            private System.Windows.Forms.Label lblUnitType;
            private System.Windows.Forms.TextBox txtProcessDescription;
            private System.Windows.Forms.Label lblUnitDescription;
        private GroupBox groupBoxProcessVariable;
        private Label label9;
        private TextBox txtVariableName;
        private Label label10;
        private TextBox txtEngineeringUnit;
        private Label label11;
        private TextBox txtVariableDescription;
        private GroupBox groupBoxSensorType;
        private Label label12;
        private TextBox txtTypeName;
        private Label label14;
        private TextBox txtSensorTypeDescription;
        private GroupBox groupBoxSensor;
        private ComboBox cmbSensor;
        private Label label16;
        private Label label15;
        private TextBox txtSensorModel;
        private Label label17;
        private TextBox txtSensorSerial;
        private Label label18;
        private TextBox txtSensorInstallDate;
        private Label label13;
        private TextBox txtSensorManufacturer;
        private GroupBox groupBox1;
        private Label label19;
        private TextBox txtBuilding;
        private Label label20;
        private TextBox txtFloor;
        private Label label21;
        private TextBox txtRoom;
        private Label label22;
        private TextBox txtLocationName;
        private ComboBox cmbLocation;
        private Label label23;
        private Label label3;
        private TextBox txtSensorName;
        private Button btnCancel;
    }
            }