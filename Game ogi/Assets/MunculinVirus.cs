using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculinVirus : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject virus; //memanggil virus
    public float waktuMinimal, waktuMaksimal;
    public float posisiMinimal, posisiMaksimal;
    void Start()
    {
        StartCoroutine(MunculVirus());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator MunculVirus()
    {
        // memunculkan virus dari posisi yang berbeda beda
        Instantiate(virus, transform.position + Vector3.right * Random.Range(posisiMinimal, posisiMaksimal), Quaternion.identity);

        // Memberikan delay dengan waktu yang berbeda beda, anda bisa melihat di inspektor
        yield return new WaitForSeconds(Random.Range(waktuMinimal, waktuMaksimal));

        //memanggil fungsi muncul virus lagi
        StartCoroutine(MunculVirus());
    }
}
