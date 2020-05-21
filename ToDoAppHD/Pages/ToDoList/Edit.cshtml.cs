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
    public class EditModel : PageModel
    {
        IToDoManager toDoManager;

        [BindProperty]
        public ToDo toDoModel { get; set; }

        [TempData]
        public string Mensaje { get; set; }

        public EditModel(IToDoManager toDoManager)
        {
            this.toDoManager = toDoManager;
        }

        public async Task OnGet(int id)
        {
            toDoModel = await toDoManager.GetById(Convert.ToInt32(id));
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await toDoManager.Update(toDoModel);
                Mensaje = "Task successfully updated";
                return RedirectToPage("Index");
            }

            return RedirectToPage();
        }
    }
}