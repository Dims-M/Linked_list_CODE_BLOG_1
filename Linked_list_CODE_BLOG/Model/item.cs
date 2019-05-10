using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_list_CODE_BLOG.Model
{
   public class Item<T>
    {

        private T data = default(T); // присваеваем значения по умолнанию. В зависитмости от типа

        private Item<T> next = null;

        /// <summary>
        /// Свойства класса Item<T>
        /// </summary>
        public T Data
        {
            get { return data; }

            set
            {
                data = value ?? throw new ArgumentNullException(nameof(value));
                //if (value !=null) //проверка на заполненность
                //{
                //    data = value;
                //}

            }
        }

        /// <summary>
        /// Автосвойство переменной next Класса Item<T>
        /// </summary>
        public Item<T> Next { get; set; }
        
        //Конструктор
        public Item(T data)
        {
            Data = data;
        }
        
    }
}
