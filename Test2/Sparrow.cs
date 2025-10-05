using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Test2;

public class Sparrow : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Chim sẻ đang mổ thóc...");
    }

    public void Fly()
    {
        Console.WriteLine("Chim sẻ đang bay tung tăng!");
    }
}
