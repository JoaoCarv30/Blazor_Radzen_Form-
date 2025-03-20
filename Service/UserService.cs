using Radzen2.Model;

public class UserService
{
    private List<UserModel> users = new();

    public void AddUser(UserModel user)
    {
        users.Add(user);
    }
    
    public void DeleteUser(UserModel user)
    {
        users.Remove(user);
    }

    public List<UserModel> GetUserList()
    {
        return users; // GARANTIR QUE O RETORNO SEJA UMA LISTA
    }
}