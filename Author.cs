namespace CA241202;

internal class Author
{
    private string keresztnev;
    private string vezeteknev;
    private Guid guid;

    public string Keresztnev
    {
        get => keresztnev; 
        set
        {
            if (value.Length < 3 || value.Length > 32) throw new Exception("Nem adott meg megfelelő hosszú karaktert!");
            keresztnev = value;
        }
    }
    public string Vezeteknev
    {
        get => vezeteknev; 
        set
        {
            if (value.Length < 3 || value.Length > 32) throw new Exception("Nem adott meg megfelelő hosszú karaktert!");
            vezeteknev = value;
        }
    }
    public Guid Guid { get => guid; set => guid = value; }

    public Author(string nev)
    {
        Guid = Guid.NewGuid();
        string[] nevek = nev.Split(' ');
        keresztnev = nevek[0];
        vezeteknev = nevek[1];
    }
}
