using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using Xamarin.Forms;

namespace EasySchedule.Data
{
    public class ScheduleDatabase
    {
        static object locker = new object();

        SQLiteConnection database = null;
        protected static ScheduleDatabase me;

        static ScheduleDatabase()
        {
            me = new ScheduleDatabase();
        }

        protected ScheduleDatabase()
        {
            database = DependencyService.Get<Data.ISQLite>().GetConnection();
            database.CreateTable<Models.Schedule>();
        }

        public static IEnumerable<Models.Schedule> GetItems()
        {
            lock (locker)
            {
                return (from i in me.database.Table<Models.Schedule>() select i).ToList();
            }
        }

        public static IEnumerable<Models.Schedule> GetItemsNotDone()
        {
            lock (locker)
            {
                return me.database.Query<Models.Schedule>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
            }
        }

        public static Models.Schedule GetItem(int id)
        {
            lock (locker)
            {
                return me.database.Table<Models.Schedule>().FirstOrDefault(x => x.Id == id);
            }
        }

        public static int SaveItem(Models.Schedule item)
        {
            lock (locker)
            {
                if (item.Id != 0)
                {
                    me.database.Update(item);
                    return item.Id;
                }
                else
                {
                    return me.database.Insert(item);
                }
            }
        }

        public static int DeleteItem(int id)
        {
            lock (locker)
            {
                return me.database.Delete<Models.Schedule>(id);
            }
        }
    }
}
