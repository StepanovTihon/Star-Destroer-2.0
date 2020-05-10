using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mins : MonoBehaviour
{
    float x,y,z,xp,yp,zp=0;
    //public Transform centerOfmass;
    public Rigidbody Rigid;
    public GameObject b;
    Vector3 tmpf; 
    public AudioClip zvu;
    void Start()
    {
       x=Random.Range(-0.08f,0.08f);   
       y=Random.Range(-0.02f,0.02f);   
       z=Random.Range(-0.08f,0.08f);   
       xp=Random.Range(-2,2);   
       yp=Random.Range(-2,2);   
       zp=Random.Range(-2,2);   
 
    }
    public void OnTriggerEnter (Collider other) {
        if(other.tag!="ne"){
          //Destroy(other.gameObject,.0f);
          Vector3 tmpf=transform.position; 
          b.transform.position= tmpf;
          Instantiate(b); 

          GetComponent<AudioSource> ().PlayOneShot(zvu);
          Destroy(gameObject,.0f);
        }


    }
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position+new Vector3(x/3, y/3, z/3);
        Rigid.transform.Rotate(xp, yp, zp, Space.World);

    }
}
