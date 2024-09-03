using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SISTEMA_1._0.Forms
{
    /**internal class ThemeManager
    {
    }**/
    public static class ThemeManager
    {
        public static void ApplyTheme(Form form)
        {
            bool isDarkMode = IsDarkMode();
            var backgroundColor = isDarkMode ? Color.Black : Color.White;
            var foregroundColor = isDarkMode ? Color.White : Color.Black;
            var buttonBackColor = isDarkMode ? Color.Gray : Color.LightGray;
            var buttonForeColor = isDarkMode ? Color.White : Color.Black;

            form.BackColor = backgroundColor;
            form.ForeColor = foregroundColor;

            foreach (Control control in form.Controls)
            {
                control.BackColor = buttonBackColor;
                control.ForeColor = buttonForeColor;
            }

            form.Refresh();
        }

        private static bool IsDarkMode()
        {
            const string registryKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            const string registryValue = "SystemUsesLightTheme";
            object value = Registry.GetValue(registryKey, registryValue, 1); // Default to light mode if not found
            return value is int intValue && intValue == 0; // 0 is dark mode, 1 is light mode
        }
    }
}
