using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< Updated upstream

public class ExperienceManager : MonoBehaviour
{
    public int exp, ;
    // Start is called before the first frame update
    void Start()
    {
        
=======
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
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        
    }
<<<<<<< Updated upstream
=======
    IEnumerator WaitTimne()
    {
        yield return new WaitForSeconds(5);
        exp = exp + 10;
        StartCoroutine(WaitTimne());
    }
>>>>>>> Stashed changes
}
