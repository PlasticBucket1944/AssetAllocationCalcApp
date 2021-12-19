using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetAllocationCalcApp
{
    /// <summary>
    /// ファンドグループマスタークラス
    /// </summary>
    class FundGroupMaster
    {
        /// <summary>
        /// データテーブル型マスターデータ取得・設定用プロパティ
        /// </summary>
        public DataTable Data { get; set; } = new DataTable();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FundGroupMaster()
        {
        }

        /// <summary>
        /// マスターデータ取り込み処理
        /// </summary>
        /// <param name="resultMessage">処理結果メッセージ</param>
        /// <returns>取り込み結果  true:正常終了 false:異常発生</returns>
        public bool ReadMasterData(out string resultMessage)
        {
            string filePath = System.Environment.CurrentDirectory + "/FundGroupMaster.csv";

            if (!File.Exists(filePath))
            {
                resultMessage = "ファンドマスターファイルが存在していません";
                return false;
            }

            try
            {
                Csv csv = new Csv();
                string messege = string.Empty;
                bool result = csv.ImportCsv(filePath, out messege);

                if (!result)
                {
                    resultMessage = "ファンドマスターファイル取り込みに失敗しました";
                    return false;
                }

                FundListWrapper fundList = new FundListWrapper(csv.ListHead, csv.ListBody);
                this.Data = fundList.DtFundList;
                this.Data.TableName = "FUND_GROUP_MASTER";
            }
            catch 
            {
                resultMessage = "ファンドマスターファイル取り込み中にエラーが発生しました";
                return false;
            }

            resultMessage = "ファンドマスターファイル取り込みに成功しました";
            return true;
        }
    }
}
