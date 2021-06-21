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
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person person)
        {
            _repository.Create<Person>(person);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var person = _repository.GetById<Person>(id);
            return View(person);
        }
        [HttpPost]
        public IActionResult Update(Person newPerson)
        {
            _repository.Update<Person>(newPerson);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var person = _repository.GetById<Person>(id);
            return View(person);
        }
        [HttpPost]
        public IActionResult Delete(Person toDeletePerson)
        {
            _repository.Delete<Person>(toDeletePerson);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var person = _repository.GetById<Person>(id);
            return View(person);
        }
    }
}
