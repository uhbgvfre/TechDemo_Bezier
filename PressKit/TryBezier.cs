using UnityEngine;

public class TryBezier : MonoBehaviour
{
    [Range(0, 100)]
    public int nodeQty = 16;

    [Range(0, 1f)]
    public float nodeRadius = .1f;

    public Transform[] ctrlPts;

    private void OnDrawGizmos()
    {
        for (int i = 0; i < nodeQty; i++)
        {
            float t = (1f / nodeQty) * i;

            Vector3 segPos =
                1f * Mathf.Pow(1f - t, 3f) * ctrlPts[0].position +
                3f * Mathf.Pow(1f - t, 2f) * t * ctrlPts[1].position +
                3f * (1f - t) * t * t * ctrlPts[2].position +
                1f * t * t * t * ctrlPts[3].position;

            Gizmos.DrawWireSphere(segPos, nodeRadius);
        }
    }
}