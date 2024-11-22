using System.Collections;
using TMPro;
using UnityEngine;

public class UpgradeCanvas : MonoBehaviour
{
    public Animator nameBannerAnimator;
    public Animator textBannerAnimator;
    public RectTransform nameBannerRect;
    public RectTransform textBannerRect;
    public TextMeshProUGUI upgradeText;
    public TextMeshProUGUI upgradeName;
    public Canvas upgradeCanvas;

    public void ShowCanvas(string upgradeName, string upgradeText)
    {
        SetUpgradeName(upgradeName);
        SetUpgradeText(upgradeText);

        nameBannerAnimator.Play("ShowUpgradeNameAnim");
        textBannerAnimator.Play("ShowUpgradeAnim");

    }

    public void SetUpgradeText(string text)
    {
        upgradeText.text = text;
    }

    public void SetUpgradeName(string text)
    {
        upgradeName.text = text;
    }

}
