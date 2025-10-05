using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Test2
{
    public class Bird
{
    public virtual void Eat()
    {
        Console.WriteLine("Bird đang ăn...");
    }

    public virtual void Fly()
    {
        Console.WriteLine("Bird đang bay...");
    }
}
}

