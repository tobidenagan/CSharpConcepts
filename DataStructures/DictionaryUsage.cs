namespace CSharpConcepts.DataStructures
{
    public static class DictionaryUsage
    {
        public static void DictionaryPractice()
        {
            List<string> list = new() { "one", "two", "three", "four" };
            Dictionary<int, string> dict = new Dictionary<int, string>();
            for (int i = 0; i < list.Count; i++)
            {
                dict.Add(i, list[i]);
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"Key is {item.Key}, Value is {item.Value}");
            }
        }
    }
}
