using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrCamera : MonoBehaviour
{
    [SerializeField] Transform alvo;

    void Start()
    {
        transform.position = new Vector3(alvo.transform.position.x, alvo.transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(alvo.transform.position.x, alvo.transform.position.y, transform.position.z);
    }
}
