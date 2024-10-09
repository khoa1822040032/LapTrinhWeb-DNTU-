using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Không được để trống Tên nhà cung cấp!")]
        [Display(Name = "Tên nhà cung cấp")]
        public string SupplierName { get; set; }

        [Required(ErrorMessage = "Không được để trống Địa chỉ!")]
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Không được để trống Số điện thoại!")]
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }
    }
}
