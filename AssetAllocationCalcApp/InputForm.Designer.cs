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
            this.gridViewImportList = new System.Windows.Forms.DataGridView();
            this.btnImportComplete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewImportList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(9, 307);
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
            this.textImportPath.Location = new System.Drawing.Point(76, 324);
            this.textImportPath.Margin = new System.Windows.Forms.Padding(2);
            this.textImportPath.Name = "textImportPath";
            this.textImportPath.Size = new System.Drawing.Size(447, 19);
            this.textImportPath.TabIndex = 1;
            // 
            // lblImportInfo
            // 
            this.lblImportInfo.Location = new System.Drawing.Point(76, 307);
            this.lblImportInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImportInfo.Name = "lblImportInfo";
            this.lblImportInfo.Size = new System.Drawing.Size(446, 14);
            this.lblImportInfo.TabIndex = 2;
            this.lblImportInfo.Text = "ここに取り込み結果が表示されますここに取り込み結果が表示されますここに取り込み結果が表示されますここに取り込み結果が表示されますここに取り込み結果が表示されます";
            // 
            // gridViewImportList
            // 
            this.gridViewImportList.AllowUserToOrderColumns = true;
            this.gridViewImportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewImportList.Location = new System.Drawing.Point(9, 10);
            this.gridViewImportList.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewImportList.Name = "gridViewImportList";
            this.gridViewImportList.RowHeadersWidth = 51;
            this.gridViewImportList.RowTemplate.Height = 24;
            this.gridViewImportList.Size = new System.Drawing.Size(582, 285);
            this.gridViewImportList.TabIndex = 3;
            // 
            // btnImportComplete
            // 
            this.btnImportComplete.Location = new System.Drawing.Point(532, 307);
            this.btnImportComplete.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportComplete.Name = "btnImportComplete";
            this.btnImportComplete.Size = new System.Drawing.Size(59, 37);
            this.btnImportComplete.TabIndex = 4;
            this.btnImportComplete.Text = "取り込み確定";
            this.btnImportComplete.UseVisualStyleBackColor = true;
            this.btnImportComplete.Click += new System.EventHandler(this.BtnImportComplete_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btnImportComplete);
            this.Controls.Add(this.gridViewImportList);
            this.Controls.Add(this.lblImportInfo);
            this.Controls.Add(this.textImportPath);
            this.Controls.Add(this.btnImport);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InputForm";
            this.Text = "CSV取り込み画面";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewImportList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox textImportPath;
        private System.Windows.Forms.Label lblImportInfo;
        private System.Windows.Forms.DataGridView gridViewImportList;
        private System.Windows.Forms.Button btnImportComplete;
    }
}

