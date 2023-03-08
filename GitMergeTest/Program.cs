using System;
using System.Collections.Generic;

namespace GitMergeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }
    }

    public class Ruler
    {
        private const float ONE_INCH = 2.54F;
        public int Centimeter { get; set; } = 0;
        public float INCH
        {
            get { return Centimeter * ONE_INCH; }
            private set { Centimeter = (int)(value / ONE_INCH); }
        }
        public Ruler(int cmValue) { Centimeter = cmValue; }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm 는 {this.INCH}inch 입니다.");
        }
    }
    
}