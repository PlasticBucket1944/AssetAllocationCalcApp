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
    /// ファンド種別マスタークラス
    /// </summary>
    static class FundTypeMaster
    {
        /// <summary>
        /// データテーブル型マスターデータ取得・設定用プロパティ
        /// </summary>
        static public DataTable Data { get; private set; } = new DataTable();

        /// <summary>
        /// マスターデータの取り込みに成功したか
        /// </summary>
        static public bool IsSucceededImport { get; private set; } = false;

        /// <summary>
        /// 取り込み結果メッセージ
        /// </summary>
        static public string ImportResultMessage { get; private set; }

        /// <summary>
        /// 静的コンストラクタ
        /// </summary>
        static FundTypeMaster()
        {
            string filePath = System.Environment.CurrentDirectory + "/FundGroupMaster.csv";

            if (!File.Exists(filePath))
            {
                ImportResultMessage = "ファンド種別マスターファイルが存在していません";
                IsSucceededImport = false;
            }

            try
            {
                Csv csv = new Csv();
                string messege = string.Empty;
                bool result = csv.ImportCsv(filePath, out messege);

                if (!result)
                {
                    ImportResultMessage = "ファンド種別マスターファイル取り込みに失敗しました";
                    IsSucceededImport = false;
                }

                FundListWrapper fundList = new FundListWrapper(csv.ListHead, csv.ListBody);
                Data = fundList.DtFundList;
                Data.TableName = "FUND_GROUP_MASTER";
            }
            catch
            {
                ImportResultMessage = "ファンド種別マスターファイル取り込み中にエラーが発生しました";
                IsSucceededImport = false;
            }

            ImportResultMessage = "ファンド種別マスターファイル取り込みに成功しました";
            IsSucceededImport = true;
        }

        /// <summary>
        /// ファンド名に紐づいた種別を検索し取得
        /// </summary>
        /// <param name="fundName">ファンド名</param>
        /// <returns>種別 見つからない場合はstring.empty</returns>
        static public string FindFundType(string fundName)
        {
            if (string.IsNullOrEmpty(fundName)) return string.Empty;

            DataRow[] dr = Data.Select($"NAME='{fundName}'");

            if (dr.Length > 0)
            {
                return Convert.ToString(dr[0]["TYPE"]);
            }

            return string.Empty;
        }

    }
}
