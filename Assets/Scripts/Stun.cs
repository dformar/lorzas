using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stun : MonoBehaviour
{

    [SerializeField]
    private float StunCooldown = 2;

    private float RemainingStunTime = 0;
    public float RemainingStunCooldown = 0;
    public bool Stunned = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.RemainingStunTime > 0)
        {
            this.RemainingStunTime -= Time.deltaTime;
        } else
        {
            this.Stunned = false;
            this.RemainingStunCooldown -= Time.deltaTime;
        }
    }

    public void StunFor(float amount)
    {
        if (this.RemainingStunCooldown > 0)
        {
            return;
        } else
        {
            this.Stunned = true;
            this.RemainingStunTime = amount;
            this.RemainingStunCooldown = this.StunCooldown;
        }
    }

}
