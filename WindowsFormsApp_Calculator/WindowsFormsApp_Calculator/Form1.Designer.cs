namespace WindowsFormsApp_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_1 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_subtracion = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_addition = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label_input = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.button_equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(15, 144);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(50, 30);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(15, 108);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(50, 30);
            this.button_4.TabIndex = 1;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(71, 108);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(50, 30);
            this.button_5.TabIndex = 2;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(71, 144);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(50, 30);
            this.button_2.TabIndex = 3;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(127, 108);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(50, 30);
            this.button_6.TabIndex = 4;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(127, 144);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(50, 30);
            this.button_3.TabIndex = 5;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(15, 72);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(50, 30);
            this.button_7.TabIndex = 6;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(71, 72);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(50, 30);
            this.button_8.TabIndex = 7;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(127, 72);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(50, 30);
            this.button_9.TabIndex = 8;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_subtracion
            // 
            this.button_subtracion.Location = new System.Drawing.Point(192, 144);
            this.button_subtracion.Name = "button_subtracion";
            this.button_subtracion.Size = new System.Drawing.Size(50, 30);
            this.button_subtracion.TabIndex = 9;
            this.button_subtracion.Text = "-";
            this.button_subtracion.UseVisualStyleBackColor = true;
            this.button_subtracion.Click += new System.EventHandler(this.button_subtracion_Click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.Location = new System.Drawing.Point(192, 108);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(50, 30);
            this.button_multiplication.TabIndex = 10;
            this.button_multiplication.Text = "x";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.button_multiplication_Click);
            // 
            // button_division
            // 
            this.button_division.Location = new System.Drawing.Point(192, 72);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(50, 30);
            this.button_division.TabIndex = 11;
            this.button_division.Text = "÷";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.button_division_Click);
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(15, 180);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(50, 30);
            this.button_0.TabIndex = 12;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_addition
            // 
            this.button_addition.Location = new System.Drawing.Point(192, 180);
            this.button_addition.Name = "button_addition";
            this.button_addition.Size = new System.Drawing.Size(50, 30);
            this.button_addition.TabIndex = 13;
            this.button_addition.Text = "+";
            this.button_addition.UseVisualStyleBackColor = true;
            this.button_addition.Click += new System.EventHandler(this.button_addition_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(127, 217);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(50, 30);
            this.button_clear.TabIndex = 15;
            this.button_clear.Text = "C";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(57, 37);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(185, 19);
            this.textBox_input.TabIndex = 16;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(57, 12);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(185, 19);
            this.textBox_result.TabIndex = 17;
            this.textBox_result.TextChanged += new System.EventHandler(this.textBox_result_TextChanged);
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Location = new System.Drawing.Point(13, 43);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(30, 12);
            this.label_input.TabIndex = 18;
            this.label_input.Text = "Input";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(13, 15);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(38, 12);
            this.label_result.TabIndex = 19;
            this.label_result.Text = "Result";
            this.label_result.Click += new System.EventHandler(this.label_result_Click);
            // 
            // button_equal
            // 
            this.button_equal.Location = new System.Drawing.Point(192, 216);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(50, 30);
            this.button_equal.TabIndex = 20;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 568);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_addition);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_multiplication);
            this.Controls.Add(this.button_subtracion);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_1);
            this.Name = "Form1";
            this.Text = "Caluclator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_subtracion;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_addition;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button_equal;
    }
}

