using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_list_CODE_BLOG.Model
{
    /// <summary>
    /// Универсальный элемент для Linked_list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Item<T>
    {

        private T data = default(T); // присваеваем значения по умолнанию. В зависитмости от типа

        private Item<T> next = null;

        /// <summary>
        /// Свойства класса Data(ДАННЫЕ)<T>
        /// </summary>
        public T Data
        {
            get => data;

            set
            {
                if (value != null)//проверка на заполненность
                    data = value;

                else
                {
                    throw new ArgumentNullException(nameof(value));
                }
            }
        }

        /// <summary>
        /// Свойство указателя на следущий элемент
        /// </summary>
        public Item<T> Next { get; set; }

        //Конструктор
        public Item(T data)
        {
            Data = data;
        }

        /// <summary>
        /// Переобпределенный метод ToString
        /// </summary>
        /// <returns>Возращае текущие данные</returns>
        public override string ToString()
        {
            return Data.ToString();
        }

    }
}
