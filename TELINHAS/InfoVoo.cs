using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Cadastro_Check_in
{
    public partial class InfoVoo : Form
    {
        public InfoVoo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            try
            {

                if (cb_Origem.SelectedItem == null && cb_Destino.SelectedItem == null) // ComboBox seleção
                {
                    MessageBox.Show("Erro, Você não selecionou a origem nem o destino", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (cb_Origem.SelectedItem == cb_Destino.SelectedItem && cb_Destino.SelectedItem != null && cb_Origem.SelectedItem != null)
                {
                    MessageBox.Show("Erro, A origem e o destino são iguais", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cb_Origem.SelectedItem == null && cb_Destino.SelectedItem != null)
                {
                    MessageBox.Show("Erro, Origem não foi selecionada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cb_Destino.SelectedItem == null && cb_Origem.SelectedItem != null)
                {
                    MessageBox.Show("Erro, Destino não foi selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    label8.Text = "Lugar de origem selecionado: " + cb_Origem.Text;
                    label9.Text = "Destino selecionado: " + cb_Destino.Text;

                    label8.Visible = true;
                    label9.Visible = true;
                }


                int taxa = pessoa.Taxa(Convert.ToInt32(comboBox2.SelectedItem));

                if (cb_Origem.SelectedItem != null && cb_Destino.SelectedItem != null && cb_Origem.SelectedItem != cb_Destino.SelectedItem
                    && dateTimePicker2.Value <= dateTimePicker3.Value) // verificador de campos em branco
                {
                    MessageBox.Show($" Compra realizada com sucesso! Valor da passagem: R$ {(Convert.ToString(350 + taxa)),00}");

                    if (checkBox1.Checked) // valores da bagagem
                    {
                        label12.Text = "Valor de taxa de bagagem a ser pago: R$ " + taxa + ",00";
                        label12.Visible = true;
                    }
                    else
                    {
                        taxa = 0;
                        label12.Text = "Valor de taxa de bagagem a ser pago: R$ " + taxa + ",00";
                        label12.Visible = true;
                    }

                    if (dateTimePicker2.Value <= dateTimePicker3.Value) // Calendario
                    {
                        DateTime dataIda = dateTimePicker2.Value;
                        string IdaSomenteData = dataIda.ToShortDateString();

                        DateTime dataVolta = dateTimePicker3.Value;
                        string VoltaSomenteData = dataVolta.ToShortDateString();

                        label10.Text = "Data de ida escolhida: " + IdaSomenteData;
                        label11.Text = "Data de volta escolhida: " + VoltaSomenteData;

                        label10.Visible = true;
                        label11.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Erro! Data de volta é anterior a data de ida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Compra não efetuada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now.AddMonths(1);
        }
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.MinDate = DateTime.Now;
            dateTimePicker3.MaxDate = DateTime.Now.AddMonths(1);
            try
            {
                if (dateTimePicker3.Value < dateTimePicker2.Value)
                {
                    MessageBox.Show("Erro! Data de volta é anterior a data de ida");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void InfoVoo_Load(object sender, EventArgs e)
        {
        }
        private void label6_Click(object sender, EventArgs e)
        {
        }
        private void label7_Click(object sender, EventArgs e)
        {
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox2.Visible = true;
                label1.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
                label1.Visible = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cb_Origem.Text = "";
            cb_Destino.Text = "";
            comboBox2.Text = "";

            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Poltronacs info = new Poltronacs();
            info.ShowDialog();
        }
    }
}

