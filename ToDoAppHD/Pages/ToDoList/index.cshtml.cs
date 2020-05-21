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
    public class ToDoListModel : PageModel
    {
        IToDoManager toDoManager;

        public List<ToDo> toDoModel { get; set; }

        [TempData]
        public string Mensaje { get; set; }

        public ToDoListModel(IToDoManager toDoManager)
        {
            this.toDoManager = toDoManager;
        }

        public async void OnGet()
        {
            toDoModel = await toDoManager.ListAll();

        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            await toDoManager.Delete(id);

            Mensaje = "Task successfully deleted";

            return RedirectToPage("Index");
        }
    }
}