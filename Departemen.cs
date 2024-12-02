using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi2Junpro
{
    internal class Departemen
    {
        private int id_dep;
        private string nama_dep;

        public int ID_Dep 
        {
            get { return  id_dep; }
        }
        public string Nama_Dep 
        {
            get { return nama_dep; }
            set { nama_dep = value; }
        }
    }
}
