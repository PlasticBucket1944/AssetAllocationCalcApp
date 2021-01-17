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
        /// コンストラクタ
        /// </summary>
        /// <param name="dataTable">表示用データ</param>
        public ResultForm(DataTable dataTable)
        {
            InitializeComponent();
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
