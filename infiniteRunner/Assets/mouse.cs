using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    
    public GameObject mouseTing;
    // Start is called before the first frame update
    void Start()
    {
        //textTing.SetActive(false);
        StartCoroutine(ExampleCoroutine());
        
    }

    // Update is called once per frame
    void Update()
    {
 
        


        
    }

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("start");


        GameObject clone;

        clone = (GameObject) Instantiate (mouseTing, new Vector3(transform.position.x,transform.position.y,transform.position.z), Quaternion.Euler (0,0,0));
         
         clone.GetComponent<Rigidbody2D> ().velocity = 10 * transform.localScale.x * clone.transform.right;





        /*GameObject instantiatedProjectile = Instantiate(mouseTing,
                                                           transform.position,
                                                           transform.rotation)
                as GameObject;
            Rigidbody2D instaTing = instantiatedProjectile.GetComponent<Rigidbody2D>();
            instaTing.velocity = transform.TransformDirection(new Vector3(0, 10, 0));

            */
            /*Rigidbody2D instantiatedProjectile2 = Instantiate(mouseTing,
                                                           transform.position,
                                                           transform.rotation)
                as Rigidbody2D;

                instantiatedProjectile2.velocity = transform.TransformDirection(new Vector3(10, 0, 0));
            */
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1);

        //After we have waited 5 seconds print the time again.
        Debug.Log("end");
        
        Destroy(clone);
        //Destroy(instantiatedProjectile2);
        
        StartCoroutine(ExampleCoroutine());
    }



}
