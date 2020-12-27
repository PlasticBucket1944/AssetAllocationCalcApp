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
            this.btnInput = new System.Windows.Forms.Button();
            this.textInputPath = new System.Windows.Forms.TextBox();
            this.lblInputInfo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInputComplete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(12, 384);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(79, 46);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "取り込み";
            this.btnInput.UseVisualStyleBackColor = true;
            // 
            // textInputPath
            // 
            this.textInputPath.Location = new System.Drawing.Point(102, 405);
            this.textInputPath.Name = "textInputPath";
            this.textInputPath.Size = new System.Drawing.Size(595, 22);
            this.textInputPath.TabIndex = 1;
            // 
            // lblInputInfo
            // 
            this.lblInputInfo.Location = new System.Drawing.Point(102, 384);
            this.lblInputInfo.Name = "lblInputInfo";
            this.lblInputInfo.Size = new System.Drawing.Size(595, 18);
            this.lblInputInfo.TabIndex = 2;
            this.lblInputInfo.Text = "ここに取り込み結果が表示されますここに取り込み結果が表示されますここに取り込み結果が表示されますここに取り込み結果が表示されますここに取り込み結果が表示されます";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 356);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnInputComplete
            // 
            this.btnInputComplete.Location = new System.Drawing.Point(709, 384);
            this.btnInputComplete.Name = "btnInputComplete";
            this.btnInputComplete.Size = new System.Drawing.Size(79, 46);
            this.btnInputComplete.TabIndex = 4;
            this.btnInputComplete.Text = "取り込み確定";
            this.btnInputComplete.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInputComplete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblInputInfo);
            this.Controls.Add(this.textInputPath);
            this.Controls.Add(this.btnInput);
            this.Name = "InputForm";
            this.Text = "CSV取り込み画面";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox textInputPath;
        private System.Windows.Forms.Label lblInputInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInputComplete;
    }
}

