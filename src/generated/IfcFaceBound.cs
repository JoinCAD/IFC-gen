/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcFaceBound : IfcTopologicalRepresentationItem 
	{
		public IfcFaceBound(IfcLoop bound,
				Boolean orientation,
				Boolean orientationSpecified,
				IfcStyledItem styledByItem) : base(styledByItem)
		{
			this.Bound = bound;
			this.Orientation = orientation;
			this.OrientationSpecified = orientationSpecified;
		}
	}
}