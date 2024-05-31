using DAL;
using DAL.Entities;
using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EffectService : IEffectService
    {
        private readonly IEffectRepo effectRepo;
        public async Task AddAsync(Effect effect)
        {
            await effectRepo.AddAsync(new Effect
            {
                Name = effect.Name
            }) ;
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(EditEffectRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetEffectResponseModel>> GetAsync(GetEffectRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<GetEffectResponseModel> GetDetailsAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
