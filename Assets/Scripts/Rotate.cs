using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    private float scale;

    void Start()
    {
        scale = 0.25F;
        transform.localScale = new Vector3(scale, scale, scale);
    }

    void Update()
    {
        if(scale <= 1)
        {
            scale += 0.025F;
            transform.localScale = new Vector3(scale, scale, scale);
        }
        //transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
}
