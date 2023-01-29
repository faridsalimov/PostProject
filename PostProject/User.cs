using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    internal class User
    {
        public int Id { get; set; }
        public static int StaticId = 1;
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public User(string? name, string? surname, int age, string? email, string password)
        {
            Id = StaticId++;
            Name = name;
            Surname = surname;
            Age = age;
            Email = email;
            Password = password;
        }

        public override string ToString()
        {
            return $"ID: {Id} \nName: {Name} \nSurname: {Surname} \nAge: {Age} \nEmail: {Email}";
        }
    }
}