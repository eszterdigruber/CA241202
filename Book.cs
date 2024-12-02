namespace CA241202;

internal class Book
{
    private long isbn;
    private List<Author> szerzok = [];
    private string cim;
    private int kiadaseve;
    private string nyelv;
    private int keszlet;
    private int ar;

    public long Isbn
    {
        get => isbn; 
        set
        {
            if (value.ToString().Length != 10) throw new Exception("Nem adott meg megfelelő értéket!");
            isbn = value;
        }
    }
    internal List<Author> Szerzok { get => szerzok; set => szerzok = value; }
    public string Cim
    {
        get => cim; 
        set
        {
            if (value.Length < 3 || value.Length > 64) throw new Exception("Nem megfelelő hosszuságú karakter adott meg!");
            cim = value;
        }
    }
    public int Kiadaseve
    {
        get => kiadaseve; 
        set
        {
            if (value < 2007 || value > DateTime.Now.Year) throw new Exception("Nem megfelelő évet adott meg!");
            kiadaseve = value;
        }
    }
    public string Nyelv
    {
        get => nyelv; 
        set
        {
            if (value != "angol" && value != "német" && value != "magyar") throw new Exception("Nem megfelelő nyelvet adott meg!");
            nyelv = value;
        }
    }
    public int Keszlet
    {
        get => keszlet; 
        set
        {
            if (value < 0) throw new Exception("Nem adott meg megfelelő értéket!");
            keszlet = value;
        }
    }
    public int Ar
    {
        get => ar; 
        set
        {
            if (value < 1000 || value > 10000 || value % 100 != 0) throw new Exception("Nem adott meg megfelelő értéket!");
            ar = value;
        }
    }
    public Book(long isbn, string cim, int kiadaseve, string nyelv, int keszlet, int ar)
    {
        this.isbn = isbn;
        this.cim = cim;
        this.kiadaseve = kiadaseve;
        this.nyelv = nyelv;
        this.keszlet = keszlet;
        this.ar = ar;
    }
}
