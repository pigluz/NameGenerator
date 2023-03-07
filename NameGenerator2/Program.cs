﻿string[] maleNames = { "Liam", "Noah", "Oliver", "Elijah", "James", "Max", "James", "William", "Benjamin", "Lucas", "Henry", "Levi" };
string[] femaleNames = { "Olivia", "Emma", "Charlotte", "Amelia", "Ava", "Sophia", "Isabella", "Mia", "Evelyn", "Camilia", "Sofia" };
string[] surnames = { "Smith", "Brown", "Wilson", "Thomson", "Robertson", "Campbell", "Anderson", "Scott", "Marshall", "Stevensn", "Jones" };

Random rand = new Random();

    Console.WriteLine("Name generator");
    Thread.Sleep(1000);

outerLoop:
    while (true)
    {
        Console.WriteLine("\nChoose gender (Male/Female):");
    string gender_choice = Console.ReadLine();

    innerLoop:
    while(true)
    {
        int RandomIndex_maleNames = rand.Next(maleNames.Length);
        string Random_maleNames = maleNames[RandomIndex_maleNames];

        int RandomIndex_femaleName = rand.Next(femaleNames.Length);
        string Random_femaleNames = femaleNames[RandomIndex_femaleName];

        int RandomIndex_surnames = rand.Next(surnames.Length);
        string Random_surnames = surnames[RandomIndex_surnames];

        int RandomAge = rand.Next(18, 30);

        if (gender_choice == "Male")
        {
            Console.WriteLine
                ("\nName: " + Random_maleNames + "\n" +
                "Surname: " + Random_surnames + "\n" +
                "Age: " + RandomAge);
            Thread.Sleep(1000);
            Console.WriteLine("\nDo you want to generate again?");
            string anotherGenerate_choice = Console.ReadLine();

            if (anotherGenerate_choice == "Yes")
            {
                goto innerLoop;
            } else
            {
                return;
                //Environment.Exit(0);
            }
        }
        else if (gender_choice == "Female")
        {
            Console.WriteLine
                ("\nName: " + Random_femaleNames + "\n" +
                "Surname: " + Random_surnames + "\n" +
                "Age: " + RandomAge);
            Thread.Sleep(1000);
            Console.WriteLine("\nDo you want to generate again?");
            string anotherGenerate_choice = Console.ReadLine();

            if (anotherGenerate_choice == "Yes")
            {
                goto innerLoop;
            } else
            {
                return;
                //Environment.Exit(0);
            }

        } else
        {
            Console.WriteLine("\nIncorrect gender.");
            goto outerLoop;
        }  
    }
}