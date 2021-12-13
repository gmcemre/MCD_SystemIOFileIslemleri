using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MCD_SystemIOFileIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //*********** Var olan Dosyaya text ekleme*************
            //bool kontrol = File.Exists("c:\\NetworkAkademi\\Merhaba.txt");
            //if (kontrol)
            //{
            //    Console.WriteLine("Belirtmiş olduğunuz dosya sistem içerisinde bulunmaktadır.");
            //}
            //else
            //{
            //    FileCreate("c:\\NetworkAkademi\\Merhaba.txt");
            //}

            FileAppenedText("c:\\NetworkAkademi\\Merhaba.txt", "Merhaba TXT");
            string metinDegeri = FileReadAllText("c:\\NetworkAkademi\\Merhaba.txt");
            Console.WriteLine(metinDegeri);

            Directory.CreateDirectory("c:\\NetworkAkademi2");
            //FileCopy("c:\\NetworkAkademi\\Merhaba.Txt", "c:\\NetworkAkademi2\\Merhaba.Txt");

            //FileMove("c:\\NetworkAkademi\\Merhaba2.Txt", "c:\\NetworkAkademi2\\Merhaba2.Txt");


            FileDelete("c:\\NetworkAkademi2\\Merhaba2.txt");
            Console.ReadLine();
        }

        static void FileCreate(string path)
        {
            FileStream Fs = File.Create(path);
            Fs.Close();
        }

        static void FileDelete(string path)
        {
            File.Delete(path);
        }

        static void FileMove(string kaynak, string hedef)
        {
            File.Move(kaynak, hedef);
        }

        static void FileCopy(string kaynak, string hedef)
        {
            File.Copy(kaynak, hedef);
        }

        static void FileAppenedText(string path, string deger)
        {
            File.AppendAllText(path, deger);
        }

        static string FileReadAllText(string path)
        {
            string metinDegeri = File.ReadAllText(path);
            return metinDegeri;
        }

    }
}
