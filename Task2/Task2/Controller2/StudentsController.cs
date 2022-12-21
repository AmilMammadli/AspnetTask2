using Microsoft.AspNetCore.Mvc;

namespace Task2.Controller2
{
    public class StudentsController:Controller
    {
        public ViewResult Index()
        {
            ViewResult view = new ViewResult();
            view.ViewName = "Index";

            string[] names = { "Amil1s", "Amil2s", "Amil3s" };
            ViewData.["Name"] = names;
            return view;
        }
    }
}
