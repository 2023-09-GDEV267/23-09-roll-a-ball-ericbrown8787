using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    [Range(3,20)]public int quantity;
    public float circleRadius;
    public GameObject pickUp;
    


    // Start is called before the first frame update
    void Start()
    {
        GameObject newPickUp;
        // Spawning two pickups above ground level to demonstrate using boost on ramp
        newPickUp = Instantiate(pickUp, new Vector3(2f, 2.5f, -3f), Quaternion.identity);
        newPickUp.transform.parent = this.transform;
        newPickUp = Instantiate(pickUp, new Vector3(4f, 2.5f, -3f), Quaternion.identity);
        newPickUp.transform.parent = this.transform;
        // Spawning a perfect ring of pickups
        for (int i = 0; i < quantity; i+=1)
        {

            float angle = i * Mathf.PI * 2f / quantity;
            Vector3 newPos = new Vector3(Mathf.Cos(angle) * circleRadius, .5f, Mathf.Sin(angle) * circleRadius);
            newPickUp = Instantiate(pickUp, newPos, Quaternion.identity);

            // Parenting the newly spawned pickups to the object this script is attached to.
            newPickUp.transform.parent = this.transform;
        }
    }
    // Return the total quantity of pickups spawned by this script
    public int GetActualQuantity()
    {
        return quantity + 2;
    }
}
