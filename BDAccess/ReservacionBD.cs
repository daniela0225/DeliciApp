using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BDAccess
{
    public class ReservacionBD
    {
        DeliciappEntities context = new DeliciappEntities();

        public List<Reservacion> Listar()
        {
            using (context)
            {
                var query = context.Reservations.Select(r => new Reservacion
                {
                    id_resv = r.id_resv,
                    id_per = r.id_per,
                    id_rest = r.id_rest,
                    resv_add = r.resv_add,
                    resv_date = r.resv_date,
                    resv_mail = r.resv_mail,
                    resv_phone = r.resv_phone
                });
                return query.ToList();
            }
        }

        public int Insert(Reservacion res)
        {
            context.insertReservations(
                res.id_rest,
                res.id_resv,
                res.id_per,
                res.resv_date,
                res.resv_phone,
                res.resv_add,
                res.resv_mail
                );
            return context.SaveChanges();
        }

        public int Update(Reservacion res)
        {
            context.updateReservations(
                res.id_resv,
                res.id_rest,
                res.id_per,
                res.resv_date,
                res.resv_phone,
                res.resv_add,
                res.resv_mail

                );
            return context.SaveChanges();
        }
        public int Delete(string id_resv)
        {
            context.deleteReservations(id_resv);
            return context.SaveChanges();
        }
    }
}
