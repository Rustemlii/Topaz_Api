using AutoMapper;
using Business.Abstrack;
using DataAccesLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BaseService<RqDTO,TEntity,RsDTO> : IBaseService<RqDTO, TEntity, RsDTO>
        where TEntity : class
    {
        protected readonly IMapper _mapper;
        protected readonly AppDbContext _DbContext;
        protected readonly DbSet<TEntity> _dBSet;

        public BaseService(IMapper mapper, AppDbContext dBContext)
        {
            _mapper = mapper;
            _DbContext = dBContext;
            _dBSet = dBContext.Set<TEntity>();
        }

        public void Delete(int id)
        {
            var ent=_dBSet.Find(id);
            _dBSet.Remove(ent);
            _DbContext.SaveChanges();
        }     

        public IEnumerable<RsDTO> GetAll()
        {
            var ent = _dBSet.ToList();
            var rsdto = _mapper.Map<IEnumerable<RsDTO>>(ent);
            return rsdto;
        }

        public RsDTO GetbyId(int id)
        {
            var ent = _dBSet.Find(id);
            var rsDto = _mapper.Map<RsDTO>(ent);
            return rsDto;
        }

        public RsDTO Insert(RqDTO dto)
        {
           var ent=_mapper.Map<TEntity>(dto);
            _dBSet.Add(ent);
            _DbContext.SaveChanges();
            var rsdto=_mapper.Map<RsDTO>(ent);
            return rsdto;
        }
        public void Update(RqDTO dto)
        {
            var ent = _mapper.Map<TEntity>(dto);
            _dBSet.Update(ent);
            _DbContext.SaveChanges();
        }

      
    }
}
