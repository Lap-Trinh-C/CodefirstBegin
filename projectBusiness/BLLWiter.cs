using projectAccessData;
using projectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectBusiness
{
    public class BLLWiter
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public Write AddWrite(Write write) {
            db.Writes.Add(write);
            db.SaveChanges();
            return write;
        }

        public Write UpdateWrite(Write write) {
            var w = db.Writes.Find(write.Id);
            w.Name = write.Name;
            db.SaveChanges();
            return w;
        }

        public Write RomoveWrite(Write write) {
            db.Writes.Remove(write);
            db.SaveChanges();
            return write;
        }

        public List<Write> GetList() {
            return db.Writes.ToList();
        }

        public Write GetWrite(int id) {
            return db.Writes.Find(id);
        }

    }
}
