using System.Collections.Generic;

namespace BaseDomainContract.ServerContract.IService
{
    /// <summary>
    /// Dto-Entity Convert
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <typeparam name="TEntity"></typeparam>
    public interface IModelConvert<TModel, TEntity> where TModel : class where TEntity : class
    {
        TModel ConvertToModel(TEntity entity);

        TEntity ConvertToEntity(TModel model);

        IEnumerable<TModel> ConvertToModels(IEnumerable<TEntity> entities);

        IEnumerable<TEntity> ConvertToEntitys(IEnumerable<TModel> models);
    }
}
