namespace API.Entities
{
    public class KomentarzForum
    {
        public required int IdUzytkownika { get; set; }
        public required int IdPosta { get; set; }
        public DateTime Data { get; set; }
    }
}