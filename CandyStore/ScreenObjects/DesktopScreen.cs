using atf.toolbox;
using SikuliModule;
using System;

namespace CandyStore.ScreenObjects
{
    public class DesktopScreen
    {
        public void ClickMSWord()
        {
            SikuliAction.Click(PatternConstants.MSWORD_ICON);
        }

        public bool IsMSWordOpened()
        {
            bool isOpened = false;

            try
            {
                if (SikuliAction.Exists(PatternConstants.MSWORD_LANDINGPAGE, 1.0f, AtfConstant.WAIT_TIME_MEDIUM) != null)
                    isOpened = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("There is no matching element")) isOpened = false;
                else throw ex;
            }

            return isOpened;
        }
        
        public void ClickClose()
        {
            SikuliAction.Click(PatternConstants.MSWORD_CLOSE);
        }
    }
}
