namespace DataAoLookupHandler.Models;

public class IncarcerationArrestXref
{
    public virtual Arrest Arrest { get; set; }
}

public class Arrest
{
    public int? ArrestType { get; set; }
    public DateTime? ArrestArraignmentDate { get; set; }
    public int? ArrestArraignmentCourtId { get; set; }
    public string ArrestCourtDocket { get; set; }

}