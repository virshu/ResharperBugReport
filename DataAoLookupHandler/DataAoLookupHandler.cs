namespace DataAoLookupHandler;

public static class DataAoLookupHandler
{
    public static readonly Dictionary<int, DataAoLookupHandlerBase> Handlers = new()
    {
        {
            5,
            new DataAoLookupHandlerBase
            {
                InitializeQueryableFunc = context => context.IncarcerationArrestXref.Select(s => new DataAoLookupResult
                {
                     RefDetails="[TYPE]: "+ context.Lookup.FirstOrDefault(w=>w.LookupIndex==s.Arrest.ArrestType && w.LookupInterfaceId==LookupConstants.ARRTYPE)!.LookupDescription
                            + "[DOCKET#]: " + s.Arrest.ArrestCourtDocket + s.Arrest.ArrestArraignmentDate + " [COURT]: "
                            +context.Agency.FirstOrDefault(w=>w.AgencyId==s.Arrest.ArrestArraignmentCourtId)!.AgencyName
                })
            }
        }
    };
}