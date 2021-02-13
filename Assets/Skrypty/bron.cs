
using UnityEngine;

public class bron : MonoBehaviour
{
    public float obrazenia = 10f;
    public float zasieg = 100f;

    public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }

        void Shoot () {
            RaycastHit hit;
           if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, zasieg)) 
           {
            Debug.Log(hit.transform.name);

            target cel = hit.transform.GetComponent<target>();
            if(cel != null)
                {
                    cel.TakeDamage(obrazenia);
                }
            }
        }
        
    }
}
