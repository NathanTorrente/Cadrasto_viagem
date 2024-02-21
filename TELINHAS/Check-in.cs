using Cadastro_Check_in.CLASSES;
using Newtonsoft.Json;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cadastro_Check_in
{
    public partial class Form1 : Form
    {
        List<Pessoa> Cadastro = new List<Pessoa>();
        public Form1()
        {
            InitializeComponent();
            try
            {
                Cadastro = Pessoa.JsonDesserializarLista(@"C:\Users\Familia Torrente ^-^\Desktop\arquivo.json");

            }
            catch (Exception ex)
            {

            }
            label1.Text = "";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa pessoa = new Pessoa();

                ValidarCpf validarCpf = new ValidarCpf();
                bool cpf = validarCpf.ValidaCPF(masktx_Cpf.Text);
                pessoa.Telefone = maskedTextBox1.Text;
                pessoa.Nome = tx_Nome.Text;
                int idade = pessoa.CalculoIdade(Convert.ToInt32(dateTimePicker1.Value.Year), Convert.ToInt32(dateTimePicker1.Value.Month), Convert.ToInt32(dateTimePicker1.Value.Day));
                pessoa.Idade = idade;

                if (cpf == false)
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "CPF é inválido";
                    masktx_Cpf.Clear();

                }
                else
                {
                    label1.Visible = false;
                    pessoa.CPF = masktx_Cpf.Text;
                    Cadastro.Add(pessoa);
                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = Cadastro;
                    masktx_Cpf.Focus();


                }

                if (cpf != false)
                {
                    var pessoas = new Pessoa();
                    if (pessoas.JsonSerializarLista(Cadastro, @"C:\Users\Familia Torrente ^-^\Desktop\arquivo.json"))
                    {
                        MessageBox.Show("Salvo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erros na sintax, confira se preencheu certo. ");
            }
            
        }
        private void lb_Bagagem_Click(object sender, EventArgs e)
        {
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                InfoVoo info = new InfoVoo();
                info.ShowDialog();
            }
            else
            {
                MessageBox.Show("A tabela está vazia. Preencha-a antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void lb_DataNascimento_Click(object sender, EventArgs e)
        {
        }
        private void br_Cancelar_Click(object sender, EventArgs e)
        {
            try                     //  verifica se o resgistro é maior que zero presente no DataGridView,
                                    // o Rows DataGridView representa a coleção de linhas na
                                    // Count retorna o número total de elementos da coleção.
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    tx_Nome.Clear();
                    masktx_Cpf.Clear();
                    maskedTextBox1.Clear();

                    int index = dataGridView1.CurrentCell.RowIndex;
                    Cadastro.RemoveAt(index);

                    dataGridView1.DataSource = null;    //zerar ou seja deixar sem nenhum elemento
                    dataGridView1.Refresh();            //atualizar toda tabela
                    dataGridView1.DataSource = Cadastro;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos antes de cancelar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Cadastro = Pessoa.JsonDesserializarLista(@"C:\Users\Familia Torrente ^-^\Desktop\arquivo.json");
            dataGridView1.DataSource = Cadastro;
            try
            {
                var strJson = "";
                using (StreamReader sr = new StreamReader(@"C:\Users\Familia Torrente ^-^\Desktop\arquivo.json"))
                {
                    strJson = sr.ReadToEnd();
                }
                var pessoa = Pessoa.JsonDesserializarLista(strJson);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! Verifique se Preencheu Tudo!");
            }
        }
        private void lb_Nome_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click_1(object sender, EventArgs e)
        {
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}