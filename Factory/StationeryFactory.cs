using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Factory
{
    public class StationeryFactory
    {
        public static int CreateID()
        {
            RAisoDBEntities db = DatabaseSingleton.getInstance();
            int id = 1;
            if (db.MsStationeries != null)
            {
                id = db.MsStationeries.Last().StationeryID;
                id++;
            }
            return id;
        }

        public static MsStationery CreateStationery(string name, int price)
        {
            int newID = CreateID();
            MsStationery newStationery = new MsStationery()
            {
                StationeryID = newID,
                StationeryName = name,
                StationeryPrice = price
            };
            return newStationery;
        }
    }
}