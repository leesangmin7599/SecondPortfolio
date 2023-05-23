using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject backbow; // 등 뒤에 위치시킬 활
    public GameObject Attackbow; // 활 공격전환시 위치시킬 활
    public GameObject arrow; // 활 공격 전환시 위치시킬 화살

    Animator anim;

    public bool isWeaponChange = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {

        WeaponChange();

    }
    void WeaponChange()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (!isWeaponChange)
            {
                anim.SetTrigger("WeaponChange");
                backbow.SetActive(false);
                Attackbow.SetActive(true);
                arrow.SetActive(true);
                isWeaponChange = true;
                Debug.Log("up");
            }
            else
            {
                anim.SetTrigger("WeaponChange2");
                StartCoroutine(LateWeapon());
                Debug.Log("down");
            }
        }

    }
    IEnumerator LateWeapon()
    {
        yield return new WaitForSeconds(0.7f);
        backbow.SetActive(true);
        Attackbow.SetActive(false);
        arrow.SetActive(false);
        isWeaponChange = false;
    }
}
