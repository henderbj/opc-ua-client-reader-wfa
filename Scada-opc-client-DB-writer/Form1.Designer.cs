namespace Scada_opc_client_DB_writer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            label1 = new Label();
            txtOpcServer = new TextBox();
            txtTagName = new TextBox();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            btnStop = new Button();
            bindingSource1 = new BindingSource(components);
            groupBox1 = new GroupBox();
            btnStart = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            txtSensorType = new TextBox();
            label6 = new Label();
            txtSensor = new TextBox();
            label7 = new Label();
            txtProcessVariable = new TextBox();
            label5 = new Label();
            txtProcessUnit = new TextBox();
            label3 = new Label();
            txtLocation = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(47, 304);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(888, 289);
            formsPlot1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "Server:";
            // 
            // txtOpcServer
            // 
            txtOpcServer.Enabled = false;
            txtOpcServer.Location = new Point(16, 49);
            txtOpcServer.Name = "txtOpcServer";
            txtOpcServer.Size = new Size(580, 27);
            txtOpcServer.TabIndex = 2;
            //txtOpcServer.Leave += txtOpcServer_Leave;
            // 
            // txtTagName
            // 
            txtTagName.Enabled = false;
            txtTagName.Location = new Point(636, 49);
            txtTagName.Name = "txtTagName";
            txtTagName.Size = new Size(270, 27);
            txtTagName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(632, 26);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 3;
            label2.Text = "Tag:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnStop
            // 
            btnStop.Location = new Point(139, 48);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(114, 31);
            btnStop.TabIndex = 20;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnStart);
            groupBox1.Controls.Add(btnStop);
            groupBox1.Location = new Point(667, 602);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 113);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sample capture";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(8, 48);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(114, 31);
            btnStart.TabIndex = 21;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTagName);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtOpcServer);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(908, 87);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "OPC UA";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSensorType);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtSensor);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtProcessVariable);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtProcessUnit);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtLocation);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(12, 115);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(908, 183);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sensor";
            // 
            // txtSensorType
            // 
            txtSensorType.Enabled = false;
            txtSensorType.Location = new Point(326, 112);
            txtSensorType.Name = "txtSensorType";
            txtSensorType.Size = new Size(270, 27);
            txtSensorType.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 89);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 7;
            label6.Text = "Sensor:";
            // 
            // txtSensor
            // 
            txtSensor.Enabled = false;
            txtSensor.Location = new Point(16, 112);
            txtSensor.Name = "txtSensor";
            txtSensor.Size = new Size(270, 27);
            txtSensor.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(326, 89);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 9;
            label7.Text = "Sensor Type:";
            // 
            // txtProcessVariable
            // 
            txtProcessVariable.Enabled = false;
            txtProcessVariable.Location = new Point(636, 49);
            txtProcessVariable.Name = "txtProcessVariable";
            txtProcessVariable.Size = new Size(270, 27);
            txtProcessVariable.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(632, 26);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 5;
            label5.Text = "Process Variable:";
            // 
            // txtProcessUnit
            // 
            txtProcessUnit.Enabled = false;
            txtProcessUnit.Location = new Point(326, 49);
            txtProcessUnit.Name = "txtProcessUnit";
            txtProcessUnit.Size = new Size(270, 27);
            txtProcessUnit.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 26);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 1;
            label3.Text = "Location:";
            // 
            // txtLocation
            // 
            txtLocation.Enabled = false;
            txtLocation.Location = new Point(16, 49);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(270, 27);
            txtLocation.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 26);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 3;
            label4.Text = "Process Unit:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(formsPlot1);
            Name = "Form1";
            Text = "OPC Client - DB Writer";
            WindowState = FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Label label1;
        private TextBox txtOpcServer;
        private TextBox txtTagName;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private Button btnStop;
        private BindingSource bindingSource1;
        private GroupBox groupBox1;
        private Button btnStart;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtProcessUnit;
        private Label label3;
        private TextBox txtLocation;
        private Label label4;
        private TextBox txtProcessVariable;
        private Label label5;
        private TextBox txtSensorType;
        private Label label6;
        private TextBox txtSensor;
        private Label label7;
    }
}
