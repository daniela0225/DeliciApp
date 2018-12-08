using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDAccess
{
    class TypeRestBD
    {
        DeliciappEntities context = new DeliciappEntities();

        public List<TypeRest> Listar()
        {
            using (context)
            {
                var query = context.TypeRest.Select(tm => new TypeRest
                {
                    id_trest = tm.id_trest,
                    trest_name = tm.trest_name
                });
                return query.ToList();
            }
        }
        public int Insert(TypeRest tm)
        {
            context.insertTypeMeal(
                    tm.trest_name
            );
            return context.SaveChanges();
        }
        public int Update(TypeRest tm)
        {
            context.updateTypeMeal(
                    tm.id_trest,
                    tm.trest_name
            );
            return context.SaveChanges();
        }
        public int Delete(string id_trest)
        {
            context.deleteTypeMeal(
                id_trest
            );
            return context.SaveChanges();
        }
    }
}
