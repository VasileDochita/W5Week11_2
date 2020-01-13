using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.Data
{
    public class CommentDataAccess : BaseDataAccess<Comment>, ICommentsRepository
    {
        public IList<Comment> GetCommentsByPostId(int id)
        {
            var list = this.GetAll();
            return list.Where(x => x.PostId == id).ToList();
        }

        protected override string GetFile()
        {
            throw new NotImplementedException();
        }


    }
}
