namespace homewok.CSahrp.Day5
{
    public class Purchase
    {
        string purchaseId, PaymentType, ShippingAddress;
        int quantityOrdered,Amount,price;
        DateTime dateOfPurchase;
        public Purchase(string purchaseId, int quantityOrdered, string PaymentType,DateTime dateOfPurchase,string ShippingAddress)
        {
            this.purchaseId = purchaseId;
            this.quantityOrdered = quantityOrdered;
            this.PaymentType = PaymentType;
            this.dateOfPurchase = dateOfPurchase;
            this.ShippingAddress = ShippingAddress;
            return;
        }
        public  void DispalyPurchaseDetails()
        {
            Console.WriteLine("Enter the Price:");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Quantity:");
            quantityOrdered = int.Parse(Console.ReadLine());
            Amount = (quantityOrdered) * price;
            Console.WriteLine("Amount:" + Amount);
            Console.WriteLine($"PurchaseId={purchaseId},quantityOrdered={quantityOrdered},price={price},PaymentType={PaymentType},Date={dateOfPurchase},Address={ShippingAddress}");
        }
        static void Main(string[] args)
        {
            Purchase p = new Purchase("101", 5, "cash", DateTime.Parse("14-12-2023") , "No.2,12th street,Sakthinagar,Nerkundram");
            p.DispalyPurchaseDetails();
        }
    }
}
