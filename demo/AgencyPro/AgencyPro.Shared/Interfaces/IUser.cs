namespace AgencyPro.Shared.Interfaces;

public interface IUser
{
    Guid Id { get; set; }
    string UserName { get; set; }
    string Email { get; set; }
    string PhoneNumber { get; set; }
}