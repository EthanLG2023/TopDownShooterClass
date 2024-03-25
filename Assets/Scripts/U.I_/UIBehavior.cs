using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBehavior : MonoBehaviour
{
    [SerializeField]
    private RawImage _healthBarFG;

    [SerializeField]
    private HealthBehaviour _healthBehaviour;

    [SerializeField]
    private Gradient _healthBarGradient;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Assert(_healthBarFG);
        Debug.Assert(_healthBehaviour);
    }

    // Update is called once per frame
    void Update()
    {
        if (_healthBarFG == null || _healthBehaviour == null)
            return;

        float health = _healthBehaviour.Health;

        float maxHealth = Mathf.Max(1, _healthBehaviour.MaxHealth);

        float healthPercentage = Mathf.Clamp01(health / maxHealth);

        Vector3 newScale = _healthBarFG.rectTransform.localScale;
        newScale.x = healthPercentage;
        _healthBarFG.rectTransform.localScale = newScale;

        _healthBarFG.color = _healthBarGradient.Evaluate(healthPercentage);
    }
}
