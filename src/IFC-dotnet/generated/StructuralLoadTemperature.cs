/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralloadtemperature.htm
	/// </summary>
	internal  partial class StructuralLoadTemperature : StructuralLoadStatic 
	{
		public Double DeltaTConstant {get;set;}

		public Double DeltaTY {get;set;}

		public Double DeltaTZ {get;set;}

		public StructuralLoadTemperature(Double deltaTConstant,
				Double deltaTY,
				Double deltaTZ,
				String name) : base(name)
		{
			this.DeltaTConstant = deltaTConstant;
			this.DeltaTY = deltaTY;
			this.DeltaTZ = deltaTZ;
		}
	}
}