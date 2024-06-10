using PSDProject.Factory;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Handler
{
    public class StationeryHandler
    {
        public static void CreateStationery(string name, int price)
        {
            StationeryRepository.CreateStationery(name, price);
        }

        public static void UpdateStationery(string name, int price)
        {
            StationeryRepository.UpdateStationery(name, price);
        }

        public static void DeleteStationery(string name)
        {
            StationeryRepository.DeleteStationery(name);
        }
    }
}