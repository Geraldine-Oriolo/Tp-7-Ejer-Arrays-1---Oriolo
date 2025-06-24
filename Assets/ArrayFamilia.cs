using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayFamilia : MonoBehaviour
{
    public int[] Familia;
    // Start is called before the first frame update
    void Start()
    {
        //Escribir el primer elemento del array
        Debug.Log (Familia[0]);

        //Escribir la cantidad de elementos del array
        Debug.Log(Familia.Length);

        //Escribir cada elemento del array
        for (int i = 0; i < Familia.Length; i++)
        {
            Debug.Log(Familia[i]);
        }

        //Escribir el promedio de los elementos del array

        float promedio = 0f;
        for( int i = 0; i < Familia.Length; i++ )
        {
            promedio =+ 
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}










//Escribir los elementos del array mayores que 20
//Escribir los elementos del array en orden inverso