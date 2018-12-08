using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BDAccess
{
    class RestauranteBD
    {
        DeliciappEntities context = new DeliciappEntities();

        public List<Restaurants> Listar()
        {
            using (context)
            {
                var query = context.Restaurants.Select(res => new Restaurante
                {
                    id_rest = res.id_rest,
                    id_trest = res.id_trest,
                    rest_name = res.rest_name,
                    rest_address = res.rest_address,
                    rest_desc = res.rest_desc,
                    rest_map = res.rest_map,
                    rest_pic = res.rest_pic
                });
                return query.ToList();
            }
        }
        public Restaurants GetID(string id_rest)
        {
            var query = context.Restaurants.Select(res => new Restaurante
            {
                id_rest = res.id_rest,
                id_trest = res.id_trest,
                rest_name = res.rest_name,
                rest_address = res.rest_address,
                rest_desc = res.rest_desc,
                rest_map = res.rest_map,
                rest_pic = res.rest_pic
            }).Where(res => res.id_rest == id_rest);
            return query.First();

        }

        public int Insert(Restaurants res)
        {
            context.insertRestaurants(
                res.id_trest,
                res.rest_address,
                res.rest_desc,
                res.rest_map,
                res.rest_name,
                res.rest_pic
                );
            return context.SaveChanges();
        }
        public int Update(Restaurants res)
        {
            context.updateRestaurants(
                res.id_rest,
                res.id_trest,
                res.rest_address,
                res.rest_desc,
                res.rest_map,
                res.rest_name,
                res.rest_pic
                );
            return context.SaveChanges();
        }
        public int Delete(String id_rest)
        {
            context.deleteRestaurants(id_rest);
            return context.SaveChanges();
        }
    }
}
