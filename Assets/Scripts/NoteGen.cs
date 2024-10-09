using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGen : MonoBehaviour
{
    public GameObject[] notes;//ノートオブジェクトの配列
    public Vector3[] notePos;//ノートの初期位置の配列
    private int noteNum;//ノートの番号
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("MusicScore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator MusicScore()//コルーチン
    {
        for (int i = 0; i < 42; i++)//音符の数だけ繰り返す
        {
            noteNum = Random.Range(0, 3);//ノートの種類を0以上4未満の乱数にする
            Instantiate(notes[noteNum], notePos[noteNum], Quaternion.identity);//noteNum番目のオブジェクトをnoteNum番目の初期位置に生成する
            yield return new WaitForSeconds(1);//一秒待つ
        }
    }
}
