﻿using DAL.Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    internal interface IImageRepo
    {
        Task AddAsync(Image image);
        Task EditAsync(EditImagesRequestModel model);
        Task<IEnumerable<GetEffectResponseModel>> GetAsync(GetEffectRequestModel model);
        Task<GetEffectResponseModel> GetDetailsAsync(long id);

        Task DeleteUserAsync(long id);
    }
}
