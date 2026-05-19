namespace Scada_DB_reader
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox3.SuspendLayout();
            SuspendLayout();
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
            groupBox3.Location = new Point(55, 59);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(908, 183);
            groupBox3.TabIndex = 24;
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
            // formsPlot1
            // 
            formsPlot1.Location = new Point(55, 283);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(906, 289);
            formsPlot1.TabIndex = 25;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 750);
            Controls.Add(formsPlot1);
            Controls.Add(groupBox3);
            Name = "Form1";
            Text = "Scada-DB-reader";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private TextBox txtSensorType;
        private Label label6;
        private TextBox txtSensor;
        private Label label7;
        private TextBox txtProcessVariable;
        private Label label5;
        private TextBox txtProcessUnit;
        private Label label3;
        private TextBox txtLocation;
        private Label label4;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private System.Windows.Forms.Timer timer1;
    }
}
