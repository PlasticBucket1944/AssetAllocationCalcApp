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
            this.gridViewImportList = new AssetAllocationCalcApp.GridViewDataList();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 384);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(79, 46);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "取り込み";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // textImportPath
            // 
            this.textImportPath.Location = new System.Drawing.Point(101, 405);
            this.textImportPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textImportPath.Name = "textImportPath";
            this.textImportPath.Size = new System.Drawing.Size(595, 22);
            this.textImportPath.TabIndex = 1;
            // 
            // lblImportInfo
            // 
            this.lblImportInfo.Location = new System.Drawing.Point(101, 384);
            this.lblImportInfo.Name = "lblImportInfo";
            this.lblImportInfo.Size = new System.Drawing.Size(595, 18);
            this.lblImportInfo.TabIndex = 2;
            this.lblImportInfo.Text = "ここに取り込み結果が表示されますここに取り込み結果が表示されますここに取り込み結果が表示されますここに取り込み結果が表示されますここに取り込み結果が表示されます";
            // 
            // btnImportComplete
            // 
            this.btnImportComplete.Location = new System.Drawing.Point(709, 384);
            this.btnImportComplete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportComplete.Name = "btnImportComplete";
            this.btnImportComplete.Size = new System.Drawing.Size(79, 46);
            this.btnImportComplete.TabIndex = 4;
            this.btnImportComplete.Text = "取り込み確定";
            this.btnImportComplete.UseVisualStyleBackColor = true;
            this.btnImportComplete.Click += new System.EventHandler(this.BtnImportComplete_Click);
            // 
            // gridViewImportList
            // 
            this.gridViewImportList.Location = new System.Drawing.Point(12, 12);
            this.gridViewImportList.Name = "gridViewImportList";
            this.gridViewImportList.Size = new System.Drawing.Size(776, 356);
            this.gridViewImportList.TabIndex = 5;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridViewImportList);
            this.Controls.Add(this.btnImportComplete);
            this.Controls.Add(this.lblImportInfo);
            this.Controls.Add(this.textImportPath);
            this.Controls.Add(this.btnImport);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InputForm";
            this.Text = "CSV取り込み画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox textImportPath;
        private System.Windows.Forms.Label lblImportInfo;
        private System.Windows.Forms.Button btnImportComplete;
        private GridViewDataList gridViewImportList;
    }
}

