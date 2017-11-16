using LoginApp.Entities;
using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApp.Repositories
{
    public class AuthorRepository
    {
        AuthorContext authorContext;

        public AuthorRepository(AuthorContext authorContext)
        {
            this.authorContext = authorContext;
        }

        public bool AuthenticateAuthor(string name)
        {
            var user = authorContext.Authors.FirstOrDefault(x => x.Name.Equals(name));
            return user != null ? true : false;
        }

        public Author GetAuthorInfo(string name)
        {
            return authorContext.Authors.FirstOrDefault(y => y.Name.Equals(name));
        }
    }
}
