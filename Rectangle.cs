namespace OOP
{
    public class DikDörtgen : BaseGeometrikSekil
    {
        public override int AlanHesaplama()
        {
            System.Console.WriteLine("dikdörtgenin alanı hesaplanıyor...");
            return base.AlanHesaplama(); // base sınıfta alan hesabı kare için uygun
        }
    }
}