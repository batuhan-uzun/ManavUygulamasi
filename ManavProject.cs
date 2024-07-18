Console.WriteLine("Rüya Manavina Hos Geldiniz!\nElma = 2 TL\nArmut = 3 TL\nÇilek = 2 TL\nMuz = 3 TL\nDiger bütün meyveler = 4 TL\n");
Console.WriteLine("Hangi meyveyi satin almak istersiniz? (Elma/Armut/Çilek/Muz/Diger): ");
string secilenMeyve = Console.ReadLine();

//Bu tarz çoklu seçenek olan uygulamalar için Switch-Case yapısı çok daha uygun olacaktır.
switch (secilenMeyve.ToLower())
{
    case "elma":
    case "çilek":
        Console.WriteLine("Seçtiginiz meyvenin fiyati: 2 TL");
        break;
    case "armut":
    case "muz":
        Console.WriteLine("Seçtiginiz meyvenin fiyati: 3 TL");
        break;
    default:
        Console.WriteLine("Seçtiginiz meyvenin fiyati: 4 TL");
        break;
}

//If-Else yapısının kullanıldığı kod bloğu
if (secilenMeyve.ToLower() == "elma" || secilenMeyve.ToLower() == "çilek") Console.WriteLine("Seçtiginiz meyvenin fiyati: 2 TL");
else if (secilenMeyve.ToLower() == "armut" || secilenMeyve.ToLower() == "muz") Console.WriteLine("Seçtiginiz meyvenin fiyati: 3 TL");
else Console.WriteLine("Seçtiginiz meyvenin fiyati: 4 TL");