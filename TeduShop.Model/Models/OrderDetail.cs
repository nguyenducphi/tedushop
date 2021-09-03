using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { set; get; }

        [Key]
        public int ProductID { set; get; }

        public int Quantity { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; } // Tự động mapping quan hệ với cột ID trong bảng Orders khi render ra Database

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; } // Tự động mapping quan hệ với cột ID trong bảng Products khi render ra Database
    }
}
