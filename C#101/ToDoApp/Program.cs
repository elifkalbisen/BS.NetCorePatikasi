using System;
using System.Collections.Generic;

// Enum kart büyüklükleri için
enum CardSize
{
    XS = 1,
    S,
    M,
    L,
    XL
}

// Line tipi enum
enum LineType
{
    TODO = 1,
    IN_PROGRESS,
    DONE
}

// Takım üyesi sınıfı
class TeamMember
{
    public int ID { get; set; }
    public string Name { get; set; }

    public TeamMember(int id, string name)
    {
        ID = id;
        Name = name;
    }
}

// Kart sınıfı
class Card
{
    public string Title { get; set; }
    public string Content { get; set; }
    public TeamMember AssignedTo { get; set; }
    public CardSize CardSize { get; set; }
    public LineType Line { get; set; }

    public Card(string title, string content, TeamMember assignedTo, CardSize cardSize, LineType line)
    {
        Title = title;
        Content = content;
        AssignedTo = assignedTo;
        CardSize = cardSize;
        Line = line;
    }
}

// Board sınıfı - üç kolon için kart listeleri tutar
class Board
{
    public List<Card> ToDo { get; set; }
    public List<Card> InProgress { get; set; }
    public List<Card> Done { get; set; }

    public Board()
    {
        ToDo = new List<Card>();
        InProgress = new List<Card>();
        Done = new List<Card>();
    }

    // Tüm kartları tek listede döner
    public List<Card> GetAllCards()
    {
        List<Card> all = new List<Card>();
        all.AddRange(ToDo);
        all.AddRange(InProgress);
        all.AddRange(Done);
        return all;
    }

    // Kart ekleme
    public void AddCard(Card card)
    {
        switch (card.Line)
        {
            case LineType.TODO:
                ToDo.Add(card);
                break;
            case LineType.IN_PROGRESS:
                InProgress.Add(card);
                break;
            case LineType.DONE:
                Done.Add(card);
                break;
        }
    }

    // Kart silme
    public void RemoveCard(Card card)
    {
        switch (card.Line)
        {
            case LineType.TODO:
                ToDo.Remove(card);
                break;
            case LineType.IN_PROGRESS:
                InProgress.Remove(card);
                break;
            case LineType.DONE:
                Done.Remove(card);
                break;
        }
    }
}

class Program
{
    static Board board = new Board();

    // Varsayılan takım üyeleri
    static List<TeamMember> team = new List<TeamMember>()
    {
        new TeamMember(1, "Ahmet"),
        new TeamMember(2, "Ayşe"),
        new TeamMember(3, "Mehmet"),
        new TeamMember(4, "Fatma")
    };

