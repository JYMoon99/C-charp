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
            Queue<int> genericQueue = new Queue<int>();

            genericQueue.Enqueue(99);  // [99]
            genericQueue.Enqueue(100); // [99] [100]
            genericQueue.Enqueue(111); // [99] [100] [111]

            // peek( ) : 맨 앞에 있는 원소를 출력하는 함수
            Console.WriteLine(genericQueue.Peek());

            genericQueue.Clear(); // empty

            genericQueue.Dequeue(); // 앞에서 Clear를 했기 때문에 터진다.

            #endregion

        }
    }
}