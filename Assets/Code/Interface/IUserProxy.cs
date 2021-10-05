using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUp
{
    public interface IUserProxy
    {
        event Action<float> OnAxisChange;
        void GetAxis();
    }
}
