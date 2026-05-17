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
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(47, 271);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(689, 289);
            formsPlot1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 35);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "Opc Server:";
            // 
            // txtOpcServer
            // 
            txtOpcServer.Location = new Point(47, 58);
            txtOpcServer.Name = "txtOpcServer";
            txtOpcServer.Size = new Size(435, 27);
            txtOpcServer.TabIndex = 2;
            txtOpcServer.Text = "opc.tcp://deskbook:62640";
            txtOpcServer.Leave += txtOpcServer_Leave;
            // 
            // txtTagName
            // 
            txtTagName.Location = new Point(488, 58);
            txtTagName.Name = "txtTagName";
            txtTagName.Size = new Size(199, 27);
            txtTagName.TabIndex = 4;
            txtTagName.Text = "ns=2;s=Tag1";
            txtTagName.Leave += txtTagName_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(488, 35);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Tag Name:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            textBox1.Text = "Main Plant";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 100);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 7;
            label4.Text = "Building:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 100);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 9;
            label5.Text = "Floor:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            textBox2.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 100);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 11;
            label3.Text = "Room:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(373, 123);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 10;
            textBox3.Text = "101";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(373, 166);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 17;
            label6.Text = "Sensor:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(373, 189);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 16;
            textBox4.Text = "Temperature";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(209, 166);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 15;
            label7.Text = "Process Variable:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(209, 189);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 14;
            textBox5.Text = "Heater";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 166);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 13;
            label8.Text = "Process Unit:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(47, 189);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 12;
            textBox6.Text = "Main Plant";
            // 
            // button1
            // 
            button1.Location = new Point(66, 566);
            button1.Name = "button1";
            button1.Size = new Size(90, 31);
            button1.TabIndex = 18;
            button1.Text = "Configure";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(165, 566);
            button2.Name = "button2";
            button2.Size = new Size(114, 31);
            button2.TabIndex = 19;
            button2.Text = "Start sampling";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(622, 566);
            button3.Name = "button3";
            button3.Size = new Size(114, 31);
            button3.TabIndex = 20;
            button3.Text = "Stop";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 657);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(txtTagName);
            Controls.Add(label2);
            Controls.Add(txtOpcServer);
            Controls.Add(label1);
            Controls.Add(formsPlot1);
            Name = "Form1";
            Text = "OPC Client - DB Writer";
            WindowState = FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Label label1;
        private TextBox txtOpcServer;
        private TextBox txtTagName;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private Button button3;
        private BindingSource bindingSource1;
    }
}
