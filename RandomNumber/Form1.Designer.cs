namespace RandomNumber
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
            lbSo1 = new Label();
            rd3 = new RadioButton();
            groupBox1 = new GroupBox();
            rd11 = new RadioButton();
            btnQuaySo = new Button();
            label3 = new Label();
            lbDiem = new Label();
            lbSo2 = new Label();
            lbSo3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbSo1
            // 
            lbSo1.AutoSize = true;
            lbSo1.BorderStyle = BorderStyle.Fixed3D;
            lbSo1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lbSo1.ForeColor = SystemColors.ActiveCaptionText;
            lbSo1.Location = new Point(247, 46);
            lbSo1.Margin = new Padding(4, 0, 4, 0);
            lbSo1.Name = "lbSo1";
            lbSo1.Size = new Size(108, 130);
            lbSo1.TabIndex = 0;
            lbSo1.Text = "0";
            // 
            // rd3
            // 
            rd3.Appearance = Appearance.Button;
            rd3.BackColor = SystemColors.Highlight;
            rd3.Checked = true;
            rd3.FlatStyle = FlatStyle.Flat;
            rd3.ForeColor = Color.Black;
            rd3.Location = new Point(131, 55);
            rd3.Margin = new Padding(4);
            rd3.Name = "rd3";
            rd3.Size = new Size(95, 52);
            rd3.TabIndex = 2;
            rd3.TabStop = true;
            rd3.Text = "3-10";
            rd3.TextAlign = ContentAlignment.MiddleCenter;
            rd3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rd11);
            groupBox1.Controls.Add(rd3);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(195, 238);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(600, 130);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chon:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rd11
            // 
            rd11.Appearance = Appearance.Button;
            rd11.BackColor = SystemColors.Highlight;
            rd11.FlatStyle = FlatStyle.Flat;
            rd11.ForeColor = Color.Black;
            rd11.Location = new Point(355, 55);
            rd11.Margin = new Padding(4);
            rd11.Name = "rd11";
            rd11.Size = new Size(95, 52);
            rd11.TabIndex = 3;
            rd11.Text = "11-18";
            rd11.TextAlign = ContentAlignment.MiddleCenter;
            rd11.UseVisualStyleBackColor = false;
            // 
            // btnQuaySo
            // 
            btnQuaySo.BackColor = Color.LightCoral;
            btnQuaySo.FlatStyle = FlatStyle.Popup;
            btnQuaySo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuaySo.ForeColor = Color.Crimson;
            btnQuaySo.Location = new Point(314, 424);
            btnQuaySo.Margin = new Padding(4);
            btnQuaySo.Name = "btnQuaySo";
            btnQuaySo.Size = new Size(142, 47);
            btnQuaySo.TabIndex = 5;
            btnQuaySo.Text = "Quay So";
            btnQuaySo.UseVisualStyleBackColor = false;
            btnQuaySo.Click += btnQuaySo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(526, 431);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 6;
            label3.Text = "Diem:";
            // 
            // lbDiem
            // 
            lbDiem.AutoSize = true;
            lbDiem.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lbDiem.Location = new Point(639, 402);
            lbDiem.Margin = new Padding(4, 0, 4, 0);
            lbDiem.Name = "lbDiem";
            lbDiem.Size = new Size(72, 86);
            lbDiem.TabIndex = 7;
            lbDiem.Text = "0";
            // 
            // lbSo2
            // 
            lbSo2.AutoSize = true;
            lbSo2.BorderStyle = BorderStyle.Fixed3D;
            lbSo2.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lbSo2.ForeColor = SystemColors.ActiveCaptionText;
            lbSo2.Location = new Point(440, 46);
            lbSo2.Margin = new Padding(4, 0, 4, 0);
            lbSo2.Name = "lbSo2";
            lbSo2.Size = new Size(108, 130);
            lbSo2.TabIndex = 8;
            lbSo2.Text = "0";
            // 
            // lbSo3
            // 
            lbSo3.AutoSize = true;
            lbSo3.BorderStyle = BorderStyle.Fixed3D;
            lbSo3.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lbSo3.ForeColor = SystemColors.ActiveCaptionText;
            lbSo3.Location = new Point(639, 46);
            lbSo3.Margin = new Padding(4, 0, 4, 0);
            lbSo3.Name = "lbSo3";
            lbSo3.Size = new Size(108, 130);
            lbSo3.TabIndex = 9;
            lbSo3.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1029, 630);
            Controls.Add(lbSo3);
            Controls.Add(lbSo2);
            Controls.Add(lbDiem);
            Controls.Add(label3);
            Controls.Add(btnQuaySo);
            Controls.Add(groupBox1);
            Controls.Add(lbSo1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Crimson;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSo1;
        private RadioButton rd3;
        private GroupBox groupBox1;
        private Button btnQuaySo;
        private Label label3;
        private Label lbDiem;
        private Label lbSo2;
        private Label lbSo3;
        private RadioButton rd11;
    }
}