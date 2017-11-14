// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MaterialResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.RepresentationResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMaterialDefinitionRepresentation
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterialDefinitionRepresentation : IIfcProductRepresentation
	{
		IIfcMaterial @RepresentedMaterial { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.RepresentationResource
{
	[ExpressType("IfcMaterialDefinitionRepresentation", 2)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialDefinitionRepresentation : IfcProductRepresentation, IInstantiableEntity, IIfcMaterialDefinitionRepresentation, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcMaterialDefinitionRepresentation>
	{
		#region IIfcMaterialDefinitionRepresentation explicit implementation
		IIfcMaterial IIfcMaterialDefinitionRepresentation.RepresentedMaterial { 
 
 
			get { return @RepresentedMaterial; } 
			set { RepresentedMaterial = value as IfcMaterial;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialDefinitionRepresentation(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcMaterial _representedMaterial;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcMaterial @RepresentedMaterial 
		{ 
			get 
			{
				if(_activated) return _representedMaterial;
				Activate();
				return _representedMaterial;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _representedMaterial = v, _representedMaterial, value,  "RepresentedMaterial", 4);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_representedMaterial = (IfcMaterial)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialDefinitionRepresentation other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Representations)
					yield return entity;
				if (@RepresentedMaterial != null)
					yield return @RepresentedMaterial;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Representations)
					yield return entity;
				if (@RepresentedMaterial != null)
					yield return @RepresentedMaterial;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}