using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceManager : MonoBehaviour
{
    public int exp;
    public Slider HabGoodSlider, HabBadSlider;
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
        
    }

    IEnumerator WaitTimne()
    {
        yield return new WaitForSeconds(5);
        exp = exp + 10;
        StartCoroutine(WaitTimne());
    }

}
