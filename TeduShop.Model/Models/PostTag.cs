using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int PostID { set; get; }

        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string TagID { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }  // Tự động mapping quan hệ với cột ID trong bảng Tags khi render ra Database

        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }   // Tự động mapping quan hệ với cột ID trong bảng Posts khi render ra Database
    }
}
