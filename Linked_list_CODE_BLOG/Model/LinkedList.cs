using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_list_CODE_BLOG.Model
{
    /// <summary>
    /// Сомодельный типизированый динамичнский Linked list
    /// </summary>
    public class LinkedList<T>
    {
        /// <summary>
        /// головной элемент Linked list
        /// </summary>
        public Item<T> Head { get; private set; }
        /// <summary>
        /// Конечный(Поседний) элемент списка Linked list. НЕ указатель
        /// </summary>
        public Item<T> Tail { get; private set; }

        /// <summary>
        /// Количество элементов в Linked list
        /// </summary>
        public int Count { get; private set; }

        //Конструкторы
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count++;
        }

        public LinkedList(T data)
        {
            //При создании обекта с параметрами
            var item = new Item<T>(data);

            SetHeadAndTail(item);

        }

        // методы
        /// <summary>
        /// Метод добавить в список элемент
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            var item = new Item<T>(data);

            //проверяем на заполненость листа

            if (Tail != null)
            {
                Tail.Next = item; //Указатель на крайний элемент привязываем текущий(новые) данные на хвостовую переменную
                Tail = item; // присваиваем в конечное свойство
                Count++;
            }

            else
            {
                SetHeadAndTail(item);
            }
        }

        public void Delete(T data)
        {
            if (Head != null) // если список не пустой
            {

                if (Head.Data.Equals(data)) //если первое значение содержитсяв первом элементе
                {
                    Head = Head.Next; // Переприсваиваем в текущие значение из следущей переменно 
                    Count--; // уменьшаем счетчик количество обьектов листа
                    return;
                }



            var current = Head.Next; //содержимое списка из следущего элемента. Так как самый первый мы уже проверили
            var previous = Head;  //Предыдущий указатель на следущий элемент

            while (current != null) // цикл работает пока не кончатся значения списка
            {
                if (current.Equals(data)) // прверяем есть в списке нужный нам обьект
                {
                        previous.Next = current.Next;
                        Count--;
                }

                    previous = current;
                    current = current.Next;

            }
          }
              
        }

        /// <summary>
        /// Метод инизализатор значений. По умолчанию Добавление указателей и увеличение Count
        /// </summary>
        /// <param name="item"></param>
        private void SetHeadAndTail(Item<T> item)
        {
            Head = item;
            Tail = item;
            Count = 1;
        }

    }
}
