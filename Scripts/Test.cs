using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject backbow; // �� �ڿ� ��ġ��ų Ȱ
    public GameObject Attackbow; // Ȱ ������ȯ�� ��ġ��ų Ȱ
    public GameObject arrow; // Ȱ ���� ��ȯ�� ��ġ��ų ȭ��

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
