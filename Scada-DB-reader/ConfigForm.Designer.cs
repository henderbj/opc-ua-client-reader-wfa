namespace Scada_DB_reader
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
            btnCancel = new Button();
            groupBox1 = new GroupBox();
            label19 = new Label();
            txtBuilding = new TextBox();
            label20 = new Label();
            txtFloor = new TextBox();
            label21 = new Label();
            txtRoom = new TextBox();
            label22 = new Label();
            txtLocationName = new TextBox();
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
            groupBoxSensorType = new GroupBox();
            label12 = new Label();
            txtSensorTypeName = new TextBox();
            label14 = new Label();
            txtSensorTypeDescription = new TextBox();
            groupBoxProcessVariable = new GroupBox();
            label9 = new Label();
            txtVariableName = new TextBox();
            label10 = new Label();
            txtEngineeringUnit = new TextBox();
            label11 = new Label();
            txtVariableDescription = new TextBox();
            groupBoxProcessUnit = new GroupBox();
            lblUnitName = new Label();
            txtProcessName = new TextBox();
            lblUnitType = new Label();
            txtProcessType = new TextBox();
            lblUnitDescription = new Label();
            txtProcessDescription = new TextBox();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            groupBoxSensor.SuspendLayout();
            groupBoxSensorType.SuspendLayout();
            groupBoxProcessVariable.SuspendLayout();
            groupBoxProcessUnit.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(976, 396);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 31);
            btnCancel.TabIndex = 76;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
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
            groupBox1.Location = new Point(14, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 177);
            groupBox1.TabIndex = 75;
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
            txtBuilding.Enabled = false;
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
            txtFloor.Enabled = false;
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
            txtRoom.Enabled = false;
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
            txtLocationName.Enabled = false;
            txtLocationName.Location = new Point(148, 30);
            txtLocationName.Name = "txtLocationName";
            txtLocationName.Size = new Size(222, 27);
            txtLocationName.TabIndex = 1;
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
            groupBoxSensor.Location = new Point(460, 306);
            groupBoxSensor.Name = "groupBoxSensor";
            groupBoxSensor.Size = new Size(400, 213);
            groupBoxSensor.TabIndex = 72;
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
            txtSensorName.Enabled = false;
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
            txtSensorModel.Enabled = false;
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
            txtSensorSerial.Enabled = false;
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
            txtSensorInstallDate.Enabled = false;
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
            txtSensorManufacturer.Enabled = false;
            txtSensorManufacturer.Location = new Point(148, 70);
            txtSensorManufacturer.Name = "txtSensorManufacturer";
            txtSensorManufacturer.Size = new Size(222, 27);
            txtSensorManufacturer.TabIndex = 1;
            // 
            // cmbSensor
            // 
            cmbSensor.FormattingEnabled = true;
            cmbSensor.Location = new Point(460, 260);
            cmbSensor.Name = "cmbSensor";
            cmbSensor.Size = new Size(400, 28);
            cmbSensor.TabIndex = 71;
            cmbSensor.SelectedIndexChanged += cmbSensor_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(460, 235);
            label16.Name = "label16";
            label16.Size = new Size(56, 20);
            label16.TabIndex = 70;
            label16.Text = "Sensor:";
            // 
            // groupBoxSensorType
            // 
            groupBoxSensorType.Controls.Add(label12);
            groupBoxSensorType.Controls.Add(txtSensorTypeName);
            groupBoxSensorType.Controls.Add(label14);
            groupBoxSensorType.Controls.Add(txtSensorTypeDescription);
            groupBoxSensorType.Location = new Point(14, 304);
            groupBoxSensorType.Name = "groupBoxSensorType";
            groupBoxSensorType.Size = new Size(400, 215);
            groupBoxSensorType.TabIndex = 69;
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
            // txtSensorTypeName
            // 
            txtSensorTypeName.Enabled = false;
            txtSensorTypeName.Location = new Point(148, 30);
            txtSensorTypeName.Name = "txtSensorTypeName";
            txtSensorTypeName.Size = new Size(222, 27);
            txtSensorTypeName.TabIndex = 1;
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
            txtSensorTypeDescription.Enabled = false;
            txtSensorTypeDescription.Location = new Point(148, 100);
            txtSensorTypeDescription.Name = "txtSensorTypeDescription";
            txtSensorTypeDescription.Size = new Size(222, 27);
            txtSensorTypeDescription.TabIndex = 3;
            // 
            // groupBoxProcessVariable
            // 
            groupBoxProcessVariable.Controls.Add(label9);
            groupBoxProcessVariable.Controls.Add(txtVariableName);
            groupBoxProcessVariable.Controls.Add(label10);
            groupBoxProcessVariable.Controls.Add(txtEngineeringUnit);
            groupBoxProcessVariable.Controls.Add(label11);
            groupBoxProcessVariable.Controls.Add(txtVariableDescription);
            groupBoxProcessVariable.Location = new Point(906, 16);
            groupBoxProcessVariable.Name = "groupBoxProcessVariable";
            groupBoxProcessVariable.Size = new Size(400, 179);
            groupBoxProcessVariable.TabIndex = 68;
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
            txtVariableName.Enabled = false;
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
            txtEngineeringUnit.Enabled = false;
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
            txtVariableDescription.Enabled = false;
            txtVariableDescription.Location = new Point(148, 100);
            txtVariableDescription.Name = "txtVariableDescription";
            txtVariableDescription.Size = new Size(222, 27);
            txtVariableDescription.TabIndex = 3;
            // 
            // groupBoxProcessUnit
            // 
            groupBoxProcessUnit.Controls.Add(lblUnitName);
            groupBoxProcessUnit.Controls.Add(txtProcessName);
            groupBoxProcessUnit.Controls.Add(lblUnitType);
            groupBoxProcessUnit.Controls.Add(txtProcessType);
            groupBoxProcessUnit.Controls.Add(lblUnitDescription);
            groupBoxProcessUnit.Controls.Add(txtProcessDescription);
            groupBoxProcessUnit.Location = new Point(460, 16);
            groupBoxProcessUnit.Name = "groupBoxProcessUnit";
            groupBoxProcessUnit.Size = new Size(400, 179);
            groupBoxProcessUnit.TabIndex = 67;
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
            txtProcessName.Enabled = false;
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
            txtProcessType.Enabled = false;
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
            txtProcessDescription.Enabled = false;
            txtProcessDescription.Location = new Point(131, 100);
            txtProcessDescription.Name = "txtProcessDescription";
            txtProcessDescription.Size = new Size(239, 27);
            txtProcessDescription.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1140, 396);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 31);
            btnSave.TabIndex = 66;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 619);
            Controls.Add(btnCancel);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxSensor);
            Controls.Add(cmbSensor);
            Controls.Add(label16);
            Controls.Add(groupBoxSensorType);
            Controls.Add(groupBoxProcessVariable);
            Controls.Add(groupBoxProcessUnit);
            Controls.Add(btnSave);
            Name = "ConfigForm";
            Text = "ConfigForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxSensor.ResumeLayout(false);
            groupBoxSensor.PerformLayout();
            groupBoxSensorType.ResumeLayout(false);
            groupBoxSensorType.PerformLayout();
            groupBoxProcessVariable.ResumeLayout(false);
            groupBoxProcessVariable.PerformLayout();
            groupBoxProcessUnit.ResumeLayout(false);
            groupBoxProcessUnit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private GroupBox groupBox1;
        private Label label19;
        private TextBox txtBuilding;
        private Label label20;
        private TextBox txtFloor;
        private Label label21;
        private TextBox txtRoom;
        private Label label22;
        private TextBox txtLocationName;
        private GroupBox groupBoxSensor;
        private Label label3;
        private TextBox txtSensorName;
        private Label label15;
        private TextBox txtSensorModel;
        private Label label17;
        private TextBox txtSensorSerial;
        private Label label18;
        private TextBox txtSensorInstallDate;
        private Label label13;
        private TextBox txtSensorManufacturer;
        private ComboBox cmbSensor;
        private Label label16;
        private GroupBox groupBoxSensorType;
        private Label label12;
        private TextBox txtSensorTypeName;
        private Label label14;
        private TextBox txtSensorTypeDescription;
        private GroupBox groupBoxProcessVariable;
        private Label label9;
        private TextBox txtVariableName;
        private Label label10;
        private TextBox txtEngineeringUnit;
        private Label label11;
        private TextBox txtVariableDescription;
        private GroupBox groupBoxProcessUnit;
        private Label lblUnitName;
        private TextBox txtProcessName;
        private Label lblUnitType;
        private TextBox txtProcessType;
        private Label lblUnitDescription;
        private TextBox txtProcessDescription;
        private Button btnSave;
    }
}