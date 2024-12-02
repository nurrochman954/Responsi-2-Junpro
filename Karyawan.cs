using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi2Junpro
{
    internal class Karyawan
    {
        private string id_karyawan;
        private string nama;
        private int id_dep;
        private string nama_dep;

        public string ID_Karyawan
        {
            get { return id_karyawan; }
            set { id_karyawan = value; }
        }
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        public int ID_Dep
        {
            get { return id_dep; }
        }
        public string Nama_Dep
        {
            get { return nama_dep; }
            set { nama_dep = value; }
        }
    }
}
