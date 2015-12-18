using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpStudy0._20151217160000
{
    /// <summary>
    /// <para>最大値を求める。</para>
    /// <para>System.Math.Max()は2つの数のみだが、任意の個数を対象にできる。</para>
    /// </summary>
    public class Maximum
    {
        /// <summary>
        /// 引数の中から最小値を返す。
        /// </summary>
        /// <param name="values">最小値を求めたい値（任意個数）</param>
        /// <returns>最小値</returns>
        public static decimal Max(params decimal[] values)
        {
            if (values.Length == 0) { throw new ArgumentException("引数を1つ以上設定してください。"); }
            if (values.Length == 1) { return values[0]; }
            if (values.Length == 2) { return System.Math.Max(values[0], values[1]); }

            // 引数から最小値を求める（引数の最小値は約数の最大値でありうる）
            decimal max = System.Math.Max(values[0], values[1]);
            decimal tmp = 0;
            for (int i = 1; i < values.Length - 1; i++)
            {
                tmp = System.Math.Max(values[i], values[(i + 1)]);
                if (max < tmp) { max = tmp; }
            }
            return max;
        }
    }
}
