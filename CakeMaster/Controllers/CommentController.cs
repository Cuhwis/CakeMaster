using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CakeMaster.Models;
using Microsoft.AspNetCore.Authorization;

namespace CakeMaster.Controllers
{
    public class CommentController : Controller
    {
        //private ICommentRepository repository;
        //public CommentController(ICommentRepository repo)
        //{
        //    repository = repo;
        //}
        public ViewResult Contact() => View(new Comment());
        [HttpPost]
        public IActionResult Contact(Comment comment) => View();
       // public ViewResult Comment() => View(repository.Comments);
    }
}
