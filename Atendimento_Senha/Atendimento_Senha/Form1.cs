using Atendimento;
using Atendimento_Senha;

namespace Atendimento_Senha
{
    public partial class Form1 : Form
    {
        Senhas lista = new Senhas();
        Guiche guiche = new Guiche();
        Guiches guiches = new Guiches();
        Senha senha = new Senha();
        int id = 1;

        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Senha senha = new Senha(id);
            lista.gerar(senha);
            label5.Text = lista.fila.Count.ToString();



            // MessageBox.Show(lista.fila.Count.ToString());
            id++;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            int qtdGuiches = guiches.listaGuiches.Count;
            Guiche guicheAtendimento = new Guiche(qtdGuiches + 1);
            labelGuiche.Text = Convert.ToString(qtdGuiches + 1);
            guiches.adicionar(guicheAtendimento);
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {


            if (textBox1.Text != "" && guiches.listaGuiches.Count > 0)
            {
                int guicheChamada = int.Parse(textBox1.Text);

                if (guiches.ExisteGuiche(guicheChamada))
                {
                    if (guiche.chamar(lista.fila))
                    {
                        listBox2.Items.Add("Guichê: " + textBox1.Text + " - " + guiche.atendimentos.Last().dadosCompletos());
                        label5.Text = lista.fila.Count.ToString();
                        label4.Text = guiche.atendimentos.Last().id.ToString();
                        label8.Text = textBox1.Text;
                    }
                    else
                    {
                        MessageBox.Show("FILA VAZIA! - Não há Senhas para Chamar!");
                    }
                }
                else MessageBox.Show("Guichê não existe!");
            }
            else
            {
                MessageBox.Show("Campo Vazio ou não há guichês abertos para atendimento!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            foreach (Senha senha in lista.fila)
            {
                listBox1.Items.Add(senha.dadosParciais());
            }
        }
    }
}