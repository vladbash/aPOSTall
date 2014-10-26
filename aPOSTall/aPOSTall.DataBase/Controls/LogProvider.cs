using System;
using aPOSTall.DataBase.Bases;

namespace aPOSTall.DataBase.Controls
{
    sealed class LogProvider:IProvider<LogDB>
    {
        private LogDB _db = new LogDB();
        public LogDB Db
        {
            get { return _db; }
            set { _db = value; }
        }

        public void AddValue(DateTime date,string evenT)
        {
            Db.Log.AddLogRow(date, evenT);
        }
    }
}
