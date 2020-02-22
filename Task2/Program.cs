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
            Train[] trains = new Train[2];

            for (int i = 0; i < trains.Length; i++)
            {
                Console.Write($"Поезд №{i + 1}:\n");

                Console.Write("пункт назначения = ");
                enteredDestionation = Console.ReadLine();

                Console.Write("номер поезда = ");
                enteredTrainNumber = Int32.Parse(Console.ReadLine());

                Console.Write("время отправления (hh:mm) = ");
                enteredDepartureTime = Console.ReadLine();

                Console.WriteLine();

                trains[i] = new Train(enteredDestionation, enteredTrainNumber, enteredDepartureTime);
            }

            do
            {
                Console.Write("Номер интересующего поезда = ");
                searchByNumberOfTrain = Int32.Parse(Console.ReadLine());
                for (int k = 0; k < trains.Length; k++)
                {
                    if (searchByNumberOfTrain == trains[k].TrainNumber)
                    {
                        Console.WriteLine(trains[k].TrainInformation);
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
