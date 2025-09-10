using System;

public class Pet
{
	//variables for pets name, age and if its a female or not 
	private string name;
	private int age;
	private bool isFemale;

	//method to enter pet-information by user
	private void PetInput()
	{
		Console.Write("What is the name of your pet? ");
		name = Console.ReadLine();

		//input is a string and we need to parse the string from input to an int.  
		Console.Write("What is the age of your pet? ");
		string ageInput = Console.ReadLine();
		age = int.Parse(ageInput);

		//same here, we need to parse the string from input to a bool. 
		Console.Write("Is the pet a female? (true/false.) ");
		string genderInput = Console.ReadLine();
		isFemale = bool.Parse(genderInput);
	}
	private void ReadPetInformation()
	{
		Console.WriteLine($"Name: {name} Age:{age}");
		Console.WriteLine($"{name} is a good {(isFemale ? "girl" : "boy")}");
	}
	//this method needs to be public to be reachable from the main-method in program.cs
	public void Start()
	{
		PetInput();
		ReadPetInformation();
	}
}


