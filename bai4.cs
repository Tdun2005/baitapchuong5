using System;

class Program
{
    static T Max<T>(T x, T y) where T : IComparable<T>
    {
        return x.CompareTo(y) > 0 ? x : y;
    }

    static void Main()
    {
        // Kiểm tra với số nguyên
        int maxInt = Max(5, 10);
        Console.WriteLine($"Max of 5 and 10 is: {maxInt}");

        // Kiểm tra với số thực
        double maxDouble = Max(3.14, 2.71);
        Console.WriteLine($"Max of 3.14 and 2.71 is: {maxDouble}");

        // Kiểm tra với chuỗi
        string maxString = Max("apple", "banana");
        Console.WriteLine($"Max of 'apple' and 'banana' is: {maxString}");

        // Kiểm tra với DateTime
        DateTime date1 = new DateTime(2024, 6, 1);
        DateTime date2 = new DateTime(2024, 7, 1);
        DateTime maxDate = Max(date1, date2);
        Console.WriteLine($"Max date is: {maxDate}");

        // Kiểm tra với kiểu enum
        DayOfWeek day1 = DayOfWeek.Monday;
        DayOfWeek day2 = DayOfWeek.Friday;
        DayOfWeek maxDay = Max(day1, day2);
        Console.WriteLine($"Max day is: {maxDay}");
    }
}
