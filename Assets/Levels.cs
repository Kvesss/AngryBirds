using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    private GoblinEnemy[] enemies;
    private static int levelCount=1;

    // Start is called before the first frame update
    private void OnEnable()
    {
        enemies = FindObjectsOfType<GoblinEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
       foreach(GoblinEnemy enemy in enemies)
        {
            if (enemy !=null)
                return;
        }
        Debug.Log("Proceed to next level!");
        levelCount++;
        string nextLvlName = "Level" + levelCount;
        //float timeCount = 0;
        //timeCount += Time.deltaTime;
        //if (timeCount > 3)
        //    SceneManager.LoadScene(nextLvlName);
        SceneManager.LoadScene(nextLvlName);
    }
}
