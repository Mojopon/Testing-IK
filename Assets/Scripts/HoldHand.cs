using UnityEngine;
using System.Collections;

public class HoldHand : MonoBehaviour
{
    public float searchRadius = 1f;

    void FixedUpdate()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, searchRadius);

        foreach(var col in hitColliders)
        {
            var target = col.GetComponent<HoldHandTarget>();

            if(target)
            {
                FaceToTarget(target);
            }
        }
    }

    void FaceToTarget(HoldHandTarget target)
    {
        transform.LookAt(target.transform);
    }
}
