using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_list_CODE_BLOG
{
    /// <summary>
    /// Лайт версия свмодельного Стека
    /// </summary>
  public  class EasyStack<T>
    {
        /// <summary>
        /// Лист для хранения данных
        /// </summary>
        private List<T> items = new List<T>();

        public int Count => items.Count; // получаем количество элементов

        /// <summary>
        /// ДОбвить в стек
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            items.Add(item);
        }

        /// <summary>
        /// Получить последний добавленный элемент
        /// </summary>
        /// <param name="item"></param>
        public T Pop()
        {
            
            if(Count > 0)
            {
                var item = items.LastOrDefault();
                items.Remove(item); // удаляем последний вытащенныйй элемент
                                    // return items.LastOrDefault(); // получаем последний элемент
                return item;
            }

            else
            {
                //Выводим ощибку
                throw new ArgumentNullException("Стек пустой");
            }
        }


    }
}
