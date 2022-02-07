using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageChkBox.Pages
{
    public class CheckBoxSelectSampleModel : PageModel
    {
        [BindProperty]
        public List<Order> OrdersThisWeek { get; set; } = new List<Order>();

        public void OnGet()
        {
            OrdersThisWeek.Add(new Order()
            {
                OrderId = 52401,
                Customer = "Smith",
                OrderDate = DateTime.Today.AddDays(-2)
            });
            OrdersThisWeek.Add(new Order()
            {
                OrderId = 52520,
                Customer = "Jones",
                OrderDate = DateTime.Today.AddDays(-1)
            });
            OrdersThisWeek.Add(new Order()
            {
                OrderId = 52658,
                Customer = "While",
                OrderDate = DateTime.Today
            });
        }

        public void OnPost()
        {
            OrdersThisWeek = OrdersThisWeek.Where(p => p.Dispatched).ToList();
            foreach (var item in OrdersThisWeek)
            {
                Console.WriteLine($"{item.OrderId} | {item.Customer}");
            }
        }
    }
}