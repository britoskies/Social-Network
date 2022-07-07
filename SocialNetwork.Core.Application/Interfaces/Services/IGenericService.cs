using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Core.Application.Interfaces.Services
{
    public interface IGenericService<Save, Model, Entity>
        where Save : class
        where Model : class
        where Entity : class
    {
        Task<Save> Add(Save vm);
        Task Delete(int id);
        Task Update(Save vm, int id);
        Task<Save> GetById(int id);
        Task<List<Model>> GetAll();
    }
}
