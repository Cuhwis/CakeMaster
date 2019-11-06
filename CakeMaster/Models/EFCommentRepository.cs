using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;


namespace CakeMaster.Models
{
    public class EFCommentRepository : ICommentRepository
    {
        private ApplicationDbContext context;
        public EFCommentRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Comment> Comments => context.Comments;
        public void SaveComment(Comment comment)
        {
            if (comment.CommentID == 0)
            {
                context.Comments.Add(comment);
            }
            else
            {
                Comment dbEntry = context.Comments
                .FirstOrDefault(c => c.CommentID == comment.CommentID);
                if (dbEntry != null)
                {
                    dbEntry.Name = comment.Name;
                    dbEntry.Text = comment.Text;
                }
            }
            context.SaveChanges();
        }
    }
}
