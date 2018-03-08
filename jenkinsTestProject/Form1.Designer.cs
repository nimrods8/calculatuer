namespace jenkinsTestProject
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonSub = new System.Windows.Forms.RadioButton();
            this.radioButtonMul = new System.Windows.Forms.RadioButton();
            this.radioButtonDiv = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Calc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(73, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(196, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(332, 98);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(75, 20);
            this.textBoxResult.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "=";
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Checked = true;
            this.radioButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonAdd.Location = new System.Drawing.Point(125, 32);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(25, 25);
            this.radioButtonAdd.TabIndex = 9;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "+";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonSub
            // 
            this.radioButtonSub.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonSub.AutoSize = true;
            this.radioButtonSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonSub.Location = new System.Drawing.Point(125, 74);
            this.radioButtonSub.Name = "radioButtonSub";
            this.radioButtonSub.Size = new System.Drawing.Size(22, 25);
            this.radioButtonSub.TabIndex = 10;
            this.radioButtonSub.Text = "-";
            this.radioButtonSub.UseVisualStyleBackColor = true;
            // 
            // radioButtonMul
            // 
            this.radioButtonMul.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonMul.AutoSize = true;
            this.radioButtonMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonMul.Location = new System.Drawing.Point(125, 119);
            this.radioButtonMul.Name = "radioButtonMul";
            this.radioButtonMul.Size = new System.Drawing.Size(26, 25);
            this.radioButtonMul.TabIndex = 11;
            this.radioButtonMul.Text = "X";
            this.radioButtonMul.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiv
            // 
            this.radioButtonDiv.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDiv.AutoSize = true;
            this.radioButtonDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonDiv.Location = new System.Drawing.Point(125, 164);
            this.radioButtonDiv.Name = "radioButtonDiv";
            this.radioButtonDiv.Size = new System.Drawing.Size(22, 25);
            this.radioButtonDiv.TabIndex = 12;
            this.radioButtonDiv.Text = ":";
            this.radioButtonDiv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 248);
            this.Controls.Add(this.radioButtonDiv);
            this.Controls.Add(this.radioButtonMul);
            this.Controls.Add(this.radioButtonSub);
            this.Controls.Add(this.radioButtonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Jenkins Test gui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.RadioButton radioButtonSub;
        private System.Windows.Forms.RadioButton radioButtonMul;
        private System.Windows.Forms.RadioButton radioButtonDiv;
    }
}

