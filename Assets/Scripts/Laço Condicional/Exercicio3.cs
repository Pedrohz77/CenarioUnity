using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    //3 - (Desafio) Considere que o jogo tem um power-up que revive o
    //personagem caso ele morra.Caso o jogador morra e tiver
    //coletado o power-up ele volta a vida com 50% de sua vida total e
    //deve ser exibido a mensagem "Ainda n�o, vida atual XX". Caso ele
    //n�o tenha coletado o power-up exiba "Game Over".

    //[SerializeField] bool hp = false;
    //[SerializeField] int pocao = 1;
    [SerializeField] bool playerVivo; //true
    [SerializeField] bool powerUp; //true
    double vidaPlayer = 100;

    //int vidaPlayerIncial = 100;
    //double vidaplayerAtual = 100;
    void Start()
    {
        //if (hp = false && pocao > 0)
        //{
        //    print("revivido");
        //} 
        //else if (hp == true)
        //{
        //    print("Est� vivo");
        //}
        //else
        //{
        //    print("Morreu");
        //}

        if (playerVivo == false && powerUp == true)
        {
            vidaPlayer = vidaPlayer * 0.5;
            print("Ainda n�o, vida atual " + vidaPlayer);
        }
        else
        {
           print("Game Over");
        }

        //if(vidaplayerAtual <= 0 && powerUp == true)
        //{
        //    vidaplayerAtual = vidaPlayerIncial * 0.5;
        //    print("Ainda n�o, vida atual " + vidaPlayer);
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
