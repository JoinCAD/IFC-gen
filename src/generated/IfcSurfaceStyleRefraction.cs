/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcSurfaceStyleRefraction : IfcPresentationItem 
	{
		public IfcSurfaceStyleRefraction(Double refractionIndex,
				Boolean refractionIndexSpecified,
				Double dispersionFactor,
				Boolean dispersionFactorSpecified) : base()
		{
			this.RefractionIndex = refractionIndex;
			this.RefractionIndexSpecified = refractionIndexSpecified;
			this.DispersionFactor = dispersionFactor;
			this.DispersionFactorSpecified = dispersionFactorSpecified;
		}
	}
}