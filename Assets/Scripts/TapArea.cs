using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler
{
    private AudioSource klik;
    // Start is called before the first frame update
    void Start()
    {
        klik = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerDown(PointerEventData eventData)

    {

        GameManager.Instance.CollectByTap(eventData.position, transform);
        klik.Play();
    }

}
