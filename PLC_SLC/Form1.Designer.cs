namespace PLC_SLC
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
            lab_1 = new Label();
            lab_2 = new Label();
            lab_3 = new Label();
            lab_4 = new Label();
            btn_connect = new Button();
            com_Type = new ComboBox();
            txt_data = new TextBox();
            txt_IP = new TextBox();
            txt_data_2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_1 = new TextBox();
            txt_2 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_disconnect = new Button();
            label4 = new Label();
            txtTimer = new TextBox();
            SuspendLayout();
            // 
            // lab_1
            // 
            lab_1.AutoSize = true;
            lab_1.Location = new Point(264, 85);
            lab_1.Name = "lab_1";
            lab_1.Size = new Size(71, 20);
            lab_1.TabIndex = 0;
            lab_1.Text = "CPU Type";
            // 
            // lab_2
            // 
            lab_2.AutoSize = true;
            lab_2.Location = new Point(264, 27);
            lab_2.Name = "lab_2";
            lab_2.Size = new Size(78, 20);
            lab_2.TabIndex = 4;
            lab_2.Text = "IP Address";
            // 
            // lab_3
            // 
            lab_3.AutoSize = true;
            lab_3.Location = new Point(145, 215);
            lab_3.Name = "lab_3";
            lab_3.Size = new Size(81, 20);
            lab_3.TabIndex = 6;
            lab_3.Text = "Good Parts";
            // 
            // lab_4
            // 
            lab_4.AutoSize = true;
            lab_4.Location = new Point(145, 263);
            lab_4.Name = "lab_4";
            lab_4.Size = new Size(70, 20);
            lab_4.TabIndex = 8;
            lab_4.Text = "Bad Parts";
            // 
            // btn_connect
            // 
            btn_connect.Location = new Point(129, 27);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(91, 32);
            btn_connect.TabIndex = 1;
            btn_connect.Text = "Connect";
            btn_connect.UseVisualStyleBackColor = true;
            btn_connect.Click += btn_connect_Click;
            // 
            // com_Type
            // 
            com_Type.FormattingEnabled = true;
            com_Type.Location = new Point(377, 82);
            com_Type.Name = "com_Type";
            com_Type.Size = new Size(128, 28);
            com_Type.TabIndex = 3;
            // 
            // txt_data
            // 
            txt_data.Location = new Point(264, 212);
            txt_data.Name = "txt_data";
            txt_data.Size = new Size(128, 27);
            txt_data.TabIndex = 2;
            // 
            // txt_IP
            // 
            txt_IP.Location = new Point(377, 24);
            txt_IP.Name = "txt_IP";
            txt_IP.Size = new Size(128, 27);
            txt_IP.TabIndex = 5;
            txt_IP.Text = "192.168.1.5";
            // 
            // txt_data_2
            // 
            txt_data_2.Location = new Point(264, 260);
            txt_data_2.Name = "txt_data_2";
            txt_data_2.Size = new Size(128, 27);
            txt_data_2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 381);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 9;
            label1.Text = "Design by Thinh Bui";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 215);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 10;
            label2.Text = "%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 260);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 11;
            label3.Text = "%";
            // 
            // txt_1
            // 
            txt_1.Location = new Point(417, 212);
            txt_1.Name = "txt_1";
            txt_1.Size = new Size(72, 27);
            txt_1.TabIndex = 12;
            // 
            // txt_2
            // 
            txt_2.Location = new Point(417, 256);
            txt_2.Name = "txt_2";
            txt_2.Size = new Size(72, 27);
            txt_2.TabIndex = 13;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btn_disconnect
            // 
            btn_disconnect.Location = new Point(129, 85);
            btn_disconnect.Name = "btn_disconnect";
            btn_disconnect.Size = new Size(91, 32);
            btn_disconnect.TabIndex = 14;
            btn_disconnect.Text = "Disconnect";
            btn_disconnect.UseVisualStyleBackColor = true;
            btn_disconnect.Click += btn_disconnect_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 131);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 15;
            label4.Text = "Interval (ms)";
            // 
            // txtTimer
            // 
            txtTimer.Location = new Point(377, 131);
            txtTimer.Name = "txtTimer";
            txtTimer.Size = new Size(72, 27);
            txtTimer.TabIndex = 16;
            txtTimer.Text = "1000";
            txtTimer.TextChanged += txtTimer_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 410);
            Controls.Add(txtTimer);
            Controls.Add(label4);
            Controls.Add(btn_disconnect);
            Controls.Add(txt_2);
            Controls.Add(txt_1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lab_4);
            Controls.Add(txt_data_2);
            Controls.Add(lab_3);
            Controls.Add(txt_IP);
            Controls.Add(lab_2);
            Controls.Add(com_Type);
            Controls.Add(txt_data);
            Controls.Add(btn_connect);
            Controls.Add(lab_1);
            Name = "Form1";
            Text = "PLC SLC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_1;
        private Button btn_connect;
        private TextBox txt_data;
        private ComboBox com_Type;
        private Label lab_2;
        private TextBox txt_IP;
        private Label lab_3;
        private TextBox txt_data_2;
        private Label lab_4;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_1;
        private TextBox txt_2;
        private System.Windows.Forms.Timer timer1;
        private Button btn_disconnect;
        private Label label4;
        private TextBox txtTimer;
    }
}