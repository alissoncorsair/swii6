// Alisson de Sousa Vieira
// Leonardo de Fontes
namespace TP01.Models
{
    public class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }


        public Author(string name, string email, char gender)
        {
            this.Name = name;
            this.Email = email;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return $"Author[name={this.Name}, email={this.Email}, gender={this.Gender}]";
        }
    }
}
