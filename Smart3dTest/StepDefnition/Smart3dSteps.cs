
using Smart3dTest.Pages;
using AventStack.ExtentReports.Gherkin.Model;
namespace Smart3dTest.StepDefnition
{
    [Binding]
    public class Smart3dSteps
    {
       [Given(@"I am on welcome page and i press take me to demo mode")]
        public void GivenIAmOnWelcomePageAndIPressTakeMeToDemoMode()
        {
            BeforeAllAroundPage.PressTakeMeToDemo();
        }
        [Then(@"I press ok on Demo mode popup")]
        public void ThenIPressOkOnDemoModePopup()
        {
            BeforeAllAroundPage.PressOk();
        }
        [Then(@"I press no thanks on welcome popup")]
        public void ThenIPressNoThanksOnWelcomePopup()
        {
            BeforeAllAroundPage.PressNoThanks();
        }
        [When(@"I am on All-Around page and i validate the program card is ""([^""]*)""")]
        public void WhenIAmOnAll_AroundPageAndIValidateTheProgramCardIs(string program)
        {
            AllAround.ValidateAllAround(program);
        }
        [When(@"I press split sourruounding volume on All-Around program")]
        public void WhenIPressSplitSourruoundingVolumeOnAll_AroundProgram()
        {
            AllAround.PressSplit();
        }
        [Then(@"I validate ""([^""]*)"" volume is '([^']*)'")]
        public void ThenIValidateVolumeIs(string HI, string value)
        {
            AllAround.ValidateHIVolume(HI, value);
        }
        [When(@"I set ""([^""]*)"" sourrounding volume to ""([^""]*)"" of All-Around program")]
        public void WhenISetSourroundingVolumeToOfAll_AroundProgram(string HI, string target_value)
        {
            AllAround.Move_sliders(HI, target_value);
        }
        [When(@"I press merge sourrounding voulume on All-Around program")]
        public void WhenIPressMergeSourroundingVoulumeOnAll_AroundProgram()
        {
            AllAround.PressMerge();
        }
        [When(@"I press '([^']*)' quick button on All-Around Program")]
        public void WhenIPressQuickButtonOnAll_AroundProgram(string button)
        {
            AllAround.PressQuickButtons(button);
        }
        [Then(@"validate '([^']*)' quick button is enabled on All-Around Program")]
        public void ThenValidateQuickButtonIsEnabledOnAll_AroundProgram(string button)
        {
            AllAround.CheckQuickButtonEnabled(button);
        }
        [Then(@"validate '([^']*)' quick button is disabled on All-Around program")]
        public void ThenValidateQuickButtonIsDisabledOnAll_AroundProgram(string button)
        {
            AllAround.CheckQuickButtonDiasbled(button);
        }
        [When(@"I press Sound Enhancer button on '([^']*)' program")]
        public void WhenIPressSoundEnhancerButtonOnProgram(string program)
        {
            switch(program.ToUpper())
            {
                case "ALL AROUND":
                    AllAround.PressSoundEnhancerAllAround();
                    break;
                case "HEAR IN NOISE":
                    HearInNoise.PressSoundEnhancerHearInNoise();
                    break;
                case "OUTDOOR":
                    Outdoor.PressSoundEnhacerOutdoor();
                    break;
            }
            
        }
        [When(@"I set '([^']*)' to '([^']*)' on All-Around Sound Enhancer")]
        public void WhenISetToOnAll_AroundSoundEnhancer(string gain, string value)
        {
            SoundEnhancer.MoveGainSliders(gain, value);
        }
        [Then(@"I validate ""([^""]*)"" is ""([^""]*)"" on All-Around Sound Enhancer")]
        public void ThenIValidateIsOnAll_AroundSoundEnhancer(string gain, string value)
        {
            SoundEnhancer.ValidateGainValue(gain,value);
        }
        [When(@"I press Tinnitus Manager on '([^']*)' Sound Enhancer")]
        public void WhenIPressTinnitusManagerOnSoundEnhancer(string p0)
        {
            SoundEnhancer.PressTinnitus();
        }
        [When(@"I press Nature sounds button ""([^""]*)"" on All-Around Tinnitus Manager")]
        public void WhenIPressNatureSoundsButtonOnAll_AroundTinnitusManager(string wave)
        {
            TinnitusManager.PressWavesAllAround(wave);
        }
        [When(@"I press the exit button on '([^']*)' Sound Enhancer")]
        public void WhenIPressTheExitButtonOnSoundEnhancer(string p0)
        {
            TinnitusManager.PressBack();
        }
        [When(@"I swipe left to '([^']*)' program from current program")]
        public void WhenISwipeLeftToProgramFromCurrentProgram(string program)
        {
            switch(program.ToUpper())
            {
                case "HEAR IN NOISE":
                    AllAround.SwipeLeftHearInNoise();
                    break;
                case "OUTDOOR":
                    HearInNoise.SwipeleftOutdoor();
                    break;
                case "MUSIC":
                    Outdoor.SwipeLeftMusic();
                    break;
            }
            
        }
        [Then(@"I validate program card is ""([^""]*)""")]
        public void ThenIValidateProgramCardIs(string program)
        {
            switch(program.ToUpper())
            {
                case "HEAR IN NOISE":
                    HearInNoise.ValidateHearInNoise(program);
                    break;
                case "OUTDOOR":
                    
                    Outdoor.ValidateProgramCardOutdoor(program);
                    break;
                case "MUSIC":
                    Music.ValidateProgramCardMusic(program);
                    break;
                case "ALL-AROUND":
                    AllAround.ValidateAllAround(program);
                    break;
            }
            
        }
        [When(@"I press white noise button Slight variation on Hear in noise Tinnitus Manager")]
        public void WhenIPressWhiteNoiseButtonSlightVariationOnHearInNoiseTinnitusManager()
        {
            TinnitusManager.PressSlightVariation();
        }
        [When(@"I press Reset button on All-Around Tinnitus Manager")]
        public void WhenIPressResetButtonOnAll_AroundTinnitusManager()
        {
             TinnitusManager.PressReset();
        }
        [When(@"I drag Wind Noise Reduction to Strong on Outdoor Sound Enhancer")]
        public void WhenIDragWindNoiseReductionToStrongOnOutdoorSoundEnhancer()
        {
            Outdoor.Set_wind_noiseReductionToStrong();
        }
        [When(@"I press '([^']*)' program on the top ribbon bar")]
        public void WhenIPressProgramOnTheTopRibbonBar(string program)
        {
            TopRibbonBar.PressPrograms(program);
        }
        [When(@"I press Program overview button on topribbonbar")]
        public void WhenIPressProgramOverviewButtonOnTopribbonbar()
        {
            TopRibbonBar.PressProgramOverview();
        }
        [When(@"I press '([^']*)' program on Program overview")]
        public void WhenIPressProgramOnProgramOverview(string program)
        {
            ProgramOverview.PressProgramProgramOverview(program);
        }
        [When(@"I press the Close button on Program overview")]
        public void WhenIPressTheCloseButtonOnProgramOverview()
        {
            ProgramOverview.Press_Close();
        }
        [When(@"I press menu item '([^']*)' on bottom ribbon bar")]
        public void WhenIPressMenuItemOnBottomRibbonBar(string MENU_ITEM)
        {
            BottomRibbonBar.PressMenuItem(MENU_ITEM);
        }
        [When(@"I press '([^']*)' on My ReSound")]
        public void WhenIPressOnMyReSound(string program)
        {
            MyResound.PressLearningProgram(program);
        }
        [When(@"I press Volume control on Learn about the app")]
        public void WhenIPressVolumeControlOnLearnAboutTheApp()
        {
            LearnAboutTheApp.PressVolumeControl();
        }
        [When(@"I swipe left to '([^']*)' page on Learn about the app")]
        public void WhenISwipeLeftToPageOnLearnAboutTheApp(string card)
        {
            LearnAboutTheApp.SwipLeftCards(card);
        }
        [Then(@"validate '([^']*)' animation is shown on Volume control")]
        public void ThenValidateAnimationIsShownOnVolumeControl(string animation_name)
        {
            LearnAboutTheApp.ValidateAnimation(animation_name);
        }
        [When(@"I close on Learn about the app and back to My Resound page")]
        public void WhenICloseOnLearnAboutTheAppAndBackToMyResoundPage()
        {
            LearnAboutTheApp.CloseLearnAboutApp();
        }
        [When(@"I press '([^']*)' on Please notice dialog")]
        public void WhenIPressOnPleaseNoticeDialog(string program)
        {
            GuidingTips.PressProgramsGuidingTips(program);
        }
        [Then(@"validate title is '([^']*)' on Guiding tips page")]
        public void ThenValidateTitleIsOnGuidingTipsPage(string title)
        {
            GuidingTips.ValidateTitleDisplayed(title);
        }
        [When(@"I press '([^']*)' on Guiding tips")]
        public void WhenIPressOnGuidingTips(string program)
        {
            GuidingTips.PressProgramsGuidingTips(program);
        }
        [When(@"I press '([^']*)' on '([^']*)' nudging dialog")]
        public void WhenIPressOnNudgingDialog(string program,string p0)
        {
            GuidingTips.PressProgramsGuidingTips(program);
        }
        [When(@"I press '([^']*)' on bottom ribbon bar and back to Guiding tips on My Resound")]
        public void WhenIPressOnBottomRibbonBarAndBackToGuidingTipsOnMyResound(string MENU_ITEM)
        {
            BottomRibbonBar.PressMenuItem(MENU_ITEM);
        }
        [Then(@"validate '([^']*)' button enabled on Music program nudging dialog")]
        public void ThenValidateButtonEnabledOnMusicProgramNudgingDialog(string button)
        {
            GuidingTips.CheckButtonsEnabled(button);
        }
        [Then(@"validate Auto-activate favorite locations switch is '([^']*)'")]
        public void ThenValidateAuto_ActivateFavoriteLocationsSwitchIs(string mode)
        {
            More.CheckAutoLocationOnOff(mode);
        }
        [When(@"I press '([^']*)' switch on More menu")]
        public void WhenIPressSwitchOnMoreMenu(string moremenuitem)
        {
            More.PressMoreMenuItem(moremenuitem);
        }
        [When(@"I press more menu item '([^']*)'")]
        public void WhenIPressMoreMenuItem(string moremenuitem)
        {
            More.PressMoreMenuItem(moremenuitem);
        }
        [Then(@"validate page title is displayed on '([^']*)' page")]
        public void ThenValidatePageTitleIsDisplayedOnPage(string title)
        {
            switch (title.ToUpper())
            {
                case "ABOUT":
                    About.ValidatePageTitle(title);
                    break;
            }  
        }
        [Then(@"validate html view is displayed on '([^']*)' page")]
        public void ThenValidateHtmlViewIsDisplayedOnPage(string program)
        {
            switch(program.ToUpper())
            {
                case "ABOUT":
                    About.CheckHTMLViewDisplayedinPage();
                    break;
                case "PRIVACY POLICY":
                    PrivacyPolicy.ValidateHtmlViewPrivacyPolicy();
                    break;
                case "SUPPORT":
                    Support.ValidateHtmlViewDisplayedSupport();
                    break;
            }
        }
        [When(@"I press '([^']*)' from '([^']*)' page")]
        public void WhenIPressFromPage(string po,string program)
        {
            switch(program.ToUpper())
            {
                case "ABOUT":
                    About.PressBack();
                    break;
                case "MANUFACTURER":
                    Manufacturer.PressBackToLegalInformation();
                    break;
                case "TERMS AND CONDITIONS":
                    TermsAndConditions.PressBackTermsAndConditions();
                    break;
                case "PRIVACY POLICY":
                    PrivacyPolicy.PressBackPrivacyPolicy();
                    break;
                case "LEGAL INFORMATION":
                    LegalInformation.PressBack();
                    break;
                case "SUPPORT":
                    Support.PressBackSupport();
                    break;
            }
        }
        [When(@"I press Legal information item '([^']*)'")]
        public void WhenIPressLegalInformationItem(string menu_item)
        {
            LegalInformation.PressLegalinfoMenuItems(menu_item);
        }
        [Then(@"I validate page title is displayed on '([^']*)' page")]
        public void ThenIValidatePageTitleIsDisplayedOnPage(string menu_item)
        {
            switch(menu_item.ToUpper())
            {
                case "MANUFACTURER":
                    Manufacturer.ValidatePageTitleDisplayed(menu_item);
                    break;
                case "TERMS AND CONDITIONS":
                    TermsAndConditions.CheckTitleDisplayedTermsAndConditions(menu_item);
                    break;
                case "PRIVACY POLICY":
                    PrivacyPolicy.ValidatePageTitleDisplayedPrivacyPolicy(menu_item);
                    break;
                case "SUPPORT":
                    Support.CheckTitleDisplayedSupport(menu_item);
                    break;
            }
            
        }
    }
}
