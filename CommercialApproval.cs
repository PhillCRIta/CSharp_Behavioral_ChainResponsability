using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beahavioral_ChainOfResponsability
{
	internal class CommercialApproval
	{
		private CommercialApproval? _nextHandler;

		string messageReturn = string.Empty;

		public CommercialApproval()
		{
			Console.WriteLine(this.GetType().Name + " instantiated");
			//for (var current = this.GetType(); current != null; current = current.BaseType)
			//             Console.WriteLine(current);
		}
		public virtual CommercialApproval SetNext(CommercialApproval handler)
		{
			Console.WriteLine("I'm calling SetNext a: " + this.GetType().Name);
			Console.WriteLine("The next handler is: " + handler.GetType().Name);
			Console.WriteLine("");
			_nextHandler = handler;
			return handler;
		}

		//virtual method con be overriden
		public virtual bool Handle(Order commOrder, ref string _message)
		{
			if (String.IsNullOrEmpty(_message) == true)
				_message += System.Environment.NewLine;
			bool? t = _nextHandler?.Handle(commOrder, ref _message);
			//_message += "****************" + System.Environment.NewLine;
			return t ?? true;
		}
	}
}
