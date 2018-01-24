using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleController : MonoBehaviour {

    public float timeToDeath;

    public Vector3 scale;
    private void Start()
    {
        GetComponent<RectTransform>().localScale = Vector3.zero;
        StartCoroutine(CircleGrow());
    }

    IEnumerator CircleGrow()
    {
        while (scale.x < 1f)
        {
            scale = GetComponent<RectTransform>().localScale + new Vector3(0.01f, 0.01f, 0.01f);
            GetComponent<RectTransform>().localScale = scale;
            yield return new WaitForSeconds(timeToDeath * 0.01f);
        }
        DeleteCircle();
    }

    public void DeleteCircle()
    {
        Destroy(gameObject);
    }
	
}
