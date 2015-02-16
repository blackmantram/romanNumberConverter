using UnityEngine;
using System.Collections;

public class Hundreds : NumericalSection {
	
	public override string FirstString
	{
		get{return "C";}
	}
	
	public override string MiddleString
	{
		get{return "D";}
	}
	
	public override string LastString
	{
		get{return "M";}
	}
	
	protected override int SectionNumber
	{
		get{return 3;}
	}
	
	public Hundreds(int number):base(number){}
}
