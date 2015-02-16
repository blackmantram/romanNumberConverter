using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {

	public InputField number1Field;
	public InputField number2Field;
	public Text resultText;

	void Awake () {
		number1Field.onValueChange.AddListener(HandleNumberValueChange);
		number2Field.onValueChange.AddListener(HandleNumberValueChange);
	}

	private void HandleNumberValueChange(string newValue)
	{
		int number1 = GetStringAsInt(number1Field.text);
		int number2 = GetStringAsInt(number2Field.text);
		int result = number1 + number2;
		PrintResult(result);
	}

	private void PrintResult(int result)
	{
		DecimalToRomanConverter converter = new DecimalToRomanConverter();
		resultText.text = converter.Convert(result);
	}

	private int GetStringAsInt(string originalString)
	{
		return originalString.Trim().Length == 0? 0 : int.Parse(originalString);
	}
}
