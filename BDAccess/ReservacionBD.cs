using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BDAccess
{
    class ReservacionBD
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
                res.id_per,
                res.id_rest,
                res.resv_add,
                res.resv_date,
                res.resv_mail,
                res.resv_phone
                );
            return context.SaveChanges();
        }

        public int Update(Reservacion res)
        {
            context.updateReservations(
                res.id_resv,
                res.id_per,
                res.id_rest,
                res.resv_add,
                res.resv_date,
                res.resv_mail,
                res.resv_phone
                );
            return context.SaveChanges();
        }
        public int Delete(string id)
        {
            context.deleteReservations(id);
            return context.SaveChanges();
        }
    }
}
