public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<ApplicationUser> UpdateUser(ApplicationUser user)
    {
        return await _userRepository.UpdateAsync(user);
    }

    // Add methods for user-specific operations as needed.
}
