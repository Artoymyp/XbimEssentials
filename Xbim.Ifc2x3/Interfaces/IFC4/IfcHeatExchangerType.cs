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
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcHeatExchangerType : IIfcHeatExchangerType
	{
		Ifc4.Interfaces.IfcHeatExchangerTypeEnum IIfcHeatExchangerType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcHeatExchangerTypeEnum.PLATE:
						return Ifc4.Interfaces.IfcHeatExchangerTypeEnum.PLATE;
					
					case IfcHeatExchangerTypeEnum.SHELLANDTUBE:
						return Ifc4.Interfaces.IfcHeatExchangerTypeEnum.SHELLANDTUBE;
					
					case IfcHeatExchangerTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcHeatExchangerTypeEnum.USERDEFINED;
					
					case IfcHeatExchangerTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcHeatExchangerTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				switch (value)
				{
					case Ifc4.Interfaces.IfcHeatExchangerTypeEnum.PLATE:
						PredefinedType = IfcHeatExchangerTypeEnum.PLATE;
						return;
					
					case Ifc4.Interfaces.IfcHeatExchangerTypeEnum.SHELLANDTUBE:
						PredefinedType = IfcHeatExchangerTypeEnum.SHELLANDTUBE;
						return;
					
					case Ifc4.Interfaces.IfcHeatExchangerTypeEnum.USERDEFINED:
						PredefinedType = IfcHeatExchangerTypeEnum.USERDEFINED;
						return;
					
					case Ifc4.Interfaces.IfcHeatExchangerTypeEnum.NOTDEFINED:
						PredefinedType = IfcHeatExchangerTypeEnum.NOTDEFINED;
						return;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}