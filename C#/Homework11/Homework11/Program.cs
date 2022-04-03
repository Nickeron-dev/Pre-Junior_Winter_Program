int[] s = { 0, 0, -2, -6, -100, 0, 0, 0 };
int[] dp = new int[9];
dp[0] = 0; dp[1] = s[0];
for (int i = 2; i < 9; i++) {
    dp[i] = Math.Max(dp[i - 1], dp[i - 2]) + s[i - 1];
    Console.WriteLine(dp[i]);
}
Console.WriteLine($"Сума чисел дорiвнює {dp[8]}");
