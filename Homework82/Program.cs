using System;
//1
//class Program
//{
//	static void Main()
//	{
//		int[,] array = new int[5, 4];
//		Random random = new Random();
//		Console.WriteLine("Масив:");
//		for (int i = 0; i < array.GetLength(0); i++)
//		{
//			for (int j = 0; j < array.GetLength(1); j++)
//			{
//				array[i, j] = random.Next(1, 101);
//				Console.Write(array[i, j] + "\t");
//			}
//			Console.WriteLine();
//		}
//		int max = array[0, 0];
//		int min = array[0, 0];
//		for (int i = 0; i < array.GetLength(0); i++)
//		{
//			for (int j = 0; j < array.GetLength(1); j++)
//			{
//				if (array[i, j] > max)
//					max = array[i, j];
//				if (array[i, j] < min)
//					min = array[i, j];
//			}
//		}
//		Console.WriteLine($"\nМаксимальний елемент в масиві: {max}");
//		Console.WriteLine($"Мінімальний елемент в масиві: {min}");
//		for (int i = 0; i < array.GetLength(0); i++)
//		{
//			int rowMax = array[i, 0];
//			int rowMin = array[i, 0];
//			for (int j = 0; j < array.GetLength(1); j++)
//			{
//				if (array[i, j] > rowMax)
//					rowMax = array[i, j];
//				if (array[i, j] < rowMin)
//					rowMin = array[i, j];
//			}
//			Console.WriteLine($"\nРядок {i + 1} - Максимальний: {rowMax}, Мінімальний: {rowMin}");
//		}
//	}
//}


//2
//using System;
//
//class Program
//{
//	static void Main()
//	{
//		Console.WriteLine("Введіть рядок:");
//		string input = Console.ReadLine();
//		string result = "";
//		foreach (char c in input)
//		{
//			if (char.IsUpper(c))
//			{
//				result += char.ToLower(c);
//			}
//			else if (char.IsLower(c))
//			{
//				result += char.ToUpper(c);
//			}
//			else
//			{
//				result += c;
//			}
//		}
//		Console.WriteLine("Результат: " + result);
//	}
//}

//3
//using System;
//
//class Program
//{
//	static void Main()
//	{
//		Console.WriteLine("Введіть рядок, що містить кілька слів:");
//		string input = Console.ReadLine();
//		string[] words = input.Split(' ');
//
//		Console.WriteLine("Окремі слова:");
//		foreach (string word in words)
//		{
//			Console.WriteLine(word);
//		}
//	}
//}

//4
//class Program
//{
//	static void Main()
//	{
//		Console.WriteLine("Введіть текст:");
//		string input = Console.ReadLine();
//		bool hasFiveConsecutiveChars = HasFiveConsecutiveChars(input);
//		if (hasFiveConsecutiveChars)
//		{
//			Console.WriteLine("В тексті є п'ять і більше однакових символів, що йдуть підряд.");
//		}
//		else
//		{
//			Console.WriteLine("В тексті немає п'яти однакових символів, що йдуть підряд.");
//		}
//	}
//	static bool HasFiveConsecutiveChars(string input)
//	{
//		if (string.IsNullOrEmpty(input))
//		{
//			return false;
//		}
//		int count = 1;
//		for (int i = 1; i < input.Length; i++)
//		{
//			if (input[i] == input[i - 1])
//			{
//				count++;
//				if (count >= 5)
//				{
//					return true;
//				}
//			}
//			else
//			{
//				count = 1;
//			}
//		}
//		return false;
//	}
//}

//5
//struct Client
//{
//	public int ClientCode;
//	public string FullName;
//	public string Address;
//	public string Phone;
//	public int OrderCount;
//	public decimal TotalOrderAmount;
//	public Client(int clientCode, string fullName, string address, string phone, int orderCount, decimal totalOrderAmount)
//	{
//		ClientCode = clientCode;
//		FullName = fullName;
//		Address = address;
//		Phone = phone;
//		OrderCount = orderCount;
//		TotalOrderAmount = totalOrderAmount;
//	}
//	public void Print()
//	{
//		Console.WriteLine("Код клієнта: " + ClientCode);
//		Console.WriteLine("ПІБ: " + FullName);
//		Console.WriteLine("Адреса: " + Address);
//		Console.WriteLine("Телефон: " + Phone);
//		Console.WriteLine("Кількість замовлень: " + OrderCount);
//		Console.WriteLine("Загальна сума замовлень: " + TotalOrderAmount);
//	}
//}
//
//class Program
//{
//	static void Main()
//	{
//		Client client = new Client(
//			clientCode: 12345,
//			fullName: "Іванов Іван Іванович",
//			address: "м. Київ, вул. Хрещатик, буд. 1",
//			phone: "+380501234567",
//			orderCount: 10,
//			totalOrderAmount: 15000.50m
//		);
//		client.Print();
//	}
//}