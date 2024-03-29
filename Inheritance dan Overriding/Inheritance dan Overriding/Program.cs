﻿using System;

namespace inheritanceoverriding
{
    class BangunDatar
    {
        public virtual void luas()
        {
            Console.WriteLine("Menghitung Luas Bangun Datar");
        }
        public virtual void keliling()
        {
            Console.WriteLine("Menghitung Keliling Bangun Datar");
        }
    }

    //Inheritace
    class InheritanceBangunDatar : BangunDatar { }

    //Override
    class Persegi : BangunDatar
    {
        public override void luas()
        {
            Console.WriteLine("Menghitung Luas Persegi");
        }
        public override void keliling()
        {
            Console.WriteLine("Menghitung keliling Persegi");
        }
    }

    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Output Inheritance :");
            InheritanceBangunDatar inheritance = new InheritanceBangunDatar();
            inheritance.luas();
            inheritance.keliling();

            Console.WriteLine("\nOutput Override :");
            Persegi persegi = new Persegi();
            persegi.luas();
            persegi.keliling();
        }
    }
}