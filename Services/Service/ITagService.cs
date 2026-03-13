using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public interface ITagService
    {
        List<Tag> GetAllTags();
        Tag? GetTagById(int id);
    }
}
