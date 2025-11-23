using TMPro;
using UnityEngine;

public class InAppPackageView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMesh;

    [field: SerializeField] public InAppPackageId InAppPackageId;
    
    private GameConfig _gameConfig;
    
    private void Awake()
    {
        _gameConfig = Bootstrap.Container.Resolve<GameConfig>();
    }

    private void Start()
    {
        if (InAppPackageId == InAppPackageId.One)
        {
            textMesh.text = string.Format(textMesh.text, _gameConfig.InAppPackageConfig.Price.ToString());
        }
        else if (InAppPackageId == InAppPackageId.Two)
        {
            textMesh.text = string.Format(textMesh.text, _gameConfig.InAppPackageConfigOne.Price.ToString());
        }
        else if (InAppPackageId == InAppPackageId.Three)
        {
            textMesh.text = string.Format(textMesh.text, _gameConfig.InAppPackageConfigTwo.Price.ToString());
        }
        else
        {
            textMesh.text = string.Format(textMesh.text, _gameConfig.InAppPackageConfigThree.Price.ToString());
        }
    }
}
