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
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCurveBoundedPlane
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCurveBoundedPlane : IIfcBoundedSurface
	{
		IIfcPlane @BasisSurface { get;  set; }
		IIfcCurve @OuterBoundary { get;  set; }
		IEnumerable<IIfcCurve> @InnerBoundaries { get; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcCurveBoundedPlane", 334)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveBoundedPlane : IfcBoundedSurface, IInstantiableEntity, IIfcCurveBoundedPlane, IContainsEntityReferences, IEquatable<@IfcCurveBoundedPlane>
	{
		#region IIfcCurveBoundedPlane explicit implementation
		IIfcPlane IIfcCurveBoundedPlane.BasisSurface { 
			get { return @BasisSurface; } 
 
 
			set { BasisSurface = value as IfcPlane;}
		}	
		IIfcCurve IIfcCurveBoundedPlane.OuterBoundary { 
			get { return @OuterBoundary; } 
 
 
			set { OuterBoundary = value as IfcCurve;}
		}	
		IEnumerable<IIfcCurve> IIfcCurveBoundedPlane.InnerBoundaries { 
			get { return @InnerBoundaries; } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveBoundedPlane(IModel model) : base(model) 		{ 
			Model = model; 
			_innerBoundaries = new ItemSet<IfcCurve>( this, 0,  3);
		}

		#region Explicit attribute fields
		private IfcPlane _basisSurface;
		private IfcCurve _outerBoundary;
		private ItemSet<IfcCurve> _innerBoundaries;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcPlane @BasisSurface 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _basisSurface;
				((IPersistEntity)this).Activate(false);
				return _basisSurface;
			} 
			set
			{
				SetValue( v =>  _basisSurface = v, _basisSurface, value,  "BasisSurface", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcCurve @OuterBoundary 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _outerBoundary;
				((IPersistEntity)this).Activate(false);
				return _outerBoundary;
			} 
			set
			{
				SetValue( v =>  _outerBoundary = v, _outerBoundary, value,  "OuterBoundary", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 5)]
		public ItemSet<IfcCurve> @InnerBoundaries 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _innerBoundaries;
				((IPersistEntity)this).Activate(false);
				return _innerBoundaries;
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_basisSurface = (IfcPlane)(value.EntityVal);
					return;
				case 1: 
					_outerBoundary = (IfcCurve)(value.EntityVal);
					return;
				case 2: 
					_innerBoundaries.InternalAdd((IfcCurve)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCurveBoundedPlane other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCurveBoundedPlane
            var root = (@IfcCurveBoundedPlane)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCurveBoundedPlane left, @IfcCurveBoundedPlane right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCurveBoundedPlane left, @IfcCurveBoundedPlane right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@BasisSurface != null)
					yield return @BasisSurface;
				if (@OuterBoundary != null)
					yield return @OuterBoundary;
				foreach(var entity in @InnerBoundaries)
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