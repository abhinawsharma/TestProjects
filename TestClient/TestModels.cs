using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClient
{
    public class TestModels
    {

    }
    public partial class NasaPhotos
    {
        public List<photos> photos { get; set; }
    }
    public partial class photos
    {
        public long id { get; set; }
        public int sol { get; set; }
        public camera camera { get; set; }
        public string img_src { get; set; }
        public string earth_date { get; set; }
        public rover rover { get; set; }
    }
    public class camera
    {
        public long id { get; set; }
        public string name { get; set; }
        public int rover_id { get; set; }
        public string full_name { get; set; }
    }
    public class rover
    {
        public long id { get; set; }
        public string name { get; set; }
        public string landing_date { get; set; }
        public string launch_date { get; set; }
        public string status { get; set; }
        public string max_sol { get; set; }
        public string max_date { get; set; }
        public string total_photos { get; set; }
        public List<camera> cameras { get; set; }
    }

    public class GridModel
    {
        public long id { get; set; }
        public string img_src { get; set; }
    }
}
