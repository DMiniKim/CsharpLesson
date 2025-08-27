namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 컬렉션 ( Collection )

            #region list

            //List<int> list = new List<int>();
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            //
            //foreach (int element in list)
            //{
            //    Console.WriteLine(element);
            //}

            #endregion

            #region 딕셔너리 ( Dictionary )

            //Dictionary<string , int> dictionary = new Dictionary<string , int>();
            //
            //dictionary.Add("Doran's Blade", 450);
            //dictionary.Add("B.F Sword", 1300);
            //dictionary.Add("Randuin's Omen", 2700);
            //
            //foreach (var element in dictionary )
            //{
            //    Console.WriteLine("key : " + $"{element.Key}");
            //    Console.WriteLine("value : " + $"{element.Value}");
            //}
            //int money = 0;
            //string key = "Doran's Blade";
            //if (dictionary.TryGetValue(key, out money)) { money = dictionary[key]; }
            //else
            //{
            //    dictionary.Add("Doran's Blade", 3000);
            //}

            #endregion

            #region stack (스택) 
            // Stack<int> stack = new Stack<int> ();
            // stack.Push (1);
            // stack.Push (2);
            // stack.Push (3);
            // stack.Push (4);
            // stack.Push (5);
            //     
            // stack.Push (6);
            // while (stack.Count > 0)
            // {
            //     Console.WriteLine(stack.Pop());
            // }
            #endregion

            #region Queue
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Enqueue(6);
            //queue.Enqueue(7);
            //queue.Enqueue(8);
            //queue.Enqueue(9);
            //queue.Enqueue(10);
            //
            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            #endregion

            #region Linked List
            //LinkedList<int> list = new LinkedList<int>();
            //list.AddFirst(1);
            //list.AddFirst(2);
            //list.AddFirst(3);
            //list.AddLast(4);
            //list.AddLast(5);
            //list.AddLast(6);
            //
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #endregion

        }
    }
}
