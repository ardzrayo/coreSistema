using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace coreSistema.AccesoDatos.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);

        //Funciona para obtener los datos de dos entidades relacionadas, propiedades
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,//Funciona para indicar que el filtro sera nulo
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
        );

        //Funciona para obtener un registro
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
        );

        //Nos permite agregar la entidad a la base de datos
        void Add(T entity);

        //Funciona para remover una entidad en base al id proporcionado
        void Remove(int id);

        //Recibe como parametro la entidad
        void Remove(T entity);
    }
}
