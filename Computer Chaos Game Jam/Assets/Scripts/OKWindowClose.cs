using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OKWindowClose : MonoBehaviour
{

    public GameObject window;

    public void DestroyWindow(){
        Destroy(window);
	}
}
