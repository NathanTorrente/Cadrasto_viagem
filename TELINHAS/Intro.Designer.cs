namespace Cadastro_Check_in
{
    partial class Intro
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(319, 259);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(123, 35);
            button1.TabIndex = 0;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(184, 28);
            label1.Name = "label1";
            label1.Size = new Size(396, 51);
            label1.TabIndex = 1;
            label1.Text = "Cadrastro de Viagem";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(319, 309);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(123, 34);
            button2.TabIndex = 2;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Intro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.viagem_aeroporto_resultado_960x640_c;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(714, 390);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Intro";
            Text = "Intro";
            Load += Intro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
    }
}