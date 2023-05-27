using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SecurePassword.Models
{
    [Table("password")]
    public class Password
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Password_id { set; get; }
        public int Status { set; get; }
        public string Name { set; get; }
        public DateTime Date_created { set; get; }
        public DateTime Date_last_updated { set; get; }
        public DateTime Date_last_time_used { set; get; }


    }
}
