using System;
using System.ComponentModel.Design;
using System.IO;

namespace ShotMethod
{
    public class Method
    {
        public double A, B, a, b, eps, alpha0, alpha1;
        public int n, k;
        private string data, rez;
        public int Icod;

        public Method()
        {
                data = "C:\\Users\\810052\\Desktop\\ВМ\\ShotMethod\\ShotMethod\\input.txt";
                rez = "C:\\Users\\810052\\Desktop\\ВМ\\ShotMethod\\ShotMethod\\output.txt";
                StreamReader read = new StreamReader(data);
                string []line;
                string line1;
                line = read.ReadLine().Split(' ');
                a = Convert.ToDouble(line[0]);
                b = Convert.ToDouble(line[1]);
                line = read.ReadLine().Split(' ');
                A = Convert.ToDouble(line[0]);
                B = Convert.ToDouble(line[1]);
                n = Convert.ToInt32(read.ReadLine());
                eps = Convert.ToDouble(read.ReadLine());
                k = Convert.ToInt32(read.ReadLine());
                line = read.ReadLine().Split(' ');
                alpha0 = Convert.ToDouble(line[0]);
                alpha1 = Convert.ToDouble(line[1]);
        }
        
        
    }
}