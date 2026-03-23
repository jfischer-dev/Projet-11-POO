public class ArmeMelee : Arme
{
    public override int Attaquer()
    {
        print("Attaque de mêlée !");
        return getDegat();
    }
}