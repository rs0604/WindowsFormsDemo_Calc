using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsAppDemo
{
    public partial class Form1 : Form
    {
        #region UIへのイベント割り当て
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //throw new System.NotImplementedException(); 
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
            addDecimalPoint();
        }
        
        private void equalKey_click(object sender, EventArgs e) {
            MessageBox.Show("=が押されました。", "Message"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void changeSignKey_click(object sender, EventArgs e) {
            toggleSign();
        }
        
        private void percentKey_click(object sender, EventArgs e) {
            percent();
        }

        private void clearKey_Click(object sender, EventArgs e) {
            clear();
        }
        #endregion
        
        #endregion
        
        // 最大桁数
        private const int MAX_LENGTH = 12;

        // 演算子候補
        private enum Operations {
            None,
            Plus,
            Minus,
            Multiple,
            Divide
        };
        
        // 予約中の演算子
        private Operations reservedOperation;
        
        // 保持中の値
        private decimal register = 0M;
        
        
        private string getDisplayValue() {
            return textBox1.Text;
        }

        private void setDisplayValue(string value) {
            
            // 小数点や符号を除く、文字数を桁数としてカウントし、最大長を超えていないかチェック
            int numberOfDigit = value.Replace("-", "").Replace(".", "").Length;
            if (numberOfDigit >= MAX_LENGTH) {
                return;
            }
            textBox1.Text = value;
        }
        
        private void pressNumberKey(int pressedNumber) {
            string currentNumberString = getDisplayValue();
            if (pointFlag && !currentNumberString.Contains(".")) {
                currentNumberString += ".";
                pointFlag = false;
            }
            setDisplayValue(currentNumberString + pressedNumber);
        }

        private bool pointFlag = false;
        private void addDecimalPoint() {
            pointFlag = true;
        }
        
        private void clear() {
            textBox1.Text = "0";
        }

        private void toggleSign() {
            decimal value = Decimal.Negate(Decimal.Parse(getDisplayValue()));
            setDisplayValue(value.ToString());
        }

        private void percent() {
            decimal value = Decimal.Parse(getDisplayValue()) / 100M;
            setDisplayValue(value.ToString());
        }
    }

    public class myButtonObject : UserControl {
        // Draw the new button
        protected override void OnPaint(PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            graphics.DrawEllipse(myPen, 0, 0, 100, 100);
            myPen.Dispose();
        }
    }
    
    
}