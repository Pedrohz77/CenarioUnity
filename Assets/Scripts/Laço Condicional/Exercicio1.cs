using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    [SerializeField] int vidapersonagem = 100;
     
    void Start()
    {
        //resultado = vidaHeroi > vidadiminuida ? "H�roi est� vivo" : "Her�i est� morto";

        //print(resultado

        if (vidapersonagem > 0) {

           print("O Personagem est� vivo.");
        
    }
       else {

           print("O Personagem est� morto");
            
        }
        
    }
    void Update() {


    }
}
