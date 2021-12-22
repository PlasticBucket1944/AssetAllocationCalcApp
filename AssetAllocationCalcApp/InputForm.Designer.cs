namespace AssetAllocationCalcApp
{
    partial class InputForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImport = new System.Windows.Forms.Button();
            this.textImportPath = new System.Windows.Forms.TextBox();
            this.lblImportInfo = new System.Windows.Forms.Label();
            this.btnImportComplete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.gridViewImportList = new AssetAllocationCalcApp.GridViewDataList();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(9, 396);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(59, 37);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "取り込み";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // textImportPath
            // 
            this.textImportPath.Location = new System.Drawing.Point(136, 413);
            this.textImportPath.Margin = new System.Windows.Forms.Padding(2);
            this.textImportPath.Name = "textImportPath";
            this.textImportPath.Size = new System.Drawing.Size(447, 19);
            this.textImportPath.TabIndex = 1;
            // 
            // lblImportInfo
            // 
            this.lblImportInfo.Location = new System.Drawing.Point(136, 396);
            this.lblImportInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImportInfo.Name = "lblImportInfo";
            this.lblImportInfo.Size = new System.Drawing.Size(446, 14);
            this.lblImportInfo.TabIndex = 2;
            this.lblImportInfo.Text = "ここに取り込み結果が表示されますここに取り込み結果が表示されますここに取り込み結果が表示されますここに取り込み結果が表示されますここに取り込み結果が表示されます";
            // 
            // btnImportComplete
            // 
            this.btnImportComplete.Location = new System.Drawing.Point(670, 396);
            this.btnImportComplete.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportComplete.Name = "btnImportComplete";
            this.btnImportComplete.Size = new System.Drawing.Size(59, 37);
            this.btnImportComplete.TabIndex = 4;
            this.btnImportComplete.Text = "取り込み確定";
            this.btnImportComplete.UseVisualStyleBackColor = true;
            this.btnImportComplete.Click += new System.EventHandler(this.BtnImportComplete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(604, 396);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 37);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.Location = new System.Drawing.Point(73, 396);
            this.btnFileSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(59, 37);
            this.btnFileSelect.TabIndex = 7;
            this.btnFileSelect.Text = " ファイル 選択";
            this.btnFileSelect.UseVisualStyleBackColor = true;
            this.btnFileSelect.Click += new System.EventHandler(this.BtnFileSelect_Click);
            // 
            // gridViewImportList
            // 
            this.gridViewImportList.Location = new System.Drawing.Point(9, 10);
            this.gridViewImportList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridViewImportList.Name = "gridViewImportList";
            this.gridViewImportList.Size = new System.Drawing.Size(732, 365);
            this.gridViewImportList.TabIndex = 5;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 440);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gridViewImportList);
            this.Controls.Add(this.btnImportComplete);
            this.Controls.Add(this.lblImportInfo);
            this.Controls.Add(this.textImportPath);
            this.Controls.Add(this.btnImport);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InputForm";
            this.Text = "CSV取り込み画面";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox textImportPath;
        private System.Windows.Forms.Label lblImportInfo;
        private System.Windows.Forms.Button btnImportComplete;
        private GridViewDataList gridViewImportList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFileSelect;
    }
}

