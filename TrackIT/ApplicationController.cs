using TrackIT.Model;
using TrackIT.View;
using System.Windows.Controls;

namespace TrackIT.SolutionItems
{
    class ApplicationController
    {
        static ApplicationController _instance;
        public static ApplicationController GetInstance()
        {
            if (_instance == null)
                _instance = new ApplicationController();
            return _instance;
        }

        Border _stage;

        private ApplicationController() { }

        public void GoToPage(ApplicationPage page)
        {
            switch (page)
            {
                case ApplicationPage.NewControl1:
                    _stage.Child = new UserControl1();
                    break;
                case ApplicationPage.NewWindow2:
                    var win = new Window2();
                    win.Show();
                    break;
            }
        }

        public void SetStage(Border Stage)
        {
            _stage = Stage;
        }

    }
}
