namespace CacPhepTinh
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            label4 = new Label();
            textBoxKetQua = new TextBox();
            btnDong = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.PaleVioletRed;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1108, 45);
            label1.TabIndex = 0;
            label1.Text = "CAC PHEP TINH DON GIAN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 124);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "So thu 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(782, 124);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "So thu 2:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(251, 116);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 29);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(900, 119);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 29);
            textBox2.TabIndex = 4;
            // 
            // btnCong
            // 
            btnCong.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCong.Location = new Point(306, 207);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(44, 35);
            btnCong.TabIndex = 5;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTru.Location = new Point(429, 207);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(44, 35);
            btnTru.TabIndex = 6;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhan.Location = new Point(561, 207);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(44, 35);
            btnNhan.TabIndex = 7;
            btnNhan.Text = "x";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnChia.Location = new Point(683, 207);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(44, 35);
            btnChia.TabIndex = 8;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 288);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 9;
            label4.Text = "Ket qua:";
            label4.Click += label4_Click;
            // 
            // textBoxKetQua
            // 
            textBoxKetQua.Location = new Point(388, 288);
            textBoxKetQua.Name = "textBoxKetQua";
            textBoxKetQua.Size = new Size(210, 29);
            textBoxKetQua.TabIndex = 10;
            // 
            // btnDong
            // 
            btnDong.AutoSize = true;
            btnDong.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDong.Location = new Point(651, 284);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(61, 35);
            btnDong.TabIndex = 11;
            btnDong.Text = "Dong";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1143, 600);
            Controls.Add(btnDong);
            Controls.Add(textBoxKetQua);
            Controls.Add(label4);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Label label4;
        private TextBox textBoxKetQua;
        private Button btnDong;
    }
}