using Microsoft.AspNetCore.Mvc;

namespace Task2.Controller2
{
    public class GroupsController:Controller
    {
        public ViewResult Index()
        {
            ViewResult view = new ViewResult();
            v.ViewName = "Index";

            string[] names = { "Amil1G", "Amil2G", "Amil3G" };
            ViewData.["Name"] = names;

            return view;
        }
    }
}
