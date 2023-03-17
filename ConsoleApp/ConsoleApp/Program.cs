namespace ConsoleApp
{

    // C#부터는 class가 단위가 됨.
    // C#은 값 타입과 참조 타입으로 나뉜다.
    // 값 타입 char, int, float
    // 참조 타입 array, class, delegate
    // C# - heap

    internal class Program
    {
        static void Main(string[] args)
        {

            #region Console.Write
            // Console.Write
            /*
            Console.Write("League of Legend"); // Write - 자동 줄바꿈 X
            Console.Write("Hello"); 



            Console.WriteLine("Hello, World!"); // WriteLine - 자동 줄바꿈

            Console.WriteLine("-------------------------");
            */
            #endregion

            #region 값 타입
            // 값 타입
            /*
            byte value = 10;        // 1 byte
            bool check = false;     // 1 byte
            char alphabet = 'A';    // 1 byte
            int data = 100;         // 4 byte
            float pi = 3.14f;       // 4 byte
            double health = 16.75;  // 8 byte

            Console.WriteLine("alphabet : " + alphabet);
            Console.WriteLine("data : " + data);
            Console.WriteLine("pi : " + pi);

            Console.WriteLine("-------------------------");
            */
            #endregion

            #region 참조 타입
            // 참조 타입
            /*
            // stirng
            // class
            // object
            // delegate

            int[] array = new int [3];
            array[0] = 100;
            array[1] = 200;
            array[2] = 300;


            for(int i = 0; i < array.Length; i++) // array.Length 배열의 길이
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();


            foreach(int element in array)
            {
                Console.WriteLine(element);
            }
*/
            #endregion

        }

    }
}