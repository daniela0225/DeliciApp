using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BDAccess
{
    class TypeMealBD
    {
        DeliciappEntities context = new DeliciappEntities();

        public List<TypeMeal> Listar()
        {
            using (context)
            {
                var query = context.TypeMeal.Select(tm => new TypeMeal
                {
                    id_tmea = tm.id_tmea,
                    tmea_name = tm.tmea_name
                });
                return query.ToList();
            }
        }
        public int Insert(TypeMeal tm)
        {
            context.inserTypeMeal(
                    tm.tmea_name
            );
            return context.SaveChanges();
        }
        public int Update(TypeMeal tm)
        {
            context.updateTypeMeal(
                    tm.id_tmea,
                    tm.tmea_name
            );
            return context.SaveChanges();
        }
        public int Delete(string id_tmea)
        {
            context.deleteTypeMeal(
                id_tmea
            );
            return context.SaveChanges();
        }
    }
}
