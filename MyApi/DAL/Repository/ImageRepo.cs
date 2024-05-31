using DAL.Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    internal class ImageRepo : IImageRepo
    {
        public Task AddAsync(Image image)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(EditImagesRequestModel model)
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
