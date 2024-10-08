namespace MyPortfolio.DAL.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsMessageRead { get; set; }

    }
}
