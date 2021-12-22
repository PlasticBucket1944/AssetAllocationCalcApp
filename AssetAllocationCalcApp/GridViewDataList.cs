using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace AssetAllocationCalcApp
{
    /// <summary>
    /// データ表示用グリッドビュークラス
    /// </summary>
    public partial class GridViewDataList : UserControl
    {
        /// <summary>
        /// カラム名：ファンド名
        /// </summary>
        private const string COL_FUND_NAME = "FUND_NAME";

        /// <summary>
        /// カラム名：ファンド種別
        /// </summary>
        private const string COL_FUND_TYPE = "FUND_TYPE";

        /// <summary>
        /// カラム名：取得金額
        /// </summary>
        private const string COL_GET_VALUE = "GET_VALUE";

        /// <summary>
        /// カラム名：評価金額
        /// </summary>
        private const string COL_EVALUATION_VALUE = "EVALUATION_VALUE";

        /// <summary>
        /// カラム名：評価差額(円)
        /// </summary>
        private const string COL_DIFF_VALUE_EN = "DIFF_VALUE_EN";

        /// <summary>
        /// カラム名：評価差額(%)
        /// </summary>
        private const string COL_DIFF_VALUE_PER = "DIFF_VALUE_PER";

        /// <summary>
        /// グリッドビュー表示用データ保持用変数
        /// </summary>
        private DataTable sauceDataTable = new DataTable();

        /// <summary>
        /// 表示データテーブル取得用プロパティ
        /// </summary>
        public DataTable SauceDataTable
        {
            get { return sauceDataTable; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GridViewDataList()
        {
            InitializeComponent();
            this.InitGridView();
            this.InitSauceDataTable();
        }

        /// <summary>
        /// セル値変更時イベント
        /// </summary>
        /// <param name="sender">イベント発生元コントロール</param>
        /// <param name="e">イベント情報</param>
        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 選択されている行インデックス、列インデックス、値を取得
            string selectedValue = string.Empty;
            int selectedRow = -1;
            int selectedCol = -1;
            foreach (DataGridViewCell c in this.dataGridView.SelectedCells)
            {
                selectedRow = c.RowIndex;
                selectedCol = c.ColumnIndex;
                selectedValue = Convert.ToString(this.dataGridView.Rows[c.RowIndex].Cells[c.ColumnIndex].Value);
            }

            if (this.sauceDataTable.Rows.Count == 0) return;

            // 保持用データテーブルに値を反映
            this.sauceDataTable.Rows[selectedRow][selectedCol] = selectedValue;
        }

        /// <summary>
        /// グリッドビュー初期設定
        /// </summary>
        private void InitGridView()
        {
            // カラム追加
            this.dataGridView.Columns.Add(COL_FUND_NAME, "ファンド名");
            this.dataGridView.Columns.Add(COL_FUND_TYPE, "ファンド種別");
            this.dataGridView.Columns.Add(COL_GET_VALUE, "取得金額");
            this.dataGridView.Columns.Add(COL_EVALUATION_VALUE, "評価金額");
            this.dataGridView.Columns.Add(COL_DIFF_VALUE_EN, "評価差額(円)");
            this.dataGridView.Columns.Add(COL_DIFF_VALUE_PER, "評価差額(%)");

            // カラム幅
            this.dataGridView.Columns[COL_FUND_NAME].Width = 240;
            this.dataGridView.Columns[COL_FUND_TYPE].Width = 100;
            this.dataGridView.Columns[COL_GET_VALUE].Width = 80;
            this.dataGridView.Columns[COL_EVALUATION_VALUE].Width = 80;
            this.dataGridView.Columns[COL_DIFF_VALUE_EN].Width = 80;
            this.dataGridView.Columns[COL_DIFF_VALUE_PER].Width = 80;

            // 金額をカンマ区切りにする
            this.dataGridView.Columns[COL_GET_VALUE].DefaultCellStyle.Format = "#,0";
            this.dataGridView.Columns[COL_EVALUATION_VALUE].DefaultCellStyle.Format = "#,0";
            this.dataGridView.Columns[COL_DIFF_VALUE_EN].DefaultCellStyle.Format = "#,0";
        }

        /// <summary>
        /// データ保持用データテーブル初期設定
        /// </summary>
        private void InitSauceDataTable()
        {
            this.sauceDataTable = new DataTable("FUND_LIST");
            this.sauceDataTable.Columns.Add(COL_FUND_NAME, typeof(string));
            this.sauceDataTable.Columns.Add(COL_FUND_TYPE, typeof(string));
            this.sauceDataTable.Columns.Add(COL_GET_VALUE, typeof(decimal));
            this.sauceDataTable.Columns.Add(COL_EVALUATION_VALUE, typeof(decimal));
            this.sauceDataTable.Columns.Add(COL_DIFF_VALUE_EN, typeof(decimal));
            this.sauceDataTable.Columns.Add(COL_DIFF_VALUE_PER, typeof(string));
        }

        /// <summary>
        /// 初期化処理
        /// </summary>
        public void Clear()
        {
            this.sauceDataTable.Rows.Clear();
            this.dataGridView.Rows.Clear();
        }

        /// <summary>
        /// グリッドビューに表示するデータを追加
        /// </summary>
        /// <param name="data">追加して表示するデータ</param>
        public void AddData(DataTable data)
        {
            this.AddDataToSauceTable(data);
            this.SetDataToGridView();
        }

        /// <summary>
        /// データ保持用データテーブルに受け取ったデータを追加
        /// </summary>
        /// <param name="dataTable">追加するデータテーブル</param>
        private void AddDataToSauceTable(DataTable dataTable)
        {
            if (dataTable == null && dataTable.Rows.Count == 0) return;

            // データを保持用のデータテーブルに追加する
            foreach (DataRow row in dataTable.Rows)
            {
                DataRow newRow = this.sauceDataTable.NewRow();
                string fundName = string.Empty;

                // 証券によってCSVヘッダー名が異なる
                // ファンド名
                if (row.Table.Columns.Contains("ファンド名"))
                {
                    // SBI
                    fundName = Convert.ToString(row["ファンド名"]);
                }
                if (row.Table.Columns.Contains("ファンド"))
                {
                    // 楽天
                    fundName = Convert.ToString(row["ファンド"]);
                }
                newRow[COL_FUND_NAME] = fundName;

                // 種別
                newRow[COL_FUND_TYPE] = FundTypeMaster.FindFundType(fundName);

                // 取得金額
                if (row.Table.Columns.Contains("買付金額"))
                {
                    // SBI
                    newRow[COL_GET_VALUE] = row["買付金額"];
                }
                if (row.Table.Columns.Contains("取得総額[円]"))
                {
                    // 楽天
                    newRow[COL_GET_VALUE] = row["取得総額[円]"];
                }

                // 評価額　
                if (row.Table.Columns.Contains("評価金額"))
                {
                    // SBI
                    newRow[COL_EVALUATION_VALUE] = row["評価金額"];
                }
                if (row.Table.Columns.Contains("時価評価額[円]"))
                {
                    // 楽天
                    newRow[COL_EVALUATION_VALUE] = row["時価評価額[円]"];
                }

                // 評価差額(円)
                if (row.Table.Columns.Contains("トータルリターン（円）"))
                {
                    // SBI
                    newRow[COL_DIFF_VALUE_EN] = row["トータルリターン（円）"];
                }
                if (row.Table.Columns.Contains("評価損益[円]"))
                {
                    // 楽天
                    newRow[COL_DIFF_VALUE_EN] = row["評価損益[円]"];
                }

                // 評価差額(%)
                if (row.Table.Columns.Contains("トータルリターン（率）"))
                {
                    // SBI
                    newRow[COL_DIFF_VALUE_PER] = row["トータルリターン（率）"];
                }
                if (row.Table.Columns.Contains("評価損益[％]"))
                {
                    // 楽天
                    newRow[COL_DIFF_VALUE_PER] = row["評価損益[％]"];
                }

                this.sauceDataTable.Rows.Add(newRow);
            }
        }

        /// <summary>
        /// グリッドビューにデータをセット
        /// </summary>
        private void SetDataToGridView()
        {
            // 一旦グリッドビューをクリア
            this.dataGridView.Rows.Clear();

            // グリッドビューにソースデータをセット
            foreach(DataRow row in this.sauceDataTable.Rows)
            {
                this.dataGridView.Rows.Add(row[COL_FUND_NAME], row[COL_FUND_TYPE], row[COL_GET_VALUE],
                    row[COL_EVALUATION_VALUE], row[COL_DIFF_VALUE_EN], row[COL_DIFF_VALUE_PER]);
            }
        }
    }
}
