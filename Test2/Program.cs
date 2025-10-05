using Test2;
using System;
namespace Test2;

class Program
{
    static void Main()
    {
        //tiếng việt có dấu
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;


        // Ban đầu ta khai báo Bird
        Bird bird = new Bird();
        bird.Eat();
        bird.Fly();

        Console.WriteLine("\n--- Thay Bird bằng Sparrow ---");
        // ✅ Dùng chim sẻ thay thế Bird
        bird = new Sparrow();
        bird.Eat(); // chạy như Chim sẻ
        bird.Fly(); // chạy như Chim sẻ

        Console.WriteLine("\n--- Thay Bird bằng Penguin ---");
        // ❌ Dùng chim cánh cụt thay thế Bird
        bird = new Penguin();
        bird.Eat(); // ok
        bird.Fly(); // lỗi runtime: NotSupportedException
    }
}

