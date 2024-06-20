using System;
using System.Collections.Generic;

namespace SimpleDictionary
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            // Thêm một số từ vào từ điển
            dictionary.Add("hello", "xin chào");
            dictionary.Add("world", "thế giới");
            dictionary.Add("computer", "máy tính");
            dictionary.Add("programming", "lập trình");
            dictionary.Add("book", "quyển sách");

            int choice;

            do
            {
                Console.WriteLine("1. Thêm từ mới");
                Console.WriteLine("2. Tra từ");
                Console.WriteLine("3. Thoát");
                Console.Write("Nhập lựa chọn của bạn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddWord(dictionary);
                        break;
                    case 2:
                        LookupWord(dictionary);
                        break;
                    case 3:
                        Console.WriteLine("Thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }

            } while (choice != 3);
        }

        static void AddWord(Dictionary<string, string> dictionary)
        {
            Console.Write("Nhập từ tiếng Anh: ");
            string englishWord = Console.ReadLine();
            Console.Write("Nhập nghĩa tiếng Việt: ");
            string vietnameseMeaning = Console.ReadLine();

            if (dictionary.ContainsKey(englishWord))
            {
                Console.WriteLine("Từ này đã có trong từ điển.");
            }
            else
            {
                dictionary.Add(englishWord, vietnameseMeaning);
                Console.WriteLine("Từ đã được thêm thành công.");
            }
        }

        static void LookupWord(Dictionary<string, string> dictionary)
        {
            Console.Write("Nhập từ tiếng Anh cần tra: ");
            string englishWord = Console.ReadLine();

            if (dictionary.ContainsKey(englishWord))
            {
                Console.WriteLine($"Nghĩa tiếng Việt: {dictionary[englishWord]}");
            }
            else
            {
                Console.WriteLine("Từ này không có trong từ điển.");
            }
        }
    }
}
