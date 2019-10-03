namespace WindowsFormsAppDemo
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.percentKey = new System.Windows.Forms.Button();
            this.equalKey = new System.Windows.Forms.Button();
            this.divideKey = new System.Windows.Forms.Button();
            this.minusKey = new System.Windows.Forms.Button();
            this.multipleKey = new System.Windows.Forms.Button();
            this.numberKey2 = new System.Windows.Forms.Button();
            this.numberKey3 = new System.Windows.Forms.Button();
            this.numberKey5 = new System.Windows.Forms.Button();
            this.numberKey6 = new System.Windows.Forms.Button();
            this.numberKey7 = new System.Windows.Forms.Button();
            this.numberKey8 = new System.Windows.Forms.Button();
            this.numberKey9 = new System.Windows.Forms.Button();
            this.changeSignKey = new System.Windows.Forms.Button();
            this.numberKey4 = new System.Windows.Forms.Button();
            this.numberKey1 = new System.Windows.Forms.Button();
            this.numberKey0 = new System.Windows.Forms.Button();
            this.numberKey00 = new System.Windows.Forms.Button();
            this.plusKey = new System.Windows.Forms.Button();
            this.pointKey = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.percentKey, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.equalKey, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.divideKey, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.minusKey, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.multipleKey, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.numberKey2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numberKey3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.numberKey5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numberKey6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.numberKey7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numberKey8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numberKey9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.changeSignKey, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.numberKey4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numberKey1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numberKey0, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numberKey00, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pointKey, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.plusKey, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 121);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 295);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // percentKey
            // 
            this.percentKey.Location = new System.Drawing.Point(261, 62);
            this.percentKey.Name = "percentKey";
            this.percentKey.Size = new System.Drawing.Size(65, 53);
            this.percentKey.TabIndex = 21;
            this.percentKey.Text = "%";
            this.percentKey.UseVisualStyleBackColor = true;
            // 
            // equalKey
            // 
            this.equalKey.Location = new System.Drawing.Point(347, 239);
            this.equalKey.Name = "equalKey";
            this.equalKey.Size = new System.Drawing.Size(65, 53);
            this.equalKey.TabIndex = 20;
            this.equalKey.Text = "=";
            this.equalKey.UseVisualStyleBackColor = true;
            this.equalKey.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // divideKey
            // 
            this.divideKey.Location = new System.Drawing.Point(347, 121);
            this.divideKey.Name = "divideKey";
            this.divideKey.Size = new System.Drawing.Size(65, 53);
            this.divideKey.TabIndex = 16;
            this.divideKey.Text = "/";
            this.divideKey.UseVisualStyleBackColor = true;
            // 
            // minusKey
            // 
            this.minusKey.Location = new System.Drawing.Point(347, 180);
            this.minusKey.Name = "minusKey";
            this.minusKey.Size = new System.Drawing.Size(65, 53);
            this.minusKey.TabIndex = 18;
            this.minusKey.Text = "-";
            this.minusKey.UseVisualStyleBackColor = true;
            // 
            // multipleKey
            // 
            this.multipleKey.Location = new System.Drawing.Point(261, 121);
            this.multipleKey.Name = "multipleKey";
            this.multipleKey.Size = new System.Drawing.Size(65, 53);
            this.multipleKey.TabIndex = 17;
            this.multipleKey.Text = "*";
            this.multipleKey.UseVisualStyleBackColor = true;
            // 
            // numberKey2
            // 
            this.numberKey2.Location = new System.Drawing.Point(89, 180);
            this.numberKey2.Name = "numberKey2";
            this.numberKey2.Size = new System.Drawing.Size(65, 53);
            this.numberKey2.TabIndex = 9;
            this.numberKey2.Text = "2";
            this.numberKey2.UseVisualStyleBackColor = true;
            this.numberKey2.Click += new System.EventHandler(this.button10_Click);
            // 
            // numberKey3
            // 
            this.numberKey3.Location = new System.Drawing.Point(175, 180);
            this.numberKey3.Name = "numberKey3";
            this.numberKey3.Size = new System.Drawing.Size(65, 53);
            this.numberKey3.TabIndex = 13;
            this.numberKey3.Text = "3";
            this.numberKey3.UseVisualStyleBackColor = true;
            this.numberKey3.Click += new System.EventHandler(this.buttonNu_Click);
            // 
            // numberKey5
            // 
            this.numberKey5.Location = new System.Drawing.Point(89, 121);
            this.numberKey5.Name = "numberKey5";
            this.numberKey5.Size = new System.Drawing.Size(65, 53);
            this.numberKey5.TabIndex = 10;
            this.numberKey5.Text = "5";
            this.numberKey5.UseVisualStyleBackColor = true;
            // 
            // numberKey6
            // 
            this.numberKey6.Location = new System.Drawing.Point(175, 121);
            this.numberKey6.Name = "numberKey6";
            this.numberKey6.Size = new System.Drawing.Size(65, 53);
            this.numberKey6.TabIndex = 14;
            this.numberKey6.Text = "6";
            this.numberKey6.UseVisualStyleBackColor = true;
            // 
            // numberKey7
            // 
            this.numberKey7.Location = new System.Drawing.Point(3, 62);
            this.numberKey7.Name = "numberKey7";
            this.numberKey7.Size = new System.Drawing.Size(65, 53);
            this.numberKey7.TabIndex = 29;
            this.numberKey7.Text = "7";
            this.numberKey7.UseVisualStyleBackColor = true;
            // 
            // numberKey8
            // 
            this.numberKey8.Location = new System.Drawing.Point(89, 62);
            this.numberKey8.Name = "numberKey8";
            this.numberKey8.Size = new System.Drawing.Size(65, 53);
            this.numberKey8.TabIndex = 30;
            this.numberKey8.Text = "8";
            this.numberKey8.UseVisualStyleBackColor = true;
            // 
            // numberKey9
            // 
            this.numberKey9.Location = new System.Drawing.Point(175, 62);
            this.numberKey9.Name = "numberKey9";
            this.numberKey9.Size = new System.Drawing.Size(65, 53);
            this.numberKey9.TabIndex = 31;
            this.numberKey9.Text = "9";
            this.numberKey9.UseVisualStyleBackColor = true;
            // 
            // changeSignKey
            // 
            this.changeSignKey.Location = new System.Drawing.Point(347, 62);
            this.changeSignKey.Name = "changeSignKey";
            this.changeSignKey.Size = new System.Drawing.Size(65, 53);
            this.changeSignKey.TabIndex = 32;
            this.changeSignKey.Text = "+ / -";
            this.changeSignKey.UseVisualStyleBackColor = true;
            this.changeSignKey.Click += new System.EventHandler(this.button9_Click);
            // 
            // numberKey4
            // 
            this.numberKey4.Location = new System.Drawing.Point(3, 121);
            this.numberKey4.Name = "numberKey4";
            this.numberKey4.Size = new System.Drawing.Size(65, 53);
            this.numberKey4.TabIndex = 33;
            this.numberKey4.Text = "4";
            this.numberKey4.UseVisualStyleBackColor = true;
            // 
            // numberKey1
            // 
            this.numberKey1.Location = new System.Drawing.Point(3, 180);
            this.numberKey1.Name = "numberKey1";
            this.numberKey1.Size = new System.Drawing.Size(65, 53);
            this.numberKey1.TabIndex = 34;
            this.numberKey1.Text = "1";
            this.numberKey1.UseVisualStyleBackColor = true;
            // 
            // numberKey0
            // 
            this.numberKey0.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (128)));
            this.numberKey0.Location = new System.Drawing.Point(3, 239);
            this.numberKey0.Name = "numberKey0";
            this.numberKey0.Size = new System.Drawing.Size(65, 53);
            this.numberKey0.TabIndex = 25;
            this.numberKey0.Text = "0";
            this.numberKey0.UseVisualStyleBackColor = true;
            this.numberKey0.Click += new System.EventHandler(this.button2_Click);
            // 
            // numberKey00
            // 
            this.numberKey00.Location = new System.Drawing.Point(89, 239);
            this.numberKey00.Name = "numberKey00";
            this.numberKey00.Size = new System.Drawing.Size(65, 53);
            this.numberKey00.TabIndex = 12;
            this.numberKey00.Text = "00";
            this.numberKey00.UseVisualStyleBackColor = true;
            // 
            // plusKey
            // 
            this.plusKey.Location = new System.Drawing.Point(261, 180);
            this.plusKey.Name = "plusKey";
            this.tableLayoutPanel1.SetRowSpan(this.plusKey, 2);
            this.plusKey.Size = new System.Drawing.Size(65, 112);
            this.plusKey.TabIndex = 36;
            this.plusKey.Text = "+";
            this.plusKey.UseVisualStyleBackColor = true;
            this.plusKey.Click += new System.EventHandler(this.button13_Click);
            // 
            // pointKey
            // 
            this.pointKey.Location = new System.Drawing.Point(175, 239);
            this.pointKey.Name = "pointKey";
            this.pointKey.Size = new System.Drawing.Size(65, 53);
            this.pointKey.TabIndex = 8;
            this.pointKey.Text = ".";
            this.pointKey.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 428);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("メイリオ", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button numberKey0;
        private System.Windows.Forms.Button numberKey7;
        private System.Windows.Forms.Button numberKey4;
        private System.Windows.Forms.Button numberKey1;
        private System.Windows.Forms.Button numberKey00;
        private System.Windows.Forms.Button pointKey;
        private System.Windows.Forms.Button numberKey6;
        private System.Windows.Forms.Button numberKey5;
        private System.Windows.Forms.Button numberKey3;
        private System.Windows.Forms.Button numberKey2;
        private System.Windows.Forms.Button plusKey;
        private System.Windows.Forms.Button numberKey8;
        private System.Windows.Forms.Button numberKey9;
        private System.Windows.Forms.Button changeSignKey;
        private System.Windows.Forms.Button percentKey;
        private System.Windows.Forms.Button minusKey;
        private System.Windows.Forms.Button multipleKey;
        private System.Windows.Forms.Button divideKey;
        private System.Windows.Forms.Button equalKey;
    }
}