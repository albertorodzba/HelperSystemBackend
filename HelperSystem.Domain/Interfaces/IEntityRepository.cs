using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperSystem.Domain.Interfaces;

public interface IEntityRepository<TEntity, TEntityID>{

    List<TEntity> GetAll();
    TEntity GetById(TEntityID entityID);
    void Add(TEntity entity);
    TEntity Update(TEntity entity);
    void Disable(TEntityID entityID);
    
}