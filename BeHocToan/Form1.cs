namespace BeHocToan
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        String[] arrPhepToan = { "+", "-", "x", "/" };
        int viTri;
        public Form1()
        {
            InitializeComponent();
        }



        void taoPhepToan()
        {
            int a = rand.Next(0, 9);
            int b = rand.Next(0, 9);
            viTri = rand.Next(0, 4);
            String phepToan = arrPhepToan[viTri];

            lbSo1.Text = a.ToString();
            lbSo2.Text = b.ToString();
            lbTinh.Text = phepToan;
            txtTraLoi.Text = "";
            txtTraLoi.Focus();
            lbKetQua.Text = "";

        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            taoPhepToan();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(lbSo1.Text);
                int b = int.Parse(lbSo2.Text);
                String phepToan = lbTinh.Text;
                int ketQua = 0;
                int chon = int.Parse(txtTraLoi.Text);


                switch (viTri)
                {
                    case 0:
                        ketQua = a + b;
                        break;
                    case 1:
                        ketQua = a - b;
                        break;
                    case 2:
                        ketQua = a * b;
                        break;
                    case 3:
                        if (b != 0) { ketQua = a / b; }
                        else
                        {
                            throw new DivideByZeroException("Loi chia cho 0!");
                        }
                        break;
                }
                if (chon != ketQua)
                {
                    lbKetQua.Text = String.Format("Sai roi! Ket qua la {0}", ketQua);
                }
                else
                {
                    lbKetQua.Text = "Dung roi";
                }
            }
            catch (DivideByZeroException ex)
            {
                lbKetQua.Text = ex.Message;
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtTraLoi.Text += bt.Text;
        }

        private void btnDauAm_Click(object sender, EventArgs e)
        {
            if (txtTraLoi.Text != "") return;
            txtTraLoi.Text += "-";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTraLoi.Text == "") return;
            txtTraLoi.Text = txtTraLoi.Text.Substring(0, txtTraLoi.Text.Length - 1);
        }
    }
}