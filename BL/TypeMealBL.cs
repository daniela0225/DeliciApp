using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BDAccess;


namespace BL
{
    public class TypeMealBL
    {
        TypeMealBD tm = new TypeMealBD();

        public List<TypeMeal> Listar()
        {
            return tm.Listar();
        }

        public int Insert(String id_tmea, String tmea_name)
        {
            TypeMeal nuevo = new TypeMeal
            {
                id_tmea = id_tmea,
                tmea_name = tmea_name
            };

            return tm.Insert(nuevo);
        }

        public int Update(String id_tmea, String tmea_name)
        {
            TypeMeal edit = new TypeMeal
            {
                id_tmea = id_tmea,
                tmea_name = tmea_name
            };

            return tm.Update(edit);
        }

        public int EliminarBLL(String id_tmea)
        {
            return tm.Delete(id_tmea);
        }
    }
}
