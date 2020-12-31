using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetAllocationCalcApp
{
    /// <summary>
    /// ファンドリストラッパークラス
    /// </summary>
    class FundListWrapper
    {
        /// <summary>
        /// データテーブル型ファンドリスト
        /// </summary>
        private DataTable dtFundList = new DataTable();

        /// <summary>
        /// データテーブル型ファンドリスト取得プロパティ
        /// </summary>
        public DataTable DtFundList
        {
            get { return dtFundList; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="listHead">CSVヘッダー列</param>
        /// <param name="listBody">CSV詳細列(複数行可)</param>
        public FundListWrapper(List<string> listHead, List<List<string>> listBody)
        {
            this.CreateDataTable(listHead, listBody);
        }

        /// <summary>
        /// 受け取ったヘッダー列と詳細列からデータテーブルを作成
        /// </summary>
        /// <param name="listHead">ヘッダー列</param>
        /// <param name="listBody">詳細列(複数行可)</param>
        private void CreateDataTable(List<string> listHead, List<List<string>> listBody)
        {
            this.dtFundList = new DataTable("FundList");

            // 受け取ったヘッダー列の名前でカラムを作成
            foreach (string headName in listHead)
            {
                this.dtFundList.Columns.Add(headName, typeof(string));
            }

            // 詳細列をデータテーブルに格納
            foreach (List<string> body in listBody)
            {
                DataRow newRow = dtFundList.NewRow();
                // i番目のカラムにi番目のデータを挿入
                for (int i = 0; i < listHead.Count; i++)
                {
                    newRow[listHead[i]] = body[i];
                }
                dtFundList.Rows.Add(newRow);
            }
        }
    }
}
