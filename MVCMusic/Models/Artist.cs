using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusic.Models {

    public class Artist {

        public int ArtistID { get; set; }

        public string Name { get; set; }

        public List<Album> Albuns { get; set; }

    }
}