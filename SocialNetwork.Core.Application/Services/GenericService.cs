using AutoMapper;
using SocialNetwork.Core.Application.Interfaces.Repositories;
using SocialNetwork.Core.Application.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Core.Application.Services
{
    public class GenericService<SaveViewModel, ViewModel, Entity> : IGenericService<SaveViewModel, ViewModel, Entity>
        where SaveViewModel : class
        where ViewModel : class
        where Entity : class
    {
        private readonly IGenericRepo<Entity> _genericRepo;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepo<Entity> genericRepo, IMapper mapper)
        {
            _genericRepo = genericRepo;
            _mapper = mapper;
        }

        public virtual async Task<SaveViewModel> Add(SaveViewModel vm)
        {
            Entity entity = _mapper.Map<Entity>(vm);
            await _genericRepo.AddAsync(entity);

            SaveViewModel saveVm = _mapper.Map<SaveViewModel>(entity);

            return saveVm;
        }

        public virtual async Task Delete(int id)
        {
            Entity entity = await _genericRepo.GetByIdAsync(id);
            await _genericRepo.DeleteAsync(entity);
        }

        public virtual async Task Update(SaveViewModel vm, int id)
        {
            Entity entity = _mapper.Map<Entity>(vm);
            await _genericRepo.UpdateAsync(entity, id);
        }

        public virtual async Task<SaveViewModel> GetById(int id)
        {
            Entity entity = await _genericRepo.GetByIdAsync(id);
            SaveViewModel saveVm = _mapper.Map<SaveViewModel>(entity);

            return saveVm;
        }

        public virtual async Task<List<ViewModel>> GetAll()
        {
            List<Entity> entityList = await _genericRepo.GetAllAsync();

            return _mapper.Map<List<ViewModel>>(entityList);
        }
    }
}
