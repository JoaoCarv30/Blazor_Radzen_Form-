using System.ComponentModel.DataAnnotations;

namespace Radzen2.Model;

public class UserModel
{
    
    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "O campo Sobrenome é obrigatório.")]
    public string LastName { get; set; }
    
    [Required(ErrorMessage = "O campo Email é obrigatório.")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
    
    public string Phone { get; set; }
    
    [Required(ErrorMessage = "O campo Senha é obrigatório.")]
    
    public string Password { get; set; }


    public UserModel()
    {
        
    }
    
    public UserModel(string name, string lastName, string email, string phone, string password)
    {
        Name = name;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Password = password;
    }
    
    
    
    
}