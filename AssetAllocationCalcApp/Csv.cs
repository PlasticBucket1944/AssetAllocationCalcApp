using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetAllocationCalcApp
{
    /// <summary>
    /// CSV制御用クラス
    /// </summary>
    class Csv
    {
        /// <summary>
        ///  CSVファイル ヘッダ列
        /// </summary>
        private List<string> listHead = new List<string>();

        /// <summary>
        ///  CSVファイル 詳細列
        /// </summary>
        private List<List<string>> listBody = new List<List<string>>();

        /// <summary>
        /// CSVファイル ヘッダ列取得プロパティ
        /// </summary>
        public List<string> ListHead
        {
            get { return listHead; }
        }

        /// <summary>
        /// CSVファイル 詳細列取得プロパティ
        /// </summary>
        public List<List<string>> ListBody
        {
            get { return listBody; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Csv()
        {
        }

        /// <summary>
        /// CSV取り込み処理
        /// </summary>
        /// <param name="filePath">ファイルパス</param>
        /// <param name="resultMessage">処理結果メッセージ</param>
        /// <returns>取り込み結果  true:正常終了 false:異常発生</returns>
        public bool ImportCsv(string filePath, out string resultMessage)
        {
            if (!File.Exists(filePath))
            {
                resultMessage = "ファイルが存在していません";
                return false;
            }

            try
            {
                StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("Shift_JIS"));

                // CSVファイルのヘッダ列を読み込み配列に格納
                this.listHead = new List<string>();
                this.listHead = this.SplitCsvLine(sr.ReadLine());

                // 最終行までCSVファイルを読み込み配列に格納
                this.listBody = new List<List<string>>();
                while (!sr.EndOfStream)
                {
                    listBody.Add(this.SplitCsvLine(sr.ReadLine()));
                }
            }
            catch
            {
                resultMessage = "ファイル取り込み中にエラーが発生しました";
                return false;
            }

            resultMessage = "ファイル取り込みが完了しました";
            return true;
        }

        /// <summary>
        /// 文字列を半角カンマ(,)で分割
        /// ダブルクォーテーション(")はエスケープ処理する
        /// </summary>
        /// <param name="baseStr">分割元文字列</param>
        /// <returns>分割した文字列をList型にしたもの</returns>
        private List<string> SplitCsvLine(string baseStr)
        {
            if(baseStr == string.Empty && baseStr == null) return new List<string>();

            // 要素がダブルクォーテーション(")で囲まれている物か確認
            if (baseStr.Contains("\""))
            {
                //ダブルクォーテーション(")で囲まれていたら「",」で分割する
                string[] splitStr = { "\"," };
                string[] splitArray = baseStr.Split(splitStr, StringSplitOptions.None);

                // 各文字の先頭にある「"」を削除(最後の要素のみ""で囲まれているのでTrimStartは使わない) 
                string[] ary = Array.ConvertAll(splitArray, str => str.Trim('\"')); // ラムダ式
                
                // List型にしてリターン
                List<string> list = new List<string>();
                list.AddRange(ary);
                return list;
            }
            else
            {
                //ダブルクォーテーション(")で囲まれていなかったら「,」で分割する
                string[] splitArray = baseStr.Split(',');

                // List型にしてリターン
                List<string> list = new List<string>();
                list.AddRange(splitArray);
                return list;
            }
        }
    }
}
