using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
   public GameObject bullet;
   public GameObject turret;
 
  

   

    // Update is called once per frame
    void Update()
    {
        fire();
    }
    private void fire()
    {
        
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        Instantiate(bullet, turret.transform.position, turret.transform.rotation);
                       
                    }  
       
    }

    

  




}
