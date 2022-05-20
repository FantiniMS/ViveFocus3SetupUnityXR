using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour
{

    public GameObject Cover;
    public HingeJoint myHinge;

    // Start is called before the first frame update
    void Start()
    {
        var myHinge = Cover.GetComponent<HingeJoint>();

        myHinge.useMotor = false;
    }

    // Update is called once per frame
    public void OpenSesame()
    {
        myHinge.useMotor = true;
        Debug.Log("motor should be true");
    }
}
