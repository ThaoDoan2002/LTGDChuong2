namespace RandomNumber
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int diem = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnQuaySo_Click(object sender, EventArgs e)
        {
            int so1 = rand.Next(1, 7);
            int so2 = rand.Next(1, 7);
            int so3 = rand.Next(1, 7);

            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbSo3.Text = so3.ToString();

            if (rd3.Checked)
            {
                if ((so1 + so2 + so3 >= 3) && (so1 + so2 + so3 <= 10))
                {
                    diem += 10;
                }
                else
                {
                    diem -= 10;
                }
            }
            else if (rd11.Checked)
            {
                if ((so1 + so2 + so3 >= 11) && (so1 + so2 + so3 <= 18))
                {
                    diem += 10;
                }
                else
                {
                    diem -= 10;
                }
            }

            lbDiem.Text = diem.ToString();
        }
    }
    }
