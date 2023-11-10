using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.UI;

public class MakeButton : MonoBehaviour
{
    [SerializeField]
    private bool physical;

    private GameObject hero;

    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(() => AttachCallBack());
        hero = GameObject.FindGameObjectWithTag("Hero");
    }

    private void AttachCallBack()
    {
        if (gameObject.name == "MeeleBtn")
        {
            hero.GetComponent<FighterAction>().SelectAttack("meele");
        }
        else if (gameObject.name == "RangeBtn")
        {
            hero.GetComponent<FighterAction>().SelectAttack("range");
        }
        else if (gameObject.name == "DefBtn")
        {
            hero.GetComponent<FighterAction>().SelectAttack("def");
        }
        else
        {
            hero.GetComponent<FighterAction>().SelectAttack("heal");
        }
    }
}
