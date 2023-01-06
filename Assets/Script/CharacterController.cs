using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Vector3 _distance;
    int _direction;
    [SerializeField] float _vitesse;


    // Start is called before the first frame update
    void Start()
    {
        _direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(new Vector3(_direction,0,0) * Time.deltaTime);

        // direction pour aller à gauche
        if (transform.position.x >= 5)
        {
            _direction = -1;
        }

        // direction pour aller à droite
        if (transform.position.x <= -5)
        {
            _direction = 1;
        }


    }


   
}

