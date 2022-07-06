using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParticipationMicroservice.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        IEnumerable<TEntity> GetByStatus(string status);
        void Add(TEntity entity);
        void Update(TEntity dbEntity, string entity);
    }
}
