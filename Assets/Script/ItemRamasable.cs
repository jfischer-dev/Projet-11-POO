using UnityEngine;

public class ItemRamasable : Item, IRamasable
{
    public override void seFaireRamasser(IRamasser ramaseur)
    {
        base.seFaireRamasser(ramasseur);
        Debug.Log(" " + ramasseur + "me ramasse");
        ramasseur.equiper(this);
    }

    private void OnTriggerEnter(Collider other)
    {
        IRamasser ramasseur = other.GetComponent<IRamasser>();
        if (ramasseur != null) return;

        seFaireRamasser(ramasseur);
    }
}
