using UnityEngine;

public class Exercicio5 : MonoBehaviour
{
    //5. (Pontuação de missão) Após completar uma missão, o jogador
    //recebe pontos.Verifique se ele ganhou mais de 50 pontos.Se sim,
    //exiba "Missão bem-sucedida"; caso contrário, "Missão
    //incompleta".

    [SerializeField] int Missão = 0;
    void Start()
    {
        if (Missão >= 50)
        {
            print("Missão Completa");

        }
        else
        {
            print("Missão Incompleta");
        }
    }

   
    void Update()
    {
        
    }
}
