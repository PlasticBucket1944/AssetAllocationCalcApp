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

            string[] primaryKey = { "FUND_TYPE" };
            string[] mergeColumns = { "GET_VALUE", "EVALUATION_VALUE" };

            this.showData = DataTableFunction.MergeDataRow(data, primaryKey, mergeColumns);
            this.gridViewDataList.AddData(this.showData);

            // 総合計値を計算して表示
            this.textGetValueAll.Text = this.gridViewDataList.GetValueAll.ToString("#,##0");
            this.textEvaluationValueAll.Text = this.gridViewDataList.EvaluationValueAll.ToString("#,##0");
            this.textDiffAllValue.Text = 
                (this.gridViewDataList.EvaluationValueAll - this.gridViewDataList.GetValueAll).ToString("#,##0");

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
    }
}
