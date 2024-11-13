using UnityEngine;

public class ExercicioRepeticao7 : MonoBehaviour
{
    //(Maior número em uma lista) Dada uma lista de números,
    //encontre o maior valor.

    int[] numeros = { 3, 5, 7, 10, 68, 23, 71, 18, 97 };
    int maior = 0; 
    void Start()
    {
        foreach (var item in numeros)
        {
            if (item > maior) 
            {
                maior = item;
            }
        }

        print("O maior número é: " + maior);
    }    


    void Update()
    {
        
    }
}
