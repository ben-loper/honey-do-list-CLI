﻿
using HoneyDoListCLI.Classes;
using System;

namespace HoneyDoListCLI
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool isRunning = true;


            Project electrical = new Project("Electrical", "Replace the lits in the kitchen and all recepticals in house", 50.00m);
            Project hoseBib = new Project("Hose Bib", "Replace backyard hose bib", 30.00m);
            Project carpets = new Project("Carpets", "Replace all the carpet in each room", 200.00m);
            Project ceilingFan = new Project("Ceiling Fan", "Replace the ceiling the fan in entrance with a chandlier", 100.00m);
            Project slidingGlassDoor = new Project("Sliding Glass Door", "Replace the wheels on the sliding glass door and repair the tracks", 30.00m);

            ProjectList projectList = new ProjectList();

            projectList.AddProjectToList(electrical);
            projectList.AddProjectToList(hoseBib);
            projectList.AddProjectToList(carpets);
            projectList.AddProjectToList(ceilingFan);
            projectList.AddProjectToList(slidingGlassDoor);


            hoseBib.FinishProject(15.55m);
            electrical.FinishProject(49.99m);

            while (isRunning)
            {  

                NewScreen();

                Console.WriteLine("A - Display all projects");
                Console.WriteLine("B - Display finished projects");
                Console.WriteLine("C - Display unfinished projects");
                Console.WriteLine("D - Create a new project");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                Console.Write("Please enter a letter for the corresponding screen and press enter: ");

                string userChoice = Console.ReadLine();
                
                if(userChoice.ToLower() == "a")
                {
                    NewScreen();

                    projectList.DisplayAllProjects();
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey();
                } else if(userChoice.ToLower() == "b")
                {
                    NewScreen();

                    projectList.DisplayFinishedProjects();
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey();
                } else if(userChoice.ToLower() == "c")
                {
                    NewScreen();
                    
                    projectList.DisplayUnfinishedProjects();
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey();
                }
                
                //Create a new project
                else if (userChoice.ToLower() == "d")
                {
                    NewScreen();

                    Console.Write("Please enter a title for your project: ");

                    string projectName = Console.ReadLine();

                    NewScreen();

                    Console.Write("Please enter a description for your project: ");

                    string projectDesc = Console.ReadLine();

                    NewScreen();

                    Console.Write("Please enter an estimated cost for the project: ");

                    decimal estimatedCost = decimal.Parse(Console.ReadLine());

                    Project project = new Project(projectName, projectDesc, estimatedCost);

                    projectList.AddProjectToList(project);

                    NewScreen();
                    Console.WriteLine("Created new project and added to list of unfinished projects");
                    Console.WriteLine();
                    Console.Write("Press any key to return to the main menu...");
                    Console.ReadKey();
                    
                }
                else if(userChoice.ToLower() == "q")
                {
                    isRunning = false;
                }
                
            }
        }

        public static void NewScreen()
        {
            Console.Clear();
            Console.WriteLine("Honey Do List");
            Console.WriteLine("-------------");
            Console.WriteLine();
        }
    }
}
