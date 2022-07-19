namespace TaskUserAdmin.Models
{
    public class Map
    {
        public int MapId { get; set; }
        public int UserId { get; set; }
        public int ModuleId { get; set; }
        public bool Read { get; set; }
        public bool Write { get; set; }

        public bool Create { get; set; }
        public bool Delete { get; set; }
        
    }
}
