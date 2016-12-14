using UnityEngine;
using System.Collections;

public class SpawnParticleTrigger : MidiEventTrigger
{

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public GameObject particle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    protected override void OnNoteOn()
    {



        //_animator.SetTrigger("Hit");

    }

    protected override void OnNoteOnNoteNum(int _noteNumber)
    {
        Vector2 pos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        
        GameObject fire = (GameObject)Instantiate(particle, pos, Quaternion.identity);

        //fire.transform.localScale = new Vector3(Mathf.Clamp((float)_noteNumber * 0.1f * 0.5f, 0.5f, 6f), Mathf.Clamp((float)_noteNumber * 0.1f * 0.5f, 0.5f, 6f),
        //     Mathf.Clamp((float)_noteNumber * 0.1f * 0.5f, 0.5f, 6f));
        
    }

}
