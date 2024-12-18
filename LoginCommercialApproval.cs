using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beahavioral_ChainOfResponsability
{
	internal class LoginCommercialApproval : CommercialApproval
	{
		public LoginCommercialApproval() : base()
		{
		}
		public override CommercialApproval SetNext(CommercialApproval handler)
		{
            //Console.WriteLine("I'm calling SetNext a: " + this.GetType().Name);
			return base.SetNext(handler);
		}
		public override bool Handle(Order commOrder, ref string message)
		{
			Console.WriteLine("Check login user's order: " + commOrder.Login);
			if (commOrder.Login == false)
			{
				message += "Login not approved" + System.Environment.NewLine   ;
				return false;
			}
			message += "Login approved" + System.Environment.NewLine; 
			return base.Handle(commOrder, ref message);
		}
	}
}
