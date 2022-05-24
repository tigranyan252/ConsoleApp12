int[] array = new int[15];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
    array[i] = rnd.Next(-5, 5);

Console.WriteLine(array.Count(a => a < 0));