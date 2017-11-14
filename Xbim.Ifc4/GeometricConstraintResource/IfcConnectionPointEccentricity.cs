// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricConstraintResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcConnectionPointEccentricity
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConnectionPointEccentricity : IIfcConnectionPointGeometry
	{
		IfcLengthMeasure? @EccentricityInX { get;  set; }
		IfcLengthMeasure? @EccentricityInY { get;  set; }
		IfcLengthMeasure? @EccentricityInZ { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[ExpressType("IfcConnectionPointEccentricity", 405)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConnectionPointEccentricity : IfcConnectionPointGeometry, IInstantiableEntity, IIfcConnectionPointEccentricity, IContainsEntityReferences, IEquatable<@IfcConnectionPointEccentricity>
	{
		#region IIfcConnectionPointEccentricity explicit implementation
		IfcLengthMeasure? IIfcConnectionPointEccentricity.EccentricityInX { 
 
			get { return @EccentricityInX; } 
			set { EccentricityInX = value;}
		}	
		IfcLengthMeasure? IIfcConnectionPointEccentricity.EccentricityInY { 
 
			get { return @EccentricityInY; } 
			set { EccentricityInY = value;}
		}	
		IfcLengthMeasure? IIfcConnectionPointEccentricity.EccentricityInZ { 
 
			get { return @EccentricityInZ; } 
			set { EccentricityInZ = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionPointEccentricity(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLengthMeasure? _eccentricityInX;
		private IfcLengthMeasure? _eccentricityInY;
		private IfcLengthMeasure? _eccentricityInZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcLengthMeasure? @EccentricityInX 
		{ 
			get 
			{
				if(_activated) return _eccentricityInX;
				Activate();
				return _eccentricityInX;
			} 
			set
			{
				SetValue( v =>  _eccentricityInX = v, _eccentricityInX, value,  "EccentricityInX", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcLengthMeasure? @EccentricityInY 
		{ 
			get 
			{
				if(_activated) return _eccentricityInY;
				Activate();
				return _eccentricityInY;
			} 
			set
			{
				SetValue( v =>  _eccentricityInY = v, _eccentricityInY, value,  "EccentricityInY", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcLengthMeasure? @EccentricityInZ 
		{ 
			get 
			{
				if(_activated) return _eccentricityInZ;
				Activate();
				return _eccentricityInZ;
			} 
			set
			{
				SetValue( v =>  _eccentricityInZ = v, _eccentricityInZ, value,  "EccentricityInZ", 5);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_eccentricityInX = value.RealVal;
					return;
				case 3: 
					_eccentricityInY = value.RealVal;
					return;
				case 4: 
					_eccentricityInZ = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConnectionPointEccentricity other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@PointOnRelatingElement != null)
					yield return @PointOnRelatingElement;
				if (@PointOnRelatedElement != null)
					yield return @PointOnRelatedElement;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}