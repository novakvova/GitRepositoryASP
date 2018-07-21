using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("tblDepartments")]
    public class Depatment
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength:255)]
        public string Name { get; set; }
        [StringLength(maximumLength:2000)]
        public string Description { get; set; }
        [StringLength(maximumLength: 128)]
        public string Image { get; set; }
        virtual public ICollection<Worker> Workers { get; set; }
    }
}
