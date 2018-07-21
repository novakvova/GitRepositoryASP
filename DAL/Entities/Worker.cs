using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("tblWorkers")]
    public class Worker
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 50)]
        public string Lastname { get; set; }
        [Required, StringLength(maximumLength:50)]
        public string Firstname { get; set; }
        [StringLength(maximumLength: 50)]
        public string Fathername { get; set; }
        [Required, EmailAddress, StringLength(maximumLength: 255)]
        public string Email { get; set; }
        [Required, StringLength(maximumLength: 255)]
        public string Password { get; set; }
        [Required, StringLength(maximumLength: 255)]
        public string PasswordSalt { get; set; }
        [ForeignKey("DepatmentOf")]
        public int DepatrmentId { get; set; }
        virtual public Depatment DepatmentOf { get; set; }
    }
}
