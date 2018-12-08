using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BDAccess;

namespace BL
{
    public class PersonaBL
    {
        PersonaBD per = new PersonaBD();

        public List<Persona> Listar()
        {
            return per.Lista();
        }

        public int Insert(String id_per, String per_name, String per_mail,
                            String per_pass, String per_phone)
        {
            Persona nuevo = new Persona
            {
                id_per = id_per,
                per_name = per_name,
                per_mail = per_mail,
                per_pass = per_pass,
                per_phone = per_phone
            };

            return per.Insert(nuevo);
        }

        public int Update(String id_per, String per_name, String per_mail,
                            String per_pass, String per_phone)
        {
            Persona edit = new Persona
            {
                id_per = id_per,
                per_name = per_name,
                per_mail = per_mail,
                per_pass = per_pass,
                per_phone = per_phone
            };

            return per.Update(edit);
        }

        public int EliminarBLL(String id_per)
        {
            return per.Delete(id_per);
        }
    }
}
