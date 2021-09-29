using System;
using System.Runtime;
using System.Linq;
namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original_String)
        {
            string v = original_String.Remove(0, 1);
            string Removed_First = v;
            string a = Removed_First.Remove(Removed_First.Length - 1, 1);
            string Removed_Last = a;
            return Removed_Last;
        }
    }
}
