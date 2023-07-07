namespace CacPhepTinhDonGian2
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
            txt1 = new TextBox();
            txt2 = new TextBox();
            label4 = new Label();
            rdCong = new RadioButton();
            rdTru = new RadioButton();
            rdNhan = new RadioButton();
            rdChia = new RadioButton();
            label5 = new Label();
            txtKetQua = new TextBox();
            btnTinh = new Button();
            panel1 = new Panel();
            rdChiaDu = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1029, 67);
            label1.TabIndex = 0;
            label1.Text = "Cac Phep Tinh Don Gian";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 122);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 1;
            label2.Text = "So thu 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(625, 127);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 2;
            label3.Text = "So thu 2:";
            // 
            // txt1
            // 
            txt1.Location = new Point(242, 119);
            txt1.Margin = new Padding(4);
            txt1.Name = "txt1";
            txt1.Size = new Size(127, 29);
            txt1.TabIndex = 3;
            txt1.TextChanged += txt1_TextChanged;
            // 
            // txt2
            // 
            txt2.Location = new Point(726, 122);
            txt2.Margin = new Padding(4);
            txt2.Name = "txt2";
            txt2.Size = new Size(127, 29);
            txt2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(15, 19);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 21);
            label4.TabIndex = 5;
            label4.Text = "Chon phep toan: ";
            // 
            // rdCong
            // 
            rdCong.AutoSize = true;
            rdCong.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdCong.Location = new Point(41, 50);
            rdCong.Margin = new Padding(4);
            rdCong.Name = "rdCong";
            rdCong.Size = new Size(45, 34);
            rdCong.TabIndex = 6;
            rdCong.TabStop = true;
            rdCong.Text = "+";
            rdCong.UseVisualStyleBackColor = true;
            // 
            // rdTru
            // 
            rdTru.AutoSize = true;
            rdTru.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdTru.Location = new Point(157, 50);
            rdTru.Margin = new Padding(4);
            rdTru.Name = "rdTru";
            rdTru.Size = new Size(39, 34);
            rdTru.TabIndex = 7;
            rdTru.TabStop = true;
            rdTru.Text = "-";
            rdTru.UseVisualStyleBackColor = true;
            rdTru.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdNhan
            // 
            rdNhan.AutoSize = true;
            rdNhan.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdNhan.Location = new Point(285, 50);
            rdNhan.Margin = new Padding(4);
            rdNhan.Name = "rdNhan";
            rdNhan.Size = new Size(41, 34);
            rdNhan.TabIndex = 8;
            rdNhan.TabStop = true;
            rdNhan.Text = "x";
            rdNhan.UseVisualStyleBackColor = true;
            rdNhan.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rdChia
            // 
            rdChia.AutoSize = true;
            rdChia.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdChia.Location = new Point(435, 50);
            rdChia.Margin = new Padding(4);
            rdChia.Name = "rdChia";
            rdChia.Size = new Size(39, 34);
            rdChia.TabIndex = 9;
            rdChia.TabStop = true;
            rdChia.Text = "/";
            rdChia.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(209, 375);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 10;
            label5.Text = "Ket qua:";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(339, 375);
            txtKetQua.Margin = new Padding(4);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(189, 29);
            txtKetQua.TabIndex = 11;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(571, 375);
            btnTinh.Margin = new Padding(4);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(96, 32);
            btnTinh.TabIndex = 12;
            btnTinh.Text = "Tinh";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(rdChiaDu);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(rdCong);
            panel1.Controls.Add(rdTru);
            panel1.Controls.Add(rdNhan);
            panel1.Controls.Add(rdChia);
            panel1.Location = new Point(158, 210);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 116);
            panel1.TabIndex = 13;
            // 
            // rdChiaDu
            // 
            rdChiaDu.AutoSize = true;
            rdChiaDu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdChiaDu.Location = new Point(568, 50);
            rdChiaDu.Margin = new Padding(4);
            rdChiaDu.Name = "rdChiaDu";
            rdChiaDu.Size = new Size(48, 34);
            rdChiaDu.TabIndex = 10;
            rdChiaDu.TabStop = true;
            rdChiaDu.Text = "%";
            rdChiaDu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(1029, 630);
            Controls.Add(panel1);
            Controls.Add(btnTinh);
            Controls.Add(txtKetQua);
            Controls.Add(label5);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DeepPink;
            Margin = new Padding(4);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            TopMost = true;
            WindowState = FormWindowState.Minimized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt1;
        private TextBox txt2;
        private Label label4;
        private RadioButton rdCong;
        private RadioButton rdTru;
        private RadioButton rdNhan;
        private RadioButton rdChia;
        private Label label5;
        private TextBox txtKetQua;
        private Button btnTinh;
        private Panel panel1;
        private RadioButton rdChiaDu;
    }
}