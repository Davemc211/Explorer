using System;
namespace Learning.Model
{
	public interface Element
	{

		int mass;

		double density;

		int conductivity;

		int magnetism;

		int meltingPoint;

		int boilingPoint;

		string color;

		string stateOfMatter;

		//int freezingPoint; // belongs in LiquidElement?

		//int dewPoint; // belong in GaseousElement?
	}
}

