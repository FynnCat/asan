using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Database : MonoBehaviour
{
    [SerializeField] float scanTime, epx, defaultTime;
    public int PlanetValue;
    public bool Branch_01 = false, Bush_01 = false, Bush_02 = false, Bush_03 = false, Flowers_01 = false, Flowers_02 = false, Grass_01 = false, Grass_02 = false, Mushroom_01 = false, Mushroom_02 = false, Rock_01 = false, Rock_02 = false, Rock_03 = false, Rock_04 = false, Rock_05 = false, Stump_01 = false, Tree_01 = false, Tree_02 = false, Tree_03 = false, Tree_04 = false, Tree_05 = false, ASAN_Creature_01 = false, ASAN_Creature_02, ASAN_Creature_03, ASAN_Creature_04;
    [SerializeField] GameObject Branch_01Data, Bush_01Data, Bush_02Data, Bush_03Data, Flowers_01Data, Flowers_02Data, Grass_01Data, Grass_02Data, Mushroom_01Data, Mushroom_02Data, Rock_01Data, Rock_02Data, Rock_03Data, Rock_04Data, Rock_05Data, Stump_01Data, Tree_01Data, Tree_02Data, Tree_03Data, Tree_04Data, Tree_05Data, ASAN_Creature_01Data, ASAN_Creature_02Data, ASAN_Creature_03Data, ASAN_Creature_04Data;
    [SerializeField] Camera _camera;
    [SerializeField] ExperienceManager _experienceManager;
    [SerializeField] saveSceneScript _saveSceneScript;
    [SerializeField] Slider _scanSlider;
    [SerializeField] GameObject _scanSliderObject;
    [SerializeField] bool _startScanning = false;
    [SerializeField] Image[] Cursor;
    [SerializeField] GameObject _scanContainer;
    [SerializeField] TMP_Text _InfoText;
    [SerializeField] AudioSource _scanAudioClip;
    [SerializeField] AudioSource _endScanAudioSource;
    [SerializeField] ParticleSystem _scanParticle;
    // Start is called before the first frame update
    
    void Start()
    {
        //_camera = Camera.main;
        _experienceManager = GameObject.FindObjectOfType<ExperienceManager>();
        _saveSceneScript = GameObject.FindObjectOfType<saveSceneScript>();
        _scanSlider.maxValue = defaultTime;
        _scanSlider.minValue = 0;
        _scanSlider.value = 0;

    }

    // Update is called once per frame
    void LateUpdate()
    {

        Vector3 rayStartPos;
        Vector3 rayDirection;

        rayStartPos = _camera.transform.position;
        rayDirection = _camera.transform.forward;

        Ray ray = new Ray(rayStartPos, rayDirection);

        RaycastHit hit;
        // yield return new WaitForSeconds(scanTime);

        if (Physics.Raycast(ray, out hit, 7))
        {

            //Debug.Log(hit.transform.tag);
            Debug.DrawRay(rayStartPos, rayDirection * 7f, Color.green);

            if (hit.collider.tag == "Branch_01" || hit.collider.tag == "Bush_01" || hit.collider.tag == "Bush_02" || hit.collider.tag == "Bush_03" || hit.collider.tag == "Flowers_01" || hit.collider.tag == "Flowers_02" || hit.collider.tag == "Grass_01" || hit.collider.tag == "Grass_02" || hit.collider.tag == "Mushroom_01" || hit.collider.tag == "Mushroom_02" || hit.collider.tag == "Rock_01" || hit.collider.tag == "Rock_02" || hit.collider.tag == "Rock_03" || hit.collider.tag == "Rock_04" || hit.collider.tag == "Rock_05" || hit.collider.tag == "Stump_01" || hit.collider.tag == "Tree_01" || hit.collider.tag == "Tree_02" || hit.collider.tag == "Tree_03" || hit.collider.tag == "Tree_04" || hit.collider.tag == "Tree_05" || hit.collider.tag == "ASAN_Creature_01" || hit.collider.tag == "ASAN_Creature_02" || hit.collider.tag == "ASAN_Creature_03" || hit.collider.tag == "ASAN_Creature_04")
            {
                Debug.Log("Green");
                foreach (Image i in Cursor)
                {
                    i.color = Color.green;
                }
            }
            else //if (hit.collider == null || hit.collider.tag == "Player" || hit.collider.tag == null)
            {
                // Debug.Log("Red");
                //Debug.Log(hit.collider.tag);
                foreach (Image i in Cursor)
                {
                    i.color = Color.red;
                    if (_startScanning)
                    {
                        _scanSliderObject.SetActive(false);
                        _startScanning = false;
                        scanTime = 0;
                        //OnScan();
                        _scanParticle.Stop();
                        _scanAudioClip.Stop();
                       
                    }
                }
            }
        }
        else
        {
         // didn't hit anything
            Debug.DrawRay(rayStartPos, rayDirection * 7f, Color.red);
        }

        if (_startScanning)
        {
            scanTime += Time.deltaTime;
            _scanSlider.value = scanTime;
            if (scanTime >= defaultTime)
            {
                _scanParticle.Stop();
                _scanSliderObject.SetActive(false);
                _startScanning = false;
                scanTime = 0;
                OnScan();
                _scanAudioClip.Stop();
            }
        }
        if (Branch_01)
        {
            Branch_01Data.SetActive(true);
        }
        if (Bush_01)
        {
            Bush_01Data.SetActive(true);
        }
        if (Bush_02)
        {
            Bush_02Data.SetActive(true);
        }
        if (Bush_03)
        {
            Bush_03Data.SetActive(true);
        }
        if (Flowers_01)
        {
            Flowers_01Data.SetActive(true);
        }
        if (Flowers_02)
        {
            Flowers_02Data.SetActive(true);
        }
        if (Grass_01)
        {
            Grass_01Data.SetActive(true);
        }
        if (Grass_02)
        {
            Grass_02Data.SetActive(true);
        }
        if (Mushroom_01)
        {
            Mushroom_01Data.SetActive(true);
        }
        if (Mushroom_02)
        {
            Mushroom_02Data.SetActive(true);
        }
        if (Rock_01)
        {
            Rock_01Data.SetActive(true);
        }
        if (Rock_02)
        {
            Rock_02Data.SetActive(true);
        }
        if (Rock_03)
        {
            Rock_03Data.SetActive(true);
        }
        if (Rock_04)
        {
            Rock_04Data.SetActive(true);
        }
        if (Rock_05)
        {
            Rock_05Data.SetActive(true);
        }
        if (Stump_01)
        {
            Stump_01Data.SetActive(true);
        }
        if (Tree_01)
        {
            Tree_01Data.SetActive(true);
        }
        if (Tree_02)
        {
            Tree_02Data.SetActive(true);
        }
        if (Tree_03)
        {
            Tree_03Data.SetActive(true);
        }
        if (Tree_04)
        {
            Tree_04Data.SetActive(true);
        }
        if (Tree_05)
        {
            Tree_05Data.SetActive(true);
        }
        if (ASAN_Creature_01)
        {
            ASAN_Creature_01Data.SetActive(true);
        }
        if (ASAN_Creature_02)
        {
            ASAN_Creature_02Data.SetActive(true);
        }
        if (ASAN_Creature_03)
        {
            ASAN_Creature_03Data.SetActive(true);
        }
        if (ASAN_Creature_04)
        {
            ASAN_Creature_04Data.SetActive(true);
        }
    }

    public void OnScan()
    {
        Ray ray = new Ray(_camera.transform.position, transform.forward);
        RaycastHit hit;
        // yield return new WaitForSeconds(scanTime);
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.transform.tag);
            if (hit.transform.tag == "Branch_01")
            {
                if (Branch_01 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Branch_01 = true;
            }
            if (hit.transform.tag == "Bush_01")
            {
                if (Bush_01 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Bush_01 = true;
            }
            if (hit.transform.tag == "Bush_02")
            {
                if (Bush_02 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Bush_02 = true;
            }
            if (hit.transform.tag == "Bush_03")
            {
                if (Bush_03 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Bush_03 = true;
            }
            if (hit.transform.tag == "Flowers_01")
            {
                if (Flowers_01 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Flowers_01 = true;
            }
            if (hit.transform.tag == "Flowers_02")
            {
                if (Flowers_02 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Flowers_02 = true;
            }
            if (hit.transform.tag == "Grass_01")
            {
                if (Grass_01 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Grass_01 = true;
            }
            if (hit.transform.tag == "Grass_02")
            {
                if (Grass_02 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Grass_02 = true;
            }
            if (hit.transform.tag == "Mushroom_01")
            {
                if (Mushroom_01 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Mushroom_01 = true;
            }
            if (hit.transform.tag == "Mushroom_02")
            {
                if (Mushroom_02 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Mushroom_02 = true;
            }
            if (hit.transform.tag == "Rock_01")
            {
                if (Rock_01 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Rock_01 = true;
            }
            if (hit.transform.tag == "Rock_02")
            {
                if (Rock_02 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Rock_02 = true;
            }
            if (hit.transform.tag == "Rock_03")
            {
                if (Rock_03 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Rock_03 = true;
            }
            if (hit.transform.tag == "Rock_04")
            {
                if (Rock_04 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Rock_04 = true;
            }
            if (hit.transform.tag == "Rock_05")
            {
                if (Rock_05 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Rock_05 = true;
            }
            if (hit.transform.tag == "Stump_01")
            {
                if (Stump_01 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Stump_01 = true;
            }
            if (hit.transform.tag == "Tree_01")
            {
                if (Tree_01 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Tree_01 = true;
            }
            if (hit.transform.tag == "Tree_02")
            {
                if (Tree_02 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Tree_02 = true;
            }
            if (hit.transform.tag == "Tree_03")
            {
                if (Tree_03 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Tree_03 = true;
            }
            if (hit.transform.tag == "Tree_04")
            {
                if (Tree_04 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Tree_04 = true;
            }
            if (hit.transform.tag == "Tree_05")
            {
                if (Tree_05 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                Tree_05 = true;
            }
            if (hit.transform.tag == "ASAN_Creature_01")
            {
                if (ASAN_Creature_01 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                ASAN_Creature_01 = true;
            }
            if (hit.transform.tag == "ASAN_Creature_02")
            {
                if (ASAN_Creature_02 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabGoodSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                ASAN_Creature_02 = true;
            }
            if (hit.transform.tag == "ASAN_Creature_03")
            {
                if (ASAN_Creature_03 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabBadSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                ASAN_Creature_03 = true;
            }
            if (hit.transform.tag == "ASAN_Creature_04")
            {
                if (ASAN_Creature_04 == false)
                {
                    Debug.Log(hit.transform.tag);
                    _saveSceneScript._numberOfItemsScanned++;
                    _experienceManager.HabBadSlider.value++;
                    _experienceManager.exp = _experienceManager.exp + 15;
                    PlanetValue = PlanetValue + 5;
                    _scanContainer.SetActive(true);
                    _InfoText.text = hit.transform.tag;
                    _endScanAudioSource.Play();
                    StartCoroutine(WaitTime());
                }
                ASAN_Creature_04 = true;

            }
        }
    }
    public void StartScan()
    {
        if (_startScanning == false)
        {
            _scanSlider.value = 0;
            _scanParticle.Play();
            _scanSliderObject.SetActive(true);
            _startScanning = true;
            _scanAudioClip.Play();
        }
    }
    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(2.5f);
        _scanContainer.SetActive(false);
    }
}

