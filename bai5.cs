using System;
using System.Collections.Generic;

class MyStack<T>
{
    private List<T> stackList;

    public MyStack()
    {
        stackList = new List<T>();
    }

    public void Push(T item)
    {
        stackList.Add(item);
    }

    public T Pop()
    {
        if (stackList.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T item = stackList[stackList.Count - 1];
        stackList.RemoveAt(stackList.Count - 1);
        return item;
    }
}

class Program
{
    static void Main()
    {
        // Kiểm tra với kiểu dữ liệu là số nguyên (int)
        MyStack<int> intStack = new MyStack<int>();
        intStack.Push(1);
        intStack.Push(2);
        intStack.Push(3);

        Console.WriteLine("Pop from intStack: " + intStack.Pop()); // In ra 3
        Console.WriteLine("Pop from intStack: " + intStack.Pop()); // In ra 2
        Console.WriteLine("Pop from intStack: " + intStack.Pop()); // In ra 1

        // Kiểm tra với kiểu dữ liệu là chuỗi (string)
        MyStack<string> stringStack = new MyStack<string>();
        stringStack.Push("first");
        stringStack.Push("second");
        stringStack.Push("third");

        Console.WriteLine("Pop from stringStack: " + stringStack.Pop()); // In ra "third"
        Console.WriteLine("Pop from stringStack: " + stringStack.Pop()); // In ra "second"
        Console.WriteLine("Pop from stringStack: " + stringStack.Pop()); // In ra "first"

        // Thử pop từ stack rỗng (sẽ ném ngoại lệ)
        //Console.WriteLine("Pop from stringStack: " + stringStack.Pop());

        // Kiểm tra với kiểu dữ liệu là DateTime
        MyStack<DateTime> dateStack = new MyStack<DateTime>();
        dateStack.Push(new DateTime(2024, 6, 1));
        dateStack.Push(new DateTime(2024, 7, 1));

        Console.WriteLine("Pop from dateStack: " + dateStack.Pop()); // In ra ngày 1/7/2024

        // Kiểm tra với kiểu dữ liệu là kiểu enum (DayOfWeek)
        MyStack<DayOfWeek> enumStack = new MyStack<DayOfWeek>();
        enumStack.Push(DayOfWeek.Monday);
        enumStack.Push(DayOfWeek.Friday);

        Console.WriteLine("Pop from enumStack: " + enumStack.Pop()); // In ra "Friday" (kiểu enum sẽ in ra tên của enum)

        // Ví dụ khác với các kiểu dữ liệu khác nhau có thể thêm vào tại đây

        Console.ReadLine(); // Dừng màn hình console để xem kết quả
    }
}
