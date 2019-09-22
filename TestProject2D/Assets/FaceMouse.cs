using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class ElephantAim : MonoBehaviour
//{
//    public GameObject elephant;
//    private Vector3 mouse_pos = new Vector3();
//    private Transform target;
//    private Vector3 object_pos = new Vector3();
//    private float angle;
//    public bool isLocal;

//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (isLocal == true)
//        {
//            Debug.Log("a");
//            mouse_pos = Input.mousePosition;
//            mouse_pos.z = -20;
//            object_pos = Camera.main.WorldToScreenPoint(target.position);
//            mouse_pos.x = mouse_pos.x - object_pos.x;
//            mouse_pos.y = mouse_pos.y - object_pos.y;
//            angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
//            transform.rotation = Quaternion.Euler(0, 0, angle);
//        }
//    }
//}

public class FaceMouse: MonoBehaviour
{
    void Update()
    {
        faceMouse();    
    }

    void faceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        transform.up = direction;
    }

}
