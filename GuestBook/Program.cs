using GuestBook;
using System.ComponentModel;
using System.Data.Common;


Methods.Welcome();


(List<string> locations, int missiles) = Methods.StrikeListContinue();

Methods.Totals(locations);

Methods.MissilesLaunched(missiles);




