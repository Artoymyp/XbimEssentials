// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.MeasureResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDerivedUnit
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDerivedUnit : IPersistEntity, IfcUnit
	{
		IEnumerable<IIfcDerivedUnitElement> @Elements { get; }
		IfcDerivedUnitEnum @UnitType { get;  set; }
		IfcLabel? @UserDefinedType { get;  set; }
		Common.Geometry.XbimDimensionalExponents @Dimensions  { get ; }
	
	}
}

namespace Xbim.Ifc4.MeasureResource
{
	[ExpressType("IfcDerivedUnit", 630)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDerivedUnit : INotifyPropertyChanged, IInstantiableEntity, IIfcDerivedUnit, IContainsEntityReferences, IEquatable<@IfcDerivedUnit>
	{
		#region IIfcDerivedUnit explicit implementation
		IEnumerable<IIfcDerivedUnitElement> IIfcDerivedUnit.Elements { 
			get { return @Elements; } 
		}	
		IfcDerivedUnitEnum IIfcDerivedUnit.UnitType { 
			get { return @UnitType; } 
 
			set { UnitType = value;}
		}	
		IfcLabel? IIfcDerivedUnit.UserDefinedType { 
			get { return @UserDefinedType; } 
 
			set { UserDefinedType = value;}
		}	
		 
		#endregion

		#region Implementation of IPersistEntity

		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
	    internal ActivationStatus ActivationStatus = ActivationStatus.NotActivated;

	    ActivationStatus IPersistEntity.ActivationStatus { get { return ActivationStatus; } }
		
		void IPersistEntity.Activate(bool write)
		{
			switch (ActivationStatus)
		    {
		        case ActivationStatus.ActivatedReadWrite:
		            return;
		        case ActivationStatus.NotActivated:
		            lock (this)
		            {
                        //check again in the lock
		                if (ActivationStatus == ActivationStatus.NotActivated)
		                {
		                    if (Model.Activate(this, write))
		                    {
		                        ActivationStatus = write
		                            ? ActivationStatus.ActivatedReadWrite
		                            : ActivationStatus.ActivatedRead;
		                    }
		                }
		            }
		            break;
		        case ActivationStatus.ActivatedRead:
		            if (!write) return;
		            if (Model.Activate(this, true))
                        ActivationStatus = ActivationStatus.ActivatedReadWrite;
		            break;
		        default:
		            throw new ArgumentOutOfRangeException();
		    }
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (ActivationStatus != ActivationStatus.NotActivated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			ActivationStatus = ActivationStatus.ActivatedRead;
		}

		ExpressType IPersistEntity.ExpressType { get { return Model.Metadata.ExpressType(this);  } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDerivedUnit(IModel model) 		{ 
			Model = model; 
			_elements = new ItemSet<IfcDerivedUnitElement>( this, 0,  1);
		}

		#region Explicit attribute fields
		private ItemSet<IfcDerivedUnitElement> _elements;
		private IfcDerivedUnitEnum _unitType;
		private IfcLabel? _userDefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 1)]
		public ItemSet<IfcDerivedUnitElement> @Elements 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _elements;
				((IPersistEntity)this).Activate(false);
				return _elements;
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 2)]
		public IfcDerivedUnitEnum @UnitType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _unitType;
				((IPersistEntity)this).Activate(false);
				return _unitType;
			} 
			set
			{
				SetValue( v =>  _unitType = v, _unitType, value,  "UnitType", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcLabel? @UserDefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _userDefinedType;
				((IPersistEntity)this).Activate(false);
				return _userDefinedType;
			} 
			set
			{
				SetValue( v =>  _userDefinedType = v, _userDefinedType, value,  "UserDefinedType", 3);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 0)]
		public Common.Geometry.XbimDimensionalExponents @Dimensions 
		{
			get 
			{
				//## Getter for Dimensions
                var derivedUnit = this as IfcDerivedUnit;
                if (derivedUnit == null)
                    throw new NotSupportedException();
                var elements = derivedUnit.Elements as IList<IfcDerivedUnitElement> ?? derivedUnit.Elements.ToList();
                if (!elements.Any())
                    throw new ArgumentNullException();

                #region Strict Implementation
                var result = new Common.Geometry.XbimDimensionalExponents(0, 0, 0, 0, 0, 0, 0);
                foreach (var unitElement in elements)
                {
                    result.LengthExponent = result.LengthExponent +
                          (unitElement.Exponent * unitElement.Unit.Dimensions.LengthExponent);
                    result.MassExponent = +result.MassExponent +
                          (unitElement.Exponent * unitElement.Unit.Dimensions.MassExponent);
                    result.TimeExponent = result.TimeExponent +
                          (unitElement.Exponent * unitElement.Unit.Dimensions.TimeExponent);
                    result.ElectricCurrentExponent = result.ElectricCurrentExponent +
                          (unitElement.Exponent * unitElement.Unit.Dimensions.ElectricCurrentExponent);
                    result.ThermodynamicTemperatureExponent = result.ThermodynamicTemperatureExponent +
                          (unitElement.Exponent * unitElement.Unit.Dimensions.ThermodynamicTemperatureExponent);
                    result.AmountOfSubstanceExponent = result.AmountOfSubstanceExponent +
                          (unitElement.Exponent * unitElement.Unit.Dimensions.AmountOfSubstanceExponent);
                    result.LuminousIntensityExponent = result.LuminousIntensityExponent +
                          (unitElement.Exponent * unitElement.Unit.Dimensions.LuminousIntensityExponent);
                }
                return result;
                #endregion Strict Implementation
			    //##
			}
		}

		#endregion


		#region INotifyPropertyChanged implementation
		 
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion

		#region Transactional property setting

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName, byte propertyOrder)
		{
			//activate for write if it is not activated yet
			if (ActivationStatus != ActivationStatus.ActivatedReadWrite)
				((IPersistEntity)this).Activate(true);

			//just set the value if the model is marked as non-transactional
			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => {
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			Action undoAction = () => {
				setter(oldValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			doAction();

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified, propertyOrder);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_elements.InternalAdd((IfcDerivedUnitElement)value.EntityVal);
					return;
				case 1: 
                    _unitType = (IfcDerivedUnitEnum) System.Enum.Parse(typeof (IfcDerivedUnitEnum), value.EnumVal, true);
					return;
				case 2: 
					_userDefinedType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDerivedUnit other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDerivedUnit
            var root = (@IfcDerivedUnit)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDerivedUnit left, @IfcDerivedUnit right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDerivedUnit left, @IfcDerivedUnit right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcDerivedUnit left, IfcUnit right)
		{
			return left == right as @IfcDerivedUnit;
		}

		public static bool operator !=(@IfcDerivedUnit left, IfcUnit right)
		{
			return !(left == right);
		}

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Elements)
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