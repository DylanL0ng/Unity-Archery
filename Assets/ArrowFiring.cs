using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFiring : MonoBehaviour
{
    [SerializeField] private GameObject arrowPrefab;
    [SerializeField] private Transform arrowSpawn;
    [SerializeField] private float arrowForce = 20f;
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject arrow = Instantiate(arrowPrefab ,arrowSpawn.position, Quaternion.identity);
            arrow.transform.Rotate(new Vector3(90, 0 ,0));
            arrow.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * arrowForce, ForceMode.VelocityChange);
        }
        
    }
}
