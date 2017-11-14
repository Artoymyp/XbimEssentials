// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PropertyResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.MaterialResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMaterial
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterial : IPersistEntity, IfcMaterialSelect, IfcObjectReferenceSelect
	{
		IfcLabel @Name { get;  set; }
		IEnumerable<IIfcMaterialDefinitionRepresentation> @HasRepresentation {  get; }
		IEnumerable<IIfcMaterialClassificationRelationship> @ClassifiedAs {  get; }
	
	}
}

namespace Xbim.Ifc2x3.MaterialResource
{
	[ExpressType("IfcMaterial", 94)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterial : PersistEntity, IInstantiableEntity, IIfcMaterial, IEquatable<@IfcMaterial>
	{
		#region IIfcMaterial explicit implementation
		IfcLabel IIfcMaterial.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		 
		IEnumerable<IIfcMaterialDefinitionRepresentation> IIfcMaterial.HasRepresentation {  get { return @HasRepresentation; } }
		IEnumerable<IIfcMaterialClassificationRelationship> IIfcMaterial.ClassifiedAs {  get { return @ClassifiedAs; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterial(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 1);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RepresentedMaterial")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 2)]
		public IEnumerable<IfcMaterialDefinitionRepresentation> @HasRepresentation 
		{ 
			get 
			{
				return Model.Instances.Where<IfcMaterialDefinitionRepresentation>(e => Equals(e.RepresentedMaterial), "RepresentedMaterial", this);
			} 
		}
		[InverseProperty("ClassifiedMaterial")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 3)]
		public IEnumerable<IfcMaterialClassificationRelationship> @ClassifiedAs 
		{ 
			get 
			{
				return Model.Instances.Where<IfcMaterialClassificationRelationship>(e => Equals(e.ClassifiedMaterial), "ClassifiedMaterial", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterial other)
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