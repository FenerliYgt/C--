internal class Program
{
    public static void Main(string[] args)
    {
        string Parola = "Parolayı Giriniz:";
        Console.Write(Parola);
        string Parola1;
        Parola1 = Console.ReadLine();

       
        if (Parola1.Length <= 15)
        {
            Console.WriteLine("Şifre Uygun Değil!!!\n");
            Console.WriteLine("Şifreyi Değiştirin!!!\n");
            
            

        }
        else
        {
            Console.WriteLine("Şifre Uygun.\n");

            string Ad = "Adınızı Giriniz:";
            Console.Write(Ad);
            string Adım;
            Adım = Console.ReadLine();
            Console.Write("\n");

            string Soyad = "Soyadınızı Giriniz:";
            Console.Write(Soyad);
            string Soyadım;
            Soyadım = Console.ReadLine();
            Console.Write("\n");


            string Not = "1. Sınav Notunu Giriniz:";
            Console.Write(Not);
            int Not1;
            Not1 = int.Parse(Console.ReadLine());
            Console.Write("\n");

            string NotA = "2. Sınav Notunu Giriniz:";
            Console.Write(NotA);
            int Not2;
            Not2 = int.Parse(Console.ReadLine());
            Console.Write("\n");

            string NotB = "3. Sınav Notunu Giriniz:";
            Console.Write(NotB);
            int Not3;
            Not3 = int.Parse(Console.ReadLine());
            Console.Write("\n");


            string NotC = "4. Sınav Notunu Giriniz:";
            Console.Write(NotC);
            int Not4;
            Not4 = int.Parse(Console.ReadLine());
            Console.Write("\n");

            string Ortalama = "Notların Ortalama Puanı=";
            Console.Write(Ortalama+Average(Not1,Not2,Not3,Not4));
            Console.Write("\n");

            if (Average(Not1,Not2,Not3,Not4) >=50 )
            {
                Console.WriteLine("Başarılı.");

            }
            else
            {
                Console.WriteLine("Başarısız!!!");
            }

           



        }
    }
    public static double Average(int a, int b, int c, int d)
    {
        double result = (a + b + c + d) / 4.0;
        return result;
    }

}