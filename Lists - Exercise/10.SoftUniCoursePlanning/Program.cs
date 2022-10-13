using System;
using System.Linq;
using System.Collections.Generic;

namespace _10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;

            while ((input = Console.ReadLine())!= "course start")
            {
                string[] cmdArgs = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                string nextLesson = cmdArgs[1]; 
                switch (command)
                {
                    case "Add":
                        if(!courses.Contains(nextLesson))
                        {
                            courses.Add(nextLesson);
                            
                        }
                        break;
                    case "Insert":
                        if (!courses.Contains(nextLesson))
                        {
                            courses.Insert(int.Parse(cmdArgs[2]),nextLesson);
                        }
                        break;
                    case "Remove":
                        courses.Remove(nextLesson);
                        if (courses.Contains($"{nextLesson}-Exercise"))
                        {
                            courses.Remove($"{nextLesson}-Exercise");
                        }
                        break;
                    case "Swap":
                        if(courses.Contains(nextLesson) && courses.Contains(cmdArgs[2]))
                        {
                            int indexOfFirst = courses.IndexOf(cmdArgs[1]);
                            int indexOfSecond = courses.IndexOf(cmdArgs[2]);
                            courses[indexOfSecond] = cmdArgs[1];
                            courses[indexOfFirst] = cmdArgs[2];

                            string firstExercise = $"{cmdArgs[1]}-Exercise";
                            string secondExercise = $"{cmdArgs[2]}-Exercise";
                            if (courses.Contains(firstExercise))
                            {
                                courses.Remove(firstExercise);
                                courses.Insert(indexOfSecond + 1, firstExercise);
                            }

                            if (courses.Contains(secondExercise))
                            {
                                courses.Remove(secondExercise);
                                courses.Insert(indexOfFirst + 1, secondExercise);
                            }
                        }
                        break;
                    case "Exercise":
                        if(courses.Contains(nextLesson))
                        {
                            if(!courses.Contains($"{nextLesson}-Exercise"))
                            {
                                courses.Insert(courses.IndexOf(nextLesson) + 1, $"{nextLesson}-Exercise");
                            }
                        }
                        else
                        {
                            courses.Add(nextLesson);
                            courses.Add($"{nextLesson}-Exercise");
                        }
                            break;
                }
            }

            for(int i = 0; i< courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courses[i]}");
            }
        }
    }
}
