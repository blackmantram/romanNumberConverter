using UnityEngine;
using System.Collections;

public abstract class NumericalSection 
{
	private int value;

	public abstract string FirstString
	{
		get;
	}

	public abstract string MiddleString
	{
		get;
	}

	public abstract string LastString
	{
		get;
	}

	protected abstract int SectionNumber
	{
		get;
	}

	public NumericalSection(int number)
	{
		value = GetNumericalSection(number, SectionNumber);
		value = value / (int)Mathf.Pow(10f, (float)SectionNumber-1);
	}

	public string GetAsString()
	{
		return EvaluateFirstMiddle(value) + EvaluateSecondMiddle(value);
	}

	private string EvaluateFirstMiddle(int number)
	{
		if (number < 4)
			return RepeatFirstString("", number);
		else if (number == 4)
			return FirstString + MiddleString;
		return "";
	}

	private string EvaluateSecondMiddle(int number)
	{
		if (number >= 5 && number < 9)
			return MiddleString + RepeatFirstString("", number-5);
		else if (number == 9)
			return FirstString + LastString;
		return "";
	}

	private string RepeatFirstString(string returnString, int count)
	{
		if (count > 0)
			returnString = RepeatFirstString(returnString + FirstString, count-1);
		return returnString;
	}
	
	private int GetNumericalSection(int number, int section)
	{
		int sum = 0;
		int i = section;
		while(i>1)
		{
			i--;
			sum += GetNumericalSection(number, i);
		}
		return (number % (int)Mathf.Pow(10f, (float)section)) - sum;
	}
}