    static void Main()
    {
        // Başlangıçta 3 kart ekleyelim
        board.AddCard(new Card("Kart 1", "İçerik 1", team[0], CardSize.M, LineType.TODO));
        board.AddCard(new Card("Kart 2", "İçerik 2", team[1], CardSize.L, LineType.IN_PROGRESS));
        board.AddCard(new Card("Kart 3", "İçerik 3", team[2], CardSize.S, LineType.DONE));

        while (true)
        {
            Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            Console.WriteLine("(0) Çıkış");
            Console.Write("Seçiminiz: ");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    ListBoard();
                    break;
                case "2":
                    AddCard();
                    break;
                case "3":
                    RemoveCard();
                    break;
                case "4":
                    MoveCard();
                    break;
                case "0":
                    Console.WriteLine("Uygulamadan çıkılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }

    static void ListBoard()
    {
        Console.WriteLine("\nTODO Line");
        Console.WriteLine("************************");
        if (board.ToDo.Count == 0) Console.WriteLine("~ BOŞ ~");
        else
        {
            foreach (var card in board.ToDo)
            {
                PrintCard(card);
                Console.WriteLine("-");
            }
        }

        Console.WriteLine("\nIN PROGRESS Line");
        Console.WriteLine("************************");
        if (board.InProgress.Count == 0) Console.WriteLine("~ BOŞ ~");
        else
        {
            foreach (var card in board.InProgress)
            {
                PrintCard(card);
                Console.WriteLine("-");
            }
        }

        Console.WriteLine("\nDONE Line");
        Console.WriteLine("************************");
        if (board.Done.Count == 0) Console.WriteLine("~ BOŞ ~");
        else
        {
            foreach (var card in board.Done)
            {
                PrintCard(card);
                Console.WriteLine("-");
            }
        }
    }

    static void PrintCard(Card card)
    {
        Console.WriteLine($"Başlık      : {card.Title}");
        Console.WriteLine($"İçerik      : {card.Content}");
        Console.WriteLine($"Atanan Kişi : {card.AssignedTo.Name}");
        Console.WriteLine($"Büyüklük    : {card.CardSize}");
    }

    static void AddCard()
    {
        Console.Write("Başlık Giriniz: ");
        string title = Console.ReadLine();

        Console.Write("İçerik Giriniz: ");
        string content = Console.ReadLine();

        Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5): ");
        string sizeInput = Console.ReadLine();

        if (!int.TryParse(sizeInput, out int sizeInt) || sizeInt < 1 || sizeInt > 5)
        {
            Console.WriteLine("Hatalı büyüklük seçimi! İşlem iptal edildi.");
            return;
        }
        CardSize size = (CardSize)sizeInt;

        Console.WriteLine("Kişi Seçiniz:");
        foreach (var member in team)
        {
            Console.WriteLine($"{member.ID} - {member.Name}");
        }
        string personInput = Console.ReadLine();

        if (!int.TryParse(personInput, out int personId) || team.FindIndex(m => m.ID == personId) == -1)
        {
            Console.WriteLine("Hatalı girişler yaptınız! İşlem iptal edildi.");
            return;
        }

        TeamMember assigned = team.Find(m => m.ID == personId);

        // Yeni kart TODO line'da başlar
        Card newCard = new Card(title, content, assigned, size, LineType.TODO);
        board.AddCard(newCard);

        Console.WriteLine("Kart başarıyla eklendi.");
    }

    static void RemoveCard()
    {
        while (true)
        {
            Console.Write("Lütfen silmek istediğiniz kartın başlığını yazınız: ");
            string title = Console.ReadLine();

            List<Card> matchedCards = new List<Card>();
            foreach (var card in board.GetAllCards())
            {
                if (string.Equals(card.Title, title, StringComparison.OrdinalIgnoreCase))
                {
                    matchedCards.Add(card);
                }
            }

            if (matchedCards.Count == 0)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                string secim = Console.ReadLine();
                if (secim == "1")
                    return;
                else if (secim == "2")
                    continue;
                else
                {
                    Console.WriteLine("Geçersiz seçim!");
                    return;
                }
            }

            foreach (var card in matchedCards)
            {
                board.RemoveCard(card);
                Console.WriteLine($"'{card.Title}' başlıklı kart silindi.");
            }
            break;
        }
    }

    static void MoveCard()
    {
        while (true)
        {
            Console.Write("Lütfen taşımak istediğiniz kartın başlığını yazınız: ");
            string title = Console.ReadLine();

            Card foundCard = null;
            foreach (var c in board.GetAllCards())
            {
                if (string.Equals(c.Title, title, StringComparison.OrdinalIgnoreCase))
                {
                    foundCard = c;
                    break;
                }
            }

            if (foundCard == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                string secim = Console.ReadLine();
                if (secim == "1")
                    return;
                else if (secim == "2")
                    continue;
                else
                {
                    Console.WriteLine("Geçersiz seçim!");
                    return;
                }
            }

            Console.WriteLine("\nBulunan Kart Bilgileri:");
            Console.WriteLine("**************************************");
            Console.WriteLine($"Başlık      : {foundCard.Title}");
            Console.WriteLine($"İçerik      : {foundCard.Content}");
            Console.WriteLine($"Atanan Kişi : {foundCard.AssignedTo.Name}");
            Console.WriteLine($"Büyüklük    : {foundCard.CardSize}");
            Console.WriteLine($"Line        : {foundCard.Line}");

            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
            Console.WriteLine("(1) TODO");
            Console.WriteLine("(2) IN PROGRESS");
            Console.WriteLine("(3) DONE");

            string lineSecim = Console.ReadLine();

            if (!int.TryParse(lineSecim, out int lineNum) || lineNum < 1 || lineNum > 3)
            {
                Console.WriteLine("Hatalı bir seçim yaptınız!");
                return;
            }

            board.RemoveCard(foundCard);
            foundCard.Line = (LineType)lineNum;
            board.AddCard(foundCard);

            Console.WriteLine("Kart başarıyla taşındı.");
            ListBoard();
            break;
        }
    }
}
