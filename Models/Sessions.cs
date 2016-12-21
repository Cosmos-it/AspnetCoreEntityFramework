namespace ConferenceBarrel.Models 
{
    public class Session
    {
        public int Id{ get; set;}
        public string Tile{ get; set;}
        public int ConferenceId { get; set;}
        public Conference Conference {get; set;}
        
    }
}