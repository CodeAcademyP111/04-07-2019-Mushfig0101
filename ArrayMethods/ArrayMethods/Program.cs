using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            //// расположим в обратном порядке
            // Array.Reverse(numbers);

            //// уменьшим массив до 4 элементов
            //Array.Resize(ref numbers, 4);

            //foreach (int number in numbers)
            //{
            //    Console.Write($"{number} \t");
            //}
            //-------------------------------------------------------------
            //int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            //int[] numbers2 = new int[5];

            //// копируем из numbers с 2-го индекса 5 элементов 
            //// и поместим их в массив numbers2, начиная с 0-го индекса
            //Array.Copy(numbers, 3, numbers2, 0, 5);

            //foreach (int number in numbers2)
            //{
            //    Console.Write($"{number} \t");
            //}

            //int[] numbers = { -3, 10, 0, -5, 12, 1, 22, 3 };

            //Array.Sort(numbers);

            //foreach (int number in numbers)
            //{
            //    Console.Write($"{number} \t");
            //}
            Console.ReadLine();
        }
    }
}

///<summary>
///Length 
///Rank
///BinarySearch()
///Clear()
///Copy()
///Exist()
///Find()
///FindAll()
///IndexOf()
///Resize(ref array,numberofLength)
///Reverse()
///Sort()
///Все массивы в C# построены на основе класса Array из пространства имен System. Этот класс определяет ряд свойств и методов, которые мы можем использовать при работе с массивами. Основные свойства и методы:

///Свойство Length возвращает длину массива

///Свойство Rank возвращает размерность массива

///Статический метод BinarySearch() выполняет бинарный поиск в отсортированном массиве

///Статический метод Clear() очищает массив, устанавливая для всех его элементов значение по умолчанию

///Статический метод Copy() копирует часть одного массива в другой массив

///Статический метод Exists() проверяет, содержит ли массив определенный элемент

///Статический метод Find() находит элемент, который удовлеворяет определенному условию

///Статический метод FindAll() находит все элементы, которые удовлеворяет определенному условию

///Статический метод IndexOf() возвращает индекс элемента

///Статический метод Resize() изменяет размер одномерного массива

///Статический метод Reverse() располагает элементы массива в обратном порядке

///Статический метод Sort() сортирует элементы одномерного массива
///
//////Разберем самые используемые методы.Например, изменим порядок элементов и размер массива:

///</summary>