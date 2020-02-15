using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private GameObject smokeParticle;
    Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.GetComponent<FlappyBird>() != null)
        {
            Instantiate(smokeParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (collision.relativeVelocity.sqrMagnitude > 200)
        {
            Instantiate(smokeParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
