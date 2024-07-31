namespace OOP
{
    public class Kare : BaseGeometrikSekil
    {
        public override int AlanHesaplama()
        {
            System.Console.WriteLine("Karenin alanı hesaplanıyor...");
            return base.AlanHesaplama(); // base sınıfta alan hesabı kare için uygun
        }
    }
}