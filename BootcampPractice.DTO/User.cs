namespace BootcampPractice.DTO
{
    //El DTO tiene cosas que puedes exponer. No puedes poner un password, por ejemplo.
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

    }
}
