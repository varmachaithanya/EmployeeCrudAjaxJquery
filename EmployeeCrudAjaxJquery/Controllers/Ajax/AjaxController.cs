// <copyright file="AjaxController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EmployeeCrudAjaxJquery.Controllers.Ajax
{
    using BusinessLayer.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore.Update.Internal;
    using RepositoryLayer;
    using RepositoryLayer.Entity;

    public class AjaxController : Controller
    {
        private readonly Context context;
        private readonly IEmployeeBusiness business;

        public AjaxController(Context context,IEmployeeBusiness business)
        {
            this.context = context;
            this.business = business;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        [HttpGet]
        public JsonResult EmployeeList()
        {
            var data = this.context.EmployeeDemo.ToList();

            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult AddEmployee(EmployeeDemo employee)
        {
            EmployeeDemo emp = new EmployeeDemo()
            {
                Name = employee.Name,
                City = employee.City,
                State = employee.State,
                Salary = employee.Salary,
            };
            this.context.EmployeeDemo.Add(emp);
            this.context.SaveChanges();
            return new JsonResult("Data is Saved");
        }

        public JsonResult Delete(int id)
        {
            var data = this.context.EmployeeDemo.Where(e => e.Id == id).SingleOrDefault();
#pragma warning disable CS8604 // Possible null reference argument.
            this.context.EmployeeDemo.Remove(data);
#pragma warning restore CS8604 // Possible null reference argument.
            this.context.SaveChanges();
            return new JsonResult("Data Deleted");
        }

        public JsonResult Edit(int id)
        {
            var data = this.context.EmployeeDemo.Where(e => e.Id == id).SingleOrDefault();
            return new JsonResult(data);
        }

        public JsonResult Update(EmployeeDemo employee)
        {
            this.context.EmployeeDemo.Update(employee);
            this.context.SaveChanges();
            return new JsonResult("Record Updated");
        }
    }
}
