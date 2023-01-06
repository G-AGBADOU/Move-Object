using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        // pour recupérer les axes X, Y
        // les valeurs sont comprise entre -1 et 1
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;


        // pour un mouvement de 10m/s au lieu de 10m/img
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;



        //deplacer les objets le long de l'axe Z
        transform.Translate(0, 0, translation);


        //rotation, autour de l'axe Y
        transform.Rotate(0, rotation, 0);



    }
}
