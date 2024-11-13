using System;
using Unity.Collections;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio8 : MonoBehaviour
{
   //8. (Contador de horas e dias) Crie um script que em que uma
   //variável inteira hora seja incrementada de uma unidade a cada 10
   //segundos e volte a ser 0 quando alcançar o valor 24. Quando
   //completar um ciclo, incremente uma variável dias e escreva o
   //número de dias que se passaram no console. (Coloque o código
   //dentro da função-evento Update).


    [SerializeField] int hora;
    [SerializeField] int dia;
    [SerializeField] float segundos;
    void Start()
    {
        
    }

    void Update()
    {
        segundos += Time.deltaTime; 

        if (segundos >= 10f) 
        {
            hora++;  
            segundos = 0f;
        }
        
        else if (hora >= 24)  
        {
            hora = 0;  
            dia++;  
            print("Dias passados: " + dia);  
        }
        
    }
}
