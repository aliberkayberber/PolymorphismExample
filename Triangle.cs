namespace OOP
{
    public class DikUcgen: BaseGeometrikSekil
    {
        public override int AlanHesaplama()
        {
            System.Console.WriteLine("Dik üçgenin alanı hesaplanıyor...");
            return (Width * Height)/2; // base sınıfta alan hesapla metotu üçgen için uygun değildi ve ovverride yaptık.
        }
    }
}