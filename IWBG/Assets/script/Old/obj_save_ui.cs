using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_save_ui : MonoBehaviour {

    private void Start()
    {
        Invoke("des", 0.5f);
    }
    private void des()
    {
        Destroy(gameObject);
    }
}
