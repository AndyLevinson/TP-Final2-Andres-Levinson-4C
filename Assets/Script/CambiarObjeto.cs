using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarObjeto : MonoBehaviour
{


    public GameObject[] Comida;
    public int currentindex = -1;
    public int currentindexantes = -2;
    public int currentindexdsp = 0;



    // Start is called before the first frame update
    void Start()
    {
        Desactivar();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.RightArrow))

        {

            currentindex++;
            currentindexantes++;
            currentindexdsp++;

            Cambiarcomida(currentindex);
            Comida[currentindexantes].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))

        {

            currentindex--;
            currentindexantes--;
            currentindexdsp--;

            Cambiarcomida(currentindex);
            Comida[currentindexdsp].SetActive(false);
        }




    }



    void Desactivar()


{


        for (int i = 0; i < Comida.Length; i++)
        {

            Comida[i].SetActive(false);


        }


  
    }

    void Cambiarcomida(int index)

    {
        Comida[index].SetActive(true);
    }

}
