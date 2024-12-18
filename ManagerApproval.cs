using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beahavioral_ChainOfResponsability
{
	internal class ManagerApproval : CommercialApproval
	{
        public ManagerApproval():base()
        {
		}
		public override CommercialApproval SetNext(CommercialApproval handler)
		{
			//Console.WriteLine("I'm calling SetNext a: " + this.GetType().Name);
			return base.SetNext(handler);
		}
		public override bool Handle(Order commOrder, ref string message)
		{
			Console.WriteLine("Manager approval: " + commOrder.ManagerApproval);
			if (commOrder.ManagerApproval == false)
			{
				message += "Manager not approved" + System.Environment.NewLine;
				return false;
			}
			message += "Manager approved" + System.Environment.NewLine;
			return base.Handle(commOrder, ref message);
		}
	}
}
