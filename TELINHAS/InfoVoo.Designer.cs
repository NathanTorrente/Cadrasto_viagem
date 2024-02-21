namespace Cadastro_Check_in
{
    partial class InfoVoo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoVoo));
            label7 = new Label();
            label6 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            cb_Destino = new ComboBox();
            label5 = new Label();
            cb_Origem = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            checkBox1 = new CheckBox();
            button2 = new Button();
            panel1 = new Panel();
            label14 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(319, 80);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 42;
            label7.Text = "Data de volta";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(319, 46);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 41;
            label6.Text = "Data de ida";
            label6.Click += label6_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(411, 76);
            dateTimePicker3.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(219, 23);
            dateTimePicker3.TabIndex = 40;
            dateTimePicker3.Value = new DateTime(2023, 8, 20, 0, 0, 0, 0);
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(411, 46);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(219, 23);
            dateTimePicker2.TabIndex = 39;
            dateTimePicker2.Value = new DateTime(2023, 8, 20, 0, 0, 0, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // cb_Destino
            // 
            cb_Destino.FormattingEnabled = true;
            cb_Destino.Items.AddRange(new object[] { "Ariquemes", "Cacoal", "Ji-Paraná", "Porto Velho", "Vilhena" });
            cb_Destino.Location = new Point(133, 74);
            cb_Destino.Margin = new Padding(3, 2, 3, 2);
            cb_Destino.Name = "cb_Destino";
            cb_Destino.Size = new Size(133, 23);
            cb_Destino.TabIndex = 38;
            cb_Destino.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 74);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 37;
            label5.Text = "Destino";
            // 
            // cb_Origem
            // 
            cb_Origem.FormattingEnabled = true;
            cb_Origem.Items.AddRange(new object[] { "Ariquemes", "Cacoal", "Ji-Paraná", "Porto Velho", "Vilhena" });
            cb_Origem.Location = new Point(133, 40);
            cb_Origem.Margin = new Padding(3, 2, 3, 2);
            cb_Origem.Name = "cb_Origem";
            cb_Origem.Size = new Size(133, 23);
            cb_Origem.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 40);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 35;
            label4.Text = "Origem";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 125);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 128);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 33;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "0 ", "1 ", "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9 ", "10 ", "11 ", "12 ", "13 ", "14 ", "15 ", "16 ", "17 ", "18 ", "19 ", "20 ", "21 ", "22 ", "23 " });
            comboBox2.Location = new Point(263, 140);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 32;
            comboBox2.Visible = false;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 142);
            label1.Name = "label1";
            label1.Size = new Size(174, 15);
            label1.TabIndex = 31;
            label1.Text = "Qual é o peso da sua Bagagem?";
            label1.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(549, 250);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(135, 59);
            button1.TabIndex = 43;
            button1.Text = "Comprar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientInactiveCaption;
            label8.Location = new Point(97, 141);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 44;
            label8.Text = "label8";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GradientInactiveCaption;
            label9.Location = new Point(96, 162);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 45;
            label9.Text = "label9";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.GradientInactiveCaption;
            label10.Location = new Point(94, 183);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 46;
            label10.Text = "label10";
            label10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.GradientInactiveCaption;
            label11.Location = new Point(95, 202);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 47;
            label11.Text = "label11";
            label11.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.GradientInactiveCaption;
            label12.Location = new Point(90, 221);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 48;
            label12.Text = "label12";
            label12.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(48, 114);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(130, 19);
            checkBox1.TabIndex = 49;
            checkBox1.Text = "Adicionar bagagem";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.InactiveCaptionText;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(549, 179);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(127, 36);
            button2.TabIndex = 50;
            button2.Text = "Cancelar";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(-38, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 296);
            panel1.TabIndex = 51;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(457, 125);
            label14.Name = "label14";
            label14.Size = new Size(72, 30);
            label14.TabIndex = 52;
            label14.Text = "Ticket";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(549, 142);
            button3.Name = "button3";
            button3.Size = new Size(127, 31);
            button3.TabIndex = 53;
            button3.Text = "Poltrona";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // InfoVoo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(button3);
            Controls.Add(label14);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(cb_Destino);
            Controls.Add(label5);
            Controls.Add(cb_Origem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InfoVoo";
            Text = "InfoVoo";
            Load += InfoVoo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private ComboBox cb_Destino;
        private Label label5;
        private ComboBox cb_Origem;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox2;
        private Label label1;
        private Button button1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private CheckBox checkBox1;
        private Label label13;
        private Button button2;
        private Panel panel1;
        private Label label14;
        private Button button3;
    }
}