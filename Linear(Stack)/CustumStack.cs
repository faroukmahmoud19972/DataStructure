using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Stack_
{
    public class CustumStack<T>
    {
        public int index;
        public List<T> List;
        public CustumStack()
        {
            index = -1;   // when push item then add index -1+1 = 0
            List = new List<T>();
             
        }
        public int Count
        {
            get { return List.Count; }


        }
        public void Push (T item)
        {
            List.Add(item); 
            index++;
        }

        // pop get the the last element then remove 
        public T Pop ()
        {
            var last = List[index];
            List.RemoveAt(index);
            index--;
            return last;
        }
        public T Peek()
        {
            var last = List[index];
            return last;
        }
        public void Clear ()
        {
            List.Clear();
        }
    }
}
