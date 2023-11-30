using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserButton : MonoBehaviour
{

    [SerializeField]
    private GameObject LaserDetector;
    [SerializeField]
    private GameObject LaserDetector2;

    private Laser Laser;
    private Laser Laser2;
    // Start is called before the first frame update
    void Start()
    {
        this.Laser = this.LaserDetector.GetComponent<Laser>();
        this.Laser2 = this.LaserDetector2.GetComponent<Laser>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        this.Laser.TurnOff();
        this.Laser2.TurnOff();
    }
}
