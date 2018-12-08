using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDAccess;


namespace BL
{
    public class TypeRestBL
    {
        TypeRestBD tr = new TypeRestBD();

        public List<TypeRest> Listar()
        {
            return tr.Listar();
        }

        public int Insert(String id_trest, String trest_name)
        {
            TypeRest nuevo = new TypeRest
            {
                id_trest = id_trest,
                trest_name = trest_name
                
            };

            return tr.Insert(nuevo);
        }

        public int Update(String id_trest, String trest_name)
        {
            TypeRest edit = new TypeRest
            {
                id_trest = id_trest,
                trest_name = trest_name
            };

            return tr.Update(edit);
        }

        public int EliminarBLL(String id_trest)
        {
            return tr.Delete(id_trest);
        }
    }
}
