
using System;
using System.Collections.Generic;

// Lop cha truu tuong
abstract class DongVat
{
    public abstract void Keu();
}

// Lop Cho
class Cho : DongVat
{
    public override void Keu()
    {
        Console.WriteLine("Cho: Gau gau");
    }
}

// Lop Meo
class Meo : DongVat
{
    public override void Keu()
    {
        Console.WriteLine("Meo: Meo meo");
    }
}

// Lop Chim
class Chim : DongVat
{
    public override void Keu()
    {
        Console.WriteLine("Chim: Chich chich");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<DongVat> ds = new List<DongVat>
        {
            new Cho(),
            new Meo(),
            new Chim()
        };

        Console.WriteLine("===== DANH SACH THU CUNG =====");

        foreach (var dv in ds)
        {
            dv.Keu();
        }
    }
}
