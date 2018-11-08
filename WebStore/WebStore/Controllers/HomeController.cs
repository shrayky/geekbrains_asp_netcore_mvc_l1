using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {

        private readonly List<EmployeeViewModel> _employees = new List<EmployeeViewModel>
        {
            new EmployeeViewModel{Id =1, FirstName = "Nataliya", SurName = "Zharkova", Patronymic = "Olegovna", Age = 34, BirthDay = new DateTime(1984, 11, 7) },
            new EmployeeViewModel{Id =1, FirstName = "Egor", SurName = "Zharkov", Patronymic = "Arsenevich", Age = 12, BirthDay = new DateTime(2006, 11, 21) }
        };

        public IActionResult Index()
        {
            return View(_employees); // возвращаем view по умолчанию Index, он должен ОБЯЗАТЕЛЬНО лежать в папке views\home\
        }

        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            EmployeeViewModel Employee = _employees.Find(x => x.Id == id);

            if (Employee != null)
                return View(Employee);
            else
                return Content($"Не найден пользователь с id {id}");

        }
    }
}