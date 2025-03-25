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

    public string Nom
    {
        get { return _nom; }
    }

    public string Prenom
    {
        get { return _prenom; }
    }

    public int Age
    {
        get { return _age; }
    }

    public int NbVoiture()
    {
        return _voiture.Count;
    }

    public void AjouterVoiture(Voiture voiture)
    {
        _voiture.Add(voiture);
    }

    public void SupprimerVoiture(Voiture voiture)
    {
        _voiture.Remove(voiture);
    }

    public void AfficherVoiture()
    {
        foreach (Voiture voiture in _voiture)
        {
            Console.WriteLine(voiture.marque + " " + voiture.modele + " " + " " + voiture.couleur + " " + voiture.annee);
        }
    }
}