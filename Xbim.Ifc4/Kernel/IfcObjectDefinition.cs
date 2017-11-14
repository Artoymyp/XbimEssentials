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
    /// Readonly interface for IfcObjectDefinition
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcObjectDefinition : IIfcRoot, IfcDefinitionSelect
	{
		IEnumerable<IIfcRelAssigns> @HasAssignments {  get; }
		IEnumerable<IIfcRelNests> @Nests {  get; }
		IEnumerable<IIfcRelNests> @IsNestedBy {  get; }
		IEnumerable<IIfcRelDeclares> @HasContext {  get; }
		IEnumerable<IIfcRelAggregates> @IsDecomposedBy {  get; }
		IEnumerable<IIfcRelAggregates> @Decomposes {  get; }
		IEnumerable<IIfcRelAssociates> @HasAssociations {  get; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcObjectDefinition", 22)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcObjectDefinition : IfcRoot, IIfcObjectDefinition, IEquatable<@IfcObjectDefinition>
	{
		#region IIfcObjectDefinition explicit implementation
		 
		IEnumerable<IIfcRelAssigns> IIfcObjectDefinition.HasAssignments {  get { return @HasAssignments; } }
		IEnumerable<IIfcRelNests> IIfcObjectDefinition.Nests {  get { return @Nests; } }
		IEnumerable<IIfcRelNests> IIfcObjectDefinition.IsNestedBy {  get { return @IsNestedBy; } }
		IEnumerable<IIfcRelDeclares> IIfcObjectDefinition.HasContext {  get { return @HasContext; } }
		IEnumerable<IIfcRelAggregates> IIfcObjectDefinition.IsDecomposedBy {  get { return @IsDecomposedBy; } }
		IEnumerable<IIfcRelAggregates> IIfcObjectDefinition.Decomposes {  get { return @Decomposes; } }
		IEnumerable<IIfcRelAssociates> IIfcObjectDefinition.HasAssociations {  get { return @HasAssociations; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcObjectDefinition(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}




		#region Inverse attributes
		[InverseProperty("RelatedObjects")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 5)]
		public IEnumerable<IfcRelAssigns> @HasAssignments 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssigns>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this), "RelatedObjects", this);
			} 
		}
		[InverseProperty("RelatedObjects")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 6)]
		public IEnumerable<IfcRelNests> @Nests 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelNests>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this), "RelatedObjects", this);
			} 
		}
		[InverseProperty("RelatingObject")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 7)]
		public IEnumerable<IfcRelNests> @IsNestedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelNests>(e => Equals(e.RelatingObject), "RelatingObject", this);
			} 
		}
		[InverseProperty("RelatedDefinitions")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 8)]
		public IEnumerable<IfcRelDeclares> @HasContext 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDeclares>(e => e.RelatedDefinitions != null &&  e.RelatedDefinitions.Contains(this), "RelatedDefinitions", this);
			} 
		}
		[InverseProperty("RelatingObject")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 9)]
		public IEnumerable<IfcRelAggregates> @IsDecomposedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAggregates>(e => Equals(e.RelatingObject), "RelatingObject", this);
			} 
		}
		[InverseProperty("RelatedObjects")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 10)]
		public IEnumerable<IfcRelAggregates> @Decomposes 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAggregates>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this), "RelatedObjects", this);
			} 
		}
		[InverseProperty("RelatedObjects")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 11)]
		public IEnumerable<IfcRelAssociates> @HasAssociations 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociates>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this), "RelatedObjects", this);
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
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcObjectDefinition other)
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