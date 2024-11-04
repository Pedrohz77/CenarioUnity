using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    //[SerializeField] bool hp = false;
    //[SerializeField] int pocao = 1;
    [SerializeField] bool playerVivo; //true
    [SerializeField] bool powerUp; //true
    double vidaPlayer = 100;

    int vidaPlayerIncial = 100;
    double vidaplayerAtual = 100;
    void Start()
    {
        //if (hp = false && pocao > 0)
        //{
        //    print("revivido");
        //} 
        //else if (hp == true)
        //{
        //    print("Está vivo");
        //}
        //else
        //{
        //    print("Morreu");
        //}

        if (playerVivo == false && powerUp == true)
        {
            vidaPlayer = vidaPlayer * 0.5;
            print("Ainda não, vida atual " + vidaPlayer);
        }
        else
        {
           print("Game Over");
        }

        //if(vidaplayerAtual <= 0 && powerUp == true)
        //{
        //    vidaplayerAtual = vidaPlayerIncial * 0.5;
        //    print("Ainda não, vida atual " + vidaPlayer);
        //}
        //else
        //{
        //    print("Game Over");
        //}

    }


    void Update()
    {
        
    }
}
