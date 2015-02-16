using UnityEngine;
using System.Collections;

public class Tens : NumericalSection {

	public override string FirstString
	{
		get{return "X";}
	}
	
	public override string MiddleString
	{
		get{return "L";}
	}
	
	public override string LastString
	{
		get{return "C";}
	}
	
	protected override int SectionNumber
	{
		get{return 2;}
	}
	
	public Tens(int number):base(number){}
}
