using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Weight : MonoBehaviour
{
    [Tooltip("Amount of mass")]
    [SerializeField]
    private float Mass;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseBy(float extraMass)
    {
        this.Mass += extraMass;
    }

    public float GetWeight() 
    { 
        return this.Mass;
    }
}
