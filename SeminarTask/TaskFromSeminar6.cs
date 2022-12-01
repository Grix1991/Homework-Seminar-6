/*
Задачу с 6 семинара на сложение\вычитание двух многочленов.
Сделать красивый вывод.
Подумать над перемножением
*/

int[] Sum(int[] f, int[] g)
{
  int powF = f.Length;
  int powG = g.Length;

  int resultMax = powF;
  int resultMin = powG;

  if (powG > resultMax)
  {
    resultMax = powG;
    resultMin = powF;
  }

int[] result = new int[resultMax];

for (int i = 0; i < resultMin; i++)
{
    result[i] = f[i] + g[i];
}

for (int i = 0; i < resultMax; i++)
{
  if (resultMax == powG) result[i] = g[i];
   else result[i] = f[i];
   }
  return result;
}

int[] Dif(int[] f, int[] g)

{
  int powF = f.Length;
  int powG = g.Length;

  int resultMax = powF;
  int resultMin = powG;

  if (powG > resultMax)
  {
    resultMax = powG;
    resultMin = powF;
  }

  int[] result = new int[resultMax];

  for (int i = 0; i < resultMin; i++)
  {
    result[i] = f[i] - g[i];
  }

  for (int i = resultMin; i < resultMax; i++)
  {
    if (resultMax == powG) result[i] = -g[i];
    else result[i] = f[i];
  }

  return result;
}

string Print(int[] f)
{
    string output = String.Empty;
  for (int i = 0; i < f.Length; i++)
  {
    int t = f[i];
    if (f[i] == 0) continue;
    if (f[i] < 0) { output += " - "; }
    else if (i != 0 && (i-1) != 0) { output += " + "; } 
                                                      
     
    if (t < 0) t = -t;
    if (i == 1) { output += $"{t}x"; }
    if (i == 0) { output += $"{t}"; }
    if (i != 1 && i != 0 && i > 1 && f[i] != 0) { output += $"{t}x^{i}";}
    
  }
  return output;
}

int[] f = { 1, 0, 0, 0, -9, -6 };
int[] g = { 0, 1, -2, -5, 0, 0, 7, 3};
Console.WriteLine(Print(f));
Console.WriteLine(Print(g));
Console.WriteLine();
int[] s = Sum(f, g);
Console.WriteLine($"Сумма = {Print(s)}");
int[] d = Dif(f, g);
Console.WriteLine($"Разность = {Print(d)}");
Console.WriteLine();