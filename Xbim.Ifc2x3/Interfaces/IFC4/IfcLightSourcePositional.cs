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

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	public partial class @IfcLightSourcePositional : IIfcLightSourcePositional
	{
		IIfcCartesianPoint IIfcLightSourcePositional.Position 
		{ 
			get
			{
				return Position;
			} 
			set
			{
				Position = value as GeometryResource.IfcCartesianPoint;
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcLightSourcePositional.Radius 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(Radius);
			} 
			set
			{
				Radius = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}
		Ifc4.MeasureResource.IfcReal IIfcLightSourcePositional.ConstantAttenuation 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcReal(ConstantAttenuation);
			} 
			set
			{
				ConstantAttenuation = new MeasureResource.IfcReal(value);
				
			}
		}
		Ifc4.MeasureResource.IfcReal IIfcLightSourcePositional.DistanceAttenuation 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcReal(DistanceAttenuation);
			} 
			set
			{
				DistanceAttenuation = new MeasureResource.IfcReal(value);
				
			}
		}
		Ifc4.MeasureResource.IfcReal IIfcLightSourcePositional.QuadricAttenuation 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcReal(QuadricAttenuation);
			} 
			set
			{
				QuadricAttenuation = new MeasureResource.IfcReal(value);
				
			}
		}
	//## Custom code
	//##
	}
}