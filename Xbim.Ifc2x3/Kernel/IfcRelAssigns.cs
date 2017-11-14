// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.Kernel;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelAssigns
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelAssigns : IIfcRelationship
	{
		IItemSet<IIfcObjectDefinition> @RelatedObjects { get; }
		IfcObjectTypeEnum? @RelatedObjectsType { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IfcRelAssigns", 10)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcRelAssigns : IfcRelationship, IIfcRelAssigns, IEquatable<@IfcRelAssigns>
	{
		#region IIfcRelAssigns explicit implementation
		IItemSet<IIfcObjectDefinition> IIfcRelAssigns.RelatedObjects { 
			get { return new Common.Collections.ProxyItemSet<IfcObjectDefinition, IIfcObjectDefinition>( @RelatedObjects); } 
		}	
		IfcObjectTypeEnum? IIfcRelAssigns.RelatedObjectsType { 
 
			get { return @RelatedObjectsType; } 
			set { RelatedObjectsType = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssigns(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedObjects = new ItemSet<IfcObjectDefinition>( this, 0,  5);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcObjectDefinition> _relatedObjects;
		private IfcObjectTypeEnum? _relatedObjectsType;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 5)]
		public IItemSet<IfcObjectDefinition> @RelatedObjects 
		{ 
			get 
			{
				if(_activated) return _relatedObjects;
				Activate();
				return _relatedObjects;
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 6)]
		public IfcObjectTypeEnum? @RelatedObjectsType 
		{ 
			get 
			{
				if(_activated) return _relatedObjectsType;
				Activate();
				return _relatedObjectsType;
			} 
			set
			{
				SetValue( v =>  _relatedObjectsType = v, _relatedObjectsType, value,  "RelatedObjectsType", 6);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_relatedObjects.InternalAdd((IfcObjectDefinition)value.EntityVal);
					return;
				case 5: 
                    _relatedObjectsType = (IfcObjectTypeEnum) System.Enum.Parse(typeof (IfcObjectTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelAssigns other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}