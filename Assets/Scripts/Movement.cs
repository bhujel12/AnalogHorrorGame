using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float walkSpeedScalar = 4f;
    [SerializeField] float runSpeedScalar = 8f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.identity;
        float leftRightMotion = Input.GetAxisRaw("Horizontal") * walkSpeedScalar;
        float upDownMotion = Input.GetAxisRaw("Vertical") * walkSpeedScalar;
        transform.Translate(leftRightMotion * Time.deltaTime, upDownMotion * Time.deltaTime, 0);
    }
}