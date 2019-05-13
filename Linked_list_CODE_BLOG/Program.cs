using Linked_list_CODE_BLOG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Linked_list_CODE_BLOG
{
    class Program
    {
        static void Main(string[] args)
        {
            ZapustList();
        }

        /// <summary>
        /// Тестовой метод запуска и создания листа
        /// </summary>
       static private void ZapustList()
        {

            var list = new Model.LinkedList<int>();

            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);


            Console.ReadKey();
        }


       
    }
}
