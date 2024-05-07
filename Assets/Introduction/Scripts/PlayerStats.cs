public class PlayerStats
{
    public float movementSpeed = 1.5f;
    public float castingTime  = 1.5f;
    public int maxHP = 100;
    public float maxMana = 50;
    public float manaRegeneration = 5;

    public int level = 1;

    public void LevelUp() 
    {
        castingTime = castingTime - 0.1f;
    }

    public void GainXp(int xp) {}


}
