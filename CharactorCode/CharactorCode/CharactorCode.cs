using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactorCode
{
    /// <summary>
    /// 文字コード
    /// </summary>
    public static class CharactorCode
    {
        /// <summary>
        /// ASCII文字範囲
        /// </summary>
        public static readonly Range ASCII_RANGE = new Range((char)0x00, (char)0x7F);

        /// <summary>
        /// サロゲートペア前半部分範囲（代用符号位置）
        /// </summary>
        public static readonly Range HIGHT_SURROGATE_RANGE = new Range((char)0xD800, (char)0xDBFF);

        /// <summary>
        /// サロゲートペア後半部分範囲
        /// </summary>
        public static readonly Range LOW_SURROGATE_RANGE = new Range((char)0xDC00, (char)0xDFFF);

        /// <summary>
        /// 基本多言語面範囲
        /// </summary>
        public static readonly List<Range> BPM_RANGE_WITHOUT_SURROGATE = new List<Range>()
        {
            new Range((char)0x0000,(char)0x1FFF),   // 一般スクリプト
            new Range((char)0x2000,(char)0x2DFF),   // 記号
            new Range((char)0x2E00,(char)0x33FF),   // CJKの表音文字と記号
            new Range((char)0x3400,(char)0x9FFF),   // CJK統合漢字
            new Range((char)0xA000,(char)0xA4CF),   // 彝文字
            new Range((char)0xAC00,(char)0xD743),   // ハングル音節
            new Range((char)0xE000,(char)0xF8FF),   // 私用
            new Range((char)0xF900,(char)0xFFFD),   // 互換文字と特殊文字
        };
    }
}
