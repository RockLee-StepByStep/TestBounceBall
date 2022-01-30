using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBlock : MonoBehaviour
{
    [Range(0, 1)] [SerializeField] float movementFactor ;
    Vector3 startongPos;
    [SerializeField] Vector3 movementVector = new Vector3(5f, 5f, 5f);
    [SerializeField] float period = 3;


    void Start()
    {
        startongPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float cycles = Time.time / period;

        const float tau = Mathf.PI * 2;
        float rawSinWave = Mathf.Sin(cycles * tau);
        movementFactor = rawSinWave / 2f + 0.5f;

            Vector3 offset = movementFactor * movementVector;
            transform.position = startongPos - offset;
    }
}
