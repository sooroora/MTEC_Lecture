using UnityEngine;

using System.Collections;

using UnityEngine.Events;





public class MidiEventTrigger : MonoBehaviour
{

    public bool[] instrumentFilter = new bool[129];

    public bool[] noteFilter = new bool[128];



    public UnityEvent eventNoteOn;

    public UnityEvent eventNoteOff;





    private bool _noteOn = false;



    public void Play()
    {

        _noteOn = false;

        OnPlay();

    }



    public void Pause()
    {

        OnPause();

    }



    public void Resume()
    {

        OnResume();

    }



    public void Stop()
    {

        OnStop();

    }



    public void NoteOn(int instrument, int noteNumber)
    {
      
        //if (_noteOn == false)
        //{
            //if (instrument == 62)
            //{
            //    Debug.Log("inst : " + instrument + ", noteNum : " + noteNumber);
            //}

            _noteOn = true;

            //Debug.Log("inst" + instrument);
            //Debug.Log("note" + noteNumber);

             //if (instrumentFilter[instrument] == true )
             //{
             //    Debug.Log("inst" + instrument);
             //}
            //if (instrument == 62)
            //{
            //    Debug.Log("inst : " + instrument + ", noteNum : " + noteNumber);

            //}

            if (instrumentFilter[instrument] == true && noteFilter[noteNumber] == true)
            {

                eventNoteOn.Invoke();

                OnNoteOn();
                OnNoteOnNoteNum(noteNumber);
            }

        //}

    }



    public void NoteOff(int instrument, int noteNumber)
    {

        _noteOn = false;



        if (instrumentFilter[instrument] == true && noteFilter[noteNumber] == true)
        {

            eventNoteOff.Invoke();

            OnNoteOff();

        }

    }



    protected virtual void OnPlay()
    {

    }



    protected virtual void OnPause()
    {

    }



    protected virtual void OnResume()
    {

    }



    protected virtual void OnStop()
    {

    }



    protected virtual void OnNoteOn()
    {

    }

    protected virtual void OnNoteOnNoteNum(int _noteNumber)
    {

    }

    protected virtual void OnNoteOff()
    {

    }

}