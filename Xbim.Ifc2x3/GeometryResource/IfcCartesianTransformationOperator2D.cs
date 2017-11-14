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
using Xbim.Ifc2x3.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCartesianTransformationOperator2D
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCartesianTransformationOperator2D : IIfcCartesianTransformationOperator
	{
		List<Common.Geometry.XbimVector3D> @U  { get ; }
	
	}
}

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IfcCartesianTransformationOperator2D", 145)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCartesianTransformationOperator2D : IfcCartesianTransformationOperator, IInstantiableEntity, IIfcCartesianTransformationOperator2D, IContainsEntityReferences, IEquatable<@IfcCartesianTransformationOperator2D>
	{
		#region IIfcCartesianTransformationOperator2D explicit implementation
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianTransformationOperator2D(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}



		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.List, EntityAttributeType.Class, 2, 2, 0)]
		public List<Common.Geometry.XbimVector3D> @U 
		{
			get 
			{
				//## Getter for U
				//TODO: Implement getter for derived attribute U
				throw new System.NotImplementedException();
				//##
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
        public bool Equals(@IfcCartesianTransformationOperator2D other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Axis1 != null)
					yield return @Axis1;
				if (@Axis2 != null)
					yield return @Axis2;
				if (@LocalOrigin != null)
					yield return @LocalOrigin;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}