using PSDProject.Factory;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public class StationeryRepository
    {
        static RAisoDBEntities db = DatabaseSingleton.getInstance();

        public static List<MsStationery> GetAllStatoneries()
        {
            return db.MsStationeries.ToList();
        }

        public static void CreateStationery(string name, int price)
        {
            MsStationery newStationery = StationeryFactory.CreateStationery(name, price);
            db.MsStationeries.Add(newStationery);
            db.SaveChanges();
        }

        public static MsStationery FindStationeryByName(string name)
        {
            MsStationery msStationery = db.MsStationeries.Where(x => x.StationeryName == name).FirstOrDefault();
            return msStationery;
        }

        public static void UpdateStationery(string name, int price)
        {
            MsStationery msStationery = FindStationeryByName(name);
            msStationery.StationeryName = name;
            msStationery.StationeryPrice = price;
            db.SaveChanges();
        }

        public static void DeleteStationery(string name)
        {
            db.MsStationeries.Remove(FindStationeryByName(name));
            db.SaveChanges();
        }

    }
}