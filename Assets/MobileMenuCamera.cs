using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMenuCamera : MonoBehaviour
{
    Vector3 startPos;
    public float startPosSmotth = 2;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        TPoseControl();

        transform.position = Vector3.Lerp(transform.position, startPos, startPosSmotth * Time.deltaTime);
    }

    public void TPoseControl()
    {
        var ac = Input.acceleration;
        if (Mathf.Abs(ac.z) < 0.1f && Mathf.Abs(ac.y) < 0.01f) return;

        var movePos = new Vector3(ac.x, (ac.z + 0.21f) * -1, ac.y + 0.21f);
        //transform.position = Vector3.Lerp(transform.position, transform.position + movePos, 2 * Time.deltaTime);
        transform.Translate(movePos * Time.deltaTime);
        
        var pos = transform.position;
        pos.z = Mathf.Clamp(transform.position.z, -1.0f, -0.50f);
        pos.y = Mathf.Clamp(transform.position.y, 1.55f, 2.2f);
        pos.x = 1.665767f;
        transform.position = pos;
    }
}
