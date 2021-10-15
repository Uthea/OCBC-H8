using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Kantor_WebAPI.Models;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Kantor_WebAPI.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            this._context = context;
        }

        // GET : api/User

        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;

            return _context.GetAllEmployee(); 
        }

        [HttpGet("{id}", Name = "Get")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetEmployee(id); 
        }
    }
}