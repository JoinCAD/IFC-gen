/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpropertyenumeratedvalue.htm
	/// </summary>
	internal  partial class PropertyEnumeratedValue : SimpleProperty 
	{
		public PropertyEnumeratedValueEnumerationValues EnumerationValues {get;set;}

		public PropertyEnumeration EnumerationReference {get;set;}

		public PropertyEnumeratedValue(PropertyEnumeratedValueEnumerationValues enumerationValues,
				PropertyEnumeration enumerationReference,
				String name,
				String description) : base(name,
				description)
		{
			this.EnumerationValues = enumerationValues;
			this.EnumerationReference = enumerationReference;
		}
	}
}