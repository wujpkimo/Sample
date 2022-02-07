using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using X.PagedList;

namespace RazorPageChkBox.Pages
{
    public class CheckBoxSelectSample3Model : PageModel
    {
        [BindProperty]
        public List<Order> OrdersThisWeek { get; set; } = new List<Order>();

        public IPagedList<Order> DataByPage { get; set; } = new List<Order>().ToPagedList();

        public void OnGet(int? p)
        {
            if (OrdersThisWeek.Count == 0)
            {
                OrdersThisWeek.Add(new Order()
                {
                    OrderId = 52401,
                    Customer = "Smith",
                    OrderDate = DateTime.Today
                });
                OrdersThisWeek.Add(new Order()
                {
                    OrderId = 52520,
                    Customer = "Jones",
                    OrderDate = DateTime.Today
                });
                OrdersThisWeek.Add(new Order()
                {
                    OrderId = 52658,
                    Customer = "While",
                    OrderDate = DateTime.Today
                });
                OrdersThisWeek.Add(new Order()
                {
                    OrderId = 52402,
                    Customer = "Jason",
                    OrderDate = DateTime.Today
                });
                OrdersThisWeek.Add(new Order()
                {
                    OrderId = 52522,
                    Customer = "Jackson",
                    OrderDate = DateTime.Today
                });
                OrdersThisWeek.Add(new Order()
                {
                    OrderId = 52665,
                    Customer = "Wizard",
                    OrderDate = DateTime.Today
                });
                OrdersThisWeek.Add(new Order()
                {
                    OrderId = 52405,
                    Customer = "Steven",
                    OrderDate = DateTime.Today
                });
                OrdersThisWeek.Add(new Order()
                {
                    OrderId = 52524,
                    Customer = "Jimmy",
                    OrderDate = DateTime.Today
                });
                OrdersThisWeek.Add(new Order()
                {
                    OrderId = 52666,
                    Customer = "Will",
                    OrderDate = DateTime.Today
                });
            }
            var pageNumber = p ?? 1; // if no page was specified in the querystring, default to the first page (1)
            DataByPage = OrdersThisWeek.ToPagedList(pageNumber, 5);
        }

        public void OnPost()
        {
            DataByPage = OrdersThisWeek.Where(p => p.Dispatched).ToList().ToPagedList(1, 5);
            foreach (var item in DataByPage)
            {
                Console.WriteLine($"{item.OrderId} | {item.Customer}");
            }
        }
    }
}