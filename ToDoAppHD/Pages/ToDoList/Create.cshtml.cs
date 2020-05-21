using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoAppHD.Models;
using ToDoAppHD.Services;

namespace ToDoAppHD.Pages.ToDoList
{
    public class CreateModel : PageModel
    {
        IToDoManager toDoManager;

        [BindProperty]
        public ToDo toDoModel { get; set; }

        [TempData]
        public string Mensaje { get; set; }

        public CreateModel(IToDoManager toDoManager)
        {
            this.toDoManager = toDoManager;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await toDoManager.Create(toDoModel);
            Mensaje = "Task successfully created";
            return RedirectToPage("Index");
        }
    }
}