// тестовый массив
string[] array01 = { "hello", "2", "world", ":-)" };
string[] array02 = { "1234", "1567", "-2", "computer sciennce" };
string[] array03 = { "Russia", "Denmark", "Kazan" };

string[] FindShortStringInArray(string[] arrayStr)
{
  int len = arrayStr.Length;
  string[] res = new string[len];

  for (int i = 0; i < len; i++)
  {
    int itemLength = arrayStr[i].Length;
    res[i] = itemLength <= 3 ? arrayStr[i] : "";
  }

  return res;
}

Console.WriteLine(string.Join(" ", FindShortStringInArray(array01)));
Console.WriteLine(string.Join(" ", FindShortStringInArray(array02)));
Console.WriteLine(string.Join(" ", FindShortStringInArray(array03)));
