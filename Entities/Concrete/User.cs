using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class User
    {
        [Key]
        public int InsanId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string ConfirmValue { get; set; }
        public bool IsConfirm { get; set; }
        public string ForgotPasswordValue { get; set; }
        public DateTime? ForgotPasswordRequestDate { get; set; }
        public bool IsForgotPasswordComplete { get; set; }
        public List<Personel> Personels { get; set; }
        public List<Kullanici> Kullanicis { get; set; }
    }
}
