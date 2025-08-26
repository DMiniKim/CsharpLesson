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

            Dictionary<string , int> dictionary = new Dictionary<string , int>();

            dictionary.Add("Doran's Blade", 450);
            dictionary.Add("B.F Sword", 1300);
            dictionary.Add("Randuin's Omen", 2700);

            foreach (var element in dictionary )
            {
                Console.WriteLine("key : " + $"{element.Key}");
                Console.WriteLine("value : " + $"{element.Value}");
            }
            int money = 0;
            string key = "Doran's Blade";
            if (dictionary.TryGetValue(key, out money)) { money = dictionary[key]; }
            else
            {
                dictionary.Add("Doran's Blade", 3000);
            }

            #endregion

            #endregion

        }
    }
}
