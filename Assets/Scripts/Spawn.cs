using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawn : MonoBehaviour
{

    [SerializeField]
    private GameObject[] Proto;
    [SerializeField]
    private float Cooldown = 5;
    [SerializeField]
    private float RotationalSpeed = 80;
    [SerializeField]
    private bool Animate = true;
    [SerializeField]
    private AnimationCurve AnimationCurve;
    [SerializeField]
    private float BobHeight = 0.3f;
    [SerializeField]
    private float BobOffset = 0.1f;

    private float AccumulatedDelta = 0;
    private float CurveTime = 0;
    private Vector3 SpawnerPosition;
    private Quaternion SpawnerRotation;

    private GameObject Spawned;

    // Start is called before the first frame update
    void Start()
    {
        this.SpawnerPosition = this.GetComponent<Transform>().position;
        this.SpawnerRotation = this.GetComponent<Transform>().rotation;
        this.AccumulatedDelta = this.Cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.Spawned == null)
        {
            this.CurveTime = 0;
            this.AccumulatedDelta += Time.deltaTime;
            if (this.AccumulatedDelta > Cooldown)
            {
                int index = UnityEngine.Random.Range(0, this.Proto.Length);
                this.AccumulatedDelta = 0;
                this.Spawned = Instantiate(this.Proto.ElementAt(index), 
                    SpawnerPosition + new Vector3(0, this.BobHeight * 2 + this.BobOffset, 0), 
                    SpawnerRotation);
            }
        } else
        {
            if (this.Animate)
            {
                this.CurveTime += Time.deltaTime / 2;
                this.Spawned.transform.position = new Vector3(this.Spawned.transform.position.x,
                    this.BobOffset + this.BobHeight + this.BobHeight * this.AnimationCurve.Evaluate(this.CurveTime) + this.SpawnerPosition.y,
                    this.Spawned.transform.position.z);
                this.Spawned.transform.Rotate(Vector3.up * Time.deltaTime * this.RotationalSpeed);

            }
        }
    }
}
