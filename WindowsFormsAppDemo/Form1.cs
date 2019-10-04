using System;
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
            this.PressNumberKey(0);
            _recentPressedKeyCategory = KeyCategory.Number;
        }

        private void numberKey1_click(object sender, EventArgs e) {
            this.PressNumberKey(1);
            _recentPressedKeyCategory = KeyCategory.Number;
        }
        
        private void numberKey2_click(object sender, EventArgs e) {
            this.PressNumberKey(2);
            _recentPressedKeyCategory = KeyCategory.Number;
        }
        
        private void numberKey3_click(object sender, EventArgs e) {
            this.PressNumberKey(3);
            _recentPressedKeyCategory = KeyCategory.Number;
        }
        
        private void numberKey4_click(object sender, EventArgs e) {
            this.PressNumberKey(4);
            _recentPressedKeyCategory = KeyCategory.Number;
        }
        
        private void numberKey5_click(object sender, EventArgs e) {
            this.PressNumberKey(5);
            _recentPressedKeyCategory = KeyCategory.Number;
        }
        
        private void numberKey6_click(object sender, EventArgs e) {
            this.PressNumberKey(6);
            _recentPressedKeyCategory = KeyCategory.Number;
        }
        
        private void numberKey7_click(object sender, EventArgs e) {
            this.PressNumberKey(7);
            _recentPressedKeyCategory = KeyCategory.Number;
        }
        
        private void numberKey8_click(object sender, EventArgs e) {
            this.PressNumberKey(8);
            _recentPressedKeyCategory = KeyCategory.Number;
        }
        
        private void numberKey9_click(object sender, EventArgs e) {
            this.PressNumberKey(9);
            _recentPressedKeyCategory = KeyCategory.Number;
        }
        
        #endregion
        
        #region 四則計算ボタン
        private void plusKey_click(object sender, EventArgs e) {
            _reservedOperation = Operations.Plus;
            _register = Decimal.Parse(GetDisplayValue());
            _recentPressedKeyCategory = KeyCategory.Operation;
        }
        
        private void minusKey_click(object sender, EventArgs e) {
            _reservedOperation = Operations.Minus;
            _register = Decimal.Parse(GetDisplayValue());
            _recentPressedKeyCategory = KeyCategory.Operation;
        }
        
        private void multipleKey_click(object sender, EventArgs e) {
            _reservedOperation = Operations.Multiple;
            _register = Decimal.Parse(GetDisplayValue());
            _recentPressedKeyCategory = KeyCategory.Operation;
        }
        
        private void divideKey_click(object sender, EventArgs e) {
            _reservedOperation = Operations.Divide;
            _register = Decimal.Parse(GetDisplayValue());
            _recentPressedKeyCategory = KeyCategory.Operation;
        }
        #endregion
        
        #region その他のボタン
        private void pointKey_click(object sender, EventArgs e) {
            AddDecimalPoint();
            _recentPressedKeyCategory = KeyCategory.Other;
        }
        
        private void equalKey_click(object sender, EventArgs e) {
            _recentPressedKeyCategory = KeyCategory.Equal;
            Operation();
        }
        
        private void changeSignKey_click(object sender, EventArgs e) {
            ToggleSign();
            _recentPressedKeyCategory = KeyCategory.Other;
        }
        
        private void percentKey_click(object sender, EventArgs e) {
            Percent();
            _recentPressedKeyCategory = KeyCategory.Other;
        }

        private void clearKey_Click(object sender, EventArgs e) {
            Clear();
            _recentPressedKeyCategory = KeyCategory.Other;
        }
        #endregion
        
        #endregion
        
        // 最大桁数
        private const int MaxLength = 12;

        // 演算子候補
        private enum Operations {
            None,
            Plus,
            Minus,
            Multiple,
            Divide
        };
        
        // 予約中の演算子
        private Operations _reservedOperation;
        
        // キーの種類
        private enum KeyCategory {
            Number,
            Operation,
            Equal,
            Other
        }
        
        // 最後に押されたキーの種類
        private KeyCategory _recentPressedKeyCategory = KeyCategory.Other;
                
        // 保持中の値
        private decimal _register = 0M;
        
        
        
        private string GetDisplayValue() {
            return textBox1.Text;
        }

        private void SetDisplayValue(string value) {
            
            // 小数点や符号を除く、文字数を桁数としてカウントし、最大長を超えていないかチェック
            int numberOfDigit = value.Replace("-", "").Replace(".", "").Length;
            if (numberOfDigit >= MaxLength) {
                return;
            }
            textBox1.Text = value;
        }
        
        private void PressNumberKey(int pressedNumber) {
            if (_recentPressedKeyCategory == KeyCategory.Operation) {
                SetDisplayValue("0");
            }
            string currentNumberString = GetDisplayValue();
            if (_pointFlag && !currentNumberString.Contains(".")) {
                currentNumberString += ".";
                _pointFlag = false;
            }

            string newNumberString = currentNumberString + pressedNumber;
            decimal newNumber = decimal.Parse(newNumberString); 
            SetDisplayValue(newNumber.ToString());
        }

        private bool _pointFlag = false;
        private void AddDecimalPoint() {
            _pointFlag = true;
        }
        
        private void Clear() {
            textBox1.Text = "0";
            _pointFlag = false;
            _register = 0;
        }

        private void ToggleSign() {
            decimal value = Decimal.Negate(Decimal.Parse(GetDisplayValue()));
            SetDisplayValue(value.ToString());
        }

        private void Percent() {
            decimal value = Decimal.Parse(GetDisplayValue()) / 100M;
            SetDisplayValue(value.ToString());
        }

        private void Operation() {
            decimal beforeValue = Decimal.Parse(GetDisplayValue());
            decimal resultValue;
            switch(_reservedOperation) {
                case Operations.Plus:
                    resultValue = _register + beforeValue;
                    break;
                case Operations.Minus:
                    resultValue = _register - beforeValue;
                    break;
                case Operations.Divide:
                    resultValue = _register / beforeValue;
                    break;
                case Operations.Multiple:
                    resultValue = _register * beforeValue;
                    break;
                default:
                    resultValue = beforeValue;
                    break;
            }
            
            // 一度Doubleにキャストしているのは、小数点以下の不要なゼロを消すため
            resultValue = (decimal) (double) resultValue;
            _register = 0; // 定数計算は実装しない。
            SetDisplayValue(resultValue.ToString());
        }
    }
}