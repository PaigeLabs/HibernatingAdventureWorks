using System.Web.Mvc;
using HibernatingCropInsurance.Data;

namespace HibernatingCropInsurance.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: Customer
        public ActionResult List()
        {
            return View(_customerRepository.GetAllCustomers());
        }

        public ActionResult Details(int id)
        {
            return View(_customerRepository.GetCustomerById(id));
        }
    }
}