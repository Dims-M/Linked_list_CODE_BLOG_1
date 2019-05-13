﻿using System;
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
        /// Конечный элемент Linked list
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
        }
    
        public LinkedList(T data )
        { 
            //При создании обекта с параметрами
            var item = new Item<T>(data);

            SetHeadAndTail(data);

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

            }
        }

        /// <summary>
        /// Метод инизализатор значений
        /// </summary>
        /// <param name="item"></param>
        private void SetHeadAndTail(Item <T> item)
        {
            Head = item;
            Tail = item;
            Count = 1;
        }

    }
}
