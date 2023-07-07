namespace CacPhepTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            textBoxKetQua.Text = String.Format("{0}", a + b);
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            textBoxKetQua.Text = String.Format("{0}", a - b);
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            textBoxKetQua.Text = String.Format("{0}", a * b);
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            if (b != 0)
            {
                textBoxKetQua.Text = String.Format("{0:0.00}", (double)a / b);
            }
            else
            {
                textBoxKetQua.Text = "So chia phai khac 0!";
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}