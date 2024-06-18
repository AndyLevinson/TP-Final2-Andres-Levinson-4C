using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarObjeto : MonoBehaviour
{


    public GameObject[] Comida;
    public int currentindex = -1;
    public int currentindexantes = -2;


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

            Cambiarcomida(currentindex);
            Sacarcomida(currentindexantes);

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




    void Sacarcomida(int index)

    {



        Comida[currentindexantes].SetActive(false);

    }

    void Sacarcomidaantes(int index)

    {

        currentindex--;
        if (currentindex < 0)
        {

            currentindex = Comida.Length - 1;


            Comida[currentindex].SetActive(false);

        }

        

    }
}
