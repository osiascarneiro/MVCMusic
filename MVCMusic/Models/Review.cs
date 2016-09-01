using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCMusic.Models {

    public class Review {

        public int ReviewID { get; set; }

        public int AlbumID { get; set; }

        public virtual Album Album { get; set; }

        [Display(Name ="Content of Review")]
        public string Contents { get; set; }

        [Required()]
        [Display(Name="Email Address")]
        [DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }

    }
}