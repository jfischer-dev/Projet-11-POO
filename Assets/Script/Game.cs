using UnityEngine;

public class Game : MonoBehaviour
{
    Arme arc;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // J'instancie une nouvelle arme

        Arme lance = new Arme("Lance rouillée");
        Debug.Log(lance.getNom());
        lance.setNom("Lance neuve");

        Arme dague = new Arme(10);

        Arme ak47 = new Arme(200, "AK47");

        Arme epee = new Arme();

        ArmeMelee epee2 = new ArmeMelee();

        epee2.setNom("Excalibur");

        Debug.Log("fini");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
