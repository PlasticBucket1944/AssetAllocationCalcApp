using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetAllocationCalcApp
{
    /// <summary>
    /// データテーブル用ファンクションクラス
    /// </summary>
    class DataTableFunction
    {
        /// <summary>
        /// データテーブル内の行をマージする
        /// </summary>
        /// <param name="dataTable">マージ対象データテーブル</param>
        /// <param name="primaryKey">マージ用 主キー</param>
        /// <param name="mergeColumns">結合対象カラム</param>
        /// <returns>結合後データテーブル</returns>
        public static DataTable MergeDataRow(DataTable dataTable, string[] primaryKey, string[] mergeColumns)
        {
            if (dataTable == null || primaryKey.Count() == 0 || mergeColumns.Count() == 0)
            {
                return null;
            }

            DataTable resultTable = dataTable.Clone();

            foreach (DataRow row in dataTable.Rows)
            {
                if (ExistRow(row, primaryKey, resultTable))
                {
                    // 行が既に存在していた場合マージ

                    // マージ対象行の列番号を取得
                    int index = SearchRowIndex(row, primaryKey, resultTable);

                    // 行マージ処理
                    foreach (string key in mergeColumns)
                    {
                        int num = Convert.ToInt32(resultTable.Rows[index][key]);
                        num += Convert.ToInt32(row[key]);
                        resultTable.Rows[index][key] = num;
                    }
                }
                else
                {
                    // 行が存在しない場合行追加
                    DataRow newRow = resultTable.NewRow();
                    
                    // 主キー及びマージ対象列の値を追加行に入れる
                    foreach (string key in primaryKey)
                    {
                        newRow[key] = row[key];
                    }
                    foreach (string key in mergeColumns)
                    {
                        newRow[key] = row[key];
                    }

                    resultTable.Rows.Add(newRow);
                }    
            }

            return resultTable;
        }

       /// <summary>
       /// 行が既にテーブル内に存在しているか
       /// </summary>
       /// <param name="row">検索したい行</param>
       /// <param name="primaryKey">比較対象カラム名</param>
       /// <param name="table">検索対象テーブル</param>
       /// <returns>存在しているか</returns>
        private static bool ExistRow(DataRow row,　string[] primaryKey,  DataTable table)
        {
            if(primaryKey.Length == 0 || table.Rows.Count == 0)
            {
                return false;
            }

            string selectStr = "1 = '1' ";
            foreach (string key in primaryKey)
            {
                selectStr += " AND " + key + " = '" + row[key] + "'";
            }

            DataRow[] rows = table.Select(selectStr);
            
            if (rows.Count() != 0) return true;
            return false;
        }

        /// <summary>
        /// 行の指定したカラム値と同等の値を持つ行の列番号を検索
        /// </summary>
        /// <param name="row">検索したい行</param>
        /// <param name="primaryKey">比較対象カラム名</param>
        /// <param name="table">検索対象テーブル</param>
        /// <returns>列番号(存在していない場合は-1)</returns>
        private static int SearchRowIndex(DataRow row, string[] primaryKey, DataTable table)
        {
            for (int i = 0; table.Rows.Count > i; i++)
            {
                bool result = true;
                // 比較対象カラムの値を比較
                foreach (string key in primaryKey)
                {
                    if (table.Rows[i][key].ToString() != row[key].ToString())
                    {
                        result = false;
                    }
                }

                // 同値の行が存在していた場合行番号を返す
                if (result) return i;
            }

            return -1;
        }
    }
}
