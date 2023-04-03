using System.Reflection;
using System.Runtime.CompilerServices;

namespace Anonymous
{
    class Vector<T>
    {
        private T[] element = new T[10];

        public T Index(int index)
        {
            return element[index];
        }

    }


    internal class Program
    {
        delegate int Calculator(int x, int y);

        // <T> 형식 매개변수
        // 호출할 떄 < > 사이에 T 대신 형식의 이름을 넣으면
        // 컴파일러는 메서드의 나머지 부분에 대해서도 T를 형식 매개 변수 값으로 치환한다.

        static void Resolution<T>(T x, T y)
        {
            Console.WriteLine("x 해상도 : " + x + " " + " y 해상도 : " + y);
        }

        static void Main(string[] args)
        {
            #region 무명 형식
            //// 이름이 없는 형식으로 선언과 동시에 인스턴스를 할당
            //
            //// 게임에서는 한 번 쓰고 안 쓸만한 것들은 무명 메소드를 활용한다 ex) 로그인, 인증
            //
            //var instance = new { name = "James", age = 19 };
            //
            //// 무명 형식은 값을 참조해서 수정할 수 없다.
            //// instance.name = "Jone"; (X)
            //
            //Console.WriteLine(instance.name);
            //Console.WriteLine(instance.age);
            #endregion

            #region 무명 메소드
            //Calculator calculator;
            //
            //calculator = delegate (int x, int y)
            //{
            //    return x + y;
            //};
            //
            //// 무명 메소드도 delegate 타입과 일치해야 한다.
            //
            //Console.WriteLine( calculator(10, 20));
            //
            //// 람다식(Lamda Expression)
            //calculator = (x, y) => x * y;
            //
            //Console.WriteLine(calculator(5, 5));
            #endregion

            // 일반화 프로그래밍 (제네릭)
            // 데이터 형식(Data Type)을 정해놓고 사용하는 게 아니라
            // 특수한 형식을 사용하는 코드의 데이터 형식을 일반화하여
            // 오버로딩하지 않고, 모든 형식을 지원할 수 있는 프로그래밍 방법

            // C++ 템플릿은 사용하지 않으면 컴파일을 하지 않고, 컴파일이 1번 일어난다
            // C# 제네릭은 컴파일이 2번 일어난다. - C#에서는 제네릭을 사용하지 않더라도 그에 관련된 정보를 저장하기 위해
            //                                      메타파일을 생성한다.

            Resolution<int>(10, 20);
            Resolution(1925.5f, 1300.5f); // <Type>을 안 해도 알아서 자동으로 처리해준다.

            Vector<int> vector = new Vector<int>();
            Console.WriteLine(vector.Index(9));
            
        }
    }
}