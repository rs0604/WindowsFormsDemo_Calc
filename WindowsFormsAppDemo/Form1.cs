using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDemo
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "このフォームで保持中の値は" + count + "です。 +1しますか？", "確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                count++;
                MessageBox.Show(count + "になりました。", "結果");
            } else if (result == DialogResult.No)
            {
                MessageBox.Show("[いいえ]が選択されました。", "結果");
            }
            //throw new System.NotImplementedException(); 
        }
    }
}