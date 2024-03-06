namespace WelcomeToDocker;

public class Update
{
    public static void UpdatePerson(AppDbContext context, int id, string newFirstName, string newLastName, int? newAge)
    {
        var personToUpdate = context.People.FirstOrDefault(p => p.Id == id);

        if (personToUpdate != null)
        {
            personToUpdate.FirstName = newFirstName;
            personToUpdate.LastName = newLastName;
            personToUpdate.Age = newAge;

            context.SaveChanges();
            Console.WriteLine("Person updated successfully!");
        }
        else
        {
            Console.WriteLine("Person with specified ID not found!");
        }
    }
}