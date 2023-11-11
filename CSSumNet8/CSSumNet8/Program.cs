namespace CSSumNetFramework {
  static class Program {
    static int SumRecMaxTail(int max, int val, int result = 0) =>
      val < max ? SumRecMaxTail(max, val + 1, result + val) : result;

    public static void Main() {
      Console.WriteLine(SumRecMaxTail(300000, 1));
    }
  }
}