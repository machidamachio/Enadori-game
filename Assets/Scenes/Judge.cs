using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    public GameObject effect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)// オブジェクトに触れている時の処理
    {
        if (other.gameObject.tag == "Note1" && Input.GetKeyDown(KeyCode.F))// もしNote1に触れたかつFキーがおされたなら、
        {
            Instantiate(effect.gameObject, other.transform.position, Quaternion.identity);// エフェクトを表示する
            Destroy(other.gameObject);// ノートを消す
        }
    }
}
