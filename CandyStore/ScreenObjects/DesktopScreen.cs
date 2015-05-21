using atf.toolbox;
using SikuliModule;

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

            if (SikuliAction.Exists(PatternConstants.MSWORD_LANDINGPAGE,.095f, AtfConstant.WAIT_TIME_MEDIUM) != null)
            isOpened = true;

            return isOpened;
        }
        
        public void ClickClose()
        {
            SikuliAction.Click(PatternConstants.MSWORD_CLOSE);
        }
    }
}
