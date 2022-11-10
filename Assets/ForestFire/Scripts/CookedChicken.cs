using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class CookedChicken : MonoBehaviour
{
    private NavMeshAgent nma = null;
    public ForestFire3D forestFire3D;
    public GameObject closestFireGameObject;

    public float stopDistance;

    private void Awake()
    {
        forestFire3D = GameObject.FindGameObjectWithTag("ForestFire3D").GetComponent<ForestFire3D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        nma = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        FindNearestFire();
    }

    //find nearest fire and send chicken to it
    private void FindNearestFire()
    {
        // iterate through each cell in the rows and columns
        for (int xCount = 0; xCount < forestFire3D.gridSizeX; xCount++)
        {
            for (int yCount = 0; yCount < forestFire3D.gridSizeY; yCount++)
            {
                if (forestFire3D.forestFireCells[xCount, yCount].cellState == ForestFireCell.State.Alight) // if the cell is currently alight let it burn but reduce it's fuel and see if it goes out
                {
                    if (closestFireGameObject == null)
                    {
                        closestFireGameObject = forestFire3D.cellGameObjects[xCount, yCount];
                    }


                    // compare distance between chicken and current closest fire object and see if there is another fire object closer
                    if (Vector3.Distance(transform.position, closestFireGameObject.transform.position)
                        > Vector3.Distance(transform.position, forestFire3D.cellGameObjects[xCount, yCount].transform.position))
                    {
                        closestFireGameObject = forestFire3D.cellGameObjects[xCount, yCount];
                        nma.SetDestination(closestFireGameObject.transform.position);
                    }
                }
            }
        }
    }
}