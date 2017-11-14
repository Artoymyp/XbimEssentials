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
using Xbim.Ifc2x3.StructuralLoadResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSlippageConnectionCondition
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSlippageConnectionCondition : IIfcStructuralConnectionCondition
	{
		IfcLengthMeasure? @SlippageX { get;  set; }
		IfcLengthMeasure? @SlippageY { get;  set; }
		IfcLengthMeasure? @SlippageZ { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.StructuralLoadResource
{
	[ExpressType("IfcSlippageConnectionCondition", 638)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSlippageConnectionCondition : IfcStructuralConnectionCondition, IInstantiableEntity, IIfcSlippageConnectionCondition, IEquatable<@IfcSlippageConnectionCondition>
	{
		#region IIfcSlippageConnectionCondition explicit implementation
		IfcLengthMeasure? IIfcSlippageConnectionCondition.SlippageX { 
 
			get { return @SlippageX; } 
			set { SlippageX = value;}
		}	
		IfcLengthMeasure? IIfcSlippageConnectionCondition.SlippageY { 
 
			get { return @SlippageY; } 
			set { SlippageY = value;}
		}	
		IfcLengthMeasure? IIfcSlippageConnectionCondition.SlippageZ { 
 
			get { return @SlippageZ; } 
			set { SlippageZ = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSlippageConnectionCondition(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLengthMeasure? _slippageX;
		private IfcLengthMeasure? _slippageY;
		private IfcLengthMeasure? _slippageZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcLengthMeasure? @SlippageX 
		{ 
			get 
			{
				if(_activated) return _slippageX;
				Activate();
				return _slippageX;
			} 
			set
			{
				SetValue( v =>  _slippageX = v, _slippageX, value,  "SlippageX", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcLengthMeasure? @SlippageY 
		{ 
			get 
			{
				if(_activated) return _slippageY;
				Activate();
				return _slippageY;
			} 
			set
			{
				SetValue( v =>  _slippageY = v, _slippageY, value,  "SlippageY", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcLengthMeasure? @SlippageZ 
		{ 
			get 
			{
				if(_activated) return _slippageZ;
				Activate();
				return _slippageZ;
			} 
			set
			{
				SetValue( v =>  _slippageZ = v, _slippageZ, value,  "SlippageZ", 4);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_slippageX = value.RealVal;
					return;
				case 2: 
					_slippageY = value.RealVal;
					return;
				case 3: 
					_slippageZ = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSlippageConnectionCondition other)
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