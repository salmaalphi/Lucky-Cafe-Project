namespace Lucky_Cafe_Order_Project
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
            this.label4 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MacamilkaMgc = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.shaax = new System.Windows.Forms.RadioButton();
            this.btnJuice = new System.Windows.Forms.RadioButton();
            this.BtnCoffee = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMeqa = new System.Windows.Forms.TextBox();
            this.Ardeyda = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsaveLoad = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Totalka = new System.Windows.Forms.Label();
            this.farintaNasibka = new System.Windows.Forms.Label();
            this.DabacadaOrder = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(23, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lucky Cafe Order";
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(28, 549);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(200, 55);
            this.btncalculate.TabIndex = 12;
            this.btncalculate.Text = "Calculate Order";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Customer Name:";
            // 
            // MacamilkaMgc
            // 
            this.MacamilkaMgc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MacamilkaMgc.Location = new System.Drawing.Point(15, 110);
            this.MacamilkaMgc.Multiline = true;
            this.MacamilkaMgc.Name = "MacamilkaMgc";
            this.MacamilkaMgc.Size = new System.Drawing.Size(385, 38);
            this.MacamilkaMgc.TabIndex = 4;
            this.MacamilkaMgc.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 187);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 150);
            this.textBox1.TabIndex = 10;
            // 
            // shaax
            // 
            this.shaax.AutoSize = true;
            this.shaax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shaax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shaax.Location = new System.Drawing.Point(27, 210);
            this.shaax.Name = "shaax";
            this.shaax.Size = new System.Drawing.Size(100, 26);
            this.shaax.TabIndex = 11;
            this.shaax.TabStop = true;
            this.shaax.Text = "Tea ($1)";
            this.shaax.UseVisualStyleBackColor = false;
            // 
            // btnJuice
            // 
            this.btnJuice.AutoSize = true;
            this.btnJuice.BackColor = System.Drawing.Color.White;
            this.btnJuice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuice.Location = new System.Drawing.Point(27, 295);
            this.btnJuice.Name = "btnJuice";
            this.btnJuice.Size = new System.Drawing.Size(110, 26);
            this.btnJuice.TabIndex = 12;
            this.btnJuice.TabStop = true;
            this.btnJuice.Text = "Juice ($3)";
            this.btnJuice.UseVisualStyleBackColor = false;
            // 
            // BtnCoffee
            // 
            this.BtnCoffee.AutoSize = true;
            this.BtnCoffee.BackColor = System.Drawing.Color.White;
            this.BtnCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCoffee.Location = new System.Drawing.Point(27, 251);
            this.BtnCoffee.Name = "BtnCoffee";
            this.BtnCoffee.Size = new System.Drawing.Size(121, 26);
            this.BtnCoffee.TabIndex = 13;
            this.BtnCoffee.TabStop = true;
            this.BtnCoffee.Text = "Coffee ($2)";
            this.BtnCoffee.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(37, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Drink Type";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantity:";
            // 
            // txtMeqa
            // 
            this.txtMeqa.Location = new System.Drawing.Point(102, 357);
            this.txtMeqa.Multiline = true;
            this.txtMeqa.Name = "txtMeqa";
            this.txtMeqa.Size = new System.Drawing.Size(72, 48);
            this.txtMeqa.TabIndex = 16;
            // 
            // Ardeyda
            // 
            this.Ardeyda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Ardeyda.Location = new System.Drawing.Point(198, 359);
            this.Ardeyda.Name = "Ardeyda";
            this.Ardeyda.Size = new System.Drawing.Size(277, 48);
            this.Ardeyda.TabIndex = 17;
            this.Ardeyda.Text = "Student Member (10% Off)";
            this.Ardeyda.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(3, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 40);
            this.label6.TabIndex = 17;
            this.label6.Text = "Customer Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Ardeyda);
            this.panel1.Controls.Add(this.txtMeqa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtnCoffee);
            this.panel1.Controls.Add(this.btnJuice);
            this.panel1.Controls.Add(this.shaax);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.MacamilkaMgc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 462);
            this.panel1.TabIndex = 14;
            // 
            // btnsaveLoad
            // 
            this.btnsaveLoad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnsaveLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveLoad.Location = new System.Drawing.Point(330, 550);
            this.btnsaveLoad.Name = "btnsaveLoad";
            this.btnsaveLoad.Size = new System.Drawing.Size(200, 55);
            this.btnsaveLoad.TabIndex = 17;
            this.btnsaveLoad.Text = "Save To File";
            this.btnsaveLoad.UseVisualStyleBackColor = false;
            this.btnsaveLoad.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFile.Location = new System.Drawing.Point(613, 550);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(200, 55);
            this.btnSaveFile.TabIndex = 18;
            this.btnSaveFile.Text = "Load from file";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.Click += new System.EventHandler(this.btnsaveLoad_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(895, 550);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(200, 55);
            this.btnclear.TabIndex = 19;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 643);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1116, 90);
            this.label7.TabIndex = 20;
            // 
            // Totalka
            // 
            this.Totalka.BackColor = System.Drawing.Color.White;
            this.Totalka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totalka.ForeColor = System.Drawing.Color.Blue;
            this.Totalka.Location = new System.Drawing.Point(24, 656);
            this.Totalka.Name = "Totalka";
            this.Totalka.Size = new System.Drawing.Size(229, 32);
            this.Totalka.TabIndex = 21;
            this.Totalka.Text = "Total Price:";
            // 
            // farintaNasibka
            // 
            this.farintaNasibka.BackColor = System.Drawing.Color.White;
            this.farintaNasibka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.farintaNasibka.ForeColor = System.Drawing.Color.Goldenrod;
            this.farintaNasibka.Location = new System.Drawing.Point(24, 688);
            this.farintaNasibka.Name = "farintaNasibka";
            this.farintaNasibka.Size = new System.Drawing.Size(349, 32);
            this.farintaNasibka.TabIndex = 22;
            this.farintaNasibka.Text = "Lucky Message : You got a Free Cookie";
            // 
            // DabacadaOrder
            // 
            this.DabacadaOrder.FormattingEnabled = true;
            this.DabacadaOrder.ItemHeight = 16;
            this.DabacadaOrder.Location = new System.Drawing.Point(613, 63);
            this.DabacadaOrder.Name = "DabacadaOrder";
            this.DabacadaOrder.Size = new System.Drawing.Size(417, 468);
            this.DabacadaOrder.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(613, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(417, 28);
            this.label8.TabIndex = 24;
            this.label8.Text = "Order List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 752);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DabacadaOrder);
            this.Controls.Add(this.farintaNasibka);
            this.Controls.Add(this.Totalka);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnsaveLoad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MacamilkaMgc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton shaax;
        private System.Windows.Forms.RadioButton btnJuice;
        private System.Windows.Forms.RadioButton BtnCoffee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMeqa;
        private System.Windows.Forms.CheckBox Ardeyda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsaveLoad;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Totalka;
        private System.Windows.Forms.Label farintaNasibka;
        private System.Windows.Forms.ListBox DabacadaOrder;
        private System.Windows.Forms.Label label8;
    }
}

