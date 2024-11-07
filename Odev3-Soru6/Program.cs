// See https://aka.ms/new-console-template for more information
int islem;
int sayi1;
int sayi2;
double sayi3;
double sayi4;
double sonuc;
string exit = "devam";
bool exit1 = false;
do
{
    Console.WriteLine("Hesap makinesi");
    Console.WriteLine("Yapmak istediğiniz işlemin numarasını giriniz");
    Console.WriteLine("------------");
    Console.WriteLine("-1:Toplama  ");
    Console.WriteLine("-2:Çıkarma  ");
    Console.WriteLine("-3:Çarpma   ");
    Console.WriteLine("-4:Bölme    ");
    Console.WriteLine("------------");
    Console.Write("İşlem: ");
    islem = int.Parse(Console.ReadLine());
    
    
    if (islem == 1)
    {
        Console.WriteLine("İşlem yapmak istediğiniz 2 sayıyı giriniz");
        Console.Write("Sayı1: ");
        sayi1 = int.Parse(Console.ReadLine());
        Console.Write("Sayı2: ");
        sayi2 = int.Parse(Console.ReadLine());
        sonuc = sayi1 + sayi2;
        Console.WriteLine("Sonuç:" + sonuc);

    }
    else if (islem == 2)
    {
        Console.WriteLine("İşlem yapmak istediğiniz 2 sayıyı giriniz");
        Console.Write("Sayı1: ");
        sayi1 = int.Parse(Console.ReadLine());
        Console.Write("Sayı2: ");
        sayi2 = int.Parse(Console.ReadLine());
        sonuc = sayi1 - sayi2;
        Console.WriteLine("Sonuç:" + sonuc);
    }
    else if (islem == 3)
    {
        Console.WriteLine("İşlem yapmak istediğiniz 2 sayıyı giriniz");
        Console.Write("Sayı1: ");
        sayi1 = int.Parse(Console.ReadLine());
        Console.Write("Sayı2: ");
        sayi2 = int.Parse(Console.ReadLine());
        sonuc = sayi1* sayi2;
        Console.WriteLine("Sonuç:" + sonuc);
    }
    else if (islem == 4)
    {
        Console.WriteLine("İşlem yapmak istediğiniz 2 sayıyı giriniz");
        Console.Write("Sayı1: ");
        sayi3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Sayı2: ");
        sayi4 = Convert.ToDouble(Console.ReadLine());
        if (sayi4 == 0)
        { 
            Console.WriteLine("Payda 0 olamaz");

        }
        else
        {          
            sonuc = sayi3 / sayi4;
            Console.WriteLine("Sonuç:" + sonuc);
        }
    }
    else
    {
        Console.WriteLine("Geçersiz bir işlem numarası girdiniz");
    }
    
    Console.WriteLine("Çıkış Yapmak için çıkış yazınız,Devam etmek için Enter'a basınız.");
    exit = Console.ReadLine();
    exit = exit.ToLower();
    if(exit == "çıkış")
    {
        exit1 = true;
    }
    
    
    
}while (exit1 == false) ;