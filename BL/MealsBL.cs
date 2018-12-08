using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDAccess;
using Entities;

namespace BL
{
    public class MealsBL
    {
        MealBD meal = new MealBD();

        public List<ClassMeals> Listar()
        {
            return meal.Listar();
        }

        public int Insert(String id_tmea, String mea_name, 
                            String mea_desc, String mea_cost, String mea_pic)
        {
            ClassMeals nuevo = new ClassMeals
            {
                id_tmea = id_tmea,
                mea_name = mea_name,
                mea_desc = mea_desc,
                mea_cost = mea_cost,
                mea_pic = mea_pic
            };

            return meal.Insertar(nuevo);
        }

        public int EditarBLL(String id_mea, String id_tmea, 
                            String mea_name, String mea_desc, 
                            String mea_cost, String mea_pic)
        {
            ClassMeals edit = new ClassMeals
            {
                id_mea = id_mea,
                id_tmea = id_tmea,
                mea_name = mea_name,
                mea_desc = mea_desc,
                mea_cost = mea_cost,
                mea_pic = mea_pic
            };

            return meal.Update(edit);
        }
        public int EliminarBLL(String id_mea)
        {
            return meal.Delete(id_mea);
        }
    }
}
