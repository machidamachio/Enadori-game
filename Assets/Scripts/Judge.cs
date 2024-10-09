//左　：V
//中央：B
//右　：N
//Note1=モンスター
//Note2=レッドブル
//Note3=Zone

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    public GameObject effect1;//
    public GameObject effect2;
    public GameObject effect3;
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
        if (other.gameObject.tag == "Note1" && Input.GetKeyDown(KeyCode.V))// もしNote1に触れたかつFキーがおされたなら、
        {
            Instantiate(effect1.gameObject, other.transform.position, Quaternion.identity);// エフェクトを表示する
            Destroy(other.gameObject);// ノートを消す
        }
        if (other.gameObject.tag == "Note2" && Input.GetKeyDown(KeyCode.V))// もしNote1に触れたかつFキーがおされたなら、
        {
            Instantiate(effect2.gameObject, other.transform.position, Quaternion.identity);// エフェクトを表示する
            Destroy(other.gameObject);// ノートを消す
        }
        if (other.gameObject.tag == "Note3" && Input.GetKeyDown(KeyCode.V))// もしNote1に触れたかつFキーがおされたなら、
        {
            Instantiate(effect3.gameObject, other.transform.position, Quaternion.identity);// エフェクトを表示する
            Destroy(other.gameObject);// ノートを消す
        }
    }
}
