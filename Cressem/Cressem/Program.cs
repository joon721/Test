using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cressem
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }

    public static class FormList
    {
        public static FormHome PageHome = new FormHome();
        public static FormManual PageManual = new FormManual();
        public static FormDevice PageDevice = new FormDevice();
        public static FormIO PageIO = new FormIO();
        public static FormMotor PageMotor = new FormMotor();
        public static FormDataView PageDataView = new FormDataView();
        public static FormUseSkip PageUseSkip = new FormUseSkip();
        public static FormLog PageLog = new FormLog();
        public static FormErrorList PageErrorList = new FormErrorList();
        public static FormUser PageUser = new FormUser();

    }
}
