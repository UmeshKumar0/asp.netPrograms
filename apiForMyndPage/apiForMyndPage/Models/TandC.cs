using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace apiForMyndPage.Models
{
    public class TandC
    {
        public int id { get; set; }
        [Required]
        public string EMPNAME { get; set; }
        [Required]
        [StringLength(250,ErrorMessage ="Name not be exceed")]
        public string Extramile { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Name not be exceed")]
        public string Creative { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Name not be exceed")]
        public string ImproveWork { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Name not be exceed")]
        public string Fellow { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Name not be exceed")]
        public string WorkUP { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Name not be exceed")]
        public string OtherComments { get; set; }
    }
}