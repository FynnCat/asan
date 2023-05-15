using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExperienceManager : MonoBehaviour
{
    public int exp;
    public Slider HabGoodSlider, HabBadSlider;
    [SerializeField] TMP_Text _expText;
    // Start is called before the first frame update
    void Start()
    {
        HabBadSlider.maxValue = 30;
        HabGoodSlider.maxValue = 30;
        StartCoroutine(WaitTimne());
        

    }

    // Update is called once per frame
    void Update()
    {
        _expText.text = "EXP: " + exp.ToString(); 
    }

    IEnumerator WaitTimne()
    {
        yield return new WaitForSeconds(5);
        exp = exp + 10;
        StartCoroutine(WaitTimne());
    }

}
