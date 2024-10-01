using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace DepoProgramı
{
    class SQLiteClass
    {

        public SQLiteConnection baglanti()
        {
            SQLiteConnection baglan = new SQLiteConnection("Data Source=Data.db;Version=3;Read Only=False;");//stringi yazdık
            //SQLiteConnection baglan = new SQLiteConnection("Data Source=Data.db;Version=3;Read Only=False;Journal Mode=off;Pooling=true;Cache Size=10000;Page Size=4096;Synchronous=off");
            baglan.Open();
            return baglan;
        }

    }
}
