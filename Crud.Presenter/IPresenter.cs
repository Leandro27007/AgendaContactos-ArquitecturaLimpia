using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Presenter
{
    public interface IPresenter<ContentType>
    {
        public ContentType Content { get;}
    }
}
