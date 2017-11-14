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
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.Kernel;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelDefinesByProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelDefinesByProperties : IIfcRelDefines
	{
		IItemSet<IIfcObjectDefinition> @RelatedObjects { get; }
		IIfcPropertySetDefinitionSelect @RelatingPropertyDefinition { get;  set; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcRelDefinesByProperties", 247)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelDefinesByProperties : IfcRelDefines, IInstantiableEntity, IIfcRelDefinesByProperties, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelDefinesByProperties>
	{
		#region IIfcRelDefinesByProperties explicit implementation
		IItemSet<IIfcObjectDefinition> IIfcRelDefinesByProperties.RelatedObjects { 
			get { return new Common.Collections.ProxyItemSet<IfcObjectDefinition, IIfcObjectDefinition>( @RelatedObjects); } 
		}	
		IIfcPropertySetDefinitionSelect IIfcRelDefinesByProperties.RelatingPropertyDefinition { 
 
 
			get { return @RelatingPropertyDefinition; } 
			set { RelatingPropertyDefinition = value as IfcPropertySetDefinitionSelect;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelDefinesByProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedObjects = new ItemSet<IfcObjectDefinition>( this, 0,  5);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcObjectDefinition> _relatedObjects;
		private IfcPropertySetDefinitionSelect _relatingPropertyDefinition;
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
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcPropertySetDefinitionSelect @RelatingPropertyDefinition 
		{ 
			get 
			{
				if(_activated) return _relatingPropertyDefinition;
				Activate();
				return _relatingPropertyDefinition;
			} 
			set
			{
				var entity = value as IPersistEntity;
				if (entity != null && !(ReferenceEquals(Model, entity.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingPropertyDefinition = v, _relatingPropertyDefinition, value,  "RelatingPropertyDefinition", 6);
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
					_relatingPropertyDefinition = (IfcPropertySetDefinitionSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelDefinesByProperties other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				foreach(var entity in @RelatedObjects)
					yield return entity;
				if(RelatingPropertyDefinition != null)
					foreach (var definition in RelatingPropertyDefinition.PropertySetDefinitions)
						yield return definition;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @RelatedObjects)
					yield return entity;
				if(RelatingPropertyDefinition != null)
					foreach (var definition in RelatingPropertyDefinition.PropertySetDefinitions)
						yield return definition;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}