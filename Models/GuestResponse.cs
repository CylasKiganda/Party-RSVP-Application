namespace PartyInvites.Models
{
    public class GuestResponse
    {
        public string Name { get; set; }
        public int Email { get; set; }
        public string Phone { get; set; }   
        public bool? WillAttend { get; set; }   
    }
}
