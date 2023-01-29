// тестовые массивы
string[] array01 = { "hello", "2", "world", ":-)" };
string[] array02 = { "1234", "1567", "-2", "computer sciennce" };
string[] array03 = { "Russia", "Denmark", "Kazan" };

//main function
string[] FindShortStringInArray(string[] arrayStr)
{
  int len = arrayStr.Length;
  string[] resPreparatory = new string[len];
  int counter = 0;

  for (int i = 0; i < len; i++)
  {
    int itemLength = arrayStr[i].Length;

    if (itemLength <= 3)
    {
      resPreparatory[i] = arrayStr[i];
      counter++;
    }
    else
    {
      resPreparatory[i] = "";
    }
  }

  string[] resFinaly = new string[counter];
  int resFinalyNumberItem = 0;

  for (int i = 0; i < len; i++)
  {
    if (resPreparatory[i] != "")
    {
      resFinaly[resFinalyNumberItem] = resPreparatory[i];
      resFinalyNumberItem++;
    }
  }

  return resFinaly;
}

Console.Write($"[{string.Join(", ", array01)}] -> ");
Console.WriteLine($"[{string.Join(", ", FindShortStringInArray(array01))}]");

Console.Write($"[{string.Join(", ", array02)}] -> ");
Console.WriteLine($"[{string.Join(", ", FindShortStringInArray(array02))}]");

Console.Write($"[{string.Join(", ", array03)}] -> ");
Console.WriteLine($"[{string.Join(", ", FindShortStringInArray(array03))}]");
