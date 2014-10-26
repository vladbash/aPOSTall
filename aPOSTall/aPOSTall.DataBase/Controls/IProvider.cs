using System;

namespace aPOSTall.DataBase.Controls
{
    interface IProvider<T>
    {
        T Db { get; set; }
    }
}
