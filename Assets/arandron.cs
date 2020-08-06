using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arandron : MonoBehaviour
{
    public GameObject bullet;
    public GameObject gun;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gunshot();
    }
    public void gunshot()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            GameObject BT = (GameObject)Instantiate(bullet, transform.position.normalized, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
            Rigidbody RB = BT.GetComponent<Rigidbody>();
            RB.AddForce(transform.forward * speed);
            Destroy(BT, 5.0f);

        }
    }
    public void gunshotposition()
    {
        this.transform.position = gun.transform.position;
    }
}
