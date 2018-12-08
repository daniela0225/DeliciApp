using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BDAccess;


namespace BL
{
    public class RestauranteBL
    {
        RestauranteBD rest = new RestauranteBD();

        public List<Restaurante> Listar()
        {
            return rest.Listar();
        }

        public int Insert(String id_trest, String rest_address, String rest_desc,
                            String rest_map, String rest_name, String rest_pic)
        {
            Restaurante nuevo = new Restaurante
            {
                id_trest = id_trest,
                rest_address = rest_address,
                rest_desc = rest_desc,
                rest_map = rest_map,
                rest_name = rest_name,
                rest_pic = rest_pic
            };

            return rest.Insert(nuevo);
        }

        public int Update(String id_rest, String id_trest, String rest_address, String rest_desc,
                            String rest_map, String rest_name, String rest_pic)
        {
            Restaurante edit = new Restaurante
            {
                id_rest = id_rest,
                id_trest = id_trest,
                rest_address = rest_address,
                rest_desc = rest_desc,
                rest_map = rest_map,
                rest_name = rest_name,
                rest_pic = rest_pic
            };

            return rest.Update(edit);
        }

        public int EliminarBLL(String id_men)
        {
            return rest.Delete(id_men);
        }
    }
}
