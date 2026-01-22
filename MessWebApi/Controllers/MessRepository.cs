using MessWebApi.Models;

namespace MessWebApi.Controllers
{
    public static class MessRepository
    {
        public static List<Student> Students { get; set; } = new List<Student>()
            {
                new Student
                {
                Id = 1,
                StudentName = "Tushar Mondal",
                Email = "tushar12@gmail.com",
                Address = "Subhash Nagar, Dehradun"
                },
                new Student
                {
                Id = 2,
                StudentName = "HEYY SECOND STUDENT",
                Email = "tushar12@gmail.com",
                Address = "Subhash Nagar, Dehradun"
                }
            };
    }
}
