namespace EmailService.Interfaces
{
    public interface IEmailService
    {
        Task SendPasswordEmailAsync(string email, string password);
    }
}
