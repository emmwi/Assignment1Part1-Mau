using System;

public class ConsumedApples
{

    private string name;
    //how many apples the user have had of different sizes. 
    private int sumLargeApples;
    private int sumSmallApples;
    private int sumMediumApples;
    private DateTime currenctDate;

    //constant for calories 
    const int kcalLargeApple = 91;
    const int kcalMiddleApple = 61;
    const int kcalSmallApple = 30;
    //total calories 
    int sumCaloriesForApples;

    // Method to welcome user and to let user add how many apples of different sizes they have eaten today. 
    private void AppleInput()
    {
        Console.Write("Welcome to Applecounter, here we count how many apples you've had today. Please tell us, what is your name? ");
        name = Console.ReadLine();

        Console.Write("how many large apples have you had today? ");
        string largeApples = Console.ReadLine();

        sumLargeApples = int.Parse(largeApples);

        Console.Write("how many medium apples have you had today? ");
        string mediumApples = Console.ReadLine();

        sumMediumApples = int.Parse(mediumApples);

        Console.Write("how many small apples have you had today? ");
        string smallApples = Console.ReadLine();

        sumSmallApples = int.Parse(smallApples);

    }


    //method to calculate the calories for the apples that have been eaten with a constant kcal per apple different constant for 3 different sizes. 
    private void CountCalories()
    {
       AppleInput();

        int kcalTotalLargeApple = sumLargeApples * kcalLargeApple;
        int kcalTotalMediumApple = sumMediumApples * kcalMiddleApple;
        int kcalTotalSmallApple = sumSmallApples * kcalSmallApple;

       sumCaloriesForApples = kcalTotalLargeApple + kcalTotalMediumApple + kcalTotalSmallApple;
    }

    //method to read out to user how many apples they have on todays-date and also how much calories all of those apples end up to be together. 
    private void readTotalOfApplesAndCalories()
    {
        CountCalories();
        //get current date here. 
        currenctDate = DateTime.Now;
        
        //make sure the string being written to user is different depending on if user had one or more apples per size. 
        string smallAppleText = sumSmallApples == 1
            ? "1 small apple" : $"{sumSmallApples} small apples";

        string mediumAppleText = sumMediumApples == 1
           ? "1 medium apple" : $"{sumMediumApples} medium apples";

        string largeAppleText = sumLargeApples == 1
           ? "1 large apple" : $"{sumLargeApples} large apples";

        //making sure its not written anything if unser didnt eat any apples of a certain size. 
        Console.WriteLine($"Hey {name}, today: {currenctDate} you have eaten: ");
        Console.WriteLine($"{(sumSmallApples == 0 ? "" : smallAppleText)}");
        Console.WriteLine($"{(sumMediumApples == 0 ? "" : mediumAppleText)}");
        Console.WriteLine($"{(sumLargeApples == 0 ? "" : largeAppleText)}");
        Console.WriteLine($"the total in calories consumed is {sumCaloriesForApples} kcal");
    }

    public void Start()
    {
        readTotalOfApplesAndCalories();
    }
}