using System;
using TMPro;
using UnityEngine;

namespace _GameAssets._Scripts
{
    public class TestADS : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _stateRewardText;
        [SerializeField]
        private TextMeshProUGUI _stateInterstitialText;
        [SerializeField]
        private TextMeshProUGUI _stateBannerText;

        private bool _hasADSManagerIS;

        private void Start()
        {
            _hasADSManagerIS = ADSManager_IS.Instance;
        }

        private void Update()
        {
            if(!_hasADSManagerIS) return;
            _stateRewardText.text = "Reward: " + ADSManager_IS.Instance.HasRewardedVideo;
            _stateInterstitialText.text = "Interstitial: " + ADSManager_IS.Instance.HasInterstitial;
            _stateBannerText.text = "Banner: " + ADSManager_IS.Instance.HasBanner;
        }

        public void ShowReward()
        {
            ADSManager_IS.Instance.ShowRewardedVideo();
        }
        
        public void ShowInterstitial()
        {
            ADSManager_IS.Instance.ShowInterstitial();
        }
        
        public void LoadBanner()
        {
            ADSManager_IS.Instance.LoadBanner();
        }
        
        public void HideBanner()
        {
            ADSManager_IS.Instance.HideBanner();
        }
    }
}