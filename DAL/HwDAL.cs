using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class HwDAL
    {

        //מחזיר את כל ש"ב
        public List<HwToStydyClassOnDate> GetHW()
        {
            using (HomeWorkProjectEntities2 db = new HomeWorkProjectEntities2())
            {
                return db.HwToStydyClassOnDate.ToList();
            }
        }
        //מוסיף ש"ב
        public int AddHw(HwToStydyClassOnDate hw)
        {
            try
            {
                using (HomeWorkProjectEntities2 db = new HomeWorkProjectEntities2())
                {
                    db.HwToStydyClassOnDate.Add(hw);
                    db.SaveChanges();
                    return 1;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

    }
}
