using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Stamina : MonoBehaviour
{

    private float DeltaConsumedEnergy = 0f;
    [SerializeField]
    private float RegenerationCooldown = 1f;
    [SerializeField]
    private float Energy = 10;
    [SerializeField]
    private float MaximumEnergy = 10;
    [SerializeField]
    private float EnergyRecuperationFactor = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.DeltaConsumedEnergy += Time.deltaTime;
        if (this.DeltaConsumedEnergy > this.RegenerationCooldown)
        {
            this.Energy = Mathf.Min(this.Energy + Time.deltaTime * this.EnergyRecuperationFactor, this.MaximumEnergy);
        }
    }

    public float GetEnergy()
    {
        return this.Energy;
    }

    
    private void IncreaseBy(float amount)
    {
        this.Energy += amount;
        this.Energy = Mathf.Min(this.Energy, this.MaximumEnergy);
    }

    private void DecreaseBy(float amount)
    {
        this.Energy -= amount;
        this.Energy = Mathf.Max(this.Energy, 0);
    }

    public void VaryBy(float amount)
    {
        if (amount >= 0)
        {
            this.IncreaseBy(amount);
        } else
        {
            this.DecreaseBy(amount);
        }
    }

    public void SprintedFor(float deltaSprinted)
    {
        this.DeltaConsumedEnergy = 0f;
        this.Energy = Mathf.Max(this.Energy - deltaSprinted, 0);
    }

    public float GetMaximumEnergy()
    {
        return this.MaximumEnergy;
    }

}
