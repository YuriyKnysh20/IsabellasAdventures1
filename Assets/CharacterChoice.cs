using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChoice : MonoBehaviour
{

    [SerializeField] private GameObject _choosingCharacterCanvas;

    [SerializeField] private GameObject _assasin;
    [SerializeField] private GameObject _witch;
    [SerializeField] private GameObject _warrior;
    [SerializeField] private GameObject _womanWarrior;
    [SerializeField] private GameObject _wizard;

    private void Start()
    {
        _choosingCharacterCanvas.SetActive(true);
    }

    public void SetCharacterAssasin()
    {
        _choosingCharacterCanvas.SetActive(false);
        Instantiate(_assasin);
    }

    public void SetCharacterWitch()
    {
        _choosingCharacterCanvas.SetActive(false);
        Instantiate(_witch);
    }

    public void SetCharacterWarrior()
    {
        _choosingCharacterCanvas.SetActive(false);
        Instantiate(_warrior);
    }

    public void SetCharacterWomanWarrior()
    {
        _choosingCharacterCanvas.SetActive(false);
        Instantiate(_womanWarrior);
    }

    public void SetCharacterWizard()
    {
        _choosingCharacterCanvas.SetActive(false);
        Instantiate(_wizard);
    }
}
