

namespace projecct_1
{
    class Program
    {
        
        private int[] muchsen = new int[79];

        
        private int n;

       
        public void read()
        {
          
            while (true)
            {
                Console.Write("masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 79)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 79 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

           
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                muchsen[i] = Int32.Parse(s1);
            }

        }
        public void display()
        {
           
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(muchsen[j]);
            }
            Console.WriteLine("");
        }
        public void insArray()
        {
            for (int i = 1; i < n; i++) 
            {
                
                for (int j = 0; j < n; j++)
                {
                    if (muchsen[j] > muchsen[j + 1]) 
                    {
                      
                        int temp;
                        temp = muchsen[j];
                        muchsen[j] = muchsen[j + 1];
                        muchsen[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //membuat object insarray class
            Program mylist = new Program();

            //pemanggilan fungsi untuk menerima elemen array 
            mylist.read();

            //pemanggilan fungsi untuk mengurutkan array
            mylist.insArray();

            //pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();

            //exit
            Console.WriteLine("\n\n Tekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }

}