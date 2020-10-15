using System;

namespace SplitCost
{
    /// <summary>
    /// 処理結果を表すクラス
    /// </summary>
    public class Result
    {
        #region コンストラクター

        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="isSuccess"></param>
        public Result(bool isSuccess)
        {
            this.IsSuccess = isSuccess;
        }

        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="isSuccess"></param>
        /// <param name="message"></param>
        public Result(bool isSuccess, string errorMessage, Exception exception = null)
        {
            this.IsSuccess = isSuccess;
            this.ErrorMessage = errorMessage;
            this.Exception = exception;
        }

        #endregion

        #region プロパティ

        public bool IsSuccess
        {
            get;
            set;
        }

        public string ErrorMessage
        {
            get;
            set;
        }

        public Exception Exception
        {
            get;
            set;
        }

        #endregion
    }
}
