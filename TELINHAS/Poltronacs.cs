using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Check_in
{
    public partial class Poltronacs : Form
    {
        private bool buttonClicked = false;
        private Random random = new Random();

        public Poltronacs()
        {
            InitializeComponent();
            label2.Text = "";
        }
        private void Poltronacs_Load(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] Aviao = { "Azul", "VASP", "Avianca" }; // Chute de aviões

            Random random = new Random();
            int Sorteio = random.Next(Aviao.Length);
            string avio = Convert.ToString(Aviao[Sorteio]);


            int randomPosition = random.Next(100); // Chute de Poltronas
            label2.Text = $"Poltrona: {randomPosition} \n Aeronave: {avio}:";

            MessageBox.Show($"Sua Vaga na Poltrona é o Nº {randomPosition}. Boa viagem!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (!buttonClicked) //Se não foi clicado, a ação foi falta (!)
            {
                buttonClicked = true; // caso clicado (True)
                button1.Enabled = false; // Desabilita o botão
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
