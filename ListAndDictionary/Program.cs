namespace ListAndDictionary
{
    internal class Program
    {
        // List variable containing names of persons
        private static List<string> personList = new List<string>();

        // Dictionary containing person name and age where the string TKey is for name and the int TValue is for age
        private static Dictionary<string, int> personAgeDictionary = new Dictionary<string, int>();

        public static void Main()
        {
            Console.WriteLine("Welcome to the Person Manager!");
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add New Person");
                Console.WriteLine("2. Remove Person");
                Console.WriteLine("3. Find Person");
                Console.WriteLine("4. List All Persons");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        RemovePerson();
                        break;
                    case "3":
                        FindPerson();
                        break;
                    case "4":
                        DisplayAllPersons();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        public static void AddPerson()
        {
            // TODO 1: Request user input for the person's name.

            Console.Write("Enter the person's name: ");
            string personName = Console.ReadLine();

            // TODO 2: Validate if the person already exists in the personList.

            if (personList.Contains(personName))
            {
                Console.WriteLine($"Person {personName} already exists in the list.");
                return; 
            }
            // TODO 3: Add the person to the personList if they don't already exist.

            personList.Add(personName);

            // TODO 4: Provide user feedback for successful addition or if the person already exists in personList.

            Console.WriteLine($"Person {personName} added successfully to the list.");

            // TODO 5: Validate if the person already exists in the personAgeDictionary.

            if (personAgeDictionary.ContainsKey(personName))
            {
                Console.WriteLine($"Person {personName} already exists in the age dictionary.");
                return; // Exit the method if person already exists in the dictionary
            }
            // TODO 6: If they don't exist, request age input and add the person to the personAgeDictionary.
            //         NOTE!: Remember to add both TKey and TValue

            Console.Write("Enter the person's age: ");
            int personAge = int.Parse(Console.ReadLine());
            personAgeDictionary.Add(personName, personAge);

            // TODO 7: Provide user feedback for successful addition or if the person already exists in personAgeDictionary.

            Console.WriteLine($"Person {personName} added successfully to the age dictionary with age {personAge}.");
        
    }

        public static void RemovePerson()
        {
            // TODO 8: Request user input for the name of the person to remove.

            Console.Write("Enter the name of the person to remove: ");
            string personNameToRemove = Console.ReadLine();

            // TODO 9: Remove the person from personList if they exist.
            // TODO 10: Provide user feedback for successful removal or if the person doesn't exist in personList.

            if (personList.Contains(personNameToRemove))
            {
                personList.Remove(personNameToRemove);
                Console.WriteLine($"Person {personNameToRemove} removed successfully from the list.");
            }
            else
            {
                Console.WriteLine($"Person {personNameToRemove} does not exist in the list.");
            }

            // TODO 11: Remove the person from personAgeDictionary if they exist.
            // TODO 12: Provide user feedback for successful removal or if the person doesn't exist in personAgeDictionary.

            if (personAgeDictionary.ContainsKey(personNameToRemove))
            {
                personAgeDictionary.Remove(personNameToRemove);
                Console.WriteLine($"Person {personNameToRemove} removed successfully from the age dictionary.");
            }
            else
            {
                Console.WriteLine($"Person {personNameToRemove} does not exist in the age dictionary.");
            }

        }

        public static void FindPerson()
        {
            // TODO 13: Request user input for the name of the person to find.

            Console.Write("Enter the name of the person to find: ");
            string personNameToFind = Console.ReadLine();

            // TODO 14: Check if the person is in personList and provide appropriate feedback.

            if (personList.Contains(personNameToFind))
            {
                Console.WriteLine($"Person {personNameToFind} found in the list.");
            }
            else
            {
                Console.WriteLine($"Person {personNameToFind} not found in the list.");
            }
            // TODO 15: Check if the person is in personAgeDictionary and provide appropriate feedback.

            if (personAgeDictionary.ContainsKey(personNameToFind))
            {
                int personAge = personAgeDictionary[personNameToFind];
                Console.WriteLine($"Person {personNameToFind} found in the age dictionary with age {personAge}.");
            }
            else
            {
                Console.WriteLine($"Person {personNameToFind} not found in the age dictionary.");
            }
        }
        public static void DisplayAllPersons()
        {
            // TODO 16: Iterate over personList and display each person's name.

            Console.WriteLine("List of Persons:");
            if (personList.Count > 0)
            {
                foreach (string personName in personList)
                {
                    Console.WriteLine(personName);
                }
            }
            else
            {
                Console.WriteLine("The person list is empty.");
            }

            // TODO 17: Iterate over personAgeDictionary and display each person's name and age.
            // TODO 18: Consider handling the case where the lists are empty by providing feedback to the user.

            Console.WriteLine("\nList of Persons with Ages:");
            if (personAgeDictionary.Count > 0)
            {
                foreach (var entry in personAgeDictionary)
                {
                    Console.WriteLine($"{entry.Key}: Age {entry.Value}");
                }
            }
            else
            {
                Console.WriteLine("The person age dictionary is empty.");
            }

            
        }
    }
}
