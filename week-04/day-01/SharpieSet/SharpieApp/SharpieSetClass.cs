using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieApp
{
    class SharpieSetClass
    {
        private List<Sharpie> sharpieList = new List<Sharpie>();
        public List<Sharpie> SharpieList
        {
            get
            {
                return sharpieList;
            }
        }

        public void CountUsable(List<Sharpie> sharpielist)
        {
            for (int i = 0; i < sharpieList.Count; i++)
            {
                if (sharpieList[i].InkAmount > 0)
                {
                    sharpieList[i].Usable = true;
                }
            }
        }
        public List<Sharpie> RemoveTrash(List<Sharpie> sharpieList)
        {
            for (int i = 0; i < sharpieList.Count; i++)
            {
                if (sharpieList[i].Usable == false)
                {
                    sharpieList.RemoveAt(i);
                }
            }
            return sharpieList;
        }
        public void PrintOutSharpieList(List<Sharpie> sharpieList)
        {
            foreach (Sharpie sharpie in sharpieList)
            {
                Console.WriteLine(sharpie.Name);
            }
        }
    }
}
