
using System;
using System.Collections.Generic;

// Lop cha truu tuong
abstract class NhanVien
{
    public string MaNV { get; set; }
    public string HoTen { get; set; }

    public NhanVien(string ma, string ten)
    {
        MaNV = ma;
        HoTen = ten;
    }

    public abstract double TinhLuong();
}

// Nhan vien van phong
class NhanVienVanPhong : NhanVien
{
    public int SoNgayCong { get; set; }

    public NhanVienVanPhong(string ma, string ten, int ngay)
        : base(ma, ten)
    {
        SoNgayCong = ngay;
    }

    public override double TinhLuong()
    {
        return SoNgayCong * 200000;
    }
}

// Nhan vien san xuat
class NhanVienSanXuat : NhanVien
{
    public int SoSanPham { get; set; }

    public NhanVienSanXuat(string ma, string ten, int sp)
        : base(ma, ten)
    {
        SoSanPham = sp;
    }

    public override double TinhLuong()
    {
        return SoSanPham * 50000;
    }
}

// Nhan vien quan ly
class NhanVienQuanLy : NhanVien
{
    public double LuongCoBan { get; set; }
    public double PhuCap { get; set; }

    public NhanVienQuanLy(string ma, string ten, double lcb, double pc)
        : base(ma, ten)
    {
        LuongCoBan = lcb;
        PhuCap = pc;
    }

    public override double TinhLuong()
    {
        return LuongCoBan + PhuCap;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<NhanVien> dsNV = new List<NhanVien>
        {
            new NhanVienVanPhong("VP01", "Phan VĂn Tỉnh", 22),
            new NhanVienSanXuat("SX01", "Nguyễn Văn BẢo", 120),
            new NhanVienQuanLy("QL01", "Nguyễn Trung Duy", 8000000, 2000000)
        };

        Console.WriteLine("===== BANG LUONG NHAN VIEN =====");

        foreach (var nv in dsNV)
        {
            Console.WriteLine($"{nv.MaNV} - {nv.HoTen} - Luong: {nv.TinhLuong():N0} VND");
        }
    }
}
