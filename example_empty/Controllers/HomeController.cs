
using example_empty.Models;
using example_empty.Security;
using example_empty.ViewModel;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace example_empty.Controllers
{


    public class HomeController : Controller
    {

        private IEmployeeRepository _employeeRepository;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IDataProtector protector;

        public HomeController(IEmployeeRepository employeeRepository, IWebHostEnvironment hostingEnvironment,


    IDataProtectionProvider dataProtectionProvider,
                              DataProtectionPurposeStrings dataProtectionPurposeStrings)
        {
            _employeeRepository = employeeRepository;
            _hostingEnvironment = hostingEnvironment;
            // Pass the purpose string as a parameter
            this.protector = dataProtectionProvider.CreateProtector(
                dataProtectionPurposeStrings.EmployeeIdRouteValue);

        }

        public ViewResult Index()
        {
            // retrieve all the employees
            var model = _employeeRepository.GetAllEmployees()
                           .Select(e =>
                           {
                               // Encrypt the ID value and store in EncryptedId property
                               e.EncryptedId = protector.Protect(e.Id.ToString());
                               return e;
                           });
            //return View(model);
           // var model2 = _employeeRepository.GetAllEmployees();
            // Pass the list of employees to the view
            return View(model);
        }
        public ViewResult Details(string id)
        {

            // Decrypt the employee id using Unprotect method
            string decryptedId = protector.Unprotect(id);
            int decryptedIntId = Convert.ToInt32(decryptedId);

            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(decryptedIntId),
                PageTitle = "Employee Details"
            };

            // Pass the ViewModel object to the View() helper method
            return View(homeDetailsViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
           
            return View();
        }

        [HttpPost]

        public IActionResult Create(CreateViewModel model)
        {
            string Uniquefilename = null;
            if (ModelState.IsValid)
            {

                if (model.Photos != null && model.Photos.Count > 0)
                {
                    foreach (IFormFile photo in model.Photos)
                    {
                        string UploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                        Uniquefilename = Guid.NewGuid().ToString() + "_" + photo.FileName;
                        string filepath = Path.Combine(UploadsFolder, Uniquefilename);
                        using (var filestream = new FileStream(filepath, FileMode.Create))
                        {
                            photo.CopyTo(filestream);
                        }
                    }
                }
                Employee newemployee = new Employee
                {
                    Name = model.Name,
                    Email = model.Email,
                    Department = model.Department,
                    AddPhotopath = Uniquefilename

                };
                _employeeRepository.Add(newemployee);
                return RedirectToAction("Index", "Home");

            }
            return View();
            
        }

        [HttpGet]
        public ViewResult Edit(string  id)
        {
            string decryptedId = protector.Unprotect(id);
            int decryptedIntId = Convert.ToInt32(decryptedId);
            Employee employee = _employeeRepository.GetEmployee(decryptedIntId);
            EditViewModel editViewModel = new EditViewModel
            {
                id = decryptedIntId,
                EncryptedId= id,
                Name = employee.Name,
                Department = employee.Department,
                Email = employee.Email,
                Existingphotopath = employee.AddPhotopath
            };
            return View(editViewModel);
        }
        [HttpPost]
        [Obsolete]
        public IActionResult Edit(EditViewModel model)
        {

            string Uniquefilename = null;
            if (ModelState.IsValid)
            {
                Employee employee = _employeeRepository.GetEmployee(model.id);
                employee.Name = model.Name;
                employee.Department = model.Department;
                employee.Email = model.Email;
                if (model.Photos != null)
                {
                    if (model.Existingphotopath != null)
                    {
                        string filelocation = Path.Combine(_hostingEnvironment.WebRootPath, "images", model.Existingphotopath);
                        System.IO.File.Delete(filelocation);
                    }
                    foreach (IFormFile photo in model.Photos)
                    {
                        string UploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                        Uniquefilename = Guid.NewGuid().ToString() + "_" + photo.FileName;
                        string filepath = Path.Combine(UploadsFolder, Uniquefilename);
                        using (var filestream = new FileStream(filepath, FileMode.Create))
                        {
                            photo.CopyTo(filestream);
                        }

                    }
                    employee.AddPhotopath = Uniquefilename;
                }
                _employeeRepository.Update(employee);
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {

            _employeeRepository.Delete(id);

            return Json(1);
        }

    }

}
