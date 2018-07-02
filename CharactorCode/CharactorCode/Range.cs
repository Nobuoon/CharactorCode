using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactorCode
{
    public class Range
    {
        /// <summary>
        /// 下限値
        /// </summary>
        public char Lower { get; private set; }

        /// <summary>
        /// 上限値
        /// </summary>
        public char Uppder { get; private set; }

        /// <summary>
        /// 範囲内の全ての値
        /// </summary>
        public List<char> Values
        {
            get
            {
                var values = new List<char>();
                for (char c = this.Lower; c <= this.Uppder; c++)
                {
                    values.Add(c);
                }
                return values;
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="lower">下限値を指定する</param>
        /// <param name="upper">上限値を指定する</param>
        public Range(char lower, char upper)
        {
            if( lower > upper )
            {
                throw new ArgumentException();
            }

            this.Lower = lower;
            this.Uppder = upper;
        }

        /// <summary>
        /// 範囲内か確認する
        /// </summary>
        /// <param name="value">チェック対象の値</param>
        /// <returns>
        /// true：範囲内
        /// false：範囲外
        /// </returns>
        public bool Widhin(char value)
        {
            return (this.Lower <= value) && (value <= this.Uppder);
        }
    }
}
