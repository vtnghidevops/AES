namespace AES_GUI
{
    public partial class AES : Form
    {
        public AES()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KEYGEN keygen = new KEYGEN();
            keygen.Show();
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            ENCRYPT en = new ENCRYPT();
            en.Show();
        }

        private void btn_decrpyt_Click(object sender, EventArgs e)
        {
            DECRYPT de = new DECRYPT();
            de.Show();
        }
    }
}
