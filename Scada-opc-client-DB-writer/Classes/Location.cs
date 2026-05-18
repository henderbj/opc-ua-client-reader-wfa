using Microsoft.Data.SqlClient;
using Scada_opc_client_DB_writer;
using System.Data;

namespace Scada_opc_client_DB_writer.Classes
{
    internal class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string Building { get; set; }
        public int Floor { get; set; }
        public string Room { get; set; }
        internal string connectionString = AppConfig.ConnectionString;

        public List<Location> GetAllLocations()
        {
            List<Location> locationList = new List<Location>();
            SqlConnection con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT LocationId, LocationName, Building, Floor, Room FROM dbo.Location", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Location location = new Location();
                    location.LocationId = Convert.ToInt32(dr["LocationId"]);
                    location.LocationName = dr["LocationName"].ToString();
                    location.Building = dr["Building"].ToString();
                    location.Floor = Convert.ToInt32(dr["Floor"]);
                    location.Room = dr["Room"].ToString();
                    locationList.Add(location);
                }
            }
            return locationList;
        }
        
        public Location FindOrCreate(string locationName, string building, int floor, string room)
        {
            Location location = new Location();
            SqlConnection con = new SqlConnection(connectionString);
            locationName = locationName.Trim();
            building = building.Trim();
            room = room.Trim();
            var cmd = new SqlCommand("usp_FindOrCreateLocation", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@LocationName", locationName);
            cmd.Parameters.AddWithValue("@Building", building);
            cmd.Parameters.AddWithValue("@Floor", floor);
            cmd.Parameters.AddWithValue("@Room", room);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    location.LocationId = Convert.ToInt32(dr["LocationId"]);
                    location.LocationName = dr["LocationName"].ToString();
                    location.Building = dr["Building"].ToString();
                    location.Floor = Convert.ToInt32(dr["Floor"]);
                    location.Room = dr["Room"].ToString();
                }
            }
            return location;
        }
    }
}
