namespace SplitCost
{
    /// <summary>
    /// 割り勘を表すクラス
    /// </summary>
    internal class SplitCost
    {
        #region コンストラクタ

        public SplitCost()
        {

        }

        #endregion

        #region プロパティ

        /// <summary>
        /// 一人当たりの金額
        /// </summary>
        internal int PricePerPeson
        {
            get;
            set;
        }

        /// <summary>
        /// 余り
        /// </summary>
        internal int Remainder
        {
            get;
            set;
        }

        #endregion
    }
}
