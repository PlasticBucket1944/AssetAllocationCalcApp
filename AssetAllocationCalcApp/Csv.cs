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

            StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("Shift_JIS"));

            // CSVファイルのヘッダ列を読み込み配列に格納
            string[] headArrey = sr.ReadLine().Split(',');
            List<string> listHead = new List<string>();
            listHead.AddRange(headArrey);

            /*
            // 最終行までCSVファイルを読み込み配列に格納
            List<string> listBody = new List<string>();
            while (!sr.EndOfStream)
            {
                string[] bodyArrey = sr.ReadLine().Split(',');

            }
            */

            resultMessage = string.Empty;
            return true;
        }
    }
}
