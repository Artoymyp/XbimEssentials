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
namespace Xbim.Ifc2x3.Kernel
{
	public partial class @IfcRelAssociatesClassification : IIfcRelAssociatesClassification
	{

		[CrossSchemaAttribute(typeof(IIfcRelAssociatesClassification), 6)]
		IIfcClassificationSelect IIfcRelAssociatesClassification.RelatingClassification 
		{ 
			get
			{
				//## Handle return of RelatingClassification for which no match was found
			    return RelatingClassification as IIfcClassificationSelect;
			    //##
			} 
			set
			{
				//## Handle setting of RelatingClassification for which no match was found
				RelatingClassification = value as ExternalReferenceResource.IfcClassificationNotationSelect;
				//##
				
			}
		}
	//## Custom code
	//##
	}
}