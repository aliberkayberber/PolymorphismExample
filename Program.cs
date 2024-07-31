using OOP;

Kare kare = new Kare();
kare.Width = 10;
kare.Height = 5;
System.Console.WriteLine("Kare Alanı: " + kare.AlanHesaplama());

DikDörtgen dikDörtgen = new DikDörtgen();
dikDörtgen.Height = 10;
dikDörtgen.Width = 8;
System.Console.WriteLine("DikDörtgen alanı: " + dikDörtgen.AlanHesaplama());

DikUcgen dikUcgen = new DikUcgen();
dikUcgen.Height = 12;
dikUcgen.Width = 4;
System.Console.WriteLine("Dik Üçgen alanı: " + dikUcgen.AlanHesaplama());
