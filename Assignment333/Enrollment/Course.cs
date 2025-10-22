using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Enum for course level
public enum Level
{
    Beginner,
    Intermediate,
    Advanced
}

namespace Assignment333.Enrollment
{
    public class Course
    {
        public string Name { get; set; }
        public string Instructor { get; set; }
        public Level CourseLevel { get; set; }

        public Course(string name, string instructor, Level level)
        {
            Name = name;
            Instructor = instructor;
            CourseLevel = level;
        }
        public virtual void PrintDetails()
        {
            Console.WriteLine($"Course: {Name}, Instructor: {Instructor}, Level: {CourseLevel}");
        }

    }

    // Derived class: VideoCourse
    public class VideoCourse : Course
    {
        public double Duration { get; set; } // in hours

        public VideoCourse(string name, string instructor, Level level, double duration)
            : base(name, instructor, level)
        {
            Duration = duration;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Duration: {Duration} hours");
        }
    }

    // Derived class: LiveSession
    public class LiveSession : Course
    {
        public DateTime Schedule { get; set; }

        public LiveSession(string name, string instructor, Level level, DateTime schedule)
            : base(name, instructor, level)
        {
            Schedule = schedule;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Scheduled on: {Schedule}");
        }
    }
    // CourseCatalog with indexer
    public class CourseCatalog
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        // Indexer to get courses by level
        public List<Course> this[Level level]
        {
            get
            {
                return courses.FindAll(c => c.CourseLevel == level);
            }
        }
    }

}
