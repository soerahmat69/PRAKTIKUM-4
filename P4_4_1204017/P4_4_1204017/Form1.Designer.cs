namespace P4_4_1204017
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbChar = new System.Windows.Forms.TextBox();
            this.tbregex = new System.Windows.Forms.TextBox();
            this.tbcom1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbcom2 = new System.Windows.Forms.TextBox();
            this.tbleng = new System.Windows.Forms.TextBox();
            this.tbupper = new System.Windows.Forms.TextBox();
            this.tblower = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.epbenar = new System.Windows.Forms.ErrorProvider(this.components);
            this.epwarn = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epbenar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epwarn)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(152, 26);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(100, 20);
            this.tbNum.TabIndex = 0;
            this.tbNum.Leave += new System.EventHandler(this.tbNum_Leave);
            // 
            // tbChar
            // 
            this.tbChar.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.tbChar.Location = new System.Drawing.Point(152, 52);
            this.tbChar.Name = "tbChar";
            this.tbChar.Size = new System.Drawing.Size(100, 20);
            this.tbChar.TabIndex = 1;
            this.tbChar.Leave += new System.EventHandler(this.tbChar_Leave);
            // 
            // tbregex
            // 
            this.tbregex.Location = new System.Drawing.Point(152, 78);
            this.tbregex.Name = "tbregex";
            this.tbregex.Size = new System.Drawing.Size(100, 20);
            this.tbregex.TabIndex = 2;
            // 
            // tbcom1
            // 
            this.tbcom1.Location = new System.Drawing.Point(152, 104);
            this.tbcom1.Name = "tbcom1";
            this.tbcom1.Size = new System.Drawing.Size(100, 20);
            this.tbcom1.TabIndex = 3;
            this.tbcom1.Leave += new System.EventHandler(this.tbcom1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NUMB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CHAR ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "REGEX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "COMPARISON1";
            // 
            // tbcom2
            // 
            this.tbcom2.Location = new System.Drawing.Point(152, 130);
            this.tbcom2.Name = "tbcom2";
            this.tbcom2.Size = new System.Drawing.Size(100, 20);
            this.tbcom2.TabIndex = 8;
            this.tbcom2.Leave += new System.EventHandler(this.tbcom2_Leave);
            // 
            // tbleng
            // 
            this.tbleng.Location = new System.Drawing.Point(152, 156);
            this.tbleng.Name = "tbleng";
            this.tbleng.Size = new System.Drawing.Size(100, 20);
            this.tbleng.TabIndex = 9;
            this.tbleng.Leave += new System.EventHandler(this.tbleng_Leave);
            // 
            // tbupper
            // 
            this.tbupper.Location = new System.Drawing.Point(152, 182);
            this.tbupper.Name = "tbupper";
            this.tbupper.Size = new System.Drawing.Size(100, 20);
            this.tbupper.TabIndex = 10;
            this.tbupper.Leave += new System.EventHandler(this.tbupper_Leave);
            // 
            // tblower
            // 
            this.tblower.Location = new System.Drawing.Point(152, 208);
            this.tblower.Name = "tblower";
            this.tblower.Size = new System.Drawing.Size(100, 20);
            this.tblower.TabIndex = 11;
            this.tblower.Leave += new System.EventHandler(this.tblower_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "KELIK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "COMPARISON2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "LENGTH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "UPPER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "LOWER";
            // 
            // epbenar
            // 
            this.epbenar.ContainerControl = this;
            this.epbenar.Icon = ((System.Drawing.Icon)(resources.GetObject("epbenar.Icon")));
            // 
            // epwarn
            // 
            this.epwarn.ContainerControl = this;
            this.epwarn.Icon = ((System.Drawing.Icon)(resources.GetObject("epwarn.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 279);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tblower);
            this.Controls.Add(this.tbupper);
            this.Controls.Add(this.tbleng);
            this.Controls.Add(this.tbcom2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbcom1);
            this.Controls.Add(this.tbregex);
            this.Controls.Add(this.tbChar);
            this.Controls.Add(this.tbNum);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epbenar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epwarn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbChar;
        private System.Windows.Forms.TextBox tbregex;
        private System.Windows.Forms.TextBox tbcom1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbcom2;
        private System.Windows.Forms.TextBox tbleng;
        private System.Windows.Forms.TextBox tbupper;
        private System.Windows.Forms.TextBox tblower;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider epbenar;
        private System.Windows.Forms.ErrorProvider epwarn;
    }
}

