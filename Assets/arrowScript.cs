using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowScript : MonoBehaviour
{
    [SerializeField] private Rigidbody myBody;
    private bool isCollided = false;

    void Start()
    {
        myBody = gameObject.GetComponent<Rigidbody>();        
    }

    void Update()
    {
        if (!isCollided)
        {
            gameObject.transform.Rotate(Vector3.forward * Random.Range(0, 5) * Time.deltaTime);
            gameObject.transform.Rotate(Vector3.up * Random.Range(180, 960) * Time.deltaTime);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        isCollided = true;
        Stick();
        Destroy(gameObject, 10f);
        
            Debug.Log($"Hit {collision.gameObject.name}");
    }

    private void Stick()
    {
        myBody.constraints = RigidbodyConstraints.FreezeAll;
    }
}
