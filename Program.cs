using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// <summary>
// namespace
// </summary>
// <remarks> namespace digunakan untuk memisahkan file-file class sesuai kategorinya </remarks>
namespace PAW_Activity02
{

    // <summary>
    // main class
    // </summary>
    // <remarks>class program dapat menerima input user, menghitung nilai, dan menentukan kelulusan</remarks>
    class Program
    {
        // <summary>
        // main method
        // </summary>
        // <remarks>method ini memiliki type array, method ini berfungsi untuk menjalankan function input, compute dan display</remarks>
        // <param name="nilM">menerima input nilai Matematika dari user</param>
        // <param name="nilb">menerima input nilai Bahasa Inggris dari user</param>
        // <param name="rerata">menjumlahkan nilai rata-rata</param>
        // <param name="status">menyimpan nilai status lulus atau gagalnya user</param>
        // <value> rerata = (nilai matematika) + (nilai bahasa inggris) / 2 </value>
        static void Main(string[] args)
        {

            // <summary>
            // <remarks>function ini merupakan deklarasi dari sebuah variabel untuk menyimpan data user</remarks>
            // <param name="nilM">menerima input nilai Matematika dari user</param>
            // <param name="nilb">menerima input nilai Bahasa Inggris dari user</param>
            // <param name="rerata">menjumlahkan nilai rata-rata</param>
            // <typeparam> variabel nilM, nilB, rerata adalah double (angka)</typeparam>
            // </summary>
            double nilM, nilB, rerata;

            // <summary>
            // <remarks>funtion ini mendeklarasikan variabel status</remarks>
            // <param name="status">menyimpan nilai status lulus atau gagalnya user</param>
            // <typeparam> variabel status adalah String (huruf)</typeparam>
            // </summary>
            string status;

            // berfungsi untuk menampilkan tulisan ke layar dan mengampil input dari user
            Console.Write("Masukan Nilai Matematika = ");

            // <summary>
            // <remarks>input user akan disimpan pada variabel nilM</remarks>
            // </summary>
            nilM = Convert.ToDouble(Console.ReadLine());

            // berfungsi untuk menampilkan tulisan ke layar dan mengampil input dari user
            Console.Write("Masukan Nilai Bahasa Inggris = ");

            // <summary>
            // <remarks>input user akan disimpan pada variabel nilB</remarks>
            // </summary>
            nilB = Convert.ToDouble(Console.ReadLine());

            // <summary>
            // <remarks>function ini merupakan tempat pengoperasian dan hasil perhitungan akan disimpan pada variabel rerata</remarks>
            // </summary>
            rerata = (nilM + nilB) / 2;

            // <summary>
            // <remarks>function ini merupakan tempat menentukan apakah user lulus atau gagal dengan persyaratan nilai rata-rata lebih besar atau sama dengan 60 dan nilai matemarika lebih besar atau sama dengan 70</remarks>
            // </summary>
            if (rerata >= 60 && nilM >= 70)
                status = "lulus";
            else
                status = "gagal";

            // berfungsi untuk menampilkan tulisan ke layar
            Console.WriteLine("Status Peserta adalah {0}", status);
            Console.ReadLine();

        }
    }
}
