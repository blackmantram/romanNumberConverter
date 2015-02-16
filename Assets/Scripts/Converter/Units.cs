using UnityEngine;
using System.Collections;

public class Units: NumericalSection {

	public override string FirstString
	{
		get{return "I";}
	}
	
	public override string MiddleString
	{
		get{return "V";}
	}
	
	public override string LastString
	{
		get{return "X";}
	}

	protected override int SectionNumber
	{
		get{return 1;}
	}

	public Units(int number):base(number){}
}
