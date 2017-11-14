// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ActorResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.UtilityResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcApplication
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcApplication : IPersistEntity
	{
		IIfcOrganization @ApplicationDeveloper { get;  set; }
		IfcLabel @Version { get;  set; }
		IfcLabel @ApplicationFullName { get;  set; }
		IfcIdentifier @ApplicationIdentifier { get;  set; }
	
	}
}

namespace Xbim.Ifc4.UtilityResource
{
	[ExpressType("IfcApplication", 627)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcApplication : PersistEntity, IInstantiableEntity, IIfcApplication, IContainsEntityReferences, IEquatable<@IfcApplication>
	{
		#region IIfcApplication explicit implementation
		IIfcOrganization IIfcApplication.ApplicationDeveloper { 
 
 
			get { return @ApplicationDeveloper; } 
			set { ApplicationDeveloper = value as IfcOrganization;}
		}	
		IfcLabel IIfcApplication.Version { 
 
			get { return @Version; } 
			set { Version = value;}
		}	
		IfcLabel IIfcApplication.ApplicationFullName { 
 
			get { return @ApplicationFullName; } 
			set { ApplicationFullName = value;}
		}	
		IfcIdentifier IIfcApplication.ApplicationIdentifier { 
 
			get { return @ApplicationIdentifier; } 
			set { ApplicationIdentifier = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcApplication(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcOrganization _applicationDeveloper;
		private IfcLabel _version;
		private IfcLabel _applicationFullName;
		private IfcIdentifier _applicationIdentifier;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 1)]
		public IfcOrganization @ApplicationDeveloper 
		{ 
			get 
			{
				if(_activated) return _applicationDeveloper;
				Activate();
				return _applicationDeveloper;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _applicationDeveloper = v, _applicationDeveloper, value,  "ApplicationDeveloper", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcLabel @Version 
		{ 
			get 
			{
				if(_activated) return _version;
				Activate();
				return _version;
			} 
			set
			{
				SetValue( v =>  _version = v, _version, value,  "Version", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcLabel @ApplicationFullName 
		{ 
			get 
			{
				if(_activated) return _applicationFullName;
				Activate();
				return _applicationFullName;
			} 
			set
			{
				SetValue( v =>  _applicationFullName = v, _applicationFullName, value,  "ApplicationFullName", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcIdentifier @ApplicationIdentifier 
		{ 
			get 
			{
				if(_activated) return _applicationIdentifier;
				Activate();
				return _applicationIdentifier;
			} 
			set
			{
				SetValue( v =>  _applicationIdentifier = v, _applicationIdentifier, value,  "ApplicationIdentifier", 4);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_applicationDeveloper = (IfcOrganization)(value.EntityVal);
					return;
				case 1: 
					_version = value.StringVal;
					return;
				case 2: 
					_applicationFullName = value.StringVal;
					return;
				case 3: 
					_applicationIdentifier = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcApplication other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ApplicationDeveloper != null)
					yield return @ApplicationDeveloper;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}