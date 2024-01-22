namespace cobaAPI
{
    public class Pegawai
    {
        public String nama { get;private set; }
        public String jabatan { get;private set; }

        public Pegawai(String nama, String jabatan)
        {
            this.nama = nama;
            this.jabatan = jabatan;

        }
    }
}