using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSumNetFramework {
  static class Program {
    static Action<ulong> OutputResult(string prefix) => (ulong value) => Console.WriteLine($"{prefix}: {value}");

    static ulong SumRecMaxTail(ulong max, ulong val, ulong result = 0) {
      if (val < max)
        return SumRecMaxTail(max, val + 1, result + val);
      else
        return result;
    }

    static IEnumerable<ulong> Range(ulong start, ulong count) {
      for (ulong x = start; x < start + count; x++) {
        yield return x;
      }
    }

    public static void Main() {
      var longList = Range(1, 300000).ToArray();
      OutputResult("SumRecMaxTail long")(SumRecMaxTail(300000, 1));
    }
  }
}