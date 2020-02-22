/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта назначения, номер поезда, время отправления. 
Написать программу, выполняющую следующие действия: 
- ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть упорядочены по номерам поездов); 
- вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет, вывести соответствующее сообщение). 
*/
using System;

namespace Task2
{
    class Sort
    {

    }

    struct Train
    {
        readonly string _destination, _departureTime;
        readonly int _trainNumber;

        public Train(string destination, int trainNumber, string departureTime)
        {
            //Конструктор в структуре должен инициализировать все поля структуры,
            //иначе ошибки CS0171.
            _destination = destination;
            _departureTime = departureTime;
            _trainNumber = trainNumber;
        }

        public int TrainNumber => _trainNumber;
        public string TrainInformation => $"Поезд №{_trainNumber} отправляется в {_departureTime}, следует до {_destination}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            string enteredDestionation, enteredDepartureTime;
            int enteredTrainNumber, searchByNumberOfTrain;
            int trainNumberCounter = 0;
            int[] arraySort = new int[2];
            Train[] trains = new Train[2];

            for (int i = 0; i < trains.Length; i++)
            {
                Console.Write($"Поезд №{i + 1}:\n");

                Console.Write("номер поезда = ");
                enteredTrainNumber = Int32.Parse(Console.ReadLine());

                Console.Write("пункт назначения = ");
                enteredDestionation = Console.ReadLine();                

                Console.Write("время отправления (hh:mm) = ");
                enteredDepartureTime = Console.ReadLine();

                Console.WriteLine();

                trains[i] = new Train(enteredDestionation, enteredTrainNumber, enteredDepartureTime);
            }

            for (int k = 0; k < trains.Length; k++)
            {
                arraySort[k] = trains[k].TrainNumber;
                if (k == trains.Length - 1)
                    Array.Sort(arraySort);
            }

            Console.Write($"Номера всех поездов (отсортированные): ");
            for (int l = 0; l < trains.Length; l++)
            {
                Console.Write($"{arraySort[l]} ");
            }
            Console.WriteLine();

            do
            {
                Console.Write("\nНомер интересующего поезда = ");
                searchByNumberOfTrain = Int32.Parse(Console.ReadLine());

                for (int m = 0; m < trains.Length; m++)
                {
                    if (searchByNumberOfTrain == trains[m].TrainNumber)
                    {
                        Console.WriteLine(trains[m].TrainInformation);
                        trainNumberCounter++;
                    }
                }

                if (trainNumberCounter == 0)
                    Console.WriteLine($"Ошибка! Поездка №{searchByNumberOfTrain} не существует.");
            } while (trainNumberCounter == 0);

            Console.ReadKey();
        }
    }
}
