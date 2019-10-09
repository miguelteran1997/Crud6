using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD6.Data
{
    public class Cars
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        [ForeignKey("MID")]
        public Manufacturers manufacID { get; set; }

    }
}
