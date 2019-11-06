using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CakeMaster.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
    }
}
