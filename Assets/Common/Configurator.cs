using UnityEngine;

public sealed class Configurator : MonoBehaviour
{
#if UNITY_IOS
    void Start() => Application.targetFrameRate = 60;
#endif
}
