using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{

    //estos son los espacios en los que estan separados los cubos 
    public float spacingX = 0.1f; 
    public float spacingY = 0.1f; 

    void Start()
    {
        //los for para armar la forma de la pared 
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                GameObject cubito = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cubito.name = "Mi cubito";
                cubito.transform.position = new Vector3(i * spacingX, j * spacingY, 0); 
                //tamaño del cubo para que tenga apariencia de pared 
                cubito.transform.localScale = new Vector3(1.9f, 1.9f, 1.9f); 
                MeshRenderer mr = cubito.GetComponent<MeshRenderer>();
                mr.material.color = new Color(1, 1, 0);

                Rigidbody rb = cubito.AddComponent<Rigidbody>();
                rb.mass = 10;
                //el constraint se usa para que no se caigan los bloques 
                rb.constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }

    void Update()
    {
        Debug.DrawLine(Vector3.zero, new Vector3(1, 0, 0), Color.red);
        Debug.DrawLine(Vector3.zero, new Vector3(0, 1, 0), Color.green);
        Debug.DrawLine(Vector3.zero, new Vector3(0, 0, 1), Color.blue);
    }
}