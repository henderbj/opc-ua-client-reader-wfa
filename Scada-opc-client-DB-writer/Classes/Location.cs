using Microsoft.Data.SqlClient;
using Scada_opc_client_DB_writer;

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
    }
}
