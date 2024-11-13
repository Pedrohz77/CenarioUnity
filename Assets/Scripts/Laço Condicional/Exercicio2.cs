using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    public int powerup = 0;

    void Start()
    {
     if (powerup > 0) 
        {
            print("Powerup coletado");

        }
     else
        {
            print("Nenhum power up encontrado");
        }
    }

   
    void Update()
    {
        
    }
}
