
using System;
using System.Collections.Generic;

// Lop cha truu tuong
abstract class TaiKhoanNganHang
{
    public string SoTaiKhoan { get; set; }
    public double SoDu { get; set; }

    public TaiKhoanNganHang(string stk, double soDu)
    {
        SoTaiKhoan = stk;
        SoDu = soDu;
    }

    public abstract void RutTien(double soTien);
    public abstract void GuiTien(double soTien);
}

// Tai khoan thanh toan
class TaiKhoanThanhToan : TaiKhoanNganHang
{
    public TaiKhoanThanhToan(string stk, double soDu)
        : base(stk, soDu)
    {
    }

    public override void RutTien(double soTien)
    {
        if (soTien > 0 && soTien <= SoDu)
        {
            SoDu -= soTien;
            Console.WriteLine("Rut tien thanh cong.");
        }
        else
        {
            Console.WriteLine("So tien rut khong hop le.");
        }
    }

    public override void GuiTien(double soTien)
    {
        if (soTien > 0)
        {
            SoDu += soTien;
            Console.WriteLine("Gui tien thanh cong.");
        }
        else
        {
            Console.WriteLine("So tien gui khong hop le.");
        }
    }
}

// Tai khoan tiet kiem
class TaiKhoanTietKiem : TaiKhoanNganHang
{
    public double LaiSuat { get; set; }

    public TaiKhoanTietKiem(string stk, double soDu, double laiSuat)
        : base(stk, soDu)
    {
        LaiSuat = laiSuat;
    }

    public override void RutTien(double soTien)
    {
        if (soTien > 0 && soTien <= SoDu)
        {
            SoDu -= soTien;
            Console.WriteLine("Rut tien tiet kiem thanh cong.");
        }
        else
        {
            Console.WriteLine("So tien rut khong hop le.");
        }
    }

    public override void GuiTien(double soTien)
    {
        if (soTien > 0)
        {
            SoDu += soTien;
            Console.WriteLine("Gui tien tiet kiem thanh cong.");
        }
        else
        {
            Console.WriteLine("So tien gui khong hop le.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<TaiKhoanNganHang> ds = new List<TaiKhoanNganHang>
        {
            new TaiKhoanThanhToan("TT01", 5000000),
            new TaiKhoanTietKiem("TK01", 10000000, 0.05)
        };

        foreach (var tk in ds)
        {
            Console.WriteLine("\nSo tai khoan: " + tk.SoTaiKhoan);
            Console.WriteLine("So du ban dau: " + tk.SoDu);

            tk.GuiTien(1000000);
            tk.RutTien(2000000);

            Console.WriteLine("So du cuoi: " + tk.SoDu);
        }
    }
}
