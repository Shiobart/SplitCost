using System;
using System.Windows.Forms;

namespace SplitCost
{
    /// <summary>
    /// メインフォーム
    /// </summary>
    public partial class MainForm : Form
    {
        #region コンストラクタ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region イベントハンドラ

        /// <summary>
        /// キープレスイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTaxExcludedPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\r' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 計算するボタン押下時イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int excludingTaxPrice;
            Result result = DovalidationExcludingTaxPrice(out excludingTaxPrice);
            if(!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage);
                return;
            }

            int IncludingTaxPrice = this.CalculateIncludingTaxPrice(excludingTaxPrice);

            int numberOfPeople;
            result = DovalidationNumberOfPeople(out numberOfPeople);
            if(!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage);
                return;
            }

            SplitCost splitCost = this.CalculatePricePerPerson(IncludingTaxPrice, numberOfPeople);

            this.SetView(splitCost);
        }

        #endregion

        #region privateメソッド

        private void SetView(SplitCost splitCost)
        {
            this.lblPerPeoplePrice.Text = splitCost.PricePerPeson.ToString() + "円";
            this.lblRemainderPrice.Text = splitCost.Remainder.ToString();
        }

        /// <summary>
        /// 税抜き金額の入力値を検証します
        /// </summary>
        /// <param name="excludingTaxPrice">税抜き金額</param>
        /// <returns>処理結果</returns>
        private Result DovalidationExcludingTaxPrice(out int excludingTaxPrice)
        {
            excludingTaxPrice = 0;
            if (!int.TryParse(this.txtTaxExcludedPrice.Text, out excludingTaxPrice))
            {
                return new Result(false, "税抜き金額の入力に誤りがあります");
            }

            return new Result(true);
        }

        /// <summary>
        /// 人数の入力値を検証します
        /// </summary>
        /// <param name="numberOfPeople">人数</param>
        /// <returns>処理結果</returns>
        private Result DovalidationNumberOfPeople(out int numberOfPeople)
        {
            numberOfPeople = 0;
            if(!int.TryParse(this.txtNumberOfPeople.Text,out numberOfPeople))
            {
                return new Result(false, "人数の入力に誤りがあります");
            }

            return new Result(true);
        }

        /// <summary>
        /// 消費税込み金額を計算します
        /// </summary>
        /// <param name="excludingTaxPrice">税抜き金額</param>
        /// <returns>消費税込み金額</returns>
        private int CalculateIncludingTaxPrice(int excludingTaxPrice)
        {
            const double SALES_TAX = 1.1;
            return (int)(excludingTaxPrice * SALES_TAX);
        }

        /// <summary>
        /// 一人あたりの金額を算出します
        /// </summary>
        /// <param name="includingTaxPrice">消費税込み金額</param>
        /// <param name="numberOfPeople">人数</param>
        /// <returns>割り勘</returns>
        private SplitCost CalculatePricePerPerson(int includingTaxPrice, int numberOfPeople)
        {
            SplitCost splitCost = new SplitCost();

            splitCost.PricePerPeson= includingTaxPrice / numberOfPeople;
            splitCost.Remainder = includingTaxPrice % numberOfPeople;

            return splitCost;
        }

        #endregion
    }
}
