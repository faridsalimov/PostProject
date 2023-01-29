using AdminNamespace;
using NotificationNamespace;
using PostNamespace;
using System.Reflection.Emit;
using UserNamespace;

Admin a1 = new("Farid", "farid@gmail.com", "farid123");

User u1 = new("Fuad", "Selimov", 14, "fuad@gmail.com", "fuad123");
User u2 = new("Rinat", "Qedimov", 15, "riko@gmail.com", "riko123");

Post p1 = new("First Post!");
Post p2 = new("Second Post OMG!");
a1.AddPost(p1);
a1.AddPost(p2);

List<User> users = new();

users.Add(u1);
users.Add(u2);

label:
Console.Clear();
string? select;
Console.WriteLine("1 - Admin\n2 - User");
select = Console.ReadLine();

if (select == "1")
{
    Console.Clear();
    string? username;
    string? password;

    Console.WriteLine("Enter username: ");
    username = Console.ReadLine();

    Console.WriteLine("Enter password: ");
    password = Console.ReadLine();

    if (username == "Farid" && password == "farid123")
    {
    label2:
        Console.Clear();
        Console.WriteLine("1 - Show Notifications\n2 - Show Posts\n3 - Add Post\n4 - Logout");
        select = Console.ReadLine();

        if (select == "1")
        {
        shownoti:
            Console.Clear();
            a1.ShowNotifications();
            Console.WriteLine("B - Back");
            select = Console.ReadLine();

            if (select == "b" || select == "B")
            {
                goto label2;
            }

            else
            {
                Console.WriteLine(">> Invilad select.");
                goto shownoti;
            }
        }

        else if (select == "2")
        {
        showposts:
            Console.Clear();
            a1.ShowPosts();

            Console.WriteLine("B - Back");
            select = Console.ReadLine();

            if (select == "b" || select == "B")
            {
                goto label2;
            }

            else
            {
                Console.WriteLine(">> Invilad select.");
                goto showposts;
            }
        }

        else if (select == "3")
        {
            Console.Clear();
            string? content;
            Console.WriteLine("Enter content: ");
            content = Console.ReadLine();

            Post post = new(content);
            a1.AddPost(post);

            Console.Clear();
            Console.WriteLine(">> Post successfully added.");
            goto label2;
        }

        else if (select == "4")
        {
            goto label;
        }

        else
        {
            Console.WriteLine(">> Invilad select.");
        }
    }
}

else if (select == "2")
{
    Console.Clear();
    string? email;
    string? password;

    Console.WriteLine("Enter email: ");
    email = Console.ReadLine();

    Console.WriteLine("Enter password: ");
    password = Console.ReadLine();

    foreach (var user in users)
    {
        if (user.Email == email && user.Password == password)
        {
        label3:
            Console.Clear();
            a1.ShowPosts();

            Console.WriteLine("1 - Like\n2 - Notification\n3 - Logout");
            select = Console.ReadLine();

            if (select == "1")
            {
                int id;
                Console.WriteLine("Enter Post ID: ");
                id = Convert.ToInt32(Console.ReadLine());

                a1.LikePostById(id);
                Console.WriteLine(">> Post successfully liked.");

                goto label3;
            }

            else if (select == "2")
            {
                int id;
                Console.WriteLine("Enter Post ID: ");
                id = Convert.ToInt32(Console.ReadLine());

                string? text;
                Console.WriteLine("Enter text: ");
                text = Console.ReadLine();

                a1.AddNotification(id, text, user);
                Console.WriteLine(">> Notification sent successfully.");

                goto label3;
            }

            else if (select == "3")
            {
                goto label;
            }

            else
            {
                Console.WriteLine(">> Invilad select.");
            }
        }
    }
}

else
{
    Console.WriteLine(">> Invilad select.");
}