namespace llstview
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
            this.txtht = new System.Windows.Forms.TextBox();
            this.txtns = new System.Windows.Forms.TextBox();
            this.txtsotientra = new System.Windows.Forms.TextBox();
            this.txtchisott = new System.Windows.Forms.TextBox();
            this.txtmct = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtht
            // 
            this.txtht.Location = new System.Drawing.Point(231, 37);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(100, 20);
            this.txtht.TabIndex = 0;
            // 
            // txtns
            // 
            this.txtns.Location = new System.Drawing.Point(231, 88);
            this.txtns.Name = "txtns";
            this.txtns.Size = new System.Drawing.Size(100, 20);
            this.txtns.TabIndex = 1;
            // 
            // txtsotientra
            // 
            this.txtsotientra.Location = new System.Drawing.Point(231, 324);
            this.txtsotientra.Name = "txtsotientra";
            this.txtsotientra.Size = new System.Drawing.Size(100, 20);
            this.txtsotientra.TabIndex = 3;
            // 
            // txtchisott
            // 
            this.txtchisott.Location = new System.Drawing.Point(231, 264);
            this.txtchisott.Name = "txtchisott";
            this.txtchisott.Size = new System.Drawing.Size(100, 20);
            this.txtchisott.TabIndex = 4;
            // 
            // txtmct
            // 
            this.txtmct.Location = new System.Drawing.Point(231, 204);
            this.txtmct.Name = "txtmct";
            this.txtmct.Size = new System.Drawing.Size(100, 20);
            this.txtmct.TabIndex = 5;
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(231, 148);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(100, 20);
            this.txtdc.TabIndex = 6;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ht";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ns";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "dc";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "mct";
            this.columnHeader4.Width = 99;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "chisott";
            this.columnHeader5.Width = 167;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "sotientra";
            this.columnHeader6.Width = 239;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Location = new System.Drawing.Point(364, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(539, 476);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 490);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.txtmct);
            this.Controls.Add(this.txtchisott);
            this.Controls.Add(this.txtsotientra);
            this.Controls.Add(this.txtns);
            this.Controls.Add(this.txtht);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.TextBox txtns;
        private System.Windows.Forms.TextBox txtsotientra;
        private System.Windows.Forms.TextBox txtchisott;
        private System.Windows.Forms.TextBox txtmct;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

