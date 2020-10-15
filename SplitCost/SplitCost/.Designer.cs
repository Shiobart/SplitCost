namespace SplitCost
{
    partial class MainForm
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
            this.lblTaxExcludedPrice = new System.Windows.Forms.Label();
            this.txtTaxExcludedPrice = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblYen = new System.Windows.Forms.Label();
            this.lblNumberOfPeople = new System.Windows.Forms.Label();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.lblPeople = new System.Windows.Forms.Label();
            this.lblPerPeople = new System.Windows.Forms.Label();
            this.lblRemainder = new System.Windows.Forms.Label();
            this.lblPerPeoplePrice = new System.Windows.Forms.Label();
            this.lblRemainderPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTaxExcludedPrice
            // 
            this.lblTaxExcludedPrice.AutoSize = true;
            this.lblTaxExcludedPrice.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTaxExcludedPrice.Location = new System.Drawing.Point(18, 53);
            this.lblTaxExcludedPrice.Name = "lblTaxExcludedPrice";
            this.lblTaxExcludedPrice.Size = new System.Drawing.Size(102, 27);
            this.lblTaxExcludedPrice.TabIndex = 0;
            this.lblTaxExcludedPrice.Text = "税抜き金額";
            // 
            // txtTaxExcludedPrice
            // 
            this.txtTaxExcludedPrice.Location = new System.Drawing.Point(18, 75);
            this.txtTaxExcludedPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaxExcludedPrice.Name = "txtTaxExcludedPrice";
            this.txtTaxExcludedPrice.Size = new System.Drawing.Size(153, 34);
            this.txtTaxExcludedPrice.TabIndex = 1;
            this.txtTaxExcludedPrice.Text = "0";
            this.txtTaxExcludedPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxExcludedPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxExcludedPrice_KeyPress);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCalculate.Location = new System.Drawing.Point(23, 291);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(454, 63);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "計算する";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblYen
            // 
            this.lblYen.AutoSize = true;
            this.lblYen.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblYen.Location = new System.Drawing.Point(177, 82);
            this.lblYen.Name = "lblYen";
            this.lblYen.Size = new System.Drawing.Size(30, 27);
            this.lblYen.TabIndex = 2;
            this.lblYen.Text = "円";
            // 
            // lblNumberOfPeople
            // 
            this.lblNumberOfPeople.AutoSize = true;
            this.lblNumberOfPeople.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumberOfPeople.Location = new System.Drawing.Point(285, 53);
            this.lblNumberOfPeople.Name = "lblNumberOfPeople";
            this.lblNumberOfPeople.Size = new System.Drawing.Size(48, 27);
            this.lblNumberOfPeople.TabIndex = 3;
            this.lblNumberOfPeople.Text = "人数";
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.Location = new System.Drawing.Point(285, 75);
            this.txtNumberOfPeople.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(153, 34);
            this.txtNumberOfPeople.TabIndex = 4;
            this.txtNumberOfPeople.Text = "0";
            this.txtNumberOfPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumberOfPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxExcludedPrice_KeyPress);
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPeople.Location = new System.Drawing.Point(444, 82);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(30, 27);
            this.lblPeople.TabIndex = 5;
            this.lblPeople.Text = "人";
            // 
            // lblPerPeople
            // 
            this.lblPerPeople.AutoSize = true;
            this.lblPerPeople.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPerPeople.Location = new System.Drawing.Point(18, 200);
            this.lblPerPeople.Name = "lblPerPeople";
            this.lblPerPeople.Size = new System.Drawing.Size(102, 27);
            this.lblPerPeople.TabIndex = 6;
            this.lblPerPeople.Text = "一人あたり";
            // 
            // lblRemainder
            // 
            this.lblRemainder.AutoSize = true;
            this.lblRemainder.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRemainder.Location = new System.Drawing.Point(279, 200);
            this.lblRemainder.Name = "lblRemainder";
            this.lblRemainder.Size = new System.Drawing.Size(48, 27);
            this.lblRemainder.TabIndex = 8;
            this.lblRemainder.Text = "余り";
            // 
            // lblPerPeoplePrice
            // 
            this.lblPerPeoplePrice.AutoSize = true;
            this.lblPerPeoplePrice.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPerPeoplePrice.Location = new System.Drawing.Point(18, 240);
            this.lblPerPeoplePrice.Name = "lblPerPeoplePrice";
            this.lblPerPeoplePrice.Size = new System.Drawing.Size(0, 27);
            this.lblPerPeoplePrice.TabIndex = 7;
            // 
            // lblRemainderPrice
            // 
            this.lblRemainderPrice.AutoSize = true;
            this.lblRemainderPrice.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRemainderPrice.Location = new System.Drawing.Point(279, 240);
            this.lblRemainderPrice.Name = "lblRemainderPrice";
            this.lblRemainderPrice.Size = new System.Drawing.Size(0, 27);
            this.lblRemainderPrice.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 369);
            this.Controls.Add(this.lblRemainderPrice);
            this.Controls.Add(this.lblPerPeoplePrice);
            this.Controls.Add(this.lblRemainder);
            this.Controls.Add(this.lblPerPeople);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.txtNumberOfPeople);
            this.Controls.Add(this.lblNumberOfPeople);
            this.Controls.Add(this.lblYen);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTaxExcludedPrice);
            this.Controls.Add(this.lblTaxExcludedPrice);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "割り勘";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaxExcludedPrice;
        private System.Windows.Forms.TextBox txtTaxExcludedPrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblYen;
        private System.Windows.Forms.Label lblNumberOfPeople;
        private System.Windows.Forms.TextBox txtNumberOfPeople;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Label lblPerPeople;
        private System.Windows.Forms.Label lblRemainder;
        private System.Windows.Forms.Label lblPerPeoplePrice;
        private System.Windows.Forms.Label lblRemainderPrice;
    }
}

