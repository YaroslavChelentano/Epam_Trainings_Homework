﻿using System;
using Training1;
using Training1.Rectangle;
using Training1.Month;
using Training1.Color;
using Training1.Long;
using Training2;
using Training3;
using Logger;

namespace Epam_Trainings_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose training: \n 1.Struct \n 2.Exceptions \n 3.I/O Streams \n 4.LoggerTest");
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
                            loggerTestforFile.WriteLog(e.Message);
                            loggerTestforFile.ReadLog(e.Message);
                            // Logger for Console
                            //loggerTestforConsole.WriteLog(e.Message);
                            //loggerTestforConsole.ReadLog(e.Message);

                        }
                        catch (Exception e)
                        {
                            loggerTestforFile.WriteLog(e.Message);
                            loggerTestforFile.ReadLog(e.Message);
                            //loggerTestforConsole.WriteLog(e.Message);
                            //loggerTestforConsole.ReadLog(e.Message);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input value");
                    break;
            }
        }
    }
}
