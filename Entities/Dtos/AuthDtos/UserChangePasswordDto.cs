namespace Entities.Dtos.AuthDtos
{
    public class UserChangePasswordDto
    {
        public int InsanId { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
