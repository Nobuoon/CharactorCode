using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactorCode
{
    public class CharactorCodeTester
    {
        /// <summary>
        /// 範囲を指定してテストする
        /// </summary>
        /// <param name="range">範囲を指定する</param>
        /// <param name="key">設定項目キーを指定する</param>
        /// <param name="checker">チェックメソッドを指定する</param>
        /// <param name="decision">判定メソッドを指定する</param>
        public void TestRange(Range range, string key, Func<string, string, bool> checker, Action<bool> decision)
        {
            range.Values.ForEach(c =>
            {
                decision(checker(key, c.ToString()));
            });
        }

        /// <summary>
        /// 中間範囲を指定してテストする
        /// </summary>
        /// <param name="range">全範囲を指定する</param>
        /// <param name="intermediateRangeList">中間範囲リストを指定する</param>
        /// <param name="key">設定項目キーを指定する</param>
        /// <param name="checker">チェックメソッドを指定する</param>
        /// <param name="intermediateRangeDecision">中間範囲内の判定メソッドを指定する</param>
        /// <param name="otherRangeDecision">中間範囲外の判定メソッドを指定する</param>
        public void TestRange(Range range, List<Range> intermediateRangeList, string key, Func<string, string, bool> checker, Action<bool> intermediateRangeDecision, Action<bool> otherRangeDecision)
        {
            range.Values.ForEach(c =>
            {
                if( true == intermediateRangeList.Any(r => r.Widhin(c)) )
                {
                    intermediateRangeDecision(checker(key, c.ToString()));
                }
                else
                {
                    otherRangeDecision(checker(key, c.ToString()));
                }
            });
        }
    }
}
