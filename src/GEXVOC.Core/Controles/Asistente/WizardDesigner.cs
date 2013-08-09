using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace GEXVOC.Core.Controles.Asistente
{
	/// <summary>
	/// Summary description for WizardDesigner.
	/// </summary>
	public class WizardDesigner : ParentControlDesigner
	{
		/// <summary>
		/// Prevents the grid from being drawn on the Wizard
		/// </summary>
		protected override bool DrawGrid
		{
			get 
			{ 
				return base.DrawGrid && _allowGrid;
			}
		}
		private bool _allowGrid = true;

		/// <summary>
		/// Simple way to ensure <see cref="WizardPage"/>s only contained here
		/// </summary>
		/// <param name="control"></param>
		/// <returns></returns>
		public override bool CanParent(Control control)
		{
			if (control is WizardPage)
				return true;
			return false;
		}
		public override bool CanParent(ControlDesigner controlDesigner)
		{
			if (controlDesigner is WizardPageDesigner)
				return true;
			return false;
		}


		protected override bool GetHitTest(Point point)
		{
			Wizard wiz = this.Control as Wizard;
		
			if(wiz.btnNext.Enabled && 
				wiz.btnNext.ClientRectangle.Contains(wiz.btnNext.PointToClient(point)))
			{
				//Next can handle that
				return true;
			}
			if(wiz.btnBack.Enabled && 
				wiz.btnBack.ClientRectangle.Contains(wiz.btnBack.PointToClient(point)))
			{
				//Back can handle that
				return true;
			}
			//Nope not interested
			return false;
		}

		public override DesignerVerbCollection Verbs
		{
			get
			{
				DesignerVerbCollection verbs = new DesignerVerbCollection();
				verbs.Add(new DesignerVerb("Add Page", new EventHandler(handleAddPage)));

				return verbs;
			}
		}

		private void handleAddPage(object sender, EventArgs e)
		{
			Wizard wiz = this.Control as Wizard;

			IDesignerHost h  = (IDesignerHost) GetService(typeof(IDesignerHost));
			IComponentChangeService c = (IComponentChangeService) GetService(typeof (IComponentChangeService));

			DesignerTransaction dt = h.CreateTransaction("Add Page");
			WizardPage page = (WizardPage) h.CreateComponent(typeof(WizardPage));
			c.OnComponentChanging(wiz, null);
    
			//Add a new page to the collection
			wiz.Pages.Add(page);
			wiz.Controls.Add(page);
			wiz.ActivatePage(page);

			c.OnComponentChanged(wiz, null, null, null);
			dt.Commit();
		}	

		protected override void OnPaintAdornments(PaintEventArgs pe)
		{
			_allowGrid = false;
			base.OnPaintAdornments (pe);
			_allowGrid = true;
		}

	}
}
