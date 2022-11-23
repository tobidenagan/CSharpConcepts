namespace CSharpConcepts.DataStructures
{
    public static class DictionaryUsage
    {
        public static void DictionaryPractice()
        {
            List<string> list = new() { "one", "two", "three", "four" };
            Dictionary<int, string> dict = new Dictionary<int, string>();

            //you can use this

            //for (int i = 0; i < list.Count; i++)
            //{
            //    dict.Add(i, list[i]);
            //}

            //you can use this also

            int i = 0;
            foreach (var item in list)
            {
                if(!dict.TryGetValue(i, out var value))
                {
                    dict.Add(i, list[i]);
                    ++i; //or i++ (first use the value before incrementing it(left to right execution))
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"Key is {item.Key}, Value is {item.Value}");
            }
            Console.WriteLine(dict[0]);
        }
    }
}
