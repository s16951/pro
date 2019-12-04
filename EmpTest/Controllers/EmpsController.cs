using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpsController : ControllerBase
    {
        private s16951Context _context;
        public EmpsController(s16951Context context)
        {
            _context = context;

        }

        [HttpGet]
        public IActionResult GetEmps()
        {
            return Ok(_context.Emp.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetEmp(int id)
        {
            var emp = _context.Emp.FirstOrDefault(e => e.Empno == id);

            if (emp == null)
            {
                return NotFound();
            }

            return Ok(emp);
        }

    }
}