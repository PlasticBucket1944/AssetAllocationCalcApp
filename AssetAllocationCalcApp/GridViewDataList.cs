using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetAllocationCalcApp
{
    /// <summary>
    /// データ表示用グリッドビュークラス
    /// </summary>
    public partial class GridViewDataList : UserControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GridViewDataList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// テスト用クラス　後で消す
        /// </summary>
        public void Add(DataTable data)
        {
            this.dataGridView.DataSource = data;
        }
    }
}
