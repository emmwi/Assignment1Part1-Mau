using System;

public class TicketSeller
{
	private string name;
	private double price = 99;
	private int numOfAdults;
	private int numOfChildren;

	private double amountToPay;

	//input for how many tickets you will need and what your name is 
	private void TicketInput()
	{
		Console.Write("Please write your name ");
		name = Console.ReadLine();


		Console.Write("How many tickets for adults do you want? ");
		string numAdults = Console.ReadLine();
		numOfAdults = int.Parse(numAdults);

		Console.Write("How many tickets for children do you want? ");
		string numChildren = Console.ReadLine();
		numOfChildren = int.Parse(numChildren);
	}

	//method to count total sum of tickets bought, where tickets for children is half the price.  
	private void TicketSum()
	{
		double totalSumAdults = numOfAdults * price;
		double totalSumForChildren = numOfChildren * (price *0.5);

	    amountToPay = totalSumAdults + totalSumForChildren; 
	}

	// method to read how much money that needs to be payed for the tickets, children and adults combined. 
	private void ReadResult()
	{
		TicketSum();
		Console.WriteLine($"Number of adult tickets: {numOfAdults} ({price}/adult)");
		Console.WriteLine($"Number of children tickets: {numOfChildren} ({(price * 0.5)}/child)");
		Console.WriteLine($"The total amount for the tickets: {amountToPay}");
	}

	public void Start() 
	{
		TicketInput();
		ReadResult();
	}
	

}