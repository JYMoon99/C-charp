namespace Parameter
{
    internal class Program
    {
        // 함수 <- C / C++
        // 메소드 <- C# / Java

        // ref : 참조형 매개변수
        static void Calculator(ref int x)
        {
            x -= 100;
        }

        // in : 참조형 매개변수이면서, 매개변수에 상수화가 이루어진 변수
        static void Function(in int x)
        {
            // 값을 변경할 수 없습니다.
            // x = 3000;

            Console.WriteLine("매개 변수 x의 값 : " + x);
        }

        // out : 참조형 매개변수이면수, 출력용 매개변수

        static void RayCast(out int x)
        {
            // out 매개변수는 외부에 있는 변수가 값을
            // 초기화하지 않아도 사용 가능하다.
            x = 300;

            // 함수의 반환형
        }

        // 가변 길이 매개 변수
        static void Information(params int[] list)
        {
            int result = 0;

            foreach(int element in list)
            {
                result += element;
            }

            Console.WriteLine("result 값 : " + result);
        }

        static void Main(string[] args)
        {
            #region 매개변수 한정자
            // // ref 매개 변수는 외부에 있는 변수의 값이
            // // 초기화되어 있어야한다.
            //
            // int data = 1000;
            // int data1 = 2000;
            // int data2;
            //
            // // ref 키워드
            // Calculator(ref data);
            // Console.WriteLine("data의 값 : " + data);
            //
            //
            // // in 키워드
            // Function(data1);
            //
            // // out 키워드
            // RayCast(out data2);
            //
            // Console.WriteLine("data2의 값 : " + data2);
            #endregion

            //// 가변 길이 매개 변수
            //Information(10, 20);
            //
            //Information(10, 20, 35, 45);
            Function(400);

            #region 백준 25314
           // int num = int.Parse(Console.ReadLine());
           //
           // for (int i = 0; i < num / 4; i++)
           // {
           //     Console.Write("long ");
           //
           // }
           //
           // if (num % 4 == 0)
           // Console.WriteLine("int");
            #endregion
        }
    }
}