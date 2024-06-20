using System;
using System.Collections;

namespace StoreManagement
{
    // Class Product để lưu trữ thông tin sản phẩm
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Description: {Description}, Price: {Price:C}";
        }
    }

    class Program
    {
        static void Main()
        {
            ArrayList products = new ArrayList();
            int choice;

            do
            {
                Console.WriteLine("1. Thêm sản phẩm mới");
                Console.WriteLine("2. Hiển thị danh sách sản phẩm");
                Console.WriteLine("3. Tìm kiếm sản phẩm theo tên");
                Console.WriteLine("4. Thoát");
                Console.Write("Nhập lựa chọn của bạn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct(products);
                        break;
                    case 2:
                        DisplayProducts(products);
                        break;
                    case 3:
                        SearchProduct(products);
                        break;
                    case 4:
                        Console.WriteLine("Thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }

            } while (choice != 4);
        }

        static void AddProduct(ArrayList products)
        {
            Console.Write("Nhập tên sản phẩm: ");
            string name = Console.ReadLine();
            Console.Write("Nhập mô tả sản phẩm: ");
            string description = Console.ReadLine();
            Console.Write("Nhập giá sản phẩm: ");
            double price = double.Parse(Console.ReadLine());

            products.Add(new Product(name, description, price));
            Console.WriteLine("Sản phẩm đã được thêm thành công.");
        }

        static void DisplayProducts(ArrayList products)
        {
            Console.WriteLine("Danh sách sản phẩm:");
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }

        static void SearchProduct(ArrayList products)
        {
            Console.Write("Nhập tên sản phẩm cần tìm: ");
            string searchName = Console.ReadLine();
            bool found = false;

            foreach (Product product in products)
            {
                if (product.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(product);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Không tìm thấy sản phẩm nào với tên đã nhập.");
            }
        }
    }
}
