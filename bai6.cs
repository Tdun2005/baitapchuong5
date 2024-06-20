using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Tạo một Hashtable
        Hashtable hashtable = new Hashtable();

        // Thêm các cặp key-value vào Hashtable
        hashtable.Add("key1", 123);
        hashtable.Add(2, "value2");
        hashtable.Add("name", "John Doe");
        hashtable.Add(3.14, true);

        // Kiểm tra sự tồn tại của một key
        Console.WriteLine($"Hashtable contains key 'key1': {hashtable.ContainsKey("key1")}");
        Console.WriteLine($"Hashtable contains key 'key2': {hashtable.ContainsKey("key2")}");

        // Kiểm tra sự tồn tại của một giá trị
        Console.WriteLine($"Hashtable contains value 123: {hashtable.ContainsValue(123)}");
        Console.WriteLine($"Hashtable contains value 'Jane Doe': {hashtable.ContainsValue("Jane Doe")}");

        // Truy xuất giá trị của một key
        Console.WriteLine($"Value associated with key 'name': {hashtable["name"]}");

        // Duyệt và in ra các key và giá trị trong Hashtable
        Console.WriteLine("\nContents of Hashtable:");
        foreach (var key in hashtable.Keys)
        {
            Console.WriteLine($"Key: {key}, Value: {hashtable[key]}");
        }
    }
}
