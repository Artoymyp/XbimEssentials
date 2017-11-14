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
namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	public partial class @IfcSectionReinforcementProperties : IIfcSectionReinforcementProperties
	{

		[CrossSchemaAttribute(typeof(IIfcSectionReinforcementProperties), 1)]
		Ifc4.MeasureResource.IfcLengthMeasure IIfcSectionReinforcementProperties.LongitudinalStartPosition 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLengthMeasure(LongitudinalStartPosition);
			} 
			set
			{
				LongitudinalStartPosition = new MeasureResource.IfcLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSectionReinforcementProperties), 2)]
		Ifc4.MeasureResource.IfcLengthMeasure IIfcSectionReinforcementProperties.LongitudinalEndPosition 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLengthMeasure(LongitudinalEndPosition);
			} 
			set
			{
				LongitudinalEndPosition = new MeasureResource.IfcLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSectionReinforcementProperties), 3)]
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcSectionReinforcementProperties.TransversePosition 
		{ 
			get
			{
				if (!TransversePosition.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(TransversePosition.Value);
			} 
			set
			{
				TransversePosition = value.HasValue ? 
					new MeasureResource.IfcLengthMeasure(value.Value) :  
					 new MeasureResource.IfcLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSectionReinforcementProperties), 4)]
		Ifc4.Interfaces.IfcReinforcingBarRoleEnum IIfcSectionReinforcementProperties.ReinforcementRole 
		{ 
			get
			{
				//## Custom code to handle enumeration of ReinforcementRole
			    if (_role.HasValue) 
                    return _role.Value;
				//##
				switch (ReinforcementRole)
				{
					case IfcReinforcingBarRoleEnum.MAIN:
						return Ifc4.Interfaces.IfcReinforcingBarRoleEnum.MAIN;
					case IfcReinforcingBarRoleEnum.SHEAR:
						return Ifc4.Interfaces.IfcReinforcingBarRoleEnum.SHEAR;
					case IfcReinforcingBarRoleEnum.LIGATURE:
						return Ifc4.Interfaces.IfcReinforcingBarRoleEnum.LIGATURE;
					case IfcReinforcingBarRoleEnum.STUD:
						return Ifc4.Interfaces.IfcReinforcingBarRoleEnum.STUD;
					case IfcReinforcingBarRoleEnum.PUNCHING:
						return Ifc4.Interfaces.IfcReinforcingBarRoleEnum.PUNCHING;
					case IfcReinforcingBarRoleEnum.EDGE:
						return Ifc4.Interfaces.IfcReinforcingBarRoleEnum.EDGE;
					case IfcReinforcingBarRoleEnum.RING:
						return Ifc4.Interfaces.IfcReinforcingBarRoleEnum.RING;
					case IfcReinforcingBarRoleEnum.USERDEFINED:
						//## Optional custom handling of ReinforcementRole == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcReinforcingBarRoleEnum.USERDEFINED;
					case IfcReinforcingBarRoleEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcReinforcingBarRoleEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of ReinforcementRole
                if (value != Ifc4.Interfaces.IfcReinforcingBarRoleEnum.ANCHORING)
                    SetValue(v => _role = v, _role, null, "ReinforcementRole", -4);
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcReinforcingBarRoleEnum.MAIN:
						ReinforcementRole = IfcReinforcingBarRoleEnum.MAIN;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarRoleEnum.SHEAR:
						ReinforcementRole = IfcReinforcingBarRoleEnum.SHEAR;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarRoleEnum.LIGATURE:
						ReinforcementRole = IfcReinforcingBarRoleEnum.LIGATURE;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarRoleEnum.STUD:
						ReinforcementRole = IfcReinforcingBarRoleEnum.STUD;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarRoleEnum.PUNCHING:
						ReinforcementRole = IfcReinforcingBarRoleEnum.PUNCHING;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarRoleEnum.EDGE:
						ReinforcementRole = IfcReinforcingBarRoleEnum.EDGE;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarRoleEnum.RING:
						ReinforcementRole = IfcReinforcingBarRoleEnum.RING;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarRoleEnum.ANCHORING:
						//## Handle setting of ANCHORING member from IfcReinforcingBarRoleEnum in property ReinforcementRole
						ReinforcementRole = IfcReinforcingBarRoleEnum.USERDEFINED;
                        SetValue(v => _role = v, _role, value, "ReinforcementRole", -4);
				        return;
						//##
										case Ifc4.Interfaces.IfcReinforcingBarRoleEnum.USERDEFINED:
						ReinforcementRole = IfcReinforcingBarRoleEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarRoleEnum.NOTDEFINED:
						ReinforcementRole = IfcReinforcingBarRoleEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSectionReinforcementProperties), 5)]
		IIfcSectionProperties IIfcSectionReinforcementProperties.SectionDefinition 
		{ 
			get
			{
				return SectionDefinition;
			} 
			set
			{
				SectionDefinition = value as IfcSectionProperties;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSectionReinforcementProperties), 6)]
		IItemSet<IIfcReinforcementBarProperties> IIfcSectionReinforcementProperties.CrossSectionReinforcementDefinitions 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcReinforcementBarProperties, IIfcReinforcementBarProperties>(CrossSectionReinforcementDefinitions);
			} 
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcPropertyAbstraction.HasExternalReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
			} 
		}
	//## Custom code
	    private Ifc4.Interfaces.IfcReinforcingBarRoleEnum? _role;
	    //##
	}
}