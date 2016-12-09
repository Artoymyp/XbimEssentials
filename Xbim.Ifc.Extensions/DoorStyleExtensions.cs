#region XbimHeader

// The eXtensible Building Information Modelling (xBIM) Toolkit
// Solution:    XbimComplete
// Project:     Xbim.Ifc.Extensions
// Filename:    DoorStyleExtensions.cs
// Published:   01, 2012
// Last Edited: 9:04 AM on 20 12 2011
// (See accompanying copyright.rtf)

#endregion

#region Directives

using System.Collections.Generic;
using System.Linq;
using Xbim.Ifc2x3.SharedBldgElements;

#endregion

namespace Xbim.Ifc2x3.Extensions
{
    public static class DoorStyleExtensions
    {
        public static IfcDoorLiningProperties GetDoorLiningProperties(this IfcDoorStyle doorStyle)
        {
            var propertySets = doorStyle.HasPropertySets;
            return propertySets != null ? propertySets.OfType<IfcDoorLiningProperties>().FirstOrDefault() : null;
        }

        public static IEnumerable<IfcDoorPanelProperties> GetDoorPanelProperties(this IfcDoorStyle doorStyle)
        {
            var propertySets = doorStyle.HasPropertySets;
            return propertySets != null 
                ? propertySets.OfType<IfcDoorPanelProperties>() 
                : new IfcDoorPanelProperties[0];
        }
    }
}
