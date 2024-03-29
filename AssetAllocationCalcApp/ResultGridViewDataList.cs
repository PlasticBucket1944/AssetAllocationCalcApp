﻿using System;
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
    /// 取り込み結果データ表示用グリッドビュークラス
    /// </summary>
    public partial class ResultGridViewDataList : UserControl
    {
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
        /// カラム名：資産比率
        /// </summary>
        private const string COL_ASSET_PER = "ASSET_PER";

        /// <summary>
        /// グリッドビュー表示用データ保持用変数
        /// </summary>
        private DataTable sauceDataTable = new DataTable();

        /// <summary>
        /// 取得金額合計
        /// </summary>
        public decimal GetValueAll { get; private set; }

        /// <summary>
        /// 評価金額合計
        /// </summary>
        public decimal EvaluationValueAll { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ResultGridViewDataList()
        {
            InitializeComponent();
            this.InitGridView();
            this.InitSauceDataTable();
        }

        /// <summary>
        /// グリッドビュー初期設定
        /// </summary>
        private void InitGridView()
        {
            // カラム追加
            this.dataGridView.Columns.Add(COL_FUND_TYPE, "ファンド種別");
            this.dataGridView.Columns.Add(COL_GET_VALUE, "取得金額");
            this.dataGridView.Columns.Add(COL_EVALUATION_VALUE, "評価金額");
            this.dataGridView.Columns.Add(COL_ASSET_PER, "比率(%)");

            // カラム幅
            this.dataGridView.Columns[COL_FUND_TYPE].Width = 250;
            this.dataGridView.Columns[COL_GET_VALUE].Width = 80;
            this.dataGridView.Columns[COL_EVALUATION_VALUE].Width = 80;
            this.dataGridView.Columns[COL_ASSET_PER].Width = 80;

            // 金額をカンマ区切りにする
            this.dataGridView.Columns[COL_GET_VALUE].DefaultCellStyle.Format = "#,0";
            this.dataGridView.Columns[COL_EVALUATION_VALUE].DefaultCellStyle.Format = "#,0";
        }

        /// <summary>
        /// データ保持用データテーブル初期設定
        /// </summary>
        private void InitSauceDataTable()
        {
            this.sauceDataTable = new DataTable("FUND_LIST");
            this.sauceDataTable.Columns.Add(COL_FUND_TYPE, typeof(string));
            this.sauceDataTable.Columns.Add(COL_GET_VALUE, typeof(decimal));
            this.sauceDataTable.Columns.Add(COL_EVALUATION_VALUE, typeof(decimal));
            this.sauceDataTable.Columns.Add(COL_ASSET_PER, typeof(decimal));
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

                // 保持用データテーブル行に値を代入
                newRow[COL_FUND_TYPE] = row[COL_FUND_TYPE];
                newRow[COL_GET_VALUE] = row[COL_GET_VALUE];
                newRow[COL_EVALUATION_VALUE] = row[COL_EVALUATION_VALUE];

                // 総合計値を計算しておく
                this.GetValueAll += Convert.ToInt32(row[COL_GET_VALUE]);
                this.EvaluationValueAll += Convert.ToInt32(row[COL_EVALUATION_VALUE]);

                this.sauceDataTable.Rows.Add(newRow);
            }

            // 資産の割合を計算(%)
            foreach (DataRow row in this.sauceDataTable.Rows)
            {
                int value = Convert.ToInt32(row[COL_EVALUATION_VALUE]); // 評価額
                decimal per = (value / this.EvaluationValueAll) * 100; // 割合を%形式で計算
                row[COL_ASSET_PER] = Math.Round(per, 2, MidpointRounding.AwayFromZero); // 小数第三位で四捨五入
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
                this.dataGridView.Rows.Add(
                    row[COL_FUND_TYPE], row[COL_GET_VALUE], row[COL_EVALUATION_VALUE], row[COL_ASSET_PER]);
            }
        }
    }
}
