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
namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	public partial class @IfcStructuralAction : IIfcStructuralAction
	{

		[CrossSchemaAttribute(typeof(IIfcStructuralAction), 10)]
		Ifc4.MeasureResource.IfcBoolean? IIfcStructuralAction.DestabilizingLoad 
		{ 
			get
			{
				//## Handle return of DestabilizingLoad for which no match was found
			    return new Ifc4.MeasureResource.IfcBoolean(DestabilizingLoad);
			    //##
			} 
			set
			{
				//## Handle setting of DestabilizingLoad for which no match was found
			    if (!value.HasValue)
			        DestabilizingLoad = false;
			    else
			        DestabilizingLoad = value.Value;
			    //##
				
			}
		}
	//## Custom code
	//##
	}
}