using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad Soyad Alanı Zorunlu(Test)")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Telefon Numarası Alanı Zorunlu(Test)")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Posta Adresi Alanı Zorunlu(Test)")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public bool WillAttend { get; set; }

    }
}
