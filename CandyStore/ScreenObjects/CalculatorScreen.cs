using atf.toolbox;
using System.Linq;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;

namespace CandyStore.ScreenObjects
{
    public class CalculatorScreen
    {
        private Window _calculator;

        public CalculatorScreen()
        {
            _calculator = ATFHandler.Instance.FormAutomation.ApplicationDriver.GetWindow("WPF Calculator");
        }

        public void ZeroClick()
        {
            ATFHandler.Instance.FormAutomation.ClickButton(_calculator.Get<Button>("B0"));
        }

        public void OneClick()
        {
            ATFHandler.Instance.FormAutomation.ClickButton(_calculator.Get<Button>("B1"));
        }

        public void TwoClick()
        {
            ATFHandler.Instance.FormAutomation.ClickButton(_calculator.Get<Button>("B2"));
        }

        public void ThreeClick()
        {
            ATFHandler.Instance.FormAutomation.ClickButton(_calculator.Get<Button>("B3"));
        }

        public void FourClick()
        {
            ATFHandler.Instance.FormAutomation.ClickButton(_calculator.Get<Button>("B4"));
        }

        public void FiveClick()
        {
            ATFHandler.Instance.FormAutomation.ClickButton(_calculator.Get<Button>("B5"));
        }

        public void SixClick()
        {
            ATFHandler.Instance.FormAutomation.ClickButton(_calculator.Get<Button>("B6"));
        }

        public void SevenClick()
        {
            ATFHandler.Instance.FormAutomation.ClickButton(_calculator.Get<Button>("B7"));
        }

        public void EightClick()
        {
            ATFHandler.Instance.FormAutomation.ClickButton(_calculator.Get<Button>("B8"));
        }

        public void NineClick()
        {
            ATFHandler.Instance.FormAutomation.ClickButton(_calculator.Get<Button>("B9"));
        }

        public void PlusClick() 
        { 
            ATFHandler.Instance.FormAutomation.ClickButton(_calculator.Get<Button>("BPlus")); 
        }

        public void MultiplyClick()
        {
            ATFHandler.Instance.FormAutomation.ClickButton(_calculator.Get<Button>("BMultiply"));
        }

        public void SubtractClick()
        {
            ATFHandler.Instance.FormAutomation.ClickButton(_calculator.Get<Button>("BMinus"));
        }

        public void DivideClick()
        {
            ATFHandler.Instance.FormAutomation.ClickButton(_calculator.Get<Button>("BDevide"));
        }

        public void EqualsClick() 
        { 
            ATFHandler.Instance.FormAutomation.ClickButton(_calculator.Get<Button>("BEqual")); 
        }

        public string TopDisplayWindowValue()
        {
            SearchCriteria searchCriteria = SearchCriteria.ByClassName("TextBox").AndIndex(0);
            TextBox textBox = (TextBox)_calculator.Get(searchCriteria);
            return textBox.Text;
        }

        public string RunningPaperDisplayWindowValue()
        {
            SearchCriteria searchCriteria = SearchCriteria.ByClassName("TextBox").AndIndex(1);
            TextBox textBox = (TextBox)_calculator.Get(searchCriteria);
            return textBox.Text;
        }

        public string[] TopMenuItemsEnabledNames()
        {
            SearchCriteria searchCriteria = SearchCriteria.ByClassName("Menu");
            MenuBar item = _calculator.Get(searchCriteria) as MenuBar;
            Menus menus = item.TopLevelMenu;

            var result = from a in menus
                         where a.Enabled == true
                         select a.Name;

            return result.ToArray<string>();
        }

        /// <summary>
        /// EnterNumberIntoCalculator
        /// </summary>
        /// <param name="numberToClick">The number to enter into the calculator</param>
        public void EnterNumberIntoCalculator(int numberToClick)
        {
            int[] numbers = numberToClick.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();

            foreach (int number in numbers)
            {
                switch (number)
                {
                    case 0:
                        ZeroClick();
                        break;
                    case 1:
                        OneClick();
                        break;
                    case 2:
                        TwoClick();
                        break;
                    case 3:
                        ThreeClick();
                        break;
                    case 4:
                        FourClick();
                        break;
                    case 5:
                        FiveClick();
                        break;
                    case 6:
                        SixClick();
                        break;
                    case 7:
                        SevenClick();
                        break;
                    case 8:
                        EightClick();
                        break;
                    case 9:
                        NineClick();
                        break;
                }
            }
        }
    }
}
