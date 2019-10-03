using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppDemo
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //throw new System.NotImplementedException(); 
        }
        private void textBox1_TextChanged(object sender, EventArgs e) {
            //throw new System.NotImplementedException();
        }
        
        private void pressNumberKey(int pressedNumber) {
            // 動作確認用。実装はまだない
            MessageBox.Show(pressedNumber + "が押されました。", "Message"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #region 数字のボタン
        private void numberKey0_click(object sender, EventArgs e) {
            this.pressNumberKey(0);
        }

        private void numberKey1_click(object sender, EventArgs e) {
            this.pressNumberKey(1);
        }
        
        private void numberKey2_click(object sender, EventArgs e) {
            this.pressNumberKey(2);
        }
        
        private void numberKey3_click(object sender, EventArgs e) {
            this.pressNumberKey(3);
        }
        
        private void numberKey4_click(object sender, EventArgs e) {
            this.pressNumberKey(4);
        }
        
        private void numberKey5_click(object sender, EventArgs e) {
            this.pressNumberKey(5);
        }
        
        private void numberKey6_click(object sender, EventArgs e) {
            this.pressNumberKey(6);
        }
        
        private void numberKey7_click(object sender, EventArgs e) {
            this.pressNumberKey(7);
        }
        
        private void numberKey8_click(object sender, EventArgs e) {
            this.pressNumberKey(8);
        }
        
        private void numberKey9_click(object sender, EventArgs e) {
            this.pressNumberKey(9);
        }
        
        private void numberKey00_click(object sender, EventArgs e) {
            this.pressNumberKey(0);
            this.pressNumberKey(0);
        }
        
        #endregion
        
        #region 四則計算ボタン
        private void plusKey_click(object sender, EventArgs e) {
            MessageBox.Show("+が押されました。", "Message"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void minusKey_click(object sender, EventArgs e) {
            MessageBox.Show("-が押されました。", "Message"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void multipleKey_click(object sender, EventArgs e) {
            MessageBox.Show("*が押されました。", "Message"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void divideKey_click(object sender, EventArgs e) {
            MessageBox.Show("/が押されました。", "Message"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
        
        #region その他のボタン
        private void pointKey_click(object sender, EventArgs e) {
            MessageBox.Show(".が押されました。", "Message"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void equalKey_click(object sender, EventArgs e) {
            MessageBox.Show("=が押されました。", "Message"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void changeSignKey_click(object sender, EventArgs e) {
            MessageBox.Show("+ / - が押されました。", "Message"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void percentKey_click(object sender, EventArgs e) {
            MessageBox.Show("%が押されました。", "Message"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
        
    }
}