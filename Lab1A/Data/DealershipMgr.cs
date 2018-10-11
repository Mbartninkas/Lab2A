using Lab1A.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1A.Data
{
    public class DealershipMgr 
    {
        public static List<Dealership> Dealerships = new List<Dealership>();

        public static List<Dealership> Get()
        {
                if (Dealerships != null)
                {
                    return Dealerships;
                }
            
            return null;
        }
        public static Dealership Get(int? ids) {

            foreach (var x in Dealerships) {
                if (x.ID == ids) {
                    return x;
                }
            }
            return null;
        }
        public static string Put(Dealership ids)
        {

            foreach (var x in Dealerships)
            {
                if (x.ID == ids.ID && x.Name != null && x.Email != null)
                {
                    x.Email = ids.Email;
                    x.Name = ids.Name;
                    x.Phone = ids.Phone;

                    return "Success";
                }
            }
            return "Failure";
        }
        public static string Delete(int? ids)
        {
            foreach (var x in Dealerships)
            {
                if (x.ID == ids) {
                    Dealerships.Remove(x);
                    return "Success";
                }
            }
            return "Failure";
        }
        public static string Post(Dealership dealership)
        {
            if (dealership!= null && dealership.Name != null && dealership.Email != null ) {
                dealership.ID = Dealerships.Count();
                Dealerships.Add(dealership);
                return "Success";
            }  
            
            return "Failure";
        }
        public static bool Exist(int ids)
        {
            foreach (var x in Dealerships)
            {
                if (x.ID == ids)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
