namespace Bai_thi_c_sharp_2
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
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tentacgia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Theloai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsotientra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtchiso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtngaynapdat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmacongto = new System.Windows.Forms.TextBox();
            this.lb5 = new System.Windows.Forms.Label();
            this.txtngaysinh = new System.Windows.Forms.TextBox();
            this.lb4 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.lbb3 = new System.Windows.Forms.Label();
            this.txtsodienthoai = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "So tien tra";
            this.columnHeader6.Width = 84;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Chi so tieu thu";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngay napd at";
            this.columnHeader4.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ma cong to";
            this.columnHeader3.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "dia chi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 25);
            this.button2.TabIndex = 27;
            this.button2.Text = "Xoa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 25);
            this.button1.TabIndex = 26;
            this.button1.Text = "Them";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "So dien thoai";
            this.columnHeader1.Width = 90;
            // 
            // tentacgia
            // 
            this.tentacgia.Text = "Ngay sinh";
            this.tentacgia.Width = 82;
            // 
            // Theloai
            // 
            this.Theloai.Text = "Ho ten";
            this.Theloai.Width = 90;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Theloai,
            this.tentacgia,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(359, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(680, 378);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsotientra);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtchiso);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtngaynapdat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtmacongto);
            this.groupBox1.Controls.Add(this.lb5);
            this.groupBox1.Controls.Add(this.txtngaysinh);
            this.groupBox1.Controls.Add(this.lb4);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.lbb3);
            this.groupBox1.Controls.Add(this.txtsodienthoai);
            this.groupBox1.Controls.Add(this.lab);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 378);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // txtsotientra
            // 
            this.txtsotientra.Enabled = false;
            this.txtsotientra.Location = new System.Drawing.Point(76, 271);
            this.txtsotientra.Name = "txtsotientra";
            this.txtsotientra.Size = new System.Drawing.Size(168, 20);
            this.txtsotientra.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "So tien tra";
            // 
            // txtchiso
            // 
            this.txtchiso.Location = new System.Drawing.Point(76, 234);
            this.txtchiso.Name = "txtchiso";
            this.txtchiso.Size = new System.Drawing.Size(168, 20);
            this.txtchiso.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Chi so tieu thu";
            // 
            // txtngaynapdat
            // 
            this.txtngaynapdat.Location = new System.Drawing.Point(76, 197);
            this.txtngaynapdat.Name = "txtngaynapdat";
            this.txtngaynapdat.Size = new System.Drawing.Size(168, 20);
            this.txtngaynapdat.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngay nap dat";
            // 
            // txtmacongto
            // 
            this.txtmacongto.Location = new System.Drawing.Point(76, 160);
            this.txtmacongto.Name = "txtmacongto";
            this.txtmacongto.Size = new System.Drawing.Size(168, 20);
            this.txtmacongto.TabIndex = 9;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(7, 166);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(61, 13);
            this.lb5.TabIndex = 8;
            this.lb5.Text = "Ma cong to";
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Location = new System.Drawing.Point(76, 49);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(168, 20);
            this.txtngaysinh.TabIndex = 7;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(11, 50);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(54, 13);
            this.lb4.TabIndex = 6;
            this.lb4.Text = "Ngay sinh";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(76, 123);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(168, 20);
            this.txtdiachi.TabIndex = 5;
            // 
            // lbb3
            // 
            this.lbb3.AutoSize = true;
            this.lbb3.Location = new System.Drawing.Point(7, 132);
            this.lbb3.Name = "lbb3";
            this.lbb3.Size = new System.Drawing.Size(40, 13);
            this.lbb3.TabIndex = 4;
            this.lbb3.Text = "Dia chi";
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.Location = new System.Drawing.Point(76, 86);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.Size = new System.Drawing.Size(168, 20);
            this.txtsodienthoai.TabIndex = 3;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(7, 89);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(69, 13);
            this.lab.TabIndex = 2;
            this.lab.Text = "So dien thoai";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(76, 12);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(168, 20);
            this.txthoten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ho ten";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 399);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader tentacgia;
        private System.Windows.Forms.ColumnHeader Theloai;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsotientra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtchiso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtngaynapdat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmacongto;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.TextBox txtngaysinh;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label lbb3;
        private System.Windows.Forms.TextBox txtsodienthoai;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label1;
    }
}

