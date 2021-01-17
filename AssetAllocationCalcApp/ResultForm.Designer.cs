namespace AssetAllocationCalcApp
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultGridViewDataList1 = new AssetAllocationCalcApp.ResultGridViewDataList();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultGridViewDataList1
            // 
            this.resultGridViewDataList1.Location = new System.Drawing.Point(13, 13);
            this.resultGridViewDataList1.Name = "resultGridViewDataList1";
            this.resultGridViewDataList1.Size = new System.Drawing.Size(976, 456);
            this.resultGridViewDataList1.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 495);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(79, 46);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.resultGridViewDataList1);
            this.Name = "ResultForm";
            this.Text = "取り込み結果画面";
            this.ResumeLayout(false);

        }

        #endregion

        private ResultGridViewDataList resultGridViewDataList1;
        private System.Windows.Forms.Button btnReturn;
    }
}