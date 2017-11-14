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
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcUnitAssignment
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcUnitAssignment : IPersistEntity
	{
		IItemSet<IIfcUnit> @Units { get; }
	
	}
}

namespace Xbim.Ifc4.MeasureResource
{
	[ExpressType("IfcUnitAssignment", 245)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcUnitAssignment : PersistEntity, IInstantiableEntity, IIfcUnitAssignment, IContainsEntityReferences, IEquatable<@IfcUnitAssignment>
	{
		#region IIfcUnitAssignment explicit implementation
		IItemSet<IIfcUnit> IIfcUnitAssignment.Units { 
			get { return new Common.Collections.ProxyItemSet<IfcUnit, IIfcUnit>( @Units); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcUnitAssignment(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_units = new ItemSet<IfcUnit>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcUnit> _units;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 1)]
		public IItemSet<IfcUnit> @Units 
		{ 
			get 
			{
				if(_activated) return _units;
				Activate();
				return _units;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_units.InternalAdd((IfcUnit)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcUnitAssignment other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Units)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}