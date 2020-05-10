using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astro : MonoBehaviour
{
    float x,y,z,xp,yp,zp=0;
    //public Transform centerOfmass;
    public Rigidbody Rigid;
    public GameObject b;
    Vector3 tmpf; 
    void Start()
    {
       x=Random.Range(-0.03f,0.03f);   
       y=Random.Range(-0.03f,0.03f);   
       z=Random.Range(-2,2);   
       xp=Random.Range(-1,1);   
       yp=Random.Range(-1,1);   
       zp=Random.Range(-1,1);   
 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position+new Vector3(x/10, y/10, z/10);
        Rigid.transform.Rotate(xp/2, yp/2, zp/2, Space.World);

    }
}
