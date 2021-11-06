using projectBusiness;
using projectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjWEBMVC.Models
{
    public class Writers
    {
        BLLWiter bll = new BLLWiter();

        public List<Write> GetList() {
           return bll.GetList();
        }

        public Write AddWrite(Write write) {
            return bll.AddWrite(write);
        }

        public Write RemoveWrite(Write write) {
            return bll.RomoveWrite(write);
        }

        public Write GetWrite(int id) {
            return bll.GetWrite(id);
        }

        public Write Update(Write write) {
            return bll.UpdateWrite(write);
        }
    }
}