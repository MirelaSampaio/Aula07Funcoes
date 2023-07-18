namespace Aula07Funcoes
{
    public partial class Form1 : Form
    {
        // Variáveis globais

        public Form1()
        {
            InitializeComponent();
        }

        // Minhas funções

        //A função serve para reutilizar o mesmo código varias vezes em diferentes lugares, assim
        // como uma variável.


        void mostraNome()
        {
            string nome = textBox1.Text;
            MessageBox.Show($"Olá {nome}!");
        } 

        double converteDinheiro( Label dimdim )
        {
            double dinheiro = double.Parse( dimdim.Text.Replace("R$", "") );
            return dinheiro;
        }

        void mostraMensagem()
        {

            MessageBox.Show("Olá, seja bem-vindo!!");
            MessageBox.Show("Faça login para continuar.");
            
            

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostraMensagem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostraNome();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(textBox2.Text);
            double dinheiro = converteDinheiro(label1);
            double soma = valor + dinheiro;
            label1.Text = $"R${soma}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(textBox3.Text);
            double dinheiro = converteDinheiro(label2);
            double soma = valor + dinheiro;
            label2.Text = $"R$ {soma}";
        }
    }
}