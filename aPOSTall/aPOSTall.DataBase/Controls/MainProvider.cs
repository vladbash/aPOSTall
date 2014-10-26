using aPOSTall.DataBase.Bases;

namespace aPOSTall.DataBase.Controls
{
    sealed class MainProvider:IProvider<MainDB>
    {
        private MainDB _db = new MainDB();
        public MainDB Db
        {
            get { return _db; }
            set { _db = value; }
        }
    }
}
