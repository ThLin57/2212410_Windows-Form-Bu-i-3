namespace _2212410_Bai1
{
    partial class Form1
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
            this.lbNhapTen = new System.Windows.Forms.Label();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.txtSaoChep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btXuLy = new System.Windows.Forms.Button();
            this.btSaoChep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNhapTen
            // 
            this.lbNhapTen.AutoSize = true;
            this.lbNhapTen.Location = new System.Drawing.Point(151, 68);
            this.lbNhapTen.Name = "lbNhapTen";
            this.lbNhapTen.Size = new System.Drawing.Size(118, 16);
            this.lbNhapTen.TabIndex = 0;
            this.lbNhapTen.Text = "Nhập tên của bạn :";
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Location = new System.Drawing.Point(301, 68);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(210, 22);
            this.txtNhapTen.TabIndex = 1;
            this.txtNhapTen.TextChanged += new System.EventHandler(this.txtNhapTen_TextChanged);
            // 
            // txtSaoChep
            // 
            this.txtSaoChep.Location = new System.Drawing.Point(301, 225);
            this.txtSaoChep.Name = "txtSaoChep";
            this.txtSaoChep.Size = new System.Drawing.Size(210, 22);
            this.txtSaoChep.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bạn đã nhập :";
            // 
            // btXuLy
            // 
            this.btXuLy.Location = new System.Drawing.Point(279, 152);
            this.btXuLy.Name = "btXuLy";
            this.btXuLy.Size = new System.Drawing.Size(75, 23);
            this.btXuLy.TabIndex = 4;
            this.btXuLy.Text = "Xử Lý";
            this.btXuLy.UseVisualStyleBackColor = true;
            this.btXuLy.Click += new System.EventHandler(this.btXuLy_Click);
            // 
            // btSaoChep
            // 
            this.btSaoChep.Location = new System.Drawing.Point(411, 152);
            this.btSaoChep.Name = "btSaoChep";
            this.btSaoChep.Size = new System.Drawing.Size(75, 23);
            this.btSaoChep.TabIndex = 5;
            this.btSaoChep.Text = "Sao Chép";
            this.btSaoChep.UseVisualStyleBackColor = true;
            this.btSaoChep.Click += new System.EventHandler(this.btSaoChep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSaoChep);
            this.Controls.Add(this.btXuLy);
            this.Controls.Add(this.txtSaoChep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhapTen);
            this.Controls.Add(this.lbNhapTen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhapTen;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.TextBox txtSaoChep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXuLy;
        private System.Windows.Forms.Button btSaoChep;
    }
}

