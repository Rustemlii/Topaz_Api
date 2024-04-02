using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstrack
{

    public interface IBaseService<RqDTO,TEntity,RsDTO>
    {
        IEnumerable<RsDTO> GetAll();
        RsDTO GetbyId(int id);
        RsDTO Insert(RqDTO dto);
        void Update(RqDTO dto);
        void Delete(int id);
    }
}