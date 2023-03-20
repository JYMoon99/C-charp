using System.Collections;

namespace BoxingAndUnBoxing
{
    internal class Program
    {
            // object - 참조 타입
        static void Main(string[] args)
        {


            #region 박싱(Boxing)이란?
            // 값 형식을 창조 형식으로 변환해주는 과정
            // int data = 100;

            // Boxing 과정은 암묵적 형변환이 발생
            // object obj = data;

            // MSDN
            // 값 형식 -> 참조 형식
            // Boxing 과정은 참조에 할당하는 것보다 20배까지 시간이 소요된다.

            // 참조 형식 -> 값 형식
            // UnBoxing은 메모리 할당에 4배 정도 소요된다.
            // Console.WriteLine(obj);
            #endregion

            #region 언박싱(UnBoxing)이란?
            // 참조 형식을 다시 값 형식으로 변환해주는 과정

            // int result = (int)obj;

            // UnBoxing 과정은 명시적 형변환이 발생
            // Console.WriteLine(result);
            #endregion

            #region AyyayList
            // ArrayList arrayList = new ArrayList();
            // arrayList.Add(100);         // 값 타입
            // arrayList.Add(3.56);        // 값 타입
            // arrayList.Add('T');         // 값 타입
            // arrayList.Add("string");    // 참조 타입
            // arrayList.Add("string");    // 참조 타입
            // arrayList.Add("string");    // 참조 타입
            // arrayList.Add("string");    // 참조 타입
            //
            // Console.WriteLine(arrayList.Capacity);
            //
            // for(int i = 0; i < arrayList.Count; i++)
            // {
            //     Console.WriteLine(arrayList[i]);
            // }
            #endregion

            #region String
            //
            //string name = "Moon";
            //
            //Console.WriteLine(name);
            //name = "Jung";
            //
            //Console.WriteLine(name);

            #endregion

  
        }




    }
}