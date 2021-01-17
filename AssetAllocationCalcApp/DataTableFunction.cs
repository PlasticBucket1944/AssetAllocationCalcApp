using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable MergeDataRow(DataTable dataTable, string[] primaryKey, string[] mergeColumns)
        {
            if (dataTable == null) return null;

            DataTable baseTable = dataTable.Copy();
            DataTable resultTable = dataTable.Clone();


            return null;
        }
    }
}
