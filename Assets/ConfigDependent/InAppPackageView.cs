using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class InAppPackageView : MonoBehaviour
{
    [SerializeField] private AssetReference _config;
    [SerializeField] private TextMeshProUGUI _textMesh;
    
    private async void Start()
    {
        AsyncOperationHandle<InAppPackageConfig> handle = _config.LoadAssetAsync<InAppPackageConfig>();
        await handle.Task;

        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            InAppPackageConfig inAppConfig = handle.Result;
            _textMesh.text = string.Format(_textMesh.text, inAppConfig.Price.ToString());
            Addressables.Release(handle);
        }
    }
}
