string[] maleNames = { "Liam", "Noah", "Oliver", "Elijah", "James", "Max", "James", "William", "Benjamin", "Lucas", "Henry", "Levi" };
string[] femaleNames = { "Olivia", "Emma", "Charlotte", "Amelia", "Ava", "Sophia", "Isabella", "Mia", "Evelyn", "Camilia", "Sofia" };
string[] surnames = { "Smith", "Brown", "Wilson", "Thomson", "Robertson", "Campbell", "Anderson", "Scott", "Marshall", "Stevensn", "Jones" };

Random rand = new Random();

Console.WriteLine("Name generator");
Thread.Sleep(1000);


while (true)
{
    Console.WriteLine("\nChoose gender (Male/Female):");
    string genderChoice = Console.ReadLine().ToLower();

    if (genderChoice != "male" && genderChoice != "female")
    {
        Console.WriteLine("\nIncorrect gender.");
        Thread.Sleep(1000);
    }
    else
    {
        GeneratePerson(genderChoice); 
    }
}

string GenerateSurname(Random rand)
{
    int randomIndexSurnames = rand.Next(surnames.Length);
    string randomSurnames = surnames[randomIndexSurnames];

    return randomSurnames;
}


void GeneratePerson(string genderChoice)
{
    while (true)
    {
        string randomSurnames = GenerateSurname(rand);
        int randomAge = rand.Next(18, 30);

        if (genderChoice == "male")
        {
            int randomIndexMaleNames = rand.Next(maleNames.Length);
            string randomMaleNames = maleNames[randomIndexMaleNames];

            Console.WriteLine
                ($"\nName: {randomMaleNames}\nSurname: {randomSurnames}\nAge: {randomAge}");
        }
        else if (genderChoice == "female")
        {
            int randomIndexFemaleName = rand.Next(femaleNames.Length);
            string randomFemaleNames = femaleNames[randomIndexFemaleName];

            Console.WriteLine
                ($"\nName: {randomFemaleNames}\nSurname: {randomSurnames}\nAge: {randomAge}");

            Console.WriteLine("\nDo you want to generate again?");
            string generateInput = Console.ReadLine().ToLower();

            if (generateInput == "no")
            {
                break;
            }
        }
    }
}





