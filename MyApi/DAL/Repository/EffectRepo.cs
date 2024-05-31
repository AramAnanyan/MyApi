using AutoMapper;
using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    internal class EffectRepo : IEffectRepo
    {
        private readonly MyApiContext context;
        private readonly IMapper mapper;
        public EffectRepo(MyApiContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task AddAsync(Effect effect)
        {
            context.Effects.Add(effect);

            await context.SaveChangesAsync();
        }
        public async Task<IEnumerable<GetEffectResponseModel>> GetAsync(GetEffectRequestModel model)
        {


            /*var effects = await context.Effects.Where(x =>
                     (!model.Id.HasValue || x.Id == model.Id) &&
                     (string.IsNullOrWhiteSpace(model.Name) || model.Name == x.Name)
                     ).ToListAsync();

            var mappedEffects = mapper.Map<IEnumerable<GetEffectResponseModel>>(effects);*/

            // return mappedEffects;
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
