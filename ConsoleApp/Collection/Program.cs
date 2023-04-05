// using System.Collections;
using System.Collections.Generic;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 콜렉션(Queue)
            //Queue queue = new Queue();
            //queue.Enqueue(10);
            //
            //// Enqueue : 데이터를 저장하는 멤버 함수
            //queue.Enqueue(10);      // [10]
            //queue.Enqueue("Game");  // [10] [Game]
            //
            //Console.WriteLine("queue의 사이즈 : " + queue.Count);
            //Console.WriteLine(queue.Dequeue()); // [Game]
            //
            //Console.WriteLine("queue의 사이즈 : " + queue.Count);
            //Console.WriteLine(queue.Dequeue()); // empty
            #endregion

            #region 콜렉션 일반화 (Queue)
            //Queue<int> genericQueue = new Queue<int>();
            //
            //genericQueue.Enqueue(99);  // [99]
            //genericQueue.Enqueue(100); // [99] [100]
            //genericQueue.Enqueue(111); // [99] [100] [111]
            //
            //// peek( ) : 맨 앞에 있는 원소를 출력하는 함수
            //Console.WriteLine(genericQueue.Peek());
            //
            //genericQueue.Clear(); // empty
            //
            //genericQueue.Dequeue(); // 앞에서 Clear를 했기 때문에 터진다.
            //
            #endregion

            #region 콜렉션 일반화 (Stack)
            //Stack<string> stack = new Stack<string>();
            //
            //stack.Push("Earth");
            //stack.Push("Sun");
            //stack.Push("Moon");
            //
            //
            //// Contains( ) : 특정 값이 존재하는지 확인하는 함수
            //Console.WriteLine(stack.Contains("Earth"));
            //
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            #endregion

            #region 콜렉션 일반화 (List)
            // List는 데이터를 중간에 추가 / 삭제하기가 편하다
            // 런타임중에 데이터를 추가할 수 있다.

            List<float> list = new List<float>();
            list.Add(10.0f);
            list.Add(20.0f);
            list.Add(30.0f);
            list.Add(40.0f);

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            list.Remove(list[0]);
            list.Remove(list[0]);

            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);

            #endregion


        }
    }
}