using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
    public class CommentsList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                     Id = 1,
                     Username = "Kenan"
                },
                new UserComment
                {
                     Id = 2,
                     Username = "Revan"
                },
                new UserComment
                {
                     Id = 3,
                     Username = "Sahil"
                }
            };
            return View(commentValues);
        }
    }
}
