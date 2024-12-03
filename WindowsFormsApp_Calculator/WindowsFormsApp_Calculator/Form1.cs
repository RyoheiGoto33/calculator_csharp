using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Calculator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 演算記号列挙子
        /// </summary>
        enum Operators
        {
            /// <summary>
            /// 未設定
            /// </summary>
            None,
            /// <summary>
            /// 加算
            /// </summary>
            Add,
            /// <summary>
            /// 減算
            /// </summary>
            Sub,
            /// <summary>
            /// 乗算
            /// </summary>
            Mul,
            /// <summary>
            /// 除算
            /// </summary>
            Div
        }

        /// <summary>
        /// 演算記号
        /// </summary>
        private Operators Operator = Operators.None;

        /// <summary>
        /// 入力値バッファ
        /// </summary>
        private int InputBuff = 0;

        /// <summary>
        /// フォームのコンストラクタ
        /// フォームの起動時に一度だけ呼び出される
        /// </summary>
        public Form1()
        {
            // フォームの初期化処理
            InitializeComponent();
        }

        /// <summary>
        /// 数字ボタン 0 クリックイベント
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void button_0_Click(object sender, EventArgs e)
        {
            // 入力のテキストボックスに0を追加する
            textBox_input.Text += "0";
        }

        /// <summary>
        /// 数字ボタン 1 クリックイベント
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void button_1_Click(object sender, EventArgs e)
        {
            // 入力のテキストボックスに1を追加する
            textBox_input.Text += "1";
        }

        /// <summary>
        /// 数字ボタン 2 クリックイベント
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void button_2_Click(object sender, EventArgs e)
        {
            // 入力のテキストボックスに2を追加する
            textBox_input.Text += "2";
        }

        /// <summary>
        /// 数字ボタン 3 クリックイベント
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void button_3_Click(object sender, EventArgs e)
        {
            // 入力のテキストボックスに3を追加する
            textBox_input.Text += "3";
        }

        /// <summary>
        /// 数字ボタン 4 クリックイベント
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void button_4_Click(object sender, EventArgs e)
        {
            // 入力のテキストボックスに4を追加する
            textBox_input.Text += "4";
        }

        /// <summary>
        /// 数字ボタン 5 クリックイベント
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void button_5_Click(object sender, EventArgs e)
        {
            // 入力のテキストボックスに5を追加する
            textBox_input.Text += "5";
        }

        /// <summary>
        /// 数字ボタン 6 クリックイベント
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void button_6_Click(object sender, EventArgs e)
        {
            // 入力のテキストボックスに6を追加する
            textBox_input.Text += "6";
        }

        /// <summary>
        /// 数字ボタン 7 クリックイベント
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void button_7_Click(object sender, EventArgs e)
        {
            // 入力のテキストボックスに7を追加する
            textBox_input.Text += "7";
        }

        /// <summary>
        /// 数字ボタン 8 クリックイベント
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void button_8_Click(object sender, EventArgs e)
        {
            // 入力のテキストボックスに8を追加する
            textBox_input.Text += "8";
        }

        /// <summary>
        /// 数字ボタン 9 クリックイベント
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void button_9_Click(object sender, EventArgs e)
        {
            // 入力のテキストボックスに9を追加する
            textBox_input.Text += "9";
        }

        /// <summary>
        /// 演算子ボタン 加算 クリックイベント
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void button_addition_Click(object sender, EventArgs e)
        {
            // 入力値の変換
            if (ConvertInput(ref InputBuff) == false)
            {
                return;
            }

            // 演算記号を加算に設定する
            Operator = Operators.Add;
        }

        /// <summary>
        /// 演算子ボタン 減算 クリックイベント
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void button_subtracion_Click(object sender, EventArgs e)
        {
            // 入力値の変換
            if (ConvertInput(ref InputBuff) == false)
            {
                return;
            }

            // 演算記号を減算に設定する
            Operator = Operators.Sub;
        }

        /// <summary>
        /// 演算子ボタン 乗算 クリックイベント
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void button_multiplication_Click(object sender, EventArgs e)
        {
            // 入力値の変換
            if (ConvertInput(ref InputBuff) == false)
            {
                return;
            }

            // 演算記号を乗算に設定する
            Operator = Operators.Mul;
        }

        /// <summary>
        /// 演算子ボタン 除算 クリックイベント
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void button_division_Click(object sender, EventArgs e)
        {
            // 入力値の変換
            if (ConvertInput(ref InputBuff) == false)
            {
                return;
            }

            // 演算記号を乗算に設定する
            Operator = Operators.Div;
        }

        /// <summary>
        /// 演算子ボタン イコール クリックイベント
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void button_equal_Click(object sender, EventArgs e)
        {
            // 右辺入力値バッファ
            int inputBuff2 = 0;
            // 計算結果
            int result = 0;

            // 演算記号が登録されているか確認
            if (Operator == Operators.None)
            {
                textBox_result.Text = "操作エラー";
                return;
            }

            // 入力値の変換
            if (ConvertInput(ref inputBuff2) == false)
            {
                return;
            }

            // 演算子に応じた計算
            switch (Operator)
            {
                case Operators.Add:
                    result = InputBuff + inputBuff2;
                    break;
                case Operators.Sub:
                    result = InputBuff - inputBuff2;
                    break;
                case Operators.Mul:
                    result = InputBuff * inputBuff2;
                    break;
                case Operators.Div:
                    // ゼロ割を例外処理で防ぐ
                    try
                    {
                        result = InputBuff / inputBuff2;
                    }
                    catch (DivideByZeroException)
                    {
                        textBox_result.Text = "除算エラー";
                        return;
                    }
                    break;
                default:
                    // 到達しない
                    break;
            }

            // 計算結果をテキストボックスに表示
            textBox_result.Text = string.Format("{0}", result);
            //textBox_result.Text = $"{result}"; // これも同じ
            //textBox_result.Text = result.ToString(); // これも同じ
        }

        /// <summary>
        /// クリアボタン クリックイベント
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void button_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        /// <summary>
        /// 入力値変換
        /// </summary>
        /// <param name="buff">バッファ</param>
        /// <returns>true=成功 false=失敗</returns>
        private bool ConvertInput(ref int buff)
        {
            // 入力した数字のテキストを整数値に変換する
            if (int.TryParse(textBox_input.Text, out int value) == false)
            {
                // 変換に失敗した場合は入力エラー表示にする
                textBox_result.Text = "数値変換エラー";
                return false;
            }

            // 整数値をバッファに保存する
            buff = value;

            // 入力の表示を結果に移動する
            textBox_result.Text = textBox_input.Text;

            // 入力の表示をリセットする
            textBox_input.Text = "";

            return true;
        }

        /// <summary>
        /// 入力クリア
        /// </summary>
        private void Clear()
        {
            // 画面表示のクリア
            textBox_result.Text = "";
            textBox_input.Text = "";

            // 内部データのクリア
            Operator = Operators.None;
            InputBuff = 0;
        }
    }
}
