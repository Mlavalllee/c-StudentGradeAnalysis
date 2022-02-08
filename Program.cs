// Grades array
int[] grades = new int[50];

// Randomize grades before starting
Randomize();

// Start 
Menu();

// Main Menu
void Menu()
{
    Console.WriteLine("Main Menu");
    Console.WriteLine("1: Display all grades");
    Console.WriteLine("2: Randomize Grades");
    Console.WriteLine("3: Stats");
    Console.WriteLine("4: Count Honours");
    Console.WriteLine("5: Exit");
    Console.WriteLine("Input:");

    string Input = Console.ReadLine();

    // Check selected option
    switch(Input)
    {
        case "1":
            Console.Clear();
            DisplayAll();
            break;
        case "2":
            Console.Clear();
            Randomize();
            break;
        case "3":
            Console.Clear();
            Stats();
            break;
        case "4":
            Console.Clear();
            Honours();
            break;
        case "5":
            Console.Clear();
            break;
        default:
            Console.Clear();
            Console.WriteLine("Option not chosen, please retry");
            Menu();
            break;
    }
}

// Display all grades
void DisplayAll()
{
    // Loop through array
    for (int i = 0;i < 50 ; i++)
    {
        // Output
        Console.WriteLine($"Student {i+1} grade: {grades[i]}%");
    }
    // Return to menu
    Menu();
}

// Randomize all grades
void Randomize()
{
    // Random num variable
    Random num = new Random();
    // Loop through array
    for (int i = 0; i < 50; i++)
    {
        // Randomize grade values
        grades[i] = num.Next(0, 100); ;
    }
    Menu();
}

//determine and output the highest, lowest, and avg grade
void Stats()
{
    // min, max, avg variables
    int min = 100;
    int max = 0;
    int avg = 0;
    for (int i = 0; i < 50; i++)
    {
        // Get lowest grade
        if(grades[i] < min)
        {
            min = grades[i];
        }
        // get highest grade
        if (grades[i] > max)
        {
            max = grades[i];
        }
        // get grade average
        avg = avg + grades[i]; 
    }
    // Calculate Average
    avg = avg / 50;
    // Output
    Console.WriteLine($"The lowest grade is: {min}");
    Console.WriteLine($"the highest grade is: {max}");
    Console.WriteLine($"the average is: {avg}");
    // Return to menu
    Menu();
}

//Ccount and output total number of grades over 80
void Honours()
{   // amount of honur students variable
    int total = 0;
    // Loop through array
    for (int i = 0; i < 50; i++)
    {
        // check is grade are over 80 and add to total
        if (grades[i] > 80)
        {
            total++;
        }
    }
    //output
    Console.WriteLine($"There are {total} Honur students");
    // Return to menu
    Menu();
}