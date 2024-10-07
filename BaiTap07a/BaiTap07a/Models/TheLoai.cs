using System.ComponentModel.DataAnnotations;

namespace BaiTap07a.Models
{
    public class TheLoai
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage ="không thể để trống tên thể loại!")]
        [StringLength (10, ErrorMessage = "{0} độ dài từ  {2} đến {1} ký tự.",  MinimumLength = 8)]
        [Display(Name ="Thể loại")]
        public string Name { get; set; }
        [Required(ErrorMessage = "không đúng định dạng ngày!")]
        [Display(Name = "Ngày tạo")]
        public DateTime DataCreated { get; set; } = DateTime.Now;
    }
}
