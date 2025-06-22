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
            
        }

        public void DictionaryOperations(Dictionary<string, int> dictionary)
        {

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

        public void Add6IfMamaExist<T>(List<string> list)
        {
            if (list.Contains("mama"))
            {
                list.Add("6");
            }
        }

        public void ReverseIfCourse59Exist(List<string> list)
        {
            if (list.Contains("course59") && list.IndexOf("course59") % 2 != 0)
            {
                list.Reverse();
            }
        }
    }
}
