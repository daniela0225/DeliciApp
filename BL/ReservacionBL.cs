using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BDAccess;


namespace BL
{
    public class ReservacionBL
    {
        ReservacionBD resv = new ReservacionBD();

        public List<Reservacion> Listar()
        {
            return resv.Listar();
        }

        public int Insert(String id_rest, String id_resv, String id_per,
                            DateTime resv_date, String resv_phone, String resv_add, String resv_mail)
        {
            Reservacion nuevo = new Reservacion
            {
                id_rest = id_rest,
                id_resv = id_resv,
                id_per = id_per,
                resv_date = resv_date,
                resv_phone = resv_phone,
                resv_add = resv_add,
                resv_mail = resv_mail
            };

            return resv.Insert(nuevo);
        }

        public int Update(String id_rest, String id_resv, String id_per,
                            DateTime resv_date, String resv_phone, String resv_add, String resv_mail)
        {
            Reservacion edit = new Reservacion
            {
                id_rest = id_rest,
                id_resv = id_resv,
                id_per = id_per,
                resv_date = resv_date,
                resv_phone = resv_phone,
                resv_add = resv_add,
                resv_mail = resv_mail
            };

            return resv.Update(edit);
        }

        public int EliminarBLL(String id_resv)
        {
            return resv.Delete(id_resv);
        }
    }
}
