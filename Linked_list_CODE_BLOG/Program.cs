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
            ZapustList();//РАбота с листом
            ZapuskCtack(); //Работа со Стеком
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
            list.Add(50);
            list.Add(60);
            list.Add(60);

            list.Delete(3); // удаление по идексу
            Console.ReadKey();
        }


        static private void ZapuskCtack()
        {
            EasyStack<int> easyStack = new EasyStack<int>();

           Console.WriteLine( easyStack.ToString());
           // easyStack.Peek();
            easyStack.Push(123);
            easyStack.Push(500);
            easyStack.Push(1000);
            Console.WriteLine(easyStack.ToString());

            Console.ReadKey();

        }

       
    }
}
