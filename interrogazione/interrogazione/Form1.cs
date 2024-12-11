namespace interrogazione
{
    public partial class Form1 : Form
    {
        ContoCorrente conto;
        public Form1()
        {
            InitializeComponent();
            conto = new ContoCorrente("Salvi", "Bancomat", 100);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conto.Prelievo(Convert.ToDouble(casellaCifra.Text));
            casellaSaldo.Text = $"{conto.Saldo}";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            conto.Deposito(Convert.ToDouble(casellaCifra.Text));
            casellaSaldo.Text = $"{conto.Saldo}";

        }

        private void casellaSaldo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
