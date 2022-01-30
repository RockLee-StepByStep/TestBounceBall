using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletEnemy : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float speedRotate;
    public LayerMask collisionMask;
    scoreBoardForEnemy score;
    
    // Start is called before the first frame update
    void Start()
    {
       
        score= FindObjectOfType<scoreBoardForEnemy>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //transform.Rotate(new Vector3(speedRotate * Time.deltaTime,0 , 0));

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if(Physics.Raycast(ray,out hit,Time.deltaTime * speed, collisionMask))
        {
            Vector3 reflection = Vector3.Reflect(ray.direction, hit.normal);
            float rot = 90 - Mathf.Atan2(reflection.z, reflection.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, rot, 0);
        }

        if(transform.position.z < -35 || transform.position.z > 35)
        {
            Destroy(this.gameObject);
        }
        if (transform.position.x < -75 || transform.position.z > 75)
        {
            Destroy(this.gameObject);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            score.IncreaseScoreEnemy(1);
            // Destroy(this.gameObject,);
           
            

        }
       
    }


}
