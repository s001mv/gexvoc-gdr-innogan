using System;
using System.Windows.Forms.Design;

namespace GEXVOC.Core.Controles.Asistente
{
	/// <summary>
	/// 
	/// </summary>
	public class InfoContainerDesigner : ParentControlDesigner
	{
		/// <summary>
		/// Drops the BackgroundImage property
		/// </summary>
		/// <param name="properties">properties to remove BackGroundImage from</param>
		protected override void PreFilterProperties(System.Collections.IDictionary properties)
		{
			base.PreFilterProperties (properties);
			if (properties.Contains("BackgroundImage") == true)
				properties.Remove("BackgroundImage");
		}

	}
}
