using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BDAccess
{
    public class PersonaBD
    {
        DeliciappEntities context = new DeliciappEntities();

        public List<Persona> Lista()
        {
            using (context)
            {
                var Query = context.Persons.Select(p => new Persona
                {
                    id_per = p.id_per,
                    per_name = p.per_name,
                    per_mail = p.per_mail,
                    per_pass = p.per_pass,
                    per_phone = p.per_phone
                });
                return Query.ToList();
            }
        }

        public int Insert(Persona per)
        {
            context.insertPersona(
                per.per_name,
                per.per_mail,
                per.per_pass,
                per.per_phone
                );
            return context.SaveChanges();
        }
        public int Update(Persona per)
        {
            context.updatePersona(
                per.id_per,
                per.per_name,
                per.per_mail,
                per.per_pass,
                per.per_phone
                );
            return context.SaveChanges();
        }

        public int Delete(string id_per)
        {
            context.deletePersona(id_per);
            return context.SaveChanges();
        }

    }
}
