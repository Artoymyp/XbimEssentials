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
	public partial class @IfcCartesianTransformationOperator3DnonUniform : IIfcCartesianTransformationOperator3DnonUniform
	{

		[CrossSchemaAttribute(typeof(IIfcCartesianTransformationOperator3DnonUniform), 6)]
		Ifc4.MeasureResource.IfcReal? IIfcCartesianTransformationOperator3DnonUniform.Scale2 
		{ 
			get
			{
				//## Handle return of Scale2 for which no match was found
                return Scale2.HasValue ? new Ifc4.MeasureResource.IfcReal(Scale2.Value) : (Ifc4.MeasureResource.IfcReal?)null;
				//##
			} 
			set
			{
				Scale2 = value;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCartesianTransformationOperator3DnonUniform), 7)]
		Ifc4.MeasureResource.IfcReal? IIfcCartesianTransformationOperator3DnonUniform.Scale3 
		{ 
			get
			{
				//## Handle return of Scale3 for which no match was found
                return Scale3.HasValue ? new Ifc4.MeasureResource.IfcReal(Scale3.Value) : (Ifc4.MeasureResource.IfcReal?)null;
				//##
			} 
			set
			{
				Scale3 = value;
				
			}
		}
		Ifc4.MeasureResource.IfcReal IIfcCartesianTransformationOperator3DnonUniform.Scl2 
		{
			get 
			{
				return new Ifc4.MeasureResource.IfcReal(Scl2);
			}
		}

		Ifc4.MeasureResource.IfcReal IIfcCartesianTransformationOperator3DnonUniform.Scl3 
		{
			get 
			{
				return new Ifc4.MeasureResource.IfcReal(Scl3);
			}
		}

	//## Custom code
	//##
	}
}