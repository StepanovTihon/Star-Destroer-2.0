using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulb : MonoBehaviour
{

    public GameObject g;
    public AudioClip zvu;
    public GameObject v;
    public GameObject d;
    //public GameObject P=g.FindGameObjectWithTag("ne");
    public GameObject l;
    public ship script2Reference;
    void Start()
    {
        //transform.rotation *= Quaternion.Euler(-90f, 0f, 0f);
    }
    void Update() 
    {
        transform.position += transform.up * Time.deltaTime*-1 * (GlobalData.abc+45.0f);
    }  
    public void OnTriggerEnter (Collider other) {
        if(other.tag=="de"){
            //Destroy(other.gameObject,.0f);
            Vector3 tmpf=transform.position; 
            v.transform.position= tmpf; 
            //Instantiate(v); 
            script2Reference.jizn -= 1;
            //other.gameObject.GetComponent<Map>().j();
            GetComponent<AudioSource> ().PlayOneShot(zvu);


        }
        

 





    }
}
  