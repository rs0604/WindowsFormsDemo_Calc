using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
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
            recentPressedKeyCategory = KeyCategory.Number;
        }

        private void numberKey1_click(object sender, EventArgs e) {
            this.pressNumberKey(1);
            recentPressedKeyCategory = KeyCategory.Number;
        }
        
        private void numberKey2_click(object sender, EventArgs e) {
            this.pressNumberKey(2);
            recentPressedKeyCategory = KeyCategory.Number;
        }
        
        private void numberKey3_click(object sender, EventArgs e) {
            this.pressNumberKey(3);
            recentPressedKeyCategory = KeyCategory.Number;
        }
        
        private void numberKey4_click(object sender, EventArgs e) {
            this.pressNumberKey(4);
            recentPressedKeyCategory = KeyCategory.Number;
        }
        
        private void numberKey5_click(object sender, EventArgs e) {
            this.pressNumberKey(5);
            recentPressedKeyCategory = KeyCategory.Number;
        }
        
        private void numberKey6_click(object sender, EventArgs e) {
            this.pressNumberKey(6);
            recentPressedKeyCategory = KeyCategory.Number;
        }
        
        private void numberKey7_click(object sender, EventArgs e) {
            this.pressNumberKey(7);
            recentPressedKeyCategory = KeyCategory.Number;
        }
        
        private void numberKey8_click(object sender, EventArgs e) {
            this.pressNumberKey(8);
            recentPressedKeyCategory = KeyCategory.Number;
        }
        
        private void numberKey9_click(object sender, EventArgs e) {
            this.pressNumberKey(9);
            recentPressedKeyCategory = KeyCategory.Number;
        }
        
        #endregion
        
        #region 四則計算ボタン
        private void plusKey_click(object sender, EventArgs e) {
            reservedOperation = Operations.Plus;
            register = Decimal.Parse(getDisplayValue());
            recentPressedKeyCategory = KeyCategory.Operation;
        }
        
        private void minusKey_click(object sender, EventArgs e) {
            reservedOperation = Operations.Minus;
            register = Decimal.Parse(getDisplayValue());
            recentPressedKeyCategory = KeyCategory.Operation;
        }
        
        private void multipleKey_click(object sender, EventArgs e) {
            reservedOperation = Operations.Multiple;
            register = Decimal.Parse(getDisplayValue());
            recentPressedKeyCategory = KeyCategory.Operation;
        }
        
        private void divideKey_click(object sender, EventArgs e) {
            reservedOperation = Operations.Divide;
            register = Decimal.Parse(getDisplayValue());
            recentPressedKeyCategory = KeyCategory.Operation;
        }
        #endregion
        
        #region その他のボタン
        private void pointKey_click(object sender, EventArgs e) {
            addDecimalPoint();
            recentPressedKeyCategory = KeyCategory.Other;
        }
        
        private void equalKey_click(object sender, EventArgs e) {
            recentPressedKeyCategory = KeyCategory.Equal;
            operation();
        }
        
        private void changeSignKey_click(object sender, EventArgs e) {
            toggleSign();
            recentPressedKeyCategory = KeyCategory.Other;
        }
        
        private void percentKey_click(object sender, EventArgs e) {
            percent();
            recentPressedKeyCategory = KeyCategory.Other;
        }

        private void clearKey_Click(object sender, EventArgs e) {
            clear();
            recentPressedKeyCategory = KeyCategory.Other;
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
        
        // キーの種類
        private enum KeyCategory {
            Number,
            Operation,
            Equal,
            Other
        }
        
        // 最後に押されたキーの種類
        private KeyCategory recentPressedKeyCategory = KeyCategory.Other;
                
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
            if (recentPressedKeyCategory == KeyCategory.Operation) {
                setDisplayValue("0");
            }
            string currentNumberString = getDisplayValue();
            if (pointFlag && !currentNumberString.Contains(".")) {
                currentNumberString += ".";
                pointFlag = false;
            }

            string newNumberString = currentNumberString + pressedNumber;
            decimal newNumber = decimal.Parse(newNumberString); 
            setDisplayValue(newNumber.ToString());
        }

        private bool pointFlag = false;
        private void addDecimalPoint() {
            pointFlag = true;
        }
        
        private void clear() {
            textBox1.Text = "0";
            pointFlag = false;
            register = 0;
        }

        private void toggleSign() {
            decimal value = Decimal.Negate(Decimal.Parse(getDisplayValue()));
            setDisplayValue(value.ToString());
        }

        private void percent() {
            decimal value = Decimal.Parse(getDisplayValue()) / 100M;
            setDisplayValue(value.ToString());
        }

        private void operation() {
            // 一度Doubleにキャストしているのは、小数点以下の不要なゼロを消すため
            decimal beforeValue = (decimal)(double)Decimal.Parse(getDisplayValue());
            decimal resultValue;
            switch(reservedOperation) {
                case Operations.Plus:
                    resultValue = register + beforeValue;
                    break;
                case Operations.Minus:
                    resultValue = register - beforeValue;
                    break;
                case Operations.Divide:
                    resultValue = register / beforeValue;
                    break;
                case Operations.Multiple:
                    resultValue = register * beforeValue;
                    break;
                default:
                    resultValue = beforeValue;
                    break;
            }

            setDisplayValue(resultValue.ToString());
        }
    }
}