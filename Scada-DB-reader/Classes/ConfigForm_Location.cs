using Scada_DB_reader.Classes;

namespace Scada_DB_reader
{
    public partial class ConfigForm: Form
    {
        //Functions that handle the Location controls in the ConfigForm

        private List<Location> _locations = new List<Location>();
        private int _locationSelected = 0;

        /// <summary>
        /// Populates the Location controls in ConfigForm
        /// </summary>
        //private void PopulateLocation()
        //{

        //    _locations = LoadLocations();

        //    cmbLocation.DataSource = _locations;
        //    cmbLocation.DisplayMember = "LocationName";
        //    cmbLocation.ValueMember = "LocationId";
        //    cmbLocation.SelectedIndex = _locationSelected;
        //    fillLocationDetails();
        //}

        /// <summary>
        /// Populates the location details in the ConfigForm with the selected Location
        /// </summary>
        private void fillLocationDetails(Location location)
        {
            txtLocationName.Text = location.LocationName;
            txtBuilding.Text = location.Building;
            txtFloor.Text = location.Floor.ToString();
            txtRoom.Text = location.Room;
        }

        /// <summary>
        /// Load Locations from the DB
        /// </summary>
        /// <returns>List of Location</returns>
        //private List<Location> LoadLocations()
        //{
        //    Location location = new Location();
        //    return location.GetAllLocations();
        //}

        //private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    _locationSelected = cmbLocation.SelectedIndex;
        //    // Fill location details
        //    fillLocationDetails();
        //}
    }
}
