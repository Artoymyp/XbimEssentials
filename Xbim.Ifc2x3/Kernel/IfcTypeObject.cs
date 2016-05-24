// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
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
    /// Readonly interface for IfcTypeObject
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTypeObject : IIfcObjectDefinition
	{
		IfcLabel? @ApplicableOccurrence { get;  set; }
		IEnumerable<IIfcPropertySetDefinition> @HasPropertySets { get; }
		IEnumerable<IIfcRelDefinesByType> @ObjectTypeOf {  get; }
	
	}
}

namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IfcTypeObject", 42)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTypeObject : IfcObjectDefinition, IInstantiableEntity, IIfcTypeObject, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcTypeObject>
	{
		#region IIfcTypeObject explicit implementation
		IfcLabel? IIfcTypeObject.ApplicableOccurrence { 
			get { return @ApplicableOccurrence; } 
 
			set { ApplicableOccurrence = value;}
		}	
		IEnumerable<IIfcPropertySetDefinition> IIfcTypeObject.HasPropertySets { 
			get { return @HasPropertySets; } 
		}	
		 
		IEnumerable<IIfcRelDefinesByType> IIfcTypeObject.ObjectTypeOf {  get { return @ObjectTypeOf; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTypeObject(IModel model) : base(model) 		{ 
			Model = model; 
			_hasPropertySets = new OptionalItemSet<IfcPropertySetDefinition>( this, 0,  6);
		}

		#region Explicit attribute fields
		private IfcLabel? _applicableOccurrence;
		private OptionalItemSet<IfcPropertySetDefinition> _hasPropertySets;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 9)]
		public IfcLabel? @ApplicableOccurrence 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _applicableOccurrence;
				((IPersistEntity)this).Activate(false);
				return _applicableOccurrence;
			} 
			set
			{
				SetValue( v =>  _applicableOccurrence = v, _applicableOccurrence, value,  "ApplicableOccurrence", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 10)]
		public OptionalItemSet<IfcPropertySetDefinition> @HasPropertySets 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _hasPropertySets;
				((IPersistEntity)this).Activate(false);
				return _hasPropertySets;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatingType")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 11)]
		public IEnumerable<IfcRelDefinesByType> @ObjectTypeOf 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByType>(e => Equals(e.RelatingType), "RelatingType", this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
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
					_applicableOccurrence = value.StringVal;
					return;
				case 5: 
					_hasPropertySets.InternalAdd((IfcPropertySetDefinition)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTypeObject other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTypeObject
            var root = (@IfcTypeObject)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTypeObject left, @IfcTypeObject right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTypeObject left, @IfcTypeObject right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				foreach(var entity in @HasPropertySets)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @HasPropertySets)
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