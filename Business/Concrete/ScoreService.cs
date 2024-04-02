using AutoMapper;
using Business.Abstrack;
using DataAccesLayer.Context;
using DataAccesLayer.Entity;
using DTO.DTOEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ScoreService : BaseService<ScoreDTO, Score, ScoreDTO>, IScoreService
    {
        public ScoreService(IMapper mapper, AppDbContext dBContext) : base(mapper, dBContext)
        {

        }
    }
}
