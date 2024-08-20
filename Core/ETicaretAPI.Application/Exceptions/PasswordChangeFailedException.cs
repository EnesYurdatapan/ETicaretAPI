using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Exceptions
{
    public class PasswordChangeFailedException:Exception
    {
        public PasswordChangeFailedException():base("Şifre güncellenirken bir sorun oluştu")
        {
            
        }
    }
}
