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
	public partial class @IfcRectangularTrimmedSurface : IIfcRectangularTrimmedSurface
	{

		[CrossSchemaAttribute(typeof(IIfcRectangularTrimmedSurface), 1)]
		IIfcSurface IIfcRectangularTrimmedSurface.BasisSurface 
		{ 
			get
			{
				return BasisSurface;
			} 
			set
			{
				BasisSurface = value as IfcSurface;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRectangularTrimmedSurface), 2)]
		Ifc4.MeasureResource.IfcParameterValue IIfcRectangularTrimmedSurface.U1 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcParameterValue(U1);
			} 
			set
			{
				U1 = new MeasureResource.IfcParameterValue(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRectangularTrimmedSurface), 3)]
		Ifc4.MeasureResource.IfcParameterValue IIfcRectangularTrimmedSurface.V1 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcParameterValue(V1);
			} 
			set
			{
				V1 = new MeasureResource.IfcParameterValue(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRectangularTrimmedSurface), 4)]
		Ifc4.MeasureResource.IfcParameterValue IIfcRectangularTrimmedSurface.U2 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcParameterValue(U2);
			} 
			set
			{
				U2 = new MeasureResource.IfcParameterValue(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRectangularTrimmedSurface), 5)]
		Ifc4.MeasureResource.IfcParameterValue IIfcRectangularTrimmedSurface.V2 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcParameterValue(V2);
			} 
			set
			{
				V2 = new MeasureResource.IfcParameterValue(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRectangularTrimmedSurface), 6)]
		Ifc4.MeasureResource.IfcBoolean IIfcRectangularTrimmedSurface.Usense 
		{ 
			get
			{
				//## Handle return of Usense for which no match was found
                return new Ifc4.MeasureResource.IfcBoolean(Usense);
			    //##
			} 
			set
			{
				Usense = value;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRectangularTrimmedSurface), 7)]
		Ifc4.MeasureResource.IfcBoolean IIfcRectangularTrimmedSurface.Vsense 
		{ 
			get
			{
				//## Handle return of Vsense for which no match was found
                return new Ifc4.MeasureResource.IfcBoolean(Vsense);
				//##
			} 
			set
			{
				Vsense = value;
				
			}
		}
	//## Custom code
	//##
	}
}