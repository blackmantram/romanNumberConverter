using UnityEngine;
using System.Collections;

public class DecimalToRomanConverter {

	private const int MAX_NUMBER_ALLOWED = 1399;
	private int number;

	public string Convert(int number)
	{
		this.number = number;
		if (number > MAX_NUMBER_ALLOWED)
			return "NotAllowed";
		return GetThousands() + GetHundreds() + GetTens() + GetUnits();
	}

	private string GetUnits()
	{
		Units units = new Units(number);
		return units.GetAsString();
	}

	private string GetTens()
	{
		Tens tens = new Tens(number);
		return tens.GetAsString();
	}

	private string GetHundreds()
	{
		Hundreds hundreds = new Hundreds(number);
		return hundreds.GetAsString();
	}

	private string GetThousands()
	{
		Thousands thousands = new Thousands(number);
		return thousands.GetAsString();
	}

}
