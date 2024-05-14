using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_project.Services
{
    public class Validation
    {
        public static bool isPhone(string phone)
        {
            foreach(var item in phone)
            {
                if(item<'0'||item>'9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
