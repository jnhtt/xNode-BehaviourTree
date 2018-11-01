using UnityEngine;
using AI.BtGraph;

public class BaseMover : MonoBehaviour
{
    private Transform cachedTransform;
    public Transform CachedTransform {
        get {
            if (cachedTransform == null) {
                cachedTransform = transform;
            }
            return cachedTransform;
        }
    }
}
