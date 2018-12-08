using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data;

namespace BDAccess
{
    public class MenuBD
    {
        DeliciappEntities context = new DeliciappEntities();
        public List<ClassMenu> Listar()
        {
            using (context)
            {
                var query = context.Menus.Select(menu => new ClassMenu
                {
                    id_mea = menu.id_mea,
                    id_men = menu.id_men,
                    id_rest = menu.id_rest,
                    men_avaiFrom = menu.men_avaiFrom ?? DateTime.Now,
                    men_avaiTo = menu.men_avaiTo ?? DateTime.Today
                });
                return query.ToList();
            }
        }

        public int Insert(ClassMenu menu)
        {
            context.insertMenus(
                menu.id_mea,
                menu.id_rest,
                menu.men_avaiForm,
                menu.men_avaiTo
                );
            return context.SaveChanges();
        }
        public int Update(ClassMenu menu)
        {
            context.updateMenus(
                menu.id_men,
                menu.id_mea,
                menu.id_rest,
                menu.men_avaiForm,
                menu.men_avaiTo
                );
            return context.SaveChanges();
        }
        public int Delete(int id_men)
        {
            context.deleteMenus(id_men);
            return context.SaveChanges();
        }
    }
}
