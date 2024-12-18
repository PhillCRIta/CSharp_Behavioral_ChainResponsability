using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beahavioral_ChainOfResponsability
{
	internal class RoleUserApproval : CommercialApproval
	{
		public RoleUserApproval() : base()
		{
		}
		public override CommercialApproval SetNext(CommercialApproval handler)
		{
			//Console.WriteLine("I'm calling SetNext a: " + this.GetType().Name);
			return base.SetNext(handler);
		}
		public override bool Handle(Order commOrder, ref string message)
		{
			Console.WriteLine("Check user's role: " + commOrder.UserRole);
			if (commOrder.UserRole != "key_account")
			{
				message += "Role's user not approved" + System.Environment.NewLine;
				return false;
			}
			message += "Role's user approved" + System.Environment.NewLine;
			return base.Handle(commOrder, ref message);
		}
	}
}
