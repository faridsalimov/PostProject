using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserNamespace;

namespace NotificationNamespace
{
    internal class Notification
    {
        public int Id { get; set; }
        public static int StaticId = 1;
        public string? Text { get; set; }
        public DateTime DateTime { get; set; }
        public User? FromUser { get; set; }

        public Notification(string? text, User? fromuser)
        {
            Id = StaticId++;
            Text = text;
            DateTime = DateTime.Now;
            FromUser = fromuser;
        }

        public override string ToString()
        {
            return $"ID: {Id} \nText: {Text} \nDate Time: {DateTime} \nFrom User: {FromUser.Name} {FromUser.Surname}\n";
        }
    }
}