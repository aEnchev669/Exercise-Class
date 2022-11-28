using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models.Interfaces
{
    public interface ILieutenantGeneral : IPrivate
    {
        List<IPrivate> Privates { get; }
    }
}
