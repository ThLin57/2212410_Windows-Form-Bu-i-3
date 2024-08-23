namespace _2212410_BT2
{
    partial class frmBai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.a = new System.Windows.Forms.Button();
            this.lsbDanhSachHH = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lsbDSHangBo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.a);
            this.panel1.Controls.Add(this.lsbDanhSachHH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(55, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 363);
            this.panel1.TabIndex = 0;
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(216, 142);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(109, 38);
            this.a.TabIndex = 2;
            this.a.Text = "Chọn hàng >>";
            this.a.UseVisualStyleBackColor = true;
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // lsbDanhSachHH
            // 
            this.lsbDanhSachHH.FormattingEnabled = true;
            this.lsbDanhSachHH.ItemHeight = 16;
            this.lsbDanhSachHH.Items.AddRange(new object[] {
            "Chuột",
            "Bàn Phím",
            "Máy In",
            "USB Kingmax"});
            this.lsbDanhSachHH.Location = new System.Drawing.Point(28, 64);
            this.lsbDanhSachHH.Name = "lsbDanhSachHH";
            this.lsbDanhSachHH.Size = new System.Drawing.Size(166, 180);
            this.lsbDanhSachHH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hàng hóa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbSoTien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lsbDSHangBo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(461, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 363);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đồng";
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Location = new System.Drawing.Point(180, 327);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(14, 16);
            this.lbSoTien.TabIndex = 5;
            this.lbSoTien.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng tiền cần thanh toán";
            // 
            // button2
            // 
            this.button2.Image = global::_2212410_BT2.Properties.Resources.expense;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(210, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tính tiền";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "<< Bỏ hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsbDSHangBo
            // 
            this.lsbDSHangBo.FormattingEnabled = true;
            this.lsbDSHangBo.ItemHeight = 16;
            this.lsbDSHangBo.Location = new System.Drawing.Point(166, 64);
            this.lsbDSHangBo.Name = "lsbDSHangBo";
            this.lsbDSHangBo.Size = new System.Drawing.Size(166, 180);
            this.lsbDSHangBo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Các mặt hàng mà khách đã mua";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lsbDSHangBo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.ListBox lsbDanhSachHH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}