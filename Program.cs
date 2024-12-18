//Chain of responsability is usefull in Web application middleware pipeline or in Desktop application between every visual component linkedd by a chain of event
//Benefits
//client decoupled from the chain of handlers (needs only initial handler)
//is possibile to reorder handlers, change handlers or so on
//every handler should be small and reusable in many situation

using Beahavioral_ChainOfResponsability;
string myM = string.Empty;
CommercialApproval approvalProcess = new CommercialApproval();


Console.WriteLine("Start complex approval order");
approvalProcess = new CommercialApproval();
Console.WriteLine("");
approvalProcess
	//the first setnext point to the base class CommercialApproval
	.SetNext(new LoginCommercialApproval())
	//the second setnext point to the logincommercialapproval, because the firs setnext return a loginapprovalclass
	.SetNext(new RoleUserApproval())
	//.. and so on, you can add new approvals pahse
	.SetNext(new CheckDiscountApproval())
	.SetNext(new ManagerApproval())
	;
//you can change the properties to approve or not the commercial offer
Console.WriteLine("Return approval order operations: " + approvalProcess.Handle(new Order()
{
	Discount = 5,
	Login = true,
	ManagerApproval = false,
	UserRole = "key_account"
}, ref myM));
Console.WriteLine("Result of approvational phase: " + myM);

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

myM = string.Empty;
Console.WriteLine("Start simple approval order");
approvalProcess
	//the first setnext point to the base class CommercialApproval
	.SetNext(new LoginCommercialApproval())
	//the second setnext point to the logincommercialapproval, because the firs setnext return a loginapprovalclass
	.SetNext(new RoleUserApproval())
	//.. and so on, you can add new approvals pahse
	;
//you can change the properties to approve or not the commercial offer
Console.WriteLine("Return approval order operations: " + approvalProcess.Handle(new Order() {	Discount = 1.5, 
																								Login = true,
																								ManagerApproval = true,
																								UserRole = "key_account"}, ref myM));
Console.WriteLine("Result of approvational phase: " + myM);

