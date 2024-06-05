using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePalette.Services
{
    public interface IAuthService
    {
        bool IsUserSignedIn();
    }
}
