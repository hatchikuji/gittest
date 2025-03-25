namespace gittest;

public class Passager
{
    private string _nom;
    private string _prenom;
    private int _age;
    private List<Voiture> _voiture;

    public Passager(string nom, string prenom, int age)
    {
        _nom = nom;
        _prenom = prenom;
        _age = age;
        _voiture = new List<Voiture>();
    }

}