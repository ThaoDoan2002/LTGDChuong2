namespace CacPhepTinhDonGian2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txt1.Text);
                int b = int.Parse(txt2.Text);
                if (rdCong.Checked)
                {
                    txtKetQua.Text = String.Format("{0}", a + b);
                }
                else if (rdTru.Checked)
                {
                    txtKetQua.Text = String.Format("{0}", a - b);
                }
                else if (rdNhan.Checked)
                {
                    txtKetQua.Text = String.Format("{0}", a * b);
                }
                else if (rdChia.Checked)
                {
                    if (b == 0)
                    {
                        throw new DivideByZeroException("So chia phai khac khong!");
                    }
                    txtKetQua.Text = String.Format("{0:0.00}", (double)a / b);
                }
                else
                {
                    txtKetQua.Text = String.Format("{0}", a % b);
                }
            }
            catch (FormatException)
            {
                txtKetQua.Text = String.Format("Ban phai nhap 2 so!");
            }
            catch (DivideByZeroException ex)
            {
                txtKetQua.Text = ex.Message;
            }
            catch (OverflowException)
            {
                txtKetQua.Text = String.Format("Khong the xu ly so qua lon!");
            }

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}