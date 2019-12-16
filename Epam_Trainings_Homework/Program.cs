using System;
using Training1;
using Training1.Rectangle;
using Training1.Month;
using Training1.Color;
using Training1.Long;
using Training2;
using Training3;
using Logger;
using NLog;
using TrainingSerializable;
using System.Collections.Generic;
using System.Reflection;
using TrainingReflection;
using TrainingThreading;
using TrainingStyleCoding;
using IocContainerHW.DependencyInjection;
using IocContainerHW;

namespace Epam_Trainings_Homework
{
    class Program
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            Console.WriteLine("Choose training: \n 1.Struct \n 2.Exceptions \n 3.I/O Streams \n 4.LoggerTest " +
                "\n 5.Serialization \n 6.Reflection \n 7.Threads \n 8.StyleCoding Rectangle and Circle \n 9.IOC container");
            int choiceTraining = int.Parse(Console.ReadLine());
            switch (choiceTraining)
            {
                case 1:
                    // Task 1
                    var Jerry = new Person() { Name = "Jerry", Surname = "Koval", Age = 17 };
                    Console.WriteLine("Enter Age of Person: ");
                    var ageToComparison = int.Parse(Console.ReadLine());
                    Jerry.DisplayAgeOfPersonInOrderToGivenNumber(ageToComparison);
                    // Task 2
                    Console.WriteLine("Enter Width of Rectangle: ");
                    var width = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Heigth of Rectangle: ");
                    var height = double.Parse(Console.ReadLine());
                    var rectangle = new Rectangle(width, height);
                    Console.WriteLine($"Perimeter of Rectangle is {rectangle.Perimeter()}");
                    // Task 3
                    Console.WriteLine("Enter number of Month: ");
                    int numberOfMonth = int.Parse(Console.ReadLine());
                    if (0 <= numberOfMonth && numberOfMonth <= 12)
                    {
                        string selectedMonth = Enum.GetName(typeof(Month), numberOfMonth - 1);
                        Console.WriteLine($"Selected Month is {selectedMonth} ");
                    }
                    else
                    {
                        Console.WriteLine("Invalid value number of Month");
                    }
                    // Task 4
                    Extensions.DisplayEnum();
                    Extensions.DisplaySortedDictionary();
                    // Task 5
                    long maxValueOfLong = (long)LongRange.Max;
                    long minValueOfLong = (long)LongRange.Min;
                    Console.WriteLine($"Max = {maxValueOfLong}");
                    Console.WriteLine($"Min = {minValueOfLong}");
                    break;
                case 2:
                    // Training 2 
                    Console.WriteLine("Choose Task that will be executed: \n 1.StackOverflowException " +
                       "\n 2.IndexOurOfRangeException \n 3.Event Viewer \n 4.Try-catch-catch construction \n 5.DoSomeMath ");
                    int choiceTaskTraining2 = int.Parse(Console.ReadLine());
                    if (choiceTaskTraining2 == 1)
                    {
                        // Task 1
                        Exceptions.RecursivePrint(0);
                    }
                    if (choiceTaskTraining2 == 2)
                    {
                        // Task 2
                        Exceptions.DisplayArray();
                    }
                    if (choiceTaskTraining2 == 3)
                    {
                        // Task 3 (to execute event viewer win+r and eventvwr.msc)
                        Console.WriteLine("Task done.Please open Training2Task3.png to see screenshot");
                    }
                    if (choiceTaskTraining2 == 4)
                    {
                        // Task 4
                        try
                        {
                            Exceptions.RecursivePrint(0);
                        }
                        catch (StackOverflowException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        try
                        {
                            Exceptions.DisplayArray();
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    if (choiceTaskTraining2 == 5)
                    {
                        Exceptions.DoSomeMath(-1, -3);
                    }
                    break;
                case 3:
                    Console.WriteLine("Choose task to check: \n 1.Directories \n 2.GetFile ");
                    var choiceTaskTraining3 = int.Parse(Console.ReadLine());
                    FileLogger loggerForExceptions = new FileLogger();
                    if (choiceTaskTraining3 == 1)
                    {
                        var cmd = new ConsolePrinter();
                        Console.WriteLine("Enter path to directory: ");
                        var pathToDirectory = Console.ReadLine();
                        var directory = new DirectoryVisualizer();
                        try
                        {
                            directory.ShowDirectoryFiles($@"{pathToDirectory}", cmd);
                            //to call exception 
                            //directory.ShowDirectoryFiles($@"{pathToDirectory}", null);
                        }
                        catch (ArgumentNullException exception)
                        {
                            loggerForExceptions.Log(exception.Message);                     
                        }
                        catch(ArgumentException exception)
                        {
                            loggerForExceptions.Log(exception.Message);

                        }
                        catch(StackOverflowException exception)
                        {
                            loggerForExceptions.Log(exception.Message);
                        }
                        catch(Exception exception)
                        {
                            loggerForExceptions.Log(exception.Message);
                        }
                    }
                    if (choiceTaskTraining3 == 2)
                    {
                        var cmd = new ConsolePrinter();
                        Console.WriteLine("Enter directory to file to find: ");
                        var pathToDirectoryToGetFiles = Console.ReadLine();
                        Console.WriteLine("Enter name of file to find: ");
                        var fileName = Console.ReadLine();
                        var checkTxtFileInDirectory = new
                            FilesProvider($@"{pathToDirectoryToGetFiles}",
                            $"{fileName}");
                        try
                        {
                            checkTxtFileInDirectory.GetFileAccordingToName(cmd);
                        }
                        catch (ArgumentNullException exception)
                        {
                            loggerForExceptions.Log(exception.Message);
                        }
                        catch(ArgumentException exception)
                        {
                            loggerForExceptions.Log(exception.Message);
                        }
                        catch(Exception exception)
                        {
                            loggerForExceptions.Log(exception.Message);
                        }
                    }
                    break;
                case 4:
                    {
                        FileLoggerClass loggerTestforFile = new FileLoggerClass();
                        loggerTestforFile.filePath = loggerTestforFile.GetConfigurationOfJson()["pathToLogFile"];
                        ConsoleLoggerClass loggerTestforConsole = new ConsoleLoggerClass();
                        // Task 1 training 3 test Logger
                        var cmd = new ConsolePrinter();
                        Console.WriteLine("Enter path to directory: ");
                        var pathToDirectory = Console.ReadLine();
                        var directory = new DirectoryVisualizer();
                        try
                        {
                            directory.ShowDirectoryFiles($@"{pathToDirectory}", null);
                        }
                        catch (ArgumentNullException e)
                        {
                            // Logger for file
                            Logger.Error(e.Message);
                            loggerTestforFile.WriteLog(e.Message);
                            loggerTestforFile.ReadLog(e.Message);
                            // Logger for Console
                            //loggerTestforConsole.WriteLog(e.Message);
                            //loggerTestforConsole.ReadLog(e.Message);

                        }
                        catch (Exception e)
                        {
                            Logger.Error(e.Message);
                            loggerTestforFile.WriteLog(e.Message);
                            loggerTestforFile.ReadLog(e.Message);
                            //loggerTestforConsole.WriteLog(e.Message);
                            //loggerTestforConsole.ReadLog(e.Message);
                        }
                    }
                    break;
                case 5:
                    Console.WriteLine("Choose serialization to check: \n 1.XML \n 2.JSON \n 3.Binary ");
                    var choiceTaskTrainingSerialization = int.Parse(Console.ReadLine());
                    Car lamborginiGallardo = new Car("Lamborgini Gallardo", 2003, 309);
                    Car lamborginiAventador = new Car("Lamborgini Aventador", 2011, 350);
                    List<Car> cars = new List<Car>();
                    cars.Add(lamborginiGallardo);
                    cars.Add(lamborginiAventador);
                    if (choiceTaskTrainingSerialization==1)
                    {
                        XMLSerializable serializationOfCars = new XMLSerializable();
                        serializationOfCars.Writer(cars);
                        foreach (Car car in serializationOfCars.Reader())
                            Console.WriteLine($"Model: {car.Model} \n Year: {car.YearOfManufacture} \n Speed: {car.Speed}");
                    }
                    if (choiceTaskTrainingSerialization==2)
                    {
                        JSONSerializable serializationOfCars = new JSONSerializable();
                        serializationOfCars.Writer(cars);
                        foreach (Car car in serializationOfCars.Reader())
                            Console.WriteLine($"Model: {car.Model} \n Year: {car.YearOfManufacture} \n Speed: {car.Speed}");
                    }
                    if (choiceTaskTrainingSerialization==3)
                    {
                        BinarySerializable serializationOfCars = new BinarySerializable();
                        serializationOfCars.Writer(cars);
                        foreach (Car car in serializationOfCars.Reader())
                            Console.WriteLine($"Model: {car.Model} \n Year: {car.YearOfManufacture} \n Speed: {car.Speed}");
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Choose info you want to show \n1. Libraries 2. Classes and Methods");
                        int trainingReflectionChoice = int.Parse(Console.ReadLine());
                        AssemblyInfoConsoleOutput info = new AssemblyInfoConsoleOutput();
                        if (trainingReflectionChoice == 1)
                        {
                            info.ShowLibraries();
                        }
                        if (trainingReflectionChoice == 2)
                        {
                            info.ShowClassesAndMethods();
                        }
                    }
                        break;
                case 7:
                    {
                        MatrixOperations sumMatrixElements = new MatrixOperations();                   
                        Console.WriteLine(MatrixOperations.MatrixSumParallel(sumMatrixElements.GetRandomMatrix(1000,1000)));
                    }
                    break;
                case 8:
                    {
                        RectangleStyleCoding rectangleFirst = new RectangleStyleCoding(1, 3, 1, 2);
                        RectangleStyleCoding rectangleSecond = new RectangleStyleCoding(2, 4, 2, 3);
                        rectangleFirst.UnionOfRectangles(rectangleFirst, rectangleSecond).DisplayRectangle();
                        
                    }
                    break;
                case 9:
                    {
                        var services = new DiServiceCollection();


                        services.RegisterTransient<ISomeService, SomeServiceOne>();
                        services.RegisterSingleton<IRandomGuidProvider, RandomGuidProvider>();

                        var container = services.GenerateContainer();

                        var serviceFirst = container.GetService<ISomeService>();
                        var serviceSecond = container.GetService<ISomeService>();

                        serviceFirst.PrintSomething();
                        serviceSecond.PrintSomething();
                    }
                    break;
                        default:
                    Console.WriteLine("Invalid input value");
                    break;
            }
        }
    }
}
