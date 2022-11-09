using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderRestrictions : MonoBehaviour
{
    private int northBound = 150;
    private int eastBound = 150;
    private int southBound = 5;
    private int westBound = 5;

    // Update is called once per frame
    void Update()
    {
        ConstrainObjectPosition();
    }

    //prevent gameobject from escaping edges of map
    void ConstrainObjectPosition()
    {
        //constrain object from going too far north by resetting their position
        if (transform.position.x > northBound)
        {
            transform.position = new Vector3(northBound, transform.position.y, transform.position.z);
        }
        //restrain object from going too far south by resetting their position
        if (transform.position.x < southBound)
        {
            transform.position = new Vector3(southBound, transform.position.y, transform.position.z);
        }
        //constrain object from going too far east by resetting their position
        if (transform.position.z > eastBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, eastBound);
        }
        //restrain object from going too far west by resetting their position
        if (transform.position.z < westBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, westBound);
        }
    }
}
