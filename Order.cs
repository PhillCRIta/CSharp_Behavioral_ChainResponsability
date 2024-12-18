namespace Beahavioral_ChainOfResponsability
{
	public class Order
	{
		public bool Login { get; internal set; } = default;
		public string UserRole { get; internal set; } = String.Empty;
		public double Discount { get; internal set; } = default;
		public bool ManagerApproval { get; internal set; } = default;
	}
}