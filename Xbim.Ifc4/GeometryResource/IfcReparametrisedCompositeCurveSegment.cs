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
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcReparametrisedCompositeCurveSegment
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcReparametrisedCompositeCurveSegment : IIfcCompositeCurveSegment
	{
		IfcParameterValue @ParamLength { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcReparametrisedCompositeCurveSegment", 1255)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReparametrisedCompositeCurveSegment : IfcCompositeCurveSegment, IInstantiableEntity, IIfcReparametrisedCompositeCurveSegment, IContainsEntityReferences, IEquatable<@IfcReparametrisedCompositeCurveSegment>
	{
		#region IIfcReparametrisedCompositeCurveSegment explicit implementation
		IfcParameterValue IIfcReparametrisedCompositeCurveSegment.ParamLength { 
 
			get { return @ParamLength; } 
			set { ParamLength = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReparametrisedCompositeCurveSegment(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcParameterValue _paramLength;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcParameterValue @ParamLength 
		{ 
			get 
			{
				if(_activated) return _paramLength;
				Activate();
				return _paramLength;
			} 
			set
			{
				SetValue( v =>  _paramLength = v, _paramLength, value,  "ParamLength", 4);
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
					_paramLength = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcReparametrisedCompositeCurveSegment other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ParentCurve != null)
					yield return @ParentCurve;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}