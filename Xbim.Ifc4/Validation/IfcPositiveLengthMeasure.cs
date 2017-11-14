using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc4.Interfaces;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.MeasureResource
{
	public partial struct IfcPositiveLengthMeasure : IExpressValidatable
	{
		public enum IfcPositiveLengthMeasureClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcPositiveLengthMeasureClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcPositiveLengthMeasureClause.WR1:
						retVal = this > 0;
						break;
				}
			} catch (Exception ex) {
				var Log = LogManager.GetLogger("Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure");
				Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcPositiveLengthMeasure.{0}'.", clause), ex);
			}
			return retVal;
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcPositiveLengthMeasureClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPositiveLengthMeasure.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
