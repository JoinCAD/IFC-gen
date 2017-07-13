/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctextliteral.htm
	/// </summary>
	internal  partial class TextLiteral : GeometricRepresentationItem 
	{
		public TextLiteralPlacement Placement {get;set;}

		public String Literal {get;set;}

		public TextPath Path {get;set;}

		public TextLiteral(TextLiteralPlacement placement,
				String literal,
				TextPath path,
				StyledItem styledByItem) : base(styledByItem)
		{
			this.Placement = placement;
			this.Literal = literal;
			this.Path = path;
		}
	}
}