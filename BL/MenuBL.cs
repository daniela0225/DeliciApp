using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BDAccess;

namespace BL
{
    public class MenuBL
    {
        MenuBD menu = new MenuBD();

        public List<ClassMenu> Listar()
        {
            return menu.Listar();
        }

        public int Insert(String id_mea, String id_men, String id_rest, 
                            DateTime men_avaiFrom, DateTime men_avaiTo)
        {
            ClassMenu nuevo = new ClassMenu
            {
                id_mea = id_mea,
                id_men = id_men,
                id_rest = id_rest,
                men_avaiFrom = men_avaiFrom,
                men_avaiTo = men_avaiTo
            };

            return menu.Insert(nuevo);
        }

        public int Update(String id_mea, String id_men, String id_rest,
                            DateTime men_avaiFrom, DateTime men_avaiTo)
        {
            ClassMenu edit = new ClassMenu
            {
                id_mea = id_mea,
                id_men = id_men,
                id_rest = id_rest,
                men_avaiFrom = men_avaiFrom,
                men_avaiTo = men_avaiTo
            };

            return menu.Update(edit);
        }

        public int EliminarBLL(String id_men)
        {
            return menu.Delete(id_men);
        }
    }
}
