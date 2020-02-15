using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour
{
    private Vector3 initialPosition;
    private bool launchedBird = false;
    [SerializeField] private float timeCount;
    [SerializeField] private float launchValue = 200;

    private void LoadNewScene()
    {
        string newSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(newSceneName);
    }

    private void Awake()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        GetComponent<LineRenderer>().SetPosition(0, transform.position);
        GetComponent<LineRenderer>().SetPosition(1, initialPosition);

        if(launchedBird && GetComponent<Rigidbody2D>().velocity.sqrMagnitude <= 0.2)
        {
            timeCount += Time.deltaTime;
            if(timeCount>3)
                LoadNewScene();

        }

        if (GetComponent<Transform>().position.x > 11 ||
            GetComponent<Transform>().position.y > 5 || 
            GetComponent<Transform>().position.x < -15 ||
            GetComponent<Transform>().position.y<-5 )
        {
            timeCount += Time.deltaTime;
            if (timeCount > 3)
                LoadNewScene();


        }
    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.magenta;
        GetComponent<LineRenderer>().enabled = true;
    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
        Vector2 Direction = initialPosition-transform.position;
        GetComponent<Rigidbody2D>().AddForce(Direction* launchValue);
        GetComponent<Rigidbody2D>().gravityScale = 1;
        launchedBird = true;
        GetComponent<LineRenderer>().enabled = false;

    }

    private void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position =new Vector3 (newPosition.x,newPosition.y,0);
    }

    
}
