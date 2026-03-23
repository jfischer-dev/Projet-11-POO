public class Arme : ItemRamasable, IDamager
{
    public void faireDegat(IDamageable cible)
    {

    }

    private string nom;
    private int degat;

    public void setNom(string valeur)
    {
        nom = valeur;
    }

    public string getNom()
    {
        return nom;
    }

    public int getDegat()
    {
        return degat;
    }
    public virtual int Attaquer()
    {
        return degat;
    }

    public Arme()
    {
        degat = 1;
        nom = "Dague rouillée";
    }

    public Arme(int degatBase)
    {
        degat = degatBase;
        nom = "Dague rouillée";
    }
    public Arme(string nomDeBase)
    {
        degat = 1;
        nom = nomDeBase;
    }
    public Arme(int degatBase, string nomDeBase)
    {
        degat = degatBase;
        nom = nomDeBase;
    }


    // Le fonctionnement de ma classe
    // Que peuc faire une arme ?



}