

using Assignment333.Enrollment;
using Assignment333.Library;
using Assignment333.Smart_Home;
using Assignment333.Ticket;
using Assignment333.Tracker;

namespace Assignment333
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicketSystem system = new TicketSystem();

            system.AddTicket(new Tickett("Concert", "A12", TicketType.VIP));
            system.AddTicket(new Tickett("Concert", "B10", TicketType.Regular));
            system.AddTicket(new Tickett("Concert", "C5", TicketType.Backstage));
            system.AddTicket(new Tickett("Concert", "D7", TicketType.VIP));
            system.AddTicket(new Tickett("Concert", "E3", TicketType.Regular));

            // Accessing tickets using indexer
            Console.WriteLine($"Seat A12: {system["A12"].EventName} Type: {system["A12"].Type}");
            Console.WriteLine($"Seat C5: {system["C5"].EventName} Type: {system["C5"].Type}");

            // Count tickets by type
            system.CountTicketsByType();

            //
            CourseCatalog catalog = new CourseCatalog();
            catalog.AddCourse(new VideoCourse("C# Basics", "Alice", Level.Beginner, 5));
            catalog.AddCourse(new LiveSession("Advanced AI", "Bob", Level.Advanced, new DateTime(2025, 11, 5, 14, 0, 0)));
            catalog.AddCourse(new VideoCourse("Data Structures", "Charlie", Level.Intermediate, 8));
            catalog.AddCourse(new LiveSession("Intro to Python", "Diana", Level.Beginner, new DateTime(2025, 10, 25, 10, 0, 0)));
            catalog.AddCourse(new VideoCourse("Machine Learning", "Eve", Level.Advanced, 12));

            // Print Beginner level courses
            Console.WriteLine("\nBeginner Level Courses:");
            foreach (var course in catalog[Level.Beginner])
            {
                course.PrintDetails();
                Console.WriteLine();
            }

            // Print Advanced level courses
            Console.WriteLine("Advanced Level Courses:");
            foreach (var course in catalog[Level.Advanced])
            {
                course.PrintDetails();
                Console.WriteLine();
            }


            //Smart Home Control Center
            SmartHome home = new SmartHome();

            // Turn on Light and AC
            home[DeviceType.Light].TurnOn();
            home[DeviceType.AC].TurnOn();

            // Turn off Fan and Heater
            home[DeviceType.Fan].TurnOff();
            home[DeviceType.Heater].TurnOff();

            // Show status of all devices
            Console.WriteLine("\nDevice Status:");
            home[DeviceType.Light].ShowStatus();
            home[DeviceType.Fan].ShowStatus();
            home[DeviceType.AC].ShowStatus();
            home[DeviceType.Heater].ShowStatus();

            home[DeviceType.Light].ShowStatus();
            home[DeviceType.AC].ShowStatus();
            home[DeviceType.Heater].ShowStatus();
            home[DeviceType.Light].ShowStatus();
            home[DeviceType.AC].ShowStatus();
            home[DeviceType.Heater].ShowStatus();
            home[DeviceType.Light].ShowStatus();
            home[DeviceType.AC].ShowStatus();
            home[DeviceType.Heater].ShowStatus();

            LibraryManager libraryManager = new LibraryManager();

            // Adding books
            libraryManager.AddBook(new Book("The Alchemist", "Paulo Coelho", BookStatus.Available));
            libraryManager.AddBook(new Book("1984", "George Orwell", BookStatus.CheckedOut));
            libraryManager.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", BookStatus.Reserved));
            libraryManager.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", BookStatus.Available));
            libraryManager.AddBook(new Book("Moby Dick", "Herman Melville", BookStatus.CheckedOut));

            // Accessing a book by title
            Console.WriteLine("\nAccessing book by title '1984':");
            Book book = libraryManager["1984"];
            if (book != null)
                book.ShowDetails();

            // Changing status
            libraryManager.ChangeStatus("The Alchemist", BookStatus.CheckedOut);

            // Filtering books by status
            libraryManager.ShowBooksByStatus(BookStatus.Available);
            libraryManager.ShowBooksByStatus(BookStatus.CheckedOut);
            libraryManager.ShowBooksByStatus(BookStatus.Reserved);
            TaskList list = new TaskList();

            // Adding tasks
            list.AddTask(new UserTask("Buy groceries", "Milk, Bread, Eggs", TaskPriority.Medium));
            list.AddTask(new UserTask("Finish report", "Complete the annual financial report", TaskPriority.High));
            list.AddTask(new UserTask("Call plumber", "Fix kitchen sink leak", TaskPriority.Low));
            list.AddTask(new UserTask("Prepare presentation", "Slides for Monday meeting", TaskPriority.High));
            list.AddTask(new UserTask("Book flight", "Trip to Dubai", TaskPriority.Medium));

            // Show tasks by priority
            Console.WriteLine("\n🔍 High Priority Tasks:");
            foreach (var task in list[TaskPriority.High])
            {
                task.ShowDetails();
                Console.WriteLine();
            }

            // Mark a task as complete
            list.MarkComplete("Finish report");

            // Show all tasks
            list.ShowAll();




        }
    }
}
