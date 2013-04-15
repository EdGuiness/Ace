using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad
{
    public interface ISPViolated
    {
    void DoThis();
    void DoThat();
    void GoHere();
    void GoThere();
    bool MyFavoriteTogglyThing { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }

    }
}
