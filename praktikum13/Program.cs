using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Berapa Data = ");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] data = new int[100];
            string[] nim = new string[100];
            string[] nama = new string[100];
            string[] gender = new string[100];
            int[] tahun = new int[100];
            string[] prodi = new string[100];
            string[] kelas = new string[100];
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine($"data ke-{i + 1}");
                Console.Write("NIM               : ");
                nim[i] = Console.ReadLine();
                Console.Write("NAMA              : ");
                nama[i] = Console.ReadLine();
                Console.Write("JENIS KELAMIN     : ");
                gender[i] = Console.ReadLine();
                Console.Write("TAHUN MASUK       : ");
                tahun[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("PROGRAM STUDI     : ");
                prodi[i] = Console.ReadLine();
                Console.Write("KELAS             : ");
                kelas[i] = Console.ReadLine();
                Console.WriteLine();
            }
            Console.Write("PRINT HASIL ? (y/n) ... ");
            string print = Console.ReadLine();
            if (print == "y")
            {
                Console.Clear();
                Console.SetCursorPosition(1, 0);
                Console.Write("NO");
                Console.SetCursorPosition(6, 0);
                Console.Write("NIM");
                Console.SetCursorPosition(15, 0);
                Console.Write("NAMA");
                Console.SetCursorPosition(35, 0);
                Console.Write("JENIS KELAMIN");
                Console.SetCursorPosition(60, 0);
                Console.Write("TAHUN MASUK");
                Console.SetCursorPosition(80, 0);
                Console.Write("PROGRAM STUDI");
                Console.SetCursorPosition(100, 0);
                Console.Write("KELAS");
                for (int i = 0; i < input; i++)
                {
                    Console.SetCursorPosition(1, (i + 2));
                    Console.Write($"{i + 1}");
                    Console.SetCursorPosition(6, (i + 2));
                    Console.Write(nim[i]);
                    Console.SetCursorPosition(15, (i + 2));
                    Console.Write(nama[i].ToUpper());
                    Console.SetCursorPosition(35, (i + 2));
                    Console.Write(gender[i].ToUpper());
                    Console.SetCursorPosition(60, (i + 2));
                    Console.Write(tahun[i]);
                    Console.SetCursorPosition(80, (i + 2));
                    Console.Write(prodi[i].ToUpper());
                    Console.SetCursorPosition(100, (i + 2));
                    Console.Write(kelas[i].ToUpper());
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Tambah Data? (y/n) ... ");
                string tambah = Console.ReadLine();
                if (tambah == "y")
                {
                    Console.WriteLine();
                    for (int i = 0; i < input; i++)
                    {
                        Console.Write("Berapa Data = ");
                        input = Convert.ToInt32(Console.ReadLine());
                        for (i = 0; i < input; i++)
                        {
                            Console.WriteLine($"data ke-{i + 1}");
                            Console.Write("NIM               : ");
                            nim[i] = Console.ReadLine();
                            if (nim[i] == nim[i])
                            {
                                Console.WriteLine("NIM SUDAH ADA, MASUKKAN NIM LAIN !!!");
                            }
                            Console.Write("NAMA              : ");
                            nama[i] = Console.ReadLine();
                            Console.Write("JENIS KELAMIN     : ");
                            gender[i] = Console.ReadLine();
                            Console.Write("TAHUN MASUK       : ");
                            tahun[i] = Convert.ToInt32(Console.ReadLine());
                            Console.Write("PROGRAM STUDI     : ");
                            prodi[i] = Console.ReadLine();
                            Console.Write("KELAS             : ");
                            kelas[i] = Console.ReadLine();
                            Console.WriteLine();
                        }
                        Console.Write("PRINT HASIL ? (y/n) ... ");
                        print = Console.ReadLine();
                        if (print == "y")
                        {
                            Console.Clear();
                            Console.SetCursorPosition(1, 0);
                            Console.Write("NO");
                            Console.SetCursorPosition(6, 0);
                            Console.Write("NIM");
                            Console.SetCursorPosition(15, 0);
                            Console.Write("NAMA");
                            Console.SetCursorPosition(35, 0);
                            Console.Write("JENIS KELAMIN");
                            Console.SetCursorPosition(60, 0);
                            Console.Write("TAHUN MASUK");
                            Console.SetCursorPosition(80, 0);
                            Console.Write("PROGRAM STUDI");
                            Console.SetCursorPosition(100, 0);
                            Console.Write("KELAS");
                            for (i = 0; i < input; i++)
                            {
                                Console.SetCursorPosition(1, (i + 2));
                                Console.Write($"{i + 1}");
                                Console.SetCursorPosition(6, (i + 2));
                                Console.Write(nim[i]);
                                Console.SetCursorPosition(15, (i + 2));
                                Console.Write(nama[i].ToUpper());
                                Console.SetCursorPosition(35, (i + 2));
                                Console.Write(gender[i].ToUpper());
                                Console.SetCursorPosition(60, (i + 2));
                                Console.Write(tahun[i]);
                                Console.SetCursorPosition(80, (i + 2));
                                Console.Write(prodi[i].ToUpper());
                                Console.SetCursorPosition(100, (i + 2));
                                Console.Write(kelas[i].ToUpper());
                            }
                        }
                    }
                }
                else if (tambah == "n")
                {
                    System.Environment.Exit(1);
                }
                    }
            else if (print == "n")
                    {
                        System.Environment.Exit(1);
                    }
                    Console.ReadKey();
                }
            }
        }
    

