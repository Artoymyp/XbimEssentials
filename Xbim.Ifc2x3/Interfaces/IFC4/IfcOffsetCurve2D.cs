// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.GeometryResource
{
	public partial class @IfcOffsetCurve2D : IIfcOffsetCurve2D
	{

		[CrossSchemaAttribute(typeof(IIfcOffsetCurve2D), 1)]
		IIfcCurve IIfcOffsetCurve2D.BasisCurve 
		{ 
			get
			{
				return BasisCurve;
			} 
			set
			{
				BasisCurve = value as IfcCurve;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcOffsetCurve2D), 2)]
		Ifc4.MeasureResource.IfcLengthMeasure IIfcOffsetCurve2D.Distance 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLengthMeasure(Distance);
			} 
			set
			{
				Distance = new MeasureResource.IfcLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcOffsetCurve2D), 3)]
		Ifc4.MeasureResource.IfcLogical IIfcOffsetCurve2D.SelfIntersect 
		{ 
			get
			{
				//## Handle return of SelfIntersect for which no match was found
                return new Ifc4.MeasureResource.IfcLogical(SelfIntersect);
				//##
			} 
			set
			{
				SelfIntersect = value;
				
			}
		}
	//## Custom code
	//##
	}
}