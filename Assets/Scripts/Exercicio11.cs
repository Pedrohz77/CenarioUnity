using UnityEngine;
using UnityEngine.InputSystem;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;
using static UnityEditor.Progress;

public class Exercicio11 : MonoBehaviour
{
    //11. (Di�logos) Implemente um sistema de di�logos onde o jogador
    //pode interagir com um NPC(personagem n�o jog�vel), e o NPC
    //responde com diferentes frases dependendo do estado do jogo.
    //Use switch case para definir as respostas baseadas no estado do
    //jogador.

    //[SerializeField] string[] Resposta = { "NPC: Ol�, a chuva foi forte neh!!", "NPC: Ol�, o dia est� seco" };
    //[SerializeField] bool molhado;
    [SerializeField] int estado;
    void Start()
    {

    }


    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    switch (true)
        //    {

        //        case (true):
        //            {
        //             if (molhado)
        //                {
        //                    print("Ol�");

        //                    print(Resposta[0]);
        //                }
        //             else
        //                {
        //                    print("Ol�");

        //                    print(Resposta[1]);
        //                }          
        //            }
        //            break;
        //     }
        //}

        switch (estado)
        {
            case 1:
                print("Da para fazer com ternario?");
                break;

            case 2:
                print("Sextooou!");
                break;

            case 3:
                print("Cad� o Thiago?");
                break;

            case 4:
                print("Cad� a Alana?");
                break;

            case 5:
                print("Jucelino, cad� meu aumento?");
                break;

            default:
                print("N�o tenho nada a dizer sobre isso!");
                break;
        }


    }
}
