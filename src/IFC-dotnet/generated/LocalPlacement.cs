/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclocalplacement.htm
	/// </summary>
	internal  partial class LocalPlacement : ObjectPlacement 
	{
		public ObjectPlacement PlacementRelTo {get;set;}

		public LocalPlacementRelativePlacement RelativePlacement {get;set;}

		public LocalPlacement(ObjectPlacement placementRelTo,
				LocalPlacementRelativePlacement relativePlacement) : base()
		{
			this.PlacementRelTo = placementRelTo;
			this.RelativePlacement = relativePlacement;
		}
	}
}