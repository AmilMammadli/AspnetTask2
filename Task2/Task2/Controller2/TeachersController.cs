using Microsoft.AspNetCore.Mvc;

namespace Task2.Controller2
{
    public class TeachersController:Controller
    {
        public ViewResult Index()
        {
            ViewResult view = new ViewResult();
            view.ViewName = "Index";

            string[] names = { "Amil1T", "Amil2T", "Amil3T" };
            ViewData.["Name"] = names;
            return view;
        }
    }
}
