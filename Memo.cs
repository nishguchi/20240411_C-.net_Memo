using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_App5
{
    public partial class Memo : Form
    {
        //Dialogで取得、入力するファイル名
        //初期値
        string fileName = "";
        public Memo()
        {
            InitializeComponent();
            fileLabel2.BackColor = Color.White;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            //終了ボタン押下
            //アプリケーション終了
            Application.Exit();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {

            //開くボタン押下
            //ダイアログを開く
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                //開いたファイルネーム取得
                fileName = openFileDialog1.FileName;
                using (StreamReader streamReader =new StreamReader(fileName, GetEncodingFromRadio(), false))
                {
                    //読み込み
                    //全ての内容をTextBoxに表示
                    textBoxMain.Text = streamReader.ReadToEnd();

                    //ファイル名表示
                    if (fileName.Length >= 40)
                    {
                        //40文字以上のファイル名
                        //ポップアップ表示
                        MessageBox.Show(fileName,"ファイル名");
                        fileLabel2.Text = "";
                    }
                    else
                    {
                        //40文字未満ファイル名
                        //ラベル表示
                        fileLabel2.Text = fileName;
                    }


                    //上書きボタン
                    //有効化
                    SaveButton.Enabled = true;

                    //新規保存ボタン
                    //有効化
                    newSaveButton.Enabled = true;

                    //ストリームリーダーを閉じる
                    streamReader.Close();
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //開いているファイル名
            saveFileDialog1.FileName = openFileDialog1.FileName;

            //名前を付けて保存ダイアログを表示
/*            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {*/
                //保存ファイル名取得
                string fileName = saveFileDialog1.FileName;

                //保存
                //TextBox内容を保存
                using (StreamWriter streamWriter = new StreamWriter(fileName,false,GetEncodingFromRadio()))
                {
                    //TextBoxの内容を書き込む
                    streamWriter.WriteLine(textBoxMain.Text);
                }
           /* }*/

        }

        private Encoding GetEncodingFromRadio ()
        {
            //エンコーディング
            //初期値
            Encoding encoding = Encoding.GetEncoding("UTF-8");

            //radioボタン選択でのエンコーディング
            if (radioB1.Checked) encoding =  Encoding.GetEncoding("utf-8");
            if (radioB2.Checked) encoding =  Encoding.GetEncoding("shift-jis");
            if (radioB3.Checked) encoding =  Encoding.GetEncoding("euc-jp");
            if (radioB4.Checked) encoding =  Encoding.GetEncoding("iso-2022-jp");
            if (radioB5.Checked) encoding = Encoding.GetEncoding("unicode");

            return encoding; 
        }

        private void newSaveButton_Click(object sender, EventArgs e)
        {
            //新規ファイル名
            saveFileDialog1.FileName = "NewFileName";

            //名前を付けて保存ダイアログを表示
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //保存ファイル名取得
                string fileName = saveFileDialog1.FileName;

                //保存
                //TextBox内容を保存
                using (StreamWriter streamWriter = new StreamWriter(fileName, false, GetEncodingFromRadio()))
                {
                    //TextBoxの内容を書き込む
                    streamWriter.WriteLine(textBoxMain.Text);
                }
            }
        }

        private void textBoxMain_Click(object sender, EventArgs e)
        {
            //新規保存ボタン
            //有効化
            newSaveButton.Enabled = true;

        }
    }
}
