public interface IRamasable
{
    public virtual void seFaireRamasser(IRamasser ramasseur);

}

public interface IRamasser
{
    public void equiper(Arme arme)
    {
        armeEquiper = arme;
    }
    public void ramasser(IRamasable ramasseur);
}