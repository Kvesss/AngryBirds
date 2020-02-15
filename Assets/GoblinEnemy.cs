
using UnityEngine;

public class GoblinEnemy : MonoBehaviour
{
    [SerializeField] private GameObject smokeParticle;
    private Vector3 initialPosition;
    // Start is called before the first frame update
    private void Start()
    {
        initialPosition = transform.position;    }

    // Update is called once per frame
    private void Update()
    {
        //if(GetComponent<BoxCollider2D>().
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.GetComponent<FlappyBird>() != null)
        {
            Instantiate(smokeParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (collision.relativeVelocity.sqrMagnitude>30)
        {
            Instantiate(smokeParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
