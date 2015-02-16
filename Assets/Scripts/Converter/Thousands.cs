using UnityEngine;
using System.Collections;

public class Thousands : NumericalSection {
	
	public override string FirstString
	{
		get{return "M";}
	}
	
	public override string MiddleString
	{
		get{return "V/";}
	}
	
	public override string LastString
	{
		get{return "X/";}
	}
	
	protected override int SectionNumber
	{
		get{return 4;}
	}
	
	public Thousands(int number):base(number){}
}
