using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDeathEffect : MonoBehaviour
{
    public GameObject DeathEffect;

    private void Start()
    {
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
