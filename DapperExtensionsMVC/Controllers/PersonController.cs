using DapperExtensionsMVC.Interfaces;
using DapperExtensionsMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperExtensionsMVC.Controllers
{
    public class PersonController : Controller
    {
        private readonly IRepository _repository;
        public PersonController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var list = _repository.GetAll<Person>(); 
            return View(list);
        }
    }
}
