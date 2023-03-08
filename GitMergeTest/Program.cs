using System;
using System.Collections.Generic;

namespace GitMergeTest
{
    // 유저 입력 기능 추가
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = string.Empty;
            Console.WriteLine("이 프로그램은 Cm를 Inch로 변환하는 프로그램입니다.");
            Console.Write("Cm 값을 입력:");
            userInput = Console.ReadLine();

            int cmInput = 0;
            int.TryParse(userInput, out cmInput);

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
            // SetInch 추가
            private set { this.SetInch(value); }
        }
        public Ruler(int cmValue) { Centimeter = cmValue; }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm 는 {this.INCH}inch 입니다.");
        }

        private void SetInch(float inchValue) { Centimeter = (int)(inchValue / ONE_INCH); }
    }
    
}