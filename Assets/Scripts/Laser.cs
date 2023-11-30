using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    [SerializeField]
    private float FlickerPeriod = 0.1f;

    private float FlickerDelta = 0f;

    private bool Flickering = false;

    private bool On = true;

    private Renderer Renderer;
    // Start is called before the first frame update
    void Start()
    {
        this.Renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.On)
        {
            if (this.Flickering)
            {
                if (this.FlickerDelta > FlickerPeriod)
                {
                    this.Renderer.enabled = !this.Renderer.enabled;
                    this.FlickerDelta = 0;
                }
                else
                {
                    this.FlickerDelta += Time.deltaTime;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.On)
        {
            this.Flickering = true;
        }
    }

    public void TurnOn()
    {
        this.On = true;
        this.Renderer.enabled = true;
    }

    public void TurnOff()
    {
        this.On = false;
        this.Renderer.enabled = false;
    }

    public void Toggle()
    {
        if (this.On)
        {
            this.TurnOff();
        } else
        {
            this.TurnOn();
        }
    }
}
