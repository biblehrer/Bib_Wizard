using UnityEngine;

public class Wizard_Easy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

        // Setze Variabeln für die Bewegung zu Beginn auf 0
        float xMovement = 0.0f;
        float yMovement = 0.0f;

        // Fange den Input ab 
        // W & S, sowie A & D heben sich auf wenn beide gedrückt sind
        // indem wir den selben Wert sowohl addiren als auch subtrahieren
        if (Input.GetKey("w"))
        {
            yMovement = yMovement + 0.02f;
        }
        if (Input.GetKey("s"))
        {
            yMovement = yMovement - 0.02f;  
        } 
        if (Input.GetKey("a"))
        {
            xMovement = xMovement - 0.02f;      
        }
        if (Input.GetKey("d"))
        {
            xMovement = xMovement + 0.02f; 
        }

        // Eine Diagonale Bewegung findet statt wenn x und y einen Wert haben, daher nicht null sind
        if (xMovement != 0 && yMovement != 0)
        {
            // Passe die Größe der Bewegung entsprechend des Satzes des Pythagoras an 
            xMovement = xMovement * 0.71f;
            yMovement = yMovement * 0.71f;
        }
            
        // Passe die Position des Characters an
        transform.position = transform.position + new Vector3(xMovement, yMovement,0);       
        
    }
}
