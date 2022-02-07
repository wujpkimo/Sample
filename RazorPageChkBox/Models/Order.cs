namespace RazorPageChkBox.Pages
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Dispatched { get; set; }
    }
}