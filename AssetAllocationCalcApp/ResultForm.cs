using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetAllocationCalcApp
{
    /// <summary>
    /// 取り込み結果画面
    /// </summary>
    public partial class ResultForm : Form
    {
        /// <summary>
        /// 表示用データテーブル
        /// </summary>
        private DataTable showData = new DataTable();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="data">表示用データ</param>
        public ResultForm(DataTable data)
        {
            InitializeComponent();

            string[] primaryKey = { "FUND_NAME" };
            string[] mergeColumns = { "GET_VALUE", "EVALUATION_VALUE" };

            this.showData = DataTableFunction.MergeDataRow(data, primaryKey, mergeColumns);

        }

        /// <summary>
        /// 戻るボタンクリック時イベント
        /// </summary>
        /// <param name="sender">イベント発生元コントロール</param>
        /// <param name="e">イベント情報</param>
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// データテーブル編集
        /// </summary>
        private void EditData()
        {
            this.showData.Columns.Add("ASSET_PER", typeof(decimal));
        }
    }
}
