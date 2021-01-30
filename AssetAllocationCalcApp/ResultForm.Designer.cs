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
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textGetValueAll = new System.Windows.Forms.TextBox();
            this.textEvaluationValueAll = new System.Windows.Forms.TextBox();
            this.gridViewDataList = new AssetAllocationCalcApp.ResultGridViewDataList();
            this.textDiffAllValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "取得金額合計";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "評価金額合計";
            // 
            // textGetValueAll
            // 
            this.textGetValueAll.Location = new System.Drawing.Point(451, 476);
            this.textGetValueAll.Name = "textGetValueAll";
            this.textGetValueAll.Size = new System.Drawing.Size(148, 22);
            this.textGetValueAll.TabIndex = 4;
            // 
            // textEvaluationValueAll
            // 
            this.textEvaluationValueAll.Location = new System.Drawing.Point(451, 504);
            this.textEvaluationValueAll.Name = "textEvaluationValueAll";
            this.textEvaluationValueAll.Size = new System.Drawing.Size(148, 22);
            this.textEvaluationValueAll.TabIndex = 5;
            // 
            // gridViewDataList
            // 
            this.gridViewDataList.Location = new System.Drawing.Point(13, 13);
            this.gridViewDataList.Name = "gridViewDataList";
            this.gridViewDataList.Size = new System.Drawing.Size(976, 456);
            this.gridViewDataList.TabIndex = 0;
            // 
            // textDiffAllValue
            // 
            this.textDiffAllValue.Location = new System.Drawing.Point(716, 504);
            this.textDiffAllValue.Name = "textDiffAllValue";
            this.textDiffAllValue.Size = new System.Drawing.Size(148, 22);
            this.textDiffAllValue.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "評価差額";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.textDiffAllValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textEvaluationValueAll);
            this.Controls.Add(this.textGetValueAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.gridViewDataList);
            this.Name = "ResultForm";
            this.Text = "取り込み結果画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ResultGridViewDataList gridViewDataList;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textGetValueAll;
        private System.Windows.Forms.TextBox textEvaluationValueAll;
        private System.Windows.Forms.TextBox textDiffAllValue;
        private System.Windows.Forms.Label label3;
    }
}