/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта назначения, номер поезда, время отправления. 
Написать программу, выполняющую следующие действия: 
- ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть упорядочены по номерам поездов); 
- вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет, вывести соответствующее сообщение). 
*/
using System;

namespace Task2
{
    struct Train
    {
        string _destination, _departureTime;
        int _trainNumber;
        string[] _array;

        public Train(string destination, int trainNumber, string departureTime)
        {
            //Конструктор в структуре должен инициализировать все поля структуры,
            //иначе ошибки CS0171.
            _destination = destination;
            _departureTime = departureTime;
            _trainNumber = trainNumber;
            _array = null;
        }

        public string this[int index]
        {
            get { return "" ; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string enteredDestionation, enteredDepartureTime;
            int enteredTrainNumber;
            Train[] trains = new Train[8];

            for (int i = 1; i <= trains.Length; i++)
            {
                Console.Write($"Поезд №{i}:\n");
                Console.Write("пункт назначения = ");
                enteredDestionation = Console.ReadLine();
                Console.Write("номер поезда = ");
                enteredTrainNumber = Int32.Parse(Console.ReadLine());
                Console.Write("время отправления (hh:mm) = ");
                enteredDepartureTime = Console.ReadLine();
                Console.WriteLine();
                trains[i] = new Train(enteredDestionation, enteredTrainNumber, enteredDepartureTime);
            }

            Console.ReadKey();
        }
    }
}
