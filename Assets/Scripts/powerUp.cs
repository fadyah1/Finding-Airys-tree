using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{

    private SpriteRenderer character;
    private Color color;
    private float activationTime;
    private bool invisible;


    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<SpriteRenderer>();
        activationTime = 0;
        invisible = false;
        color = character.color;
    }

    // Update is called once per frame
    void Update()
    {
        activationTime += Time.deltaTime;
        if (invisible && activationTime >= 3)
        {
            invisible = false;
            color.a = 1;
            character.color = color;
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Invisible")
        {
            invisible = true;
            activationTime = 0;
            color.a = .2f;
            character.color = color;
        }
    }




}
