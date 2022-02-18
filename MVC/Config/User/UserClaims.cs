using System.Linq;
using System.Security.Claims;

public class UserClaims
{

    public string GetSpecificClaim(System.Security.Principal.IIdentity IIdentity, string claimType)
    {
        ClaimsIdentity claimsIdentity = (ClaimsIdentity)IIdentity;

        var claim = claimsIdentity.Claims.FirstOrDefault(x => x.Type == claimType);

        return (claim != null) ? claim.Value : string.Empty;
    }

}

