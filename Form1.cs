namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double dinheiroAtual = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Extrato extrato = new Extrato();
            extrato.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Saque saque = new Saque();
            saque.ShowDialog();


        }
        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Deposito deposito = new Deposito();
            deposito.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int saldo = 0;
            MessageBox.Show("Seu saldo Atual R$ " + dinheiroAtual + ",00"); 
        }
    }
}
