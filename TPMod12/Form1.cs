namespace TPMod12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int input))
            {
                label1.Text = CariTandaBilangan(input);
            }
            else {
                MessageBox.Show("Input tidak valid!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string CariTandaBilangan
    }
}
