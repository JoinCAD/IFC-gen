/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcRelSpaceBoundary : IfcRelConnects 
	{
		public IfcRelSpaceBoundary(IfcRelSpaceBoundaryRelatingSpace relatingSpace,
				IfcElement relatedBuildingElement,
				IfcConnectionGeometry connectionGeometry,
				IfcPhysicalOrVirtualEnum physicalOrVirtualBoundary,
				Boolean physicalOrVirtualBoundarySpecified,
				IfcInternalOrExternalEnum internalOrExternalBoundary,
				Boolean internalOrExternalBoundarySpecified) : base()
		{
			this.RelatingSpace = relatingSpace;
			this.RelatedBuildingElement = relatedBuildingElement;
			this.ConnectionGeometry = connectionGeometry;
			this.PhysicalOrVirtualBoundary = physicalOrVirtualBoundary;
			this.PhysicalOrVirtualBoundarySpecified = physicalOrVirtualBoundarySpecified;
			this.InternalOrExternalBoundary = internalOrExternalBoundary;
			this.InternalOrExternalBoundarySpecified = internalOrExternalBoundarySpecified;
		}
	}
}