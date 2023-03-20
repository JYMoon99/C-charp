using System.Net.Cache;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Class
{

    class Dog
    {
        // 접근 지정자
        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        protected char grade;

        private float health;

        // 기본 접근 지정자 (private)

        // public : 클래스 외부로부터 접근을 허용하는 지정자


        // protected : 자기 자신의 클래스와 자기가 상속하고 있는
        //             클래스에서만 접근을 허용하는 지정자

        // private : 클래스 내부에서만 접근을 허용하는 지정자

    }

    class Maltese : Dog
    {
        public void Information()
        {
            grade = 'A';
            Console.WriteLine("등급 : " + grade);
        }
    }

    class LOL
    {
        private int level;

        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                if(value >= 19)
                {
                    value = 18;
                }
                level = value;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region 클래스
            //Dog dog = new Dog();
            //
            //dog.Age = 5;
            //
            //Console.WriteLine("dog.age의 값 : " + dog.Age);
            //
            //Maltese maltese = new Maltese();
            //
            //maltese.Information();
            //
            //LOL lol = new LOL();
            //
            //lol.Level = 20;
            //Console.WriteLine("LoL level : " + lol.Level);

            // int size = Marshal.SizeOf(new Dog());
            // Console.WriteLine("Dog의 크기 : " + Marshal.SizeOf(size));
            #endregion



            
        }
    }
}