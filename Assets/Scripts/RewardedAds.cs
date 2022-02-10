using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
public class RewardedAds : MonoBehaviour, IUnityAdsListener
{
    [SerializeField] private bool _testMode = false;
    [SerializeField] private Button _adsButton;
    private string _gameId = "4263973";
    private string _rewardedVideo = "Rewarded_Android";

    void Start()
    {
        _adsButton = GetComponent<Button>();
        _adsButton.interactable = Advertisement.IsReady(_rewardedVideo);

        if (_adsButton)
            _adsButton.onClick.AddListener(ShowRewardedVideo);

        Advertisement.AddListener(this);
        Advertisement.Initialize(_gameId, true);
    }

    public void ShowRewardedVideo()
    {
        Advertisement.Show(_rewardedVideo);
    }

    public void OnUnityAdsReady(string placementId)
    {
        if (placementId == _rewardedVideo)
        {
            _adsButton.interactable = true; //действия, если реклама доступна
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        //ошибка рекламы
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        // только запустили рекламу
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult) //обработка рекламы (тут определеяем вознаграждение)
    {
        if (showResult == ShowResult.Finished)
        {
            if (placementId == "Rewarded_Android")
                Debug.Log("Вау");
            //действия, если пользователь посмотрел рекламу до конца
        }
        else if (showResult == ShowResult.Skipped)
        {
            //действия, если пользователь пропустил рекламу
        }
        else if (showResult == ShowResult.Failed)
        {
            //действия при ошибке
        }
    }

}
