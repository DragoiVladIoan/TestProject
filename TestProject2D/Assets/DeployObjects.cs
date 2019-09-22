using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployObjects : MonoBehaviour
{
    public GameObject[] interactiveObjects;
    public float respawTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(objectWave());
    }

    private void spawnObject()
    {
        int objectSelected = Random.Range(0, interactiveObjects.Length);
        GameObject obj = Instantiate(interactiveObjects[objectSelected]) as GameObject;
        obj.transform.position = new Vector3(screenBounds.x + 3, -3, -2);
    }
    
    IEnumerator objectWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawTime);
            spawnObject();
        }
        
    }
}
