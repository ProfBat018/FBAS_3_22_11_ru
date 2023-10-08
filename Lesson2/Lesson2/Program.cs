using Lesson2.Presenters;
using Lesson2.Views;

namespace Lesson2
{
    public static class Program
    {
        public static MainForm MainView { get; set; } = new();
        public static AddForm AddView { get; set; } = new();
        public static EditForm EditView { get; set; } = new();

        public static AddFormPresenter AddPresenter { get; set; } = new();
        public static MainFormPresenter MainPresenter { get; set; } = new();
        public static EditFormPresenter EditPresenter { get; set; } = new();


        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(MainView);
        }
    }
}