using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pmove1 : MonoBehaviour
{
    
    private float horizontalMove;
    private float verticalMove;
    public  float speed;

   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * (-Time.deltaTime * speed);
        verticalMove = Input.GetAxis("Vertical") * (-Time.deltaTime * speed);
        transform.Translate(new Vector3(horizontalMove,0, verticalMove));
    }
}
