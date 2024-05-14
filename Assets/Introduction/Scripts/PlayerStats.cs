using UnityEngine;

public class PlayerStats
{
    public float movementSpeed = 1.5f;
    public float castingTime  = 1.5f;
    public int maxHP = 100;
    public float maxMana = 50;
    public float manaRegeneration = 5;

    public int level = 1;

    public int xp = 0;

    public void LevelUp() 
    {
        level++;
        castingTime = castingTime - 0.1f;
        movementSpeed += 0.1f; 
        maxHP += 5;
        maxMana += 2;
        manaRegeneration += 0.2f;
    }

    public void GainXp(int newxp) {
        xp  += newxp;
        
        // Level Up
        if (xp >= level * 3)
        {
            xp -= level * 3;
            LevelUp();
        }
    }


}
