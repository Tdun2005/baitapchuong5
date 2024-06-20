using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tạo một Dictionary<TKey, TValue>
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        // Thêm các cặp key-value vào Dictionary
        dictionary.Add("apple", 50);
        dictionary.Add("banana", 30);
        dictionary.Add("cherry", 20);

        // Kiểm tra sự tồn tại của một key
        Console.WriteLine($"Dictionary contains key 'apple': {dictionary.ContainsKey("apple")}");
        Console.WriteLine($"Dictionary contains key 'pear': {dictionary.ContainsKey("pear")}");

        // Truy xuất giá trị của một key một cách an toàn
        int value;
        if (dictionary.TryGetValue("banana", out value))
        {
            Console.WriteLine($"Value associated with key 'banana': {value}");
        }
        else
        {
            Console.WriteLine("Key 'banana' not found in dictionary");
        }

        // Duyệt và in ra các cặp key-value trong Dictionary
        Console.WriteLine("\nContents of Dictionary:");
        foreach (var pair in dictionary)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }
    }
}
