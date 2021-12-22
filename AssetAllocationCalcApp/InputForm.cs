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
    /// CSV取り込み画面
    /// </summary>
    public partial class InputForm : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public InputForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロード時イベント
        /// </summary>
        /// <param name="sender">イベント発生元コントロール</param>
        /// <param name="e">イベント情報</param>
        private void InputForm_Load(object sender, EventArgs e)
        {
            // exeと同ディレクトリからマスターデータを取得
            string messege = FundTypeMaster.ImportResultMessage;
            this.lblImportInfo.Text = messege;
        }

        /// <summary>
        /// 取り込みボタンクリック時イベント
        /// </summary>
        /// <param name="sender">イベント発生元コントロール</param>
        /// <param name="e">イベント情報</param>
        private void BtnImport_Click(object sender, EventArgs e)
        {
            Csv csv = new Csv();
            string messege = string.Empty;
            bool result = csv.ImportCsv(this.textImportPath.Text, out messege);

            this.lblImportInfo.Text = messege;
            if (!result) return;

            FundListWrapper fundList = new FundListWrapper(csv.ListHead, csv.ListBody);
            this.gridViewImportList.AddData(fundList.DtFundList);
        }

        /// <summary>
        /// 取り込み確定ボタンクリック時イベント
        /// </summary>
        /// <param name="sender">イベント発生元コントロール</param>
        /// <param name="e">イベント情報</param>
        private void BtnImportComplete_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm(gridViewImportList.SauceDataTable);
            resultForm.Show();
        }

        /// <summary>
        /// クリアボタンクリック時イベント
        /// </summary>
        /// <param name="sender">イベント発生元コントロール</param>
        /// <param name="e">イベント情報</param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.gridViewImportList.Clear();
        }

        /// <summary>
        /// ファイル選択ボタンクリック時イベント
        /// </summary>
        /// <param name="sender">イベント発生元コントロール</param>
        /// <param name="e">イベント情報</param>
        private void BtnFileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            //はじめに表示されるフォルダを指定
            fileDialog.InitialDirectory = @"C:\";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // ファイルダイアログで選択したパスをテキストボックスに代入
                this.textImportPath.Text = fileDialog.FileName;
            }
        }
    }
}
