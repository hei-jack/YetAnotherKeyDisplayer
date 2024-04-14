using System.Collections.Generic;
using YAKD.Enums;

namespace YAKD.Helpers
{
    /// <summary>
    /// Converts button names to more understandable and simple ones
    /// </summary>
    public static class MouseButtonsConverter
    {
        #region Fields

        /// <summary>
        /// List of beautiful named buttons
        /// </summary>
        private static readonly Dictionary<MouseMessage, string> Buttons;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of MouseButtonsConverter class
        /// </summary>
        static MouseButtonsConverter()
        {
            Buttons = new Dictionary<MouseMessage, string>
            {
                { MouseMessage.WM_LBUTTONUP, "鼠标左键" },
                { MouseMessage.WM_LBUTTONDOWN, "鼠标左键" },
                { MouseMessage.WM_LBUTTONDBLCLK, "鼠标左键" },
                { MouseMessage.WM_RBUTTONUP, "鼠标右键" },
                { MouseMessage.WM_RBUTTONDOWN, "鼠标右键" },
                { MouseMessage.WM_RBUTTONDBLCLK, "鼠标右键" },
                { MouseMessage.WM_MBUTTONUP, "鼠标中键" },
                { MouseMessage.WM_MBUTTONDOWN, "鼠标中键" },
                { MouseMessage.WM_MBUTTONDBLCLK, "鼠标中键" },
                { MouseMessage.WM_XBUTTONUP, "XMB" },
                { MouseMessage.WM_XBUTTONDOWN, "XMB" },
                { MouseMessage.WM_XBUTTONDBLCLK, "XMB" },
                { MouseMessage.WM_MOUSEWHEEL, "鼠标滚动" }
            };
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns button name
        /// </summary>
        /// <param name="mouseMessages">Name of button from WinApi hook</param>
        /// <returns>Button name</returns>
        public static string GetButtonName(MouseMessage mouseMessages)
        {
            return Buttons.TryGetValue(mouseMessages, out var buttonName) ? buttonName : mouseMessages.ToString();
        }

        #endregion
    }
}
