using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Collection:ICollectionOperations
    {
        public void ListOperations(List<string> list)
        {
            RemoveMiddle(ref list);
            Add6IfMamaExist(ref list);
            ReverseIfCourse59Exist(ref list);
            AddNumberOnSecondIndex(ref list);
        }

        public void DictionaryOperations(Dictionary<string, int> dictionary)
        {
            foreach(string key in dictionary.Keys)
            {
                if (key == "scuba" && dictionary["scuba"] == 6)
                {
                    dictionary.Add("dive", 6);
                }
            }
        }

        public void StackOperations(Stack<DateTime> stack)
        {

        }


        public void RemoveMiddle<T>(ref List<T> list) where T : class
        {
            List<T> temporaryList = new List<T>();
            for (int i=0; i<list.Count; i++)
            {
                if (i != list.Count / 2)
                {
                    temporaryList.Add(list[i]);
                }
            }
            list = temporaryList;
        }

        public void Add6IfMamaExist(ref List<string> list)
        {
            if (list.Contains("mama"))
            {
                list.Add("6");
            }
        }

        public void ReverseIfCourse59Exist(ref List<string> list)
        {
            if (list.Contains("course59") && list.IndexOf("course59") % 2 != 0)
            {
                list.Reverse();
            }
        }

        public void AddNumberOnSecondIndex(ref List<string> list)
        {
            int numberOfUniqueAppearances = GetNumberOfUniqueAppearances(list);
            if (numberOfUniqueAppearances == 3)
            {
                List<string> tempList = new List<string>();
                for (int i=0; i<2; i++)
                {
                    tempList.Add(list[i]);
                }
                tempList.AddRange(new List<string> { "2", "3", "4" });
                for (int i = 2; i < list.Count; i++)
                {
                    tempList.Add(list[i]);
                }
                list = tempList;
            }
        }

        public int GetNumberOfUniqueAppearances<T>(List<T> list)
        {
            List<T> uniqueValues = new List<T>();
            foreach (T value in list)
            {
                if (!uniqueValues.Contains(value))
                {
                    uniqueValues.Add(value);
                }
            }
            return uniqueValues.Count;
        }
    }
}
