using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beahavioral_ChainOfResponsability
{
	internal class CheckDiscountApproval : CommercialApproval
	{
        public CheckDiscountApproval():base()
        {
		}
		public override CommercialApproval SetNext(CommercialApproval handler)
		{
			//Console.WriteLine("I'm calling SetNext a: " + this.GetType().Name);
			return base.SetNext(handler);
		}
		public override bool Handle(Order commOrder, ref string message)
		{
			Console.WriteLine("Check discount percent: " + commOrder.Discount);
			if (commOrder.Discount > 2.55)
			{
				message += "Check discount not approved" + System.Environment.NewLine;
				return false;
			}
			message += "Check discount approved" + System.Environment.NewLine;
			return base.Handle(commOrder, ref message);
		}
	}
}
