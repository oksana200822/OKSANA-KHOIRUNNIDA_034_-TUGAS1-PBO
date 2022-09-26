using System;
 
namespace inheritance
{
    class siswa
    {
          private string nama;
          private string jurusan;
 
          public void pertama(string name)
            {
              this.nama = name;
            }
          public void kedua(string jurus)
            {
              this.jurusan = jurus;
            }
          public string getnama()
            {
              return (nama);
            }
          public string getjurusan()
            {
              return (jurusan);
            }
        }
      class satu : siswa
      {
          private double induk;
 
          public void setnim(double nim)
            {
             induk= nim;
            }
          public double getnim()
            {
              return (induk);
            }
          public void tampil()
            {
              Console.WriteLine("Nim     = "+getnim());
              Console.WriteLine("Nama    = "+getnama());
              Console.WriteLine("Jurusan = "+getjurusan());
            }
        }
    class Program
        {
        public static void Main(string[] args)
        {
            satu a = new satu();
                    a.pertama("Tsania Zuyyina Asara");
                    a.kedua("S1 SISTEM INFORMSI");
                    a.setnim(21051214064);
                    a.tampil();
                    Console.WriteLine();
                Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
     }
}
