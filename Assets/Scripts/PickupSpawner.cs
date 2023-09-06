using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public int quantity;
    public float circleRadius;
    public GameObject pickUp;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newPickUp;
        for (int i = 0; i < quantity; i+=1)
        {

            float angle = i * Mathf.PI * 2f / quantity;
            Vector3 newPos = new Vector3(Mathf.Cos(angle) * circleRadius, .5f, Mathf.Sin(angle) * circleRadius);
            newPickUp = Instantiate(pickUp, newPos, Quaternion.identity);
            newPickUp.transform.parent = this.transform;
        }
    }
}
