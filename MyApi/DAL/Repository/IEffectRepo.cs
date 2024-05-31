using DAL.Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IEffectRepo
    {
        Task AddAsync(Effect effect);
        Task EditAsync(EditEffectRequestModel model);
        Task<IEnumerable<GetEffectResponseModel>> GetAsync(GetEffectRequestModel model);
        Task<GetEffectResponseModel> GetDetailsAsync(long id);

        Task DeleteUserAsync(long id);
    }
}
