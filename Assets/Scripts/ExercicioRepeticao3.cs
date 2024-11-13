using UnityEngine;

public class ExercicioRepeticao3 : MonoBehaviour
{
    //(Cálculo de moedas coletadas) O jogador coleta 3 moedas a cada fase.
    //Após 10 fases, exiba o total de moedas coletadas.

    //[SerializeField] int MoedasFases = 3;
    //[SerializeField] int Fases = 10;
    [SerializeField] int totalMoeda = 0;

    void Start()
    {
        for (int fase = 1; fase <= 10; fase++)
        {
            //totalMoeda = totalMoeda + 3;
            totalMoeda += 3;
            print("O total de moedas até agora é: " + totalMoeda);
        }
        print("Total de moedas: " + totalMoeda);

        //int TotalMoedas = 0;

        //for (int i = 1; i <= Fases; i++)
        //{
            
        //    TotalMoedas += MoedasFases;
        //}

        //print("Total de moedas coletadas após " + Fases + " fases: " + TotalMoedas);
    }


        void Update()
    {
        
    }
}
