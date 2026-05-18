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
            button1 = new Button();
            button3 = new Button();
            bindingSource1 = new BindingSource(components);
            groupBox1 = new GroupBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox1.SuspendLayout();
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
            txtOpcServer.Leave += txtOpcServer_Leave;
            // 
            // txtTagName
            // 
            txtTagName.Location = new Point(488, 58);
            txtTagName.Name = "txtTagName";
            txtTagName.Size = new Size(199, 27);
            txtTagName.TabIndex = 4;
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
            // button1
            // 
            button1.Location = new Point(79, 639);
            button1.Name = "button1";
            button1.Size = new Size(90, 31);
            button1.TabIndex = 18;
            button1.Text = "Configure";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(139, 48);
            button3.Name = "button3";
            button3.Size = new Size(114, 31);
            button3.TabIndex = 20;
            button3.Text = "Stop";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(454, 591);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 113);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sample capture";
            // 
            // button2
            // 
            button2.Location = new Point(8, 48);
            button2.Name = "button2";
            button2.Size = new Size(114, 31);
            button2.TabIndex = 21;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 716);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(txtTagName);
            Controls.Add(label2);
            Controls.Add(txtOpcServer);
            Controls.Add(label1);
            Controls.Add(formsPlot1);
            Name = "Form1";
            Text = "OPC Client - DB Writer";
            WindowState = FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
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
        private Button button1;
        private Button button3;
        private BindingSource bindingSource1;
        private GroupBox groupBox1;
        private Button button2;
    }
}
