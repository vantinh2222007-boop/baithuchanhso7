
using System;
using System.Collections.Generic;

// Lop cha truu tuong
abstract class HinhHoc
{
    public abstract double DienTich();
    public abstract double ChuVi();
}

// Lop HinhTron
class HinhTron : HinhHoc
{
    public double R { get; set; }

    public HinhTron(double r)
    {
        R = r;
    }

    public override double DienTich()
    {
        return Math.PI * R * R;
    }

    public override double ChuVi()
    {
        return 2 * Math.PI * R;
    }
}

// Lop HinhChuNhat
class HinhChuNhat : HinhHoc
{
    public double Dai { get; set; }
    public double Rong { get; set; }

    public HinhChuNhat(double d, double r)
    {
        Dai = d;
        Rong = r;
    }

    public override double DienTich()
    {
        return Dai * Rong;
    }

    public override double ChuVi()
    {
        return 2 * (Dai + Rong);
    }
}

// Lop HinhVuong
class HinhVuong : HinhHoc
{
    public double Canh { get; set; }

    public HinhVuong(double a)
    {
        Canh = a;
    }

    public override double DienTich()
    {
        return Canh * Canh;
    }

    public override double ChuVi()
    {
        return 4 * Canh;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<HinhHoc> ds = new List<HinhHoc>
        {
            new HinhTron(5),
            new HinhChuNhat(4, 6),
            new HinhVuong(3)
        };

        foreach (var h in ds)
        {
            Console.WriteLine($"{h.GetType().Name}: DT={h.DienTich():F2}, CV={h.ChuVi():F2}");
        }
    }
}
