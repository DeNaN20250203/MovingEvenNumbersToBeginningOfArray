namespace MovingEvenNumbersBeginningOfArray_001
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
			int[] array = [1, 22, 33, 4, 15, 66, 22, 99, 98, 97, 96];
			Console.WriteLine(String.Join(", ", array));
			Console.WriteLine(String.Join(", ", (GetEvenOddOr(array))));
			Console.WriteLine(String.Join(", ", await (GetEvenOddAsync(array)).ToArrayAsync()));
			Console.WriteLine();
        }

		/// <summary>
		/// <para>Method…</para>
		/// <para>Асинхронно получает четные числа из массива, а затем нечетные числа.</para>
		/// </summary>
		/// <param name="array">Массив целых чисел.</param>
		/// <returns>Возвращает асинхронную последовательность целых чисел, 
		/// начинающуюся с четных чисел, затем нечетных.</returns>
		public static async IAsyncEnumerable<int> GetEvenOddAsync(int[] array)
		{
			await Task.Delay(1);
			foreach (var item in array)
				if (item % 2 == 0)
					yield return item;

			foreach (var item in array)
				if (item % 2 == 1)
					yield return item;
		}

		/// <summary>
		/// <para>Method…</para>
		/// <para>Получает четные числа из массива, а затем нечетные числа.</para>
		/// </summary>
		/// <param name="array">Массив целых чисел.</param>
		/// <returns>Возвращает последовательность целых чисел, 
		/// начинающуюся с четных чисел, затем нечетных.</returns>
		public static IEnumerable<int> GetEvenOddOr(int[] array)
		{
			foreach (var item in array)
				if (item % 2 == 0)
					yield return item;

			foreach (var item in array)
				if (item % 2 == 1)
					yield return item;
		}
	}
}
