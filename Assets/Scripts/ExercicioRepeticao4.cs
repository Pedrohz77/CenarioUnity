using UnityEngine;

public class ExercicioRepeticao4 : MonoBehaviour
{
    //(Pontua��o em combos) Cada combo realizado aumenta em 10
    //pontos.Exiba a pontua��o total ap�s 7 combos.

    [SerializeField] int Pontos = 10;
    [SerializeField] int TotalPontos = 0;


    void Start()
    {

        for (int i = 1; i <= 7; i++)
        {
            print("Combo " + i + ": Pontos = " + Pontos);
            TotalPontos += Pontos;
            Pontos += 10;


        }

        print("Pontua��o Total ap�s 7 combos: " + TotalPontos);
    }
     

    void Update()
    {
        
    }
}
