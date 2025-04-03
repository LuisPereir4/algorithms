using System;
					
public class Program
{
	public static void Main()
	{
		BinarySearch(new int[] { 1, 2, 3 }, 2);
	}
	
	public static int BinarySearch(int[] orderedArray, int desiredValue) 
	{
		int low = 0;
		int high = orderedArray.Length - 1;
		
		while (low <= high) 
		{
			int midIndex = (high + low) / 2; 
			int midValue = orderedArray[midIndex];
			
			if (midValue == desiredValue) 
			{
				Console.WriteLine($"Value {desiredValue} was found on the array position {midIndex}");
				return midIndex;
			}
			else if (midValue < desiredValue) 
			{
				low = midIndex + 1;
			}
			else if (midValue > desiredValue) 
			{
				high = midIndex - 1;
			}
		}
		
		Console.WriteLine($"Value {desiredValue} was not found on the array");
		return int.MaxValue;
	}
}