// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationAppearanceResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSurfaceTexture
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurfaceTexture : IPersistEntity
	{
		bool @RepeatS { get; }
		bool @RepeatT { get; }
		IfcSurfaceTextureEnum @TextureType { get; }
		IIfcCartesianTransformationOperator2D @TextureTransform { get; }
		
	}
}

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IFCSURFACETEXTURE", 722)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcSurfaceTexture : IPersistEntity, INotifyPropertyChanged, IIfcSurfaceTexture, IEqualityComparer<@IfcSurfaceTexture>, IEquatable<@IfcSurfaceTexture>
	{
		#region IIfcSurfaceTexture explicit implementation
		bool IIfcSurfaceTexture.RepeatS { get { return @RepeatS; } }	
		bool IIfcSurfaceTexture.RepeatT { get { return @RepeatT; } }	
		IfcSurfaceTextureEnum IIfcSurfaceTexture.TextureType { get { return @TextureType; } }	
		IIfcCartesianTransformationOperator2D IIfcSurfaceTexture.TextureTransform { get { return @TextureTransform; } }	
		 
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
		internal IfcSurfaceTexture(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private bool _repeatS;
		private bool _repeatT;
		private IfcSurfaceTextureEnum _textureType;
		private IfcCartesianTransformationOperator2D _textureTransform;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool @RepeatS 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _repeatS;
				((IPersistEntity)this).Activate(false);
				return _repeatS;
			} 
			set
			{
				SetValue( v =>  _repeatS = v, _repeatS, value,  "RepeatS");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool @RepeatT 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _repeatT;
				((IPersistEntity)this).Activate(false);
				return _repeatT;
			} 
			set
			{
				SetValue( v =>  _repeatT = v, _repeatT, value,  "RepeatT");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcSurfaceTextureEnum @TextureType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textureType;
				((IPersistEntity)this).Activate(false);
				return _textureType;
			} 
			set
			{
				SetValue( v =>  _textureType = v, _textureType, value,  "TextureType");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCartesianTransformationOperator2D @TextureTransform 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textureTransform;
				((IPersistEntity)this).Activate(false);
				return _textureTransform;
			} 
			set
			{
				SetValue( v =>  _textureTransform = v, _textureTransform, value,  "TextureTransform");
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

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName)
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
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_repeatS = value.BooleanVal;
					return;
				case 1: 
					_repeatT = value.BooleanVal;
					return;
				case 2: 
                    _textureType = (IfcSurfaceTextureEnum) System.Enum.Parse(typeof (IfcSurfaceTextureEnum), value.EnumVal, true);
					return;
				case 3: 
					_textureTransform = (IfcCartesianTransformationOperator2D)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceTexture other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSurfaceTexture
            var root = (@IfcSurfaceTexture)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSurfaceTexture left, @IfcSurfaceTexture right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSurfaceTexture left, @IfcSurfaceTexture right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSurfaceTexture x, @IfcSurfaceTexture y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSurfaceTexture obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}