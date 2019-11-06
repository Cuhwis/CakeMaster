using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeMaster.Models
{
    public interface ICommentRepository
    {
        IQueryable<Comment> Comments { get; }
        void SaveComment(Comment comment);
    }
}
