using UnityEngine;

public class Joueur : MonoBehaviour
{
    private int id;
    private int vie;
    private int vitesseCourse;

    public void seDeplacer()
    {

    }

    public void attaquer()
    {

    }

    public void ramaser()
    {

    }

    public void prendreDegats()
    {
        //Debug.Log("ayeuh -" + degat);
    }

    public Joueur(int id, int vie, int vitesseCourse)
    {
        this.id = id;
        this.vie = vie;
        this.vitesseCourse = vitesseCourse;
    }

    public void equiper(Arme arme)
    {
        //armeEquiper = arme;
    }

}
