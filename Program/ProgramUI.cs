using System;
using System.Collections.Generic;
using _01_Cafe;
using CafeMenuRepo;

namespace Program
{
    public class ProgramUI
    {
        private MenuRepo _CafeRepo = new MenuRepo();

        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRunMenu = true;

            while (continueToRunMenu)
            {
                Console.Clear();
                Console.WriteLine(
                    "What would you like to order?:\n" +
                    "1. Show Menu\n" +
                    "2. Add to Menu\n" +
                    "3. Remove from Menu\n" +
                    "4. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowAllContent();
                        break;
                    case "2":

                        break;
                    case "3":
                        CreateAndAddContentToOrder();
                        break;
                    case "4":
                        RemoveContent();
                        break;
                    case "5":
                        continueToRunMenu = false;
                        break;
                    default:
                        Console.WriteLine("Enter a number between 1 and 4.\n" +
                            "Press any key to continue...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        


        private void CreateAndAddContentToOrder()
        {
            Menu content = new Menu();
            Console.Write("Please type in a meal number: ");
            string mealNumber = Console.ReadLine();
            content.MealNumber = int.Parse(mealNumber);

            Console.Write("Please enter a meal name: ");
            content.MealName = Console.ReadLine();

            Console.Write("Please enter a description: ");
            content.Description = Console.ReadLine();

            Console.Write("Please list ingredients: ");
            content.Ingredients = Console.ReadLine();

            Console.Write("Price: ");
            string price = Console.ReadLine();
            content.Price = decimal.Parse(price);


            _CafeRepo.AddContentToMenu(content);
        }

        private void ShowAllContent()
        {
            List<Menu> listOfContent = _CafeRepo.GetMenuOrder();

            foreach(Menu content in listOfContent)
            {
                Console.WriteLine($"{content.MealName} {content.Description}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
       

        private void RemoveContent()
        {
            Console.WriteLine("Which item would you like to remove?");
            int count = 0;
            List<Menu> contentList = _CafeRepo.GetMenuOrder();
            foreach (Menu content in contentList)
            {
                count++;
                Console.WriteLine($"{count}.{content.MealName}");
            }
        }
    }
}
