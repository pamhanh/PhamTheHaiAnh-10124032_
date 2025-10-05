using Test2;
using System;

public class Penguin : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Chim cánh cụt đang ăn cá...");
    }

    public override void Fly()
    {
        // ❌ Đây là điểm sai — Penguin không bay được
        throw new NotSupportedException("Chim cánh cụt không thể bay!");
    }
}
