namespace PeekStock.API.Domain.Entities;

public class User(string name, string email) : BaseEntity
{
	public string Name { get; set; } = name;
	public string Email { get; set; } = email;
	public string Password { get; private set; } = string.Empty;

	public void SetPassword(string password) => Password = HashPassword(password);

	public bool ValidatePassword(string password)
		=> BCrypt.Net.BCrypt.Verify(password, Password);

	private string HashPassword(string password)
		=> BCrypt.Net.BCrypt.HashPassword(password);

	public void Edit(string name, string email, string password, bool isDeleted = false)
	{
		Name = name;
		Email = email;
		Password = HashPassword(password);
		AlterDate = DateTime.Now;
		IsDeleted = isDeleted;
	}
}

