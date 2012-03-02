namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.d2Amt = new System.Windows.Forms.TextBox();
            this.d4Amt = new System.Windows.Forms.TextBox();
            this.d6Amt = new System.Windows.Forms.TextBox();
            this.d8Amt = new System.Windows.Forms.TextBox();
            this.d10Amt = new System.Windows.Forms.TextBox();
            this.d12Amt = new System.Windows.Forms.TextBox();
            this.d20Amt = new System.Windows.Forms.TextBox();
            this.rollBut = new System.Windows.Forms.Button();
            this.resetBut = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.d2Mod = new System.Windows.Forms.TextBox();
            this.d4Mod = new System.Windows.Forms.TextBox();
            this.d6Mod = new System.Windows.Forms.TextBox();
            this.d8Mod = new System.Windows.Forms.TextBox();
            this.d10Mod = new System.Windows.Forms.TextBox();
            this.d12Mod = new System.Windows.Forms.TextBox();
            this.d20Mod = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "d2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "d4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "d6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "d8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "d10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "d12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "d20";
            // 
            // d2Amt
            // 
            this.d2Amt.Location = new System.Drawing.Point(44, 19);
            this.d2Amt.Name = "d2Amt";
            this.d2Amt.Size = new System.Drawing.Size(45, 20);
            this.d2Amt.TabIndex = 7;
            this.d2Amt.Text = "0";
            this.d2Amt.TextChanged += new System.EventHandler(this.d2Amt_TextChanged);
            // 
            // d4Amt
            // 
            this.d4Amt.Location = new System.Drawing.Point(44, 47);
            this.d4Amt.Name = "d4Amt";
            this.d4Amt.Size = new System.Drawing.Size(45, 20);
            this.d4Amt.TabIndex = 8;
            this.d4Amt.Text = "0";
            this.d4Amt.TextChanged += new System.EventHandler(this.d4Amt_TextChanged);
            // 
            // d6Amt
            // 
            this.d6Amt.Location = new System.Drawing.Point(44, 75);
            this.d6Amt.Name = "d6Amt";
            this.d6Amt.Size = new System.Drawing.Size(45, 20);
            this.d6Amt.TabIndex = 9;
            this.d6Amt.Text = "0";
            this.d6Amt.TextChanged += new System.EventHandler(this.d6Amt_TextChanged);
            // 
            // d8Amt
            // 
            this.d8Amt.Location = new System.Drawing.Point(44, 105);
            this.d8Amt.Name = "d8Amt";
            this.d8Amt.Size = new System.Drawing.Size(45, 20);
            this.d8Amt.TabIndex = 10;
            this.d8Amt.Text = "0";
            this.d8Amt.TextChanged += new System.EventHandler(this.d8Amt_TextChanged);
            // 
            // d10Amt
            // 
            this.d10Amt.Location = new System.Drawing.Point(44, 131);
            this.d10Amt.Name = "d10Amt";
            this.d10Amt.Size = new System.Drawing.Size(45, 20);
            this.d10Amt.TabIndex = 11;
            this.d10Amt.Text = "0";
            this.d10Amt.TextChanged += new System.EventHandler(this.d10Amt_TextChanged);
            // 
            // d12Amt
            // 
            this.d12Amt.Location = new System.Drawing.Point(44, 157);
            this.d12Amt.Name = "d12Amt";
            this.d12Amt.Size = new System.Drawing.Size(45, 20);
            this.d12Amt.TabIndex = 12;
            this.d12Amt.Text = "0";
            this.d12Amt.TextChanged += new System.EventHandler(this.d12Amt_TextChanged);
            // 
            // d20Amt
            // 
            this.d20Amt.Location = new System.Drawing.Point(44, 185);
            this.d20Amt.Name = "d20Amt";
            this.d20Amt.Size = new System.Drawing.Size(45, 20);
            this.d20Amt.TabIndex = 13;
            this.d20Amt.Text = "0";
            this.d20Amt.TextChanged += new System.EventHandler(this.d20Amt_TextChanged);
            // 
            // rollBut
            // 
            this.rollBut.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollBut.Location = new System.Drawing.Point(17, 218);
            this.rollBut.Name = "rollBut";
            this.rollBut.Size = new System.Drawing.Size(181, 59);
            this.rollBut.TabIndex = 15;
            this.rollBut.Text = "Roll";
            this.rollBut.UseVisualStyleBackColor = true;
            this.rollBut.Click += new System.EventHandler(this.rollBut_Click);
            // 
            // resetBut
            // 
            this.resetBut.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBut.Location = new System.Drawing.Point(16, 283);
            this.resetBut.Name = "resetBut";
            this.resetBut.Size = new System.Drawing.Size(182, 44);
            this.resetBut.TabIndex = 16;
            this.resetBut.Text = "Reset";
            this.resetBut.UseVisualStyleBackColor = true;
            this.resetBut.Click += new System.EventHandler(this.resetBut_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "+";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "+";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(95, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "+";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(95, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "+";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(95, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 19);
            this.label12.TabIndex = 21;
            this.label12.Text = "+";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(95, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 19);
            this.label13.TabIndex = 22;
            this.label13.Text = "+";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(95, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 19);
            this.label14.TabIndex = 23;
            this.label14.Text = "+";
            // 
            // d2Mod
            // 
            this.d2Mod.Location = new System.Drawing.Point(119, 19);
            this.d2Mod.Name = "d2Mod";
            this.d2Mod.Size = new System.Drawing.Size(45, 20);
            this.d2Mod.TabIndex = 24;
            this.d2Mod.Text = "0";
            this.d2Mod.TextChanged += new System.EventHandler(this.d2Mod_TextChanged);
            // 
            // d4Mod
            // 
            this.d4Mod.Location = new System.Drawing.Point(119, 49);
            this.d4Mod.Name = "d4Mod";
            this.d4Mod.Size = new System.Drawing.Size(45, 20);
            this.d4Mod.TabIndex = 25;
            this.d4Mod.Text = "0";
            this.d4Mod.TextChanged += new System.EventHandler(this.d4Mod_TextChanged);
            // 
            // d6Mod
            // 
            this.d6Mod.Location = new System.Drawing.Point(119, 77);
            this.d6Mod.Name = "d6Mod";
            this.d6Mod.Size = new System.Drawing.Size(45, 20);
            this.d6Mod.TabIndex = 26;
            this.d6Mod.Text = "0";
            this.d6Mod.TextChanged += new System.EventHandler(this.d6Mod_TextChanged);
            // 
            // d8Mod
            // 
            this.d8Mod.Location = new System.Drawing.Point(119, 105);
            this.d8Mod.Name = "d8Mod";
            this.d8Mod.Size = new System.Drawing.Size(45, 20);
            this.d8Mod.TabIndex = 27;
            this.d8Mod.Text = "0";
            this.d8Mod.TextChanged += new System.EventHandler(this.d8Mod_TextChanged);
            // 
            // d10Mod
            // 
            this.d10Mod.Location = new System.Drawing.Point(119, 131);
            this.d10Mod.Name = "d10Mod";
            this.d10Mod.Size = new System.Drawing.Size(45, 20);
            this.d10Mod.TabIndex = 28;
            this.d10Mod.Text = "0";
            this.d10Mod.TextChanged += new System.EventHandler(this.d10Mod_TextChanged);
            // 
            // d12Mod
            // 
            this.d12Mod.Location = new System.Drawing.Point(119, 157);
            this.d12Mod.Name = "d12Mod";
            this.d12Mod.Size = new System.Drawing.Size(45, 20);
            this.d12Mod.TabIndex = 29;
            this.d12Mod.Text = "0";
            this.d12Mod.TextChanged += new System.EventHandler(this.d12Mod_TextChanged);
            // 
            // d20Mod
            // 
            this.d20Mod.Location = new System.Drawing.Point(119, 186);
            this.d20Mod.Name = "d20Mod";
            this.d20Mod.Size = new System.Drawing.Size(45, 20);
            this.d20Mod.TabIndex = 30;
            this.d20Mod.Text = "0";
            this.d20Mod.TextChanged += new System.EventHandler(this.d20Mod_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(42, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 9);
            this.label15.TabIndex = 31;
            this.label15.Text = "Dice amount";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(117, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 9);
            this.label16.TabIndex = 32;
            this.label16.Text = "Dice modifier";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(219, 19);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(193, 330);
            this.outputBox.TabIndex = 33;
            this.outputBox.TextChanged += new System.EventHandler(this.outputBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 366);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.d20Mod);
            this.Controls.Add(this.d12Mod);
            this.Controls.Add(this.d10Mod);
            this.Controls.Add(this.d8Mod);
            this.Controls.Add(this.d6Mod);
            this.Controls.Add(this.d4Mod);
            this.Controls.Add(this.d2Mod);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.resetBut);
            this.Controls.Add(this.rollBut);
            this.Controls.Add(this.d20Amt);
            this.Controls.Add(this.d12Amt);
            this.Controls.Add(this.d10Amt);
            this.Controls.Add(this.d8Amt);
            this.Controls.Add(this.d6Amt);
            this.Controls.Add(this.d4Amt);
            this.Controls.Add(this.d2Amt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox d2Amt;
        private System.Windows.Forms.TextBox d4Amt;
        private System.Windows.Forms.TextBox d6Amt;
        private System.Windows.Forms.TextBox d8Amt;
        private System.Windows.Forms.TextBox d10Amt;
        private System.Windows.Forms.TextBox d12Amt;
        private System.Windows.Forms.TextBox d20Amt;
        private System.Windows.Forms.Button rollBut;
        private System.Windows.Forms.Button resetBut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox d2Mod;
        private System.Windows.Forms.TextBox d4Mod;
        private System.Windows.Forms.TextBox d6Mod;
        private System.Windows.Forms.TextBox d8Mod;
        private System.Windows.Forms.TextBox d10Mod;
        private System.Windows.Forms.TextBox d12Mod;
        private System.Windows.Forms.TextBox d20Mod;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox outputBox;

    }
}

