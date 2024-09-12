using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstProyect.Models;
public class MyPageModel : PageModel
{
    
    [BindProperty]
    public int Number1{get; set;} = 0;

    [BindProperty]
    public int Number2{get; set;} = 0;


    public string? Mensaje{get; set;}

    public void OnGet()
    {
        Mensaje=null;
    }

    public IActionResult OnPost(){
        if (ModelState.IsValid)
        {
            // Puedes manejar los datos aquí, como guardarlos en una base de datos.
            Mensaje = $"{Number1} + {Number2} = {Number1 + Number2}";
            return Page();
        }

        // Si los datos no son válidos, vuelve a mostrar el formulario con los errores
        return Page();
    }
}

