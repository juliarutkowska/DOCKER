namespace WelcomeToDocker;

public class Delete
{
    public static void DeletePerson(AppDbContext context, string firstName, string lastName, int? age)
    {
        var personToDelete = context.People.FirstOrDefault(p =>
            p.FirstName == firstName && p.LastName == lastName && p.Age == age);

        if (personToDelete != null)
        {
            context.People.Remove(personToDelete);
            context.SaveChanges();
            Console.WriteLine("Person deleted successfully!");
        }
        else
        {
            Console.WriteLine("Person with specified criteria not found!");
        }
    }
    
    
    // static void DeletePerson(AppDbContext context, int id)
    // {
    //     var personToDelete = context.People.FirstOrDefault(p => p.Id == id);
    //
    //     if (personToDelete != null)
    //     {
    //         context.People.Remove(personToDelete);
    //         context.SaveChanges();
    //         Console.WriteLine("Person deleted successfully!");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Person with specified ID not found!");
    //     }
    // }
}